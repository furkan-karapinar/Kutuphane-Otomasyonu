Imports System.Data.SqlClient
Imports System.Data.SQLite

Public Class main_form
    Dim dc As Database_Control = New Database_Control
    Private Sub btnOduncKitapVer_Click(sender As Object, e As EventArgs) Handles btnOduncKitapVer.Click
        Dim secimogrenciid, secimkitapid, oduncdurumu As Integer
        Dim tarih, getirilecektarih, verilentarih As DateTime
        tarih = Date.Now.Date
        verilentarih = Date.Now.Date
        getirilecektarih = tarih.AddDays(15)
        secimkitapid = dgKitapListe.CurrentRow.Cells(0).Value
        secimogrenciid = dgOgrenciListe.CurrentRow.Cells(0).Value
        oduncdurumu = dgKitapListe.CurrentRow.Cells(8).Value
        If oduncdurumu <> 1 Then
            dc.Insert_Data("odunc", New List(Of String) From {"ogrenciid", "kitapid", "atarih", "gelecektarih", "durum", "vtarih"}, New List(Of String) From {secimogrenciid, secimkitapid, tarih.ToString("yyyy-MM-dd"), getirilecektarih.ToString("yyyy-MM-dd"), 0, verilentarih.ToString("yyyy-MM-dd")})
            dc.Update_Data("kitap", "odunc", "1", "id", secimkitapid)
            txtOgrenciNo.Text = ""
            txtKitapNo.Text = ""
            txtBarkod.Text = ""
            dgOgrenciListe.Rows.Clear()
            dgKitapListe.Rows.Clear()
            txtOgrenciNo.Focus()
            odunctekiler()
            MsgBox("Kitap ödünç verildi")
        Else
            MsgBox("Kitap ödünç verilmiş durumda. Kitabı veremezsiniz!", vbInformation)
            Exit Sub
        End If
    End Sub

    Public Sub odunctekiler()
        dgOdunc.Rows.Clear()
        Dim atarih, gelecektarih As DateTime

        Using conn As New SQLiteConnection("Data Source=database.db;Version=3;")
            conn.Open()

            Dim sorgu As String = "SELECT * FROM odunc WHERE durum='0' ORDER BY id DESC"
            Using cmd As New SQLiteCommand(sorgu, conn)

                Using dr As SQLiteDataReader = cmd.ExecuteReader()
                    While dr.Read()
                        atarih = dr.GetDateTime(dr.GetOrdinal("atarih"))
                        gelecektarih = dr.GetDateTime(dr.GetOrdinal("gelecektarih"))

                        dgOdunc.Rows.Add(dr.Item("id"), dr.Item("ogrenciid"), dr.Item("kitapid"), atarih.ToString("dd.MM.yyyy"), gelecektarih.ToString("dd.MM.yyyy"))
                    End While
                End Using
            End Using
        End Using
    End Sub

    Private Sub btnKitapAl_Click(sender As Object, e As EventArgs) Handles btnKitapAl.Click
        Dim secimkitapid, secimodunc As Integer
        Dim tarih As DateTime
        tarih = Date.Now.Date
        Try
            secimkitapid = dgOdunc.CurrentRow.Cells(2).Value
            secimodunc = dgOdunc.CurrentRow.Cells(0).Value

            ' MsgBox(secimodunc)
            ' MsgBox(secimkitapid)
            'kitabı ödünçten çıkart
            dc.Update_Data("kitap", "odunc", "0", "id", secimkitapid)
            'ödünç tarihini gir
            dc.Run_Command("UPDATE odunc SET durum='1', vtarih='" & tarih.ToString("yyyy-MM-dd") & "' WHERE id='" & secimodunc & "'")
            MsgBox("Kitap geri alındı")
            odunctekiler()
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        odunctekiler()
    End Sub

    Private Sub txtOgrenciNo_TextChanged(sender As Object, e As EventArgs) Handles txtOgrenciNo.TextChanged
        ogrencigetir()
    End Sub

    Private Sub txtOgrenciTamAdi_TextChanged(sender As Object, e As EventArgs) Handles txtOgrenciTamAdi.TextChanged
        ogrencigetir2()
    End Sub

    Private Sub txtKitapNo_TextChanged(sender As Object, e As EventArgs) Handles txtKitapNo.TextChanged
        kitapgetir()
    End Sub

    Private Sub txtBarkod_TextChanged(sender As Object, e As EventArgs) Handles txtBarkod.TextChanged
        kitapgetir1()
    End Sub

    Private Sub txtKitapAdi_TextChanged(sender As Object, e As EventArgs) Handles txtKitapAdi.TextChanged
        kitapgetir2()
    End Sub

    Public Sub ogrencigetir()
        dgOgrenciListe.Rows.Clear()
        Dim gelenogrencino = Trim(Val(txtOgrenciNo.Text))

        Using conn As New SQLiteConnection("Data Source=database.db;Version=3;")
            conn.Open()

            Dim sorgu As String = "SELECT * FROM ogrenci WHERE okulno LIKE '%" & gelenogrencino & "%'"
            Using cmd As New SQLiteCommand(sorgu, conn)
                Using dr As SQLiteDataReader = cmd.ExecuteReader()
                    While dr.Read()
                        dgOgrenciListe.Rows.Add(dr.Item("id"), dr.Item("adsoyad"), dr.Item("sinif"), dr.Item("okulno"))
                    End While
                End Using
            End Using
        End Using
    End Sub

    Public Sub ogrencigetir2()
        dgOgrenciListe.Rows.Clear()
        Dim ogradi = Trim(txtOgrenciTamAdi.Text)

        Using conn As New SQLiteConnection("Data Source=database.db;Version=3;")
            conn.Open()

            Dim sorgu As String = "SELECT * FROM ogrenci WHERE adsoyad LIKE '%" & ogradi & "%'"
            Using cmd As New SQLiteCommand(sorgu, conn)

                Using dr As SQLiteDataReader = cmd.ExecuteReader()
                    While dr.Read()
                        dgOgrenciListe.Rows.Add(dr.Item("id"), dr.Item("adsoyad"), dr.Item("sinif"), dr.Item("okulno"))
                    End While
                End Using
            End Using
        End Using
    End Sub

    Public Sub kitapgetir()
        dgKitapListe.Rows.Clear()
        Dim gelendemirbasno = Trim(Val(txtKitapNo.Text))

        Using conn As New SQLiteConnection("Data Source=database.db;Version=3;")
            conn.Open()

            Dim sorgu As String = "SELECT * FROM kitap WHERE demirbasno LIKE '%" & gelendemirbasno & "%'"
            Using cmd As New SQLiteCommand(sorgu, conn)

                Using dr As SQLiteDataReader = cmd.ExecuteReader()
                    While dr.Read()
                        dgKitapListe.Rows.Add(dr.Item("id"), dr.Item("demirbasno"), dr.Item("barkod"), dr.Item("eser"), dr.Item("yazar"), dr.Item("bolum"), dr.Item("tur"), dr.Item("yayinevi"), dr.Item("odunc"))
                    End While
                End Using
            End Using
        End Using
    End Sub

    Public Sub kitapgetir1()
        dgKitapListe.Rows.Clear()
        Dim gelenbarkod = Trim(Val(txtBarkod.Text))

        Using conn As New SQLiteConnection("Data Source=database.db;Version=3;")
            conn.Open()

            Dim sorgu As String = "SELECT * FROM kitap WHERE barkod LIKE '%" & gelenbarkod & "%'"
            Using cmd As New SQLiteCommand(sorgu, conn)

                Using dr As SQLiteDataReader = cmd.ExecuteReader()
                    While dr.Read()
                        dgKitapListe.Rows.Add(dr.Item("id"), dr.Item("demirbasno"), dr.Item("barkod"), dr.Item("eser"), dr.Item("yazar"), dr.Item("bolum"), dr.Item("tur"), dr.Item("yayinevi"), dr.Item("odunc"))
                    End While
                End Using
            End Using
        End Using
    End Sub

    Public Sub kitapgetir2()
        dgKitapListe.Rows.Clear()
        Dim gelenkitapadi = Trim(txtKitapAdi.Text)

        Using conn As New SQLiteConnection("Data Source=database.db;Version=3;")
            conn.Open()

            Dim sorgu As String = "SELECT * FROM kitap WHERE eser LIKE '%" & gelenkitapadi & "%'"
            Using cmd As New SQLiteCommand(sorgu, conn)

                Using dr As SQLiteDataReader = cmd.ExecuteReader()
                    While dr.Read()
                        dgKitapListe.Rows.Add(dr.Item("id"), dr.Item("demirbasno"), dr.Item("barkod"), dr.Item("eser"), dr.Item("yazar"), dr.Item("bolum"), dr.Item("tur"), dr.Item("yayinevi"), dr.Item("odunc"))
                    End While
                End Using
            End Using
        End Using
    End Sub

    Private Sub main_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        odunctekiler()
    End Sub

    Private Sub ÖğrenciİşlemleriToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ÖğrenciİşlemleriToolStripMenuItem.Click
        Add_Student.Show()
    End Sub

    Private Sub KitapİşlemleriToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KitapİşlemleriToolStripMenuItem.Click
        Add_Book.Show()
    End Sub

    Private Sub GecikenKitaplarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GecikenKitaplarToolStripMenuItem.Click
        Delayed_Books_List.Show()
    End Sub
End Class