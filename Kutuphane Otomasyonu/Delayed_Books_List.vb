Imports System.Data.SQLite

Public Class Delayed_Books_List
    Public Sub Listele()
        Dim bugun As Date = Date.Today

        Using conn As New SQLiteConnection("Data Source=database.db;Version=3;")
            conn.Open()

            Dim sorgu As String = "SELECT * FROM odunc WHERE durum = 0 AND gelecektarih < @bugun"
            Using cmd As New SQLiteCommand(sorgu, conn)
                cmd.Parameters.AddWithValue("@bugun", bugun)

                Using adapter As New SQLiteDataAdapter(cmd)
                    Dim dataset As New DataSet()
                    adapter.Fill(dataset, "odunc")

                    DataGridView1.DataSource = dataset.Tables("odunc")

                End Using
            End Using
        End Using
    End Sub

    Public Sub odunctekiler()
        DataGridView1.Rows.Clear()
        Dim atarih, gelecektarih As DateTime
        Dim bugun As Date = Date.Today
        Using conn As New SQLiteConnection("Data Source=database.db;Version=3;")
            conn.Open()

            Dim sorgu As String = "SELECT * FROM odunc WHERE durum = 0 AND gelecektarih < @bugun"
            Using cmd As New SQLiteCommand(sorgu, conn)
                cmd.Parameters.AddWithValue("@bugun", bugun)

                Using dr As SQLiteDataReader = cmd.ExecuteReader()
                    While dr.Read()
                        atarih = dr.GetDateTime(dr.GetOrdinal("atarih"))
                        gelecektarih = dr.GetDateTime(dr.GetOrdinal("gelecektarih"))

                        DataGridView1.Rows.Add(dr.Item("id"), dr.Item("ogrenciid"), dr.Item("kitapid"), atarih.ToString("dd.MM.yyyy"), gelecektarih.ToString("dd.MM.yyyy"))
                    End While
                End Using
            End Using
        End Using
    End Sub
    Private Sub Delayed_Books_List_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        odunctekiler()
    End Sub
End Class