<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Add_Book
    Inherits System.Windows.Forms.Form

    'Form, bileşen listesini temizlemeyi bırakmayı geçersiz kılar.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows Form Tasarımcısı tarafından gerektirilir
    Private components As System.ComponentModel.IContainer

    'NOT: Aşağıdaki yordam Windows Form Tasarımcısı için gereklidir
    'Windows Form Tasarımcısı kullanılarak değiştirilebilir.  
    'Kod düzenleyicisini kullanarak değiştirmeyin.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.t8 = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnKitapGetir1 = New System.Windows.Forms.Button()
        Me.btnKitapGetir = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnEkle = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txttur = New System.Windows.Forms.ComboBox()
        Me.txtdemirbasno = New System.Windows.Forms.TextBox()
        Me.txtyayinevi = New System.Windows.Forms.TextBox()
        Me.txtbarkod = New System.Windows.Forms.TextBox()
        Me.txtbolum = New System.Windows.Forms.TextBox()
        Me.txteser = New System.Windows.Forms.TextBox()
        Me.txtyazar = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        't8
        '
        Me.t8.Location = New System.Drawing.Point(140, 263)
        Me.t8.Margin = New System.Windows.Forms.Padding(4)
        Me.t8.Name = "t8"
        Me.t8.ReadOnly = True
        Me.t8.Size = New System.Drawing.Size(113, 22)
        Me.t8.TabIndex = 13
        Me.t8.Visible = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.Control
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button2.Location = New System.Drawing.Point(455, 293)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(107, 53)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "KİTAP SİL"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'btnKitapGetir1
        '
        Me.btnKitapGetir1.BackColor = System.Drawing.SystemColors.Control
        Me.btnKitapGetir1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnKitapGetir1.Location = New System.Drawing.Point(455, 71)
        Me.btnKitapGetir1.Margin = New System.Windows.Forms.Padding(4)
        Me.btnKitapGetir1.Name = "btnKitapGetir1"
        Me.btnKitapGetir1.Size = New System.Drawing.Size(107, 27)
        Me.btnKitapGetir1.TabIndex = 11
        Me.btnKitapGetir1.Text = ">>>"
        Me.btnKitapGetir1.UseVisualStyleBackColor = False
        '
        'btnKitapGetir
        '
        Me.btnKitapGetir.BackColor = System.Drawing.SystemColors.Control
        Me.btnKitapGetir.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnKitapGetir.Location = New System.Drawing.Point(455, 39)
        Me.btnKitapGetir.Margin = New System.Windows.Forms.Padding(4)
        Me.btnKitapGetir.Name = "btnKitapGetir"
        Me.btnKitapGetir.Size = New System.Drawing.Size(107, 27)
        Me.btnKitapGetir.TabIndex = 10
        Me.btnKitapGetir.Text = ">>>"
        Me.btnKitapGetir.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.Control
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button1.Location = New System.Drawing.Point(140, 354)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(422, 53)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "KİTAP DÜZENLE"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.t8)
        Me.GroupBox1.Controls.Add(Me.btnKitapGetir1)
        Me.GroupBox1.Controls.Add(Me.btnKitapGetir)
        Me.GroupBox1.Controls.Add(Me.btnEkle)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txttur)
        Me.GroupBox1.Controls.Add(Me.txtdemirbasno)
        Me.GroupBox1.Controls.Add(Me.txtyayinevi)
        Me.GroupBox1.Controls.Add(Me.txtbarkod)
        Me.GroupBox1.Controls.Add(Me.txtbolum)
        Me.GroupBox1.Controls.Add(Me.txteser)
        Me.GroupBox1.Controls.Add(Me.txtyazar)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(10, 10)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(591, 442)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        '
        'btnEkle
        '
        Me.btnEkle.BackColor = System.Drawing.SystemColors.Control
        Me.btnEkle.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnEkle.Location = New System.Drawing.Point(139, 293)
        Me.btnEkle.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEkle.Name = "btnEkle"
        Me.btnEkle.Size = New System.Drawing.Size(308, 53)
        Me.btnEkle.TabIndex = 1
        Me.btnEkle.Text = "KİTAP EKLE"
        Me.btnEkle.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(103, 266)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(20, 16)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "ID"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(69, 236)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(59, 16)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Yayınevi"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(93, 203)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 16)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Türü"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 172)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(111, 16)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Bulunduğu Bölüm"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(84, 140)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 16)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Yazarı"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(71, 108)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Eser Adı"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(77, 76)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 16)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Barkod"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(41, 44)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Demirbaş No"
        '
        'txttur
        '
        Me.txttur.FormattingEnabled = True
        Me.txttur.Items.AddRange(New Object() {"ATATURK", "DERGI", "HIKAYE", "ROMAN", "SIIR", "BILIM TEKNIK", "MESLEKI KITAPLAR", "BIYOGRAFI", "SOZLUK", "ATLAS", "YABANCI DIL"})
        Me.txttur.Location = New System.Drawing.Point(140, 199)
        Me.txttur.Margin = New System.Windows.Forms.Padding(4)
        Me.txttur.Name = "txttur"
        Me.txttur.Size = New System.Drawing.Size(307, 24)
        Me.txttur.TabIndex = 8
        '
        'txtdemirbasno
        '
        Me.txtdemirbasno.Location = New System.Drawing.Point(140, 41)
        Me.txtdemirbasno.Margin = New System.Windows.Forms.Padding(4)
        Me.txtdemirbasno.Name = "txtdemirbasno"
        Me.txtdemirbasno.Size = New System.Drawing.Size(307, 22)
        Me.txtdemirbasno.TabIndex = 1
        '
        'txtyayinevi
        '
        Me.txtyayinevi.Location = New System.Drawing.Point(140, 233)
        Me.txtyayinevi.Margin = New System.Windows.Forms.Padding(4)
        Me.txtyayinevi.Name = "txtyayinevi"
        Me.txtyayinevi.Size = New System.Drawing.Size(307, 22)
        Me.txtyayinevi.TabIndex = 7
        '
        'txtbarkod
        '
        Me.txtbarkod.Location = New System.Drawing.Point(140, 73)
        Me.txtbarkod.Margin = New System.Windows.Forms.Padding(4)
        Me.txtbarkod.Name = "txtbarkod"
        Me.txtbarkod.Size = New System.Drawing.Size(307, 22)
        Me.txtbarkod.TabIndex = 2
        '
        'txtbolum
        '
        Me.txtbolum.Location = New System.Drawing.Point(140, 169)
        Me.txtbolum.Margin = New System.Windows.Forms.Padding(4)
        Me.txtbolum.Name = "txtbolum"
        Me.txtbolum.Size = New System.Drawing.Size(307, 22)
        Me.txtbolum.TabIndex = 5
        '
        'txteser
        '
        Me.txteser.Location = New System.Drawing.Point(140, 105)
        Me.txteser.Margin = New System.Windows.Forms.Padding(4)
        Me.txteser.Name = "txteser"
        Me.txteser.Size = New System.Drawing.Size(307, 22)
        Me.txteser.TabIndex = 3
        '
        'txtyazar
        '
        Me.txtyazar.Location = New System.Drawing.Point(140, 137)
        Me.txtyazar.Margin = New System.Windows.Forms.Padding(4)
        Me.txtyazar.Name = "txtyazar"
        Me.txtyazar.Size = New System.Drawing.Size(307, 22)
        Me.txtyazar.TabIndex = 4
        '
        'Add_Book
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(611, 462)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "Add_Book"
        Me.Padding = New System.Windows.Forms.Padding(10)
        Me.Text = "Kitap Ekle"
        Me.TopMost = True
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents t8 As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents btnKitapGetir1 As Button
    Friend WithEvents btnKitapGetir As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnEkle As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txttur As ComboBox
    Friend WithEvents txtdemirbasno As TextBox
    Friend WithEvents txtyayinevi As TextBox
    Friend WithEvents txtbarkod As TextBox
    Friend WithEvents txtbolum As TextBox
    Friend WithEvents txteser As TextBox
    Friend WithEvents txtyazar As TextBox
    Friend WithEvents Label8 As Label
End Class
