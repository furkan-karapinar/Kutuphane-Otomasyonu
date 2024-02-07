Imports System.Data.SqlClient
Imports System.Data.SQLite
Imports Microsoft.VisualBasic.ApplicationServices

Public Class Add_Book
    Dim dc As Database_Control = New Database_Control

    Public Sub kitapgetir()
        Try
            Dim gdno As String = Trim(txtdemirbasno.Text)
            Dim barkod, eser, yazar, bolum, tur, yayinevi, kitapID As String

            Using conn As New SQLiteConnection("Data Source=database.db;Version=3;")
                conn.Open()

                Dim sorgu As String = "SELECT * FROM kitap WHERE demirbasno = @gdno"
                Using cmd As New SQLiteCommand(sorgu, conn)
                    cmd.Parameters.AddWithValue("@gdno", gdno)

                    Using dr As SQLiteDataReader = cmd.ExecuteReader()
                        If dr.Read() Then
                            barkod = dr.Item("barkod").ToString()
                            eser = dr.Item("eser").ToString()
                            yazar = dr.Item("yazar").ToString()
                            bolum = dr.Item("bolum").ToString()
                            tur = dr.Item("tur").ToString()
                            yayinevi = dr.Item("yayinevi").ToString()
                            kitapID = dr.Item("id").ToString()



                            txtbarkod.Text = barkod
                            txteser.Text = eser
                            txtyazar.Text = yazar
                            txtbolum.Text = bolum
                            txttur.Text = tur
                            txtyayinevi.Text = yayinevi
                            t8.Text = kitapID
                        End If
                    End Using
                    If eser <> String.Empty Then
                        MsgBox("Kitap Bulundu!", vbInformation)
                    Else
                        MsgBox("Kitap Bulunamadı!", vbCritical)
                        txtdemirbasno.Text = ""
                        txtbarkod.Text = ""
                        txteser.Text = ""
                        txtyazar.Text = ""
                        txtbolum.Text = ""
                        txttur.Text = ""
                        txtyayinevi.Text = ""
                        txtdemirbasno.Focus()
                    End If
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Kitap Bulunamadı")
            txtdemirbasno.Text = ""
            txtdemirbasno.Focus()
        End Try
    End Sub

    Public Sub kitapgetir1()
        Try
            Dim gelenbarkod As String = Trim(txtbarkod.Text)
            Dim demirbasno, eser, yazar, bolum, tur, yayinevi, kitapID As String

            Using conn As New SQLiteConnection("Data Source=database.db;Version=3;")
                conn.Open()

                Dim sorgu As String = "SELECT * FROM kitap WHERE barkod = @gelenbarkod"
                Using cmd As New SQLiteCommand(sorgu, conn)
                    cmd.Parameters.AddWithValue("@gelenbarkod", gelenbarkod)

                    Using dr As SQLiteDataReader = cmd.ExecuteReader()
                        If dr.Read() Then
                            demirbasno = dr.Item("demirbasno").ToString()
                            eser = dr.Item("eser").ToString()
                            yazar = dr.Item("yazar").ToString()
                            bolum = dr.Item("bolum").ToString()
                            tur = dr.Item("tur").ToString()
                            yayinevi = dr.Item("yayinevi").ToString()
                            kitapID = dr.Item("id").ToString()


                            txtdemirbasno.Text = demirbasno
                            txteser.Text = eser
                            txtyazar.Text = yazar
                            txtbolum.Text = bolum
                            txttur.Text = tur
                            txtyayinevi.Text = yayinevi
                            t8.Text = kitapID
                        End If
                    End Using

                    If eser <> String.Empty Then
                        MsgBox("Kitap Bulundu!", vbInformation)
                    Else
                        MsgBox("Kitap Bulunamadı!", vbCritical)
                        txtdemirbasno.Text = ""
                        txtbarkod.Text = ""
                        txteser.Text = ""
                        txtyazar.Text = ""
                        txtbolum.Text = ""
                        txttur.Text = ""
                        txtyayinevi.Text = ""
                        txtdemirbasno.Focus()
                    End If
                End Using
            End Using
        Catch ex As Exception
            MsgBox("Kitap Bulunamadı")
            txtdemirbasno.Text = ""
            txtdemirbasno.Focus()
        End Try
    End Sub


    Private Sub btnKitapGetir_Click(sender As Object, e As EventArgs) Handles btnKitapGetir.Click
        kitapgetir()
    End Sub

    Private Sub btnKitapGetir1_Click(sender As Object, e As EventArgs) Handles btnKitapGetir1.Click
        kitapgetir1()
    End Sub

    Private Sub btnEkle_Click(sender As Object, e As EventArgs) Handles btnEkle.Click
        dc.Insert_Data("kitap", New List(Of String) From {"demirbasno", "barkod", "eser", "yazar", "bolum", "tur", "yayinevi", "odunc", "verilensayi"}, New List(Of String) From {Val(txtdemirbasno.Text), txtbarkod.Text, txteser.Text, txtyazar.Text, txtbolum.Text, txttur.Text, txtyayinevi.Text, 0, 0})
        txtdemirbasno.Text = ""
        txtbarkod.Text = ""
        txteser.Text = ""
        txtyazar.Text = ""
        txtbolum.Text = ""
        txttur.Text = ""
        txtyayinevi.Text = ""
        txtdemirbasno.Focus()
        MsgBox("Kitap Eklendi")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If MsgBox("Kitap silinsin mi?", vbOKCancel) = vbOK Then
            Try
                dc.Delete_Data("kitap", "id", Val(t8.Text))

                txtdemirbasno.Text = ""
                txtbarkod.Text = ""
                txteser.Text = ""
                txtyazar.Text = ""
                txtbolum.Text = ""
                txttur.Text = ""
                txtyayinevi.Text = ""
                t8.Text = ""
                MsgBox("Kitap Silindi", vbInformation)
            Catch ex As Exception
                MsgBox("Kitap Silinemedi!")
            End Try
        Else
            Exit Sub
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If MsgBox("Kitap bilgileri güncellensin mi?", vbOKCancel) = vbOK Then
            Try
                dc.Update_Data("kitap", "eser", txteser.Text, "id", Val(t8.Text))
                dc.Update_Data("kitap", "yazar", txtyazar.Text, "id", Val(t8.Text))
                dc.Update_Data("kitap", "bolum", txtbolum.Text, "id", Val(t8.Text))
                dc.Update_Data("kitap", "tur", txttur.Text, "id", Val(t8.Text))
                dc.Update_Data("kitap", "yayinevi", txtyayinevi.Text, "id", Val(t8.Text))
                txtdemirbasno.Text = ""
                txtbarkod.Text = ""
                txteser.Text = ""
                txtyazar.Text = ""
                txtbolum.Text = ""
                txttur.Text = ""
                txtyayinevi.Text = ""
                t8.Text = ""
                MsgBox("Kitap Güncellendi", vbInformation)
            Catch ex As Exception
                MsgBox("Güncelleme Yapılamadı!")
                txtdemirbasno.Text = ""
                txtbarkod.Text = ""
                txteser.Text = ""
                txtyazar.Text = ""
                txtbolum.Text = ""
                txttur.Text = ""
                txtyayinevi.Text = ""
                t8.Text = ""
            End Try
        Else
            Exit Sub
        End If
    End Sub
End Class