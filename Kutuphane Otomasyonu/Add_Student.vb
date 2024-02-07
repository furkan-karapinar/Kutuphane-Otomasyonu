Imports System.Data.SqlClient
Imports System.Data.SQLite

Public Class Add_Student
    Dim dc As Database_Control = New Database_Control
    Private Sub btnEkle_Click(sender As Object, e As EventArgs) Handles btnEkle.Click
        Dim adsoyad, sinif As String
        Dim okulno, bulunan As Integer
        bulunan = 0
        adsoyad = txtAdSoyad.Text
        sinif = cmbSinif.Text
        okulno = Val(txtOkulNo.Text)
        If adsoyad = "" Or sinif = "" Or okulno < 1 Then
            MsgBox("Tüm alanları doldurun")
            Exit Sub
        End If
        Using conn As New SQLiteConnection("Data Source=database.db;Version=3;")
            conn.Open()

            Dim sorgu As String = "SELECT COUNT(*) FROM ogrenci WHERE okulno = @okulno"
            Using cmd As New SQLiteCommand(sorgu, conn)
                cmd.Parameters.AddWithValue("@okulno", okulno)

                bulunan = CInt(cmd.ExecuteScalar())
            End Using
        End Using
        If bulunan = 0 Then
            dc.Insert_Data("ogrenci", New List(Of String) From {"adsoyad", "okulno", "sinif"}, New List(Of String) From {adsoyad, okulno, sinif})
            txtAdSoyad.Text = ""
            txtOkulNo.Text = ""
            cmbSinif.Text = ""
            MsgBox("Öğrenci kaydı yapıldı")
        Else
            MsgBox("Bu numara ile öğrenci kayıtlı lütfen kontrol edin")
            txtOkulNo.Text = ""
            txtOkulNo.Focus()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If MsgBox("Seçili öğrenci düzenlenecek! kabul ediyor musunuz?", vbOKCancel) = vbOK Then
            dc.Update_Data("ogrenci", "adsoyad", txtAdSoyad.Text, "okulno", txtOkulNo.Text)
            dc.Update_Data("ogrenci", "sinif", cmbSinif.Text, "okulno", txtOkulNo.Text)
            txtAdSoyad.Text = ""
            cmbSinif.Text = ""
            txtOkulNo.Text = ""
            txtOkulNo.Focus()
            MsgBox("Kayıt Güncellendi")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ogrencibul()
    End Sub

    Public Sub ogrencibul()
        Dim o_no As Integer = Val(txtOkulNo.Text)
        Dim o_adsoyad, o_sinif As String

        Using conn As New SQLiteConnection("Data Source=database.db;Version=3;")
            conn.Open()

            Dim sorgu As String = "SELECT adsoyad, sinif FROM ogrenci WHERE okulno = @o_no"
            Using cmd As New SQLiteCommand(sorgu, conn)
                cmd.Parameters.AddWithValue("@o_no", o_no)

                Using dr As SQLiteDataReader = cmd.ExecuteReader()
                    If dr.Read() Then
                        o_adsoyad = dr.Item("adsoyad").ToString()
                        o_sinif = dr.Item("sinif").ToString()
                        MsgBox("Öğrenci Bulundu!", vbInformation)
                    End If
                End Using
            End Using
        End Using
        If o_adsoyad = o_sinif Then
            MsgBox("Öğrenci Bulunamadı!", vbCritical)
        End If
        txtAdSoyad.Text = o_adsoyad
        cmbSinif.Text = o_sinif
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If MsgBox("Seçili öğrenci silinecek! kabul ediyor musunuz?", vbOKCancel) = vbOK Then
            dc.Delete_Data("ogrenci", "okulno", txtOkulNo.Text)

            txtAdSoyad.Text = ""
            cmbSinif.Text = ""
            txtOkulNo.Text = ""
            txtOkulNo.Focus()
            MsgBox("Kayıt Silindi")
        End If
    End Sub
End Class