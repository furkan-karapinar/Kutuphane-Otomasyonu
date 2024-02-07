Public Class login_form
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "admin" And TextBox2.Text = "password" Then
            MsgBox("Giriş Yapıldı", vbInformation)
            main_form.Show()
            Me.Hide()
            Me.Close()
        Else
            MsgBox("Kullanıcı Adı yada şifre hatalı", vbCritical)
        End If
    End Sub
End Class
