Imports System.Data.SQLite
Imports System.Windows.Forms

Public Class Database_Control
    Private data_connection As SQLiteConnection
    Private command As SQLiteCommand
    Private reader As SQLiteDataReader

    Public Developer_Mode As Boolean = False
    Dim database_full_path As String = Application.StartupPath & "\database.db"

    Private Sub Command_Error(ByVal error_message As String)
        If Developer_Mode = True Then
            MsgBox("Command Error" & vbNewLine & error_message)
        End If

    End Sub

    Public Function Run_Command(ByVal command As String) As Integer
        Try
            Dim cs As String = "URI=file:" & database_full_path
            Dim con = New SQLiteConnection(cs)
            con.Open()
            Dim cmd = New SQLiteCommand(con)
            cmd.CommandText = command
            cmd.ExecuteNonQuery()
            cmd.Cancel()
            Return 1 'Command Processing Successful
        Catch ex As Exception
            Command_Error(ex.ToString)
            Return 0 'Command Processing Unsuccessful
        End Try


    End Function

    Public Function Returnable_Run_Command(ByVal command As String) As Object
        Try
            Dim cs As String = "URI=file:" & database_full_path
            Dim con = New SQLiteConnection(cs)
            con.Open()
            Dim cmd = New SQLiteCommand(con)
            cmd.CommandText = command
            Dim sqlite_message = cmd.ExecuteScalar()
            cmd.Cancel()
            Return sqlite_message
        Catch ex As Exception
            Command_Error(ex.ToString)
            Return 0
        End Try

    End Function

    Public Function Create_Database(ByVal datatable_name As String, ByVal datatable_columns As List(Of String)) As Integer
        ' Veritabanı yoksa oluşturur.
        Try

            Dim columns_data As String
            For Each str As String In datatable_columns
                columns_data = columns_data + " " + str + " ,"
            Next
            columns_data = columns_data.Substring(0, columns_data.Length - 2)




            If Not System.IO.File.Exists(database_full_path) Then
                SQLiteConnection.CreateFile(database_full_path)
            End If

            Using sqlite = New SQLiteConnection("Data Source=" & database_full_path)
                sqlite.Open()
                Dim sql As String = "CREATE TABLE IF NOT EXISTS " & datatable_name & " (" & columns_data & ")"
                Dim cmd As SQLiteCommand = New SQLiteCommand(sql, sqlite)
                cmd.ExecuteNonQuery()
                cmd.Cancel()
            End Using
            Return 1
        Catch ex As Exception
            Command_Error(ex.ToString)
            Return 0
        End Try

    End Function
    Public Function Create_Datatable(ByVal datatable_name As String, ByVal columns As List(Of String)) As Integer
        'Create Database Table
        Try
            Dim columns_data As String
            For Each str As String In columns
                columns_data = columns_data + " " + str + " ,"
            Next
            columns_data = columns_data.Substring(0, columns_data.Length - 2)


            Dim cs As String = "URI=file:" & database_full_path

            Dim con = New SQLiteConnection(cs)
            con.Open()
            Dim cmd = New SQLiteCommand(con)
            cmd.CommandText = "CREATE TABLE IF NOT EXISTS " & datatable_name & "(" & columns_data & ")"
            cmd.ExecuteNonQuery()
            cmd.Cancel()
            Return 1
        Catch ex As Exception
            Command_Error(ex.ToString)
            Return 0
        End Try


    End Function


    Public Function Get_Single_Data(ByVal datatable_name As String, ByVal column_name As String, ByVal data_value As String, ByVal value As Object, ByVal value_type As String) As Object
        Dim cs As String = "URI=file:" & database_full_path
        Dim data As String = "Null"
        Try
            Dim data_connection = New SQLiteConnection(cs)
            data_connection.Open()
            Dim stm As String = "SELECT * FROM " & datatable_name & " WHERE " & column_name & " = " & data_value
            Dim command = New SQLiteCommand(stm, data_connection)
            reader = command.ExecuteReader()

            While reader.Read()
                Select Case value_type
                    Case "Boolean"
                        data = reader.GetBoolean(value)
                    Case "Byte"
                        data = reader.GetByte(value)
                    Case "Char"
                        data = reader.GetChar(value)
                    Case "DateTime"
                        data = reader.GetDateTime(value)
                    Case "Decimal"
                        data = reader.GetDecimal(value)
                    Case "Double"
                        data = reader.GetDouble(value)
                    Case "Float"
                        data = reader.GetFloat(value)
                    Case "String"
                        data = reader.GetString(value)
                    Case "Integer"
                        data = reader.GetValue(value)
                    Case "Equals"
                        data = reader.Equals(value)
                    Case "IsDbNull"
                        data = reader.IsDBNull(value)
                    Case Else
                        data = "Null"

                End Select
            End While
            Return data
        Catch ex As Exception
            Command_Error(ex.ToString)
            Return "Null"
        End Try
    End Function



    Public Function Delete_Data(ByVal datatable_name As String, ByVal database_item_name As String, ByVal item_name As String) As Integer
        ' Veritabanından veri siler
        Dim cs As String = "URI=file:" & database_full_path
        Try
            Dim con = New SQLiteConnection(cs)
            con.Open()
            Dim cmd = New SQLiteCommand(con)
            cmd.CommandText = "DELETE FROM " & datatable_name & " WHERE " & database_item_name & "=@name"
            cmd.Prepare()
            cmd.Parameters.AddWithValue("@name", item_name)
            cmd.ExecuteNonQuery()
            cmd.Cancel()
            Return 1
        Catch ex As Exception
            Command_Error(ex.ToString)
            Return 0
        End Try
    End Function
    Public Function Delete_Datatable(ByVal datatable_name As String) As Integer
        'Delete Database Table
        Try
            Dim cs As String = "URI=file:" & database_full_path

            Dim con = New SQLiteConnection(cs)
            con.Open()
            Dim cmd = New SQLiteCommand(con)
            cmd.CommandText = "DROP TABLE IF EXISTS" & datatable_name
            cmd.ExecuteNonQuery()
            cmd.Cancel()
            Return 1
        Catch ex As Exception
            Command_Error(ex.ToString)
            Return 0
        End Try


    End Function

    Public Function Insert_Data(ByVal datatable_name As String, ByVal columns As List(Of String), ByVal values As List(Of String)) As Integer
        ' Veritabanına veri ekler
        Try
            Dim columns_data As String
            For Each str As String In columns
                columns_data = columns_data + " '" + str + "' ,"
            Next
            columns_data = columns_data.Substring(0, columns_data.Length - 2)


            Dim values_data As String
            For Each str As String In values
                values_data = values_data + " '" + str + "' ,"
            Next
            values_data = values_data.Substring(0, values_data.Length - 2)


            Dim cs As String = "URI=file:" & database_full_path

            Dim con = New SQLiteConnection(cs)
            con.Open()
            Dim cmd = New SQLiteCommand(con)
            cmd.CommandText = "INSERT INTO " & datatable_name & "(" & columns_data & ") VALUES(" & values_data & ")"
            cmd.ExecuteNonQuery()
            cmd.Cancel()
            Return 1

        Catch ex As Exception
            Command_Error(ex.ToString)
            Return 0
        End Try

    End Function
    Public Function Insert_Data_And_Return_Last_ID(ByVal datatable_name As String, ByVal columns As List(Of String), ByVal values As List(Of String)) As Integer
        ' Veritabanına veri ekler
        Try
            Dim columns_data As String
            For Each str As String In columns
                columns_data = columns_data + " '" + str + "' ,"
            Next
            columns_data = columns_data.Substring(0, columns_data.Length - 2)


            Dim values_data As String
            For Each str As String In values
                values_data = values_data + " '" + str + "' ,"
            Next
            values_data = values_data.Substring(0, values_data.Length - 2)

            Dim cs As String = "URI=file:" & database_full_path

            Dim con = New SQLiteConnection(cs)
            con.Open()
            Dim cmd = New SQLiteCommand(con)
            cmd.CommandText = "INSERT INTO " & datatable_name & "(" & columns_data & ") VALUES(" & values_data & "); SELECT last_insert_rowid();"
            Dim lastRowId = cmd.ExecuteScalar()
            cmd.Cancel()
            Return lastRowId
        Catch ex As Exception
            Command_Error(ex.ToString)
            Return 0
        End Try


    End Function



    Public Function Update_Data(ByVal datatable_name As String, ByVal column_name As String, ByVal value_data As String, ByVal id_or_other_data_name As String, ByVal id_or_data_value As String) As Integer
        ' Veritabanındaki veriyi günceller
        Try

            Dim cs As String = "URI=file:" & database_full_path
            value_data = "'" & value_data & "'"
            Dim con = New SQLiteConnection(cs)
            con.Open()
            Dim cmd = New SQLiteCommand(con)
            Dim k As String = "UPDATE " & datatable_name & " SET " & column_name & " = " & value_data & " WHERE " & id_or_other_data_name & " = " & id_or_data_value
            cmd.CommandText = k
            cmd.ExecuteNonQuery()
            cmd.Cancel()
            Return 1

        Catch ex As Exception
            Command_Error(ex.ToString)
            Return 0
        End Try

    End Function


End Class
