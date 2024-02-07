<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class main_form
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
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnKitapAl = New System.Windows.Forms.Button()
        Me.btnOduncKitapVer = New System.Windows.Forms.Button()
        Me.dgOdunc = New System.Windows.Forms.DataGridView()
        Me.OID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OOGRENCIID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OKITAPID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OATARIH = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OGTARIH = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtKitapAdi = New System.Windows.Forms.TextBox()
        Me.dgKitapListe = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DNO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BARKOD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ESER = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.YAZAR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BOLUM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TUR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.YAYINEVI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ODUNC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtKitapNo = New System.Windows.Forms.TextBox()
        Me.txtBarkod = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtOgrenciTamAdi = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtOgrenciNo = New System.Windows.Forms.TextBox()
        Me.dgOgrenciListe = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ADSOYAD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SINIF = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OKULNO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ÖğrenciİşlemleriToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KitapİşlemleriToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RaporlarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.GecikenKitaplarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgOdunc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgKitapListe, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgOgrenciListe, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnKitapAl)
        Me.GroupBox3.Controls.Add(Me.btnOduncKitapVer)
        Me.GroupBox3.Controls.Add(Me.dgOdunc)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox3.Location = New System.Drawing.Point(15, 625)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Size = New System.Drawing.Size(1391, 313)
        Me.GroupBox3.TabIndex = 12
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Ödünç İşlemleri"
        '
        'btnKitapAl
        '
        Me.btnKitapAl.Location = New System.Drawing.Point(37, 134)
        Me.btnKitapAl.Margin = New System.Windows.Forms.Padding(4)
        Me.btnKitapAl.Name = "btnKitapAl"
        Me.btnKitapAl.Size = New System.Drawing.Size(300, 50)
        Me.btnKitapAl.TabIndex = 8
        Me.btnKitapAl.Text = "KİTAP AL"
        Me.btnKitapAl.UseVisualStyleBackColor = True
        '
        'btnOduncKitapVer
        '
        Me.btnOduncKitapVer.Location = New System.Drawing.Point(38, 66)
        Me.btnOduncKitapVer.Margin = New System.Windows.Forms.Padding(4)
        Me.btnOduncKitapVer.Name = "btnOduncKitapVer"
        Me.btnOduncKitapVer.Size = New System.Drawing.Size(300, 50)
        Me.btnOduncKitapVer.TabIndex = 7
        Me.btnOduncKitapVer.Text = "ÖDÜNÇ KİTAP VER"
        Me.btnOduncKitapVer.UseVisualStyleBackColor = True
        '
        'dgOdunc
        '
        Me.dgOdunc.AllowUserToAddRows = False
        Me.dgOdunc.AllowUserToDeleteRows = False
        Me.dgOdunc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgOdunc.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgOdunc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgOdunc.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.OID, Me.OOGRENCIID, Me.OKITAPID, Me.OATARIH, Me.OGTARIH})
        Me.dgOdunc.Location = New System.Drawing.Point(362, 23)
        Me.dgOdunc.Margin = New System.Windows.Forms.Padding(4)
        Me.dgOdunc.Name = "dgOdunc"
        Me.dgOdunc.ReadOnly = True
        Me.dgOdunc.RowHeadersWidth = 51
        Me.dgOdunc.Size = New System.Drawing.Size(1003, 203)
        Me.dgOdunc.TabIndex = 18
        '
        'OID
        '
        Me.OID.HeaderText = "ID"
        Me.OID.MinimumWidth = 6
        Me.OID.Name = "OID"
        Me.OID.ReadOnly = True
        Me.OID.Width = 49
        '
        'OOGRENCIID
        '
        Me.OOGRENCIID.HeaderText = "ÖĞRENCİ ID"
        Me.OOGRENCIID.MinimumWidth = 6
        Me.OOGRENCIID.Name = "OOGRENCIID"
        Me.OOGRENCIID.ReadOnly = True
        Me.OOGRENCIID.Width = 104
        '
        'OKITAPID
        '
        Me.OKITAPID.HeaderText = "KİTAP ID"
        Me.OKITAPID.MinimumWidth = 6
        Me.OKITAPID.Name = "OKITAPID"
        Me.OKITAPID.ReadOnly = True
        Me.OKITAPID.Width = 83
        '
        'OATARIH
        '
        Me.OATARIH.HeaderText = "ALINAN TARİH"
        Me.OATARIH.MinimumWidth = 6
        Me.OATARIH.Name = "OATARIH"
        Me.OATARIH.ReadOnly = True
        Me.OATARIH.Width = 118
        '
        'OGTARIH
        '
        Me.OGTARIH.HeaderText = "GETİRİLECEK TARİH"
        Me.OGTARIH.MinimumWidth = 6
        Me.OGTARIH.Name = "OGTARIH"
        Me.OGTARIH.ReadOnly = True
        Me.OGTARIH.Width = 152
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txtKitapAdi)
        Me.GroupBox2.Controls.Add(Me.dgKitapListe)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.txtKitapNo)
        Me.GroupBox2.Controls.Add(Me.txtBarkod)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox2.Location = New System.Drawing.Point(15, 348)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(1391, 247)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Kitap Seç"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(52, 145)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 16)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Kitap Adı"
        '
        'txtKitapAdi
        '
        Me.txtKitapAdi.Location = New System.Drawing.Point(125, 141)
        Me.txtKitapAdi.Margin = New System.Windows.Forms.Padding(4)
        Me.txtKitapAdi.Name = "txtKitapAdi"
        Me.txtKitapAdi.Size = New System.Drawing.Size(160, 22)
        Me.txtKitapAdi.TabIndex = 5
        '
        'dgKitapListe
        '
        Me.dgKitapListe.AllowUserToAddRows = False
        Me.dgKitapListe.AllowUserToDeleteRows = False
        Me.dgKitapListe.AllowUserToResizeColumns = False
        Me.dgKitapListe.AllowUserToResizeRows = False
        Me.dgKitapListe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgKitapListe.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgKitapListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgKitapListe.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DNO, Me.BARKOD, Me.ESER, Me.YAZAR, Me.BOLUM, Me.TUR, Me.YAYINEVI, Me.ODUNC})
        Me.dgKitapListe.Location = New System.Drawing.Point(362, 23)
        Me.dgKitapListe.Margin = New System.Windows.Forms.Padding(4)
        Me.dgKitapListe.Name = "dgKitapListe"
        Me.dgKitapListe.ReadOnly = True
        Me.dgKitapListe.RowHeadersWidth = 51
        Me.dgKitapListe.Size = New System.Drawing.Size(1003, 203)
        Me.dgKitapListe.TabIndex = 17
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 49
        '
        'DNO
        '
        Me.DNO.HeaderText = "D. NO"
        Me.DNO.MinimumWidth = 6
        Me.DNO.Name = "DNO"
        Me.DNO.ReadOnly = True
        Me.DNO.Width = 67
        '
        'BARKOD
        '
        Me.BARKOD.HeaderText = "BARKOD"
        Me.BARKOD.MinimumWidth = 6
        Me.BARKOD.Name = "BARKOD"
        Me.BARKOD.ReadOnly = True
        Me.BARKOD.Width = 92
        '
        'ESER
        '
        Me.ESER.HeaderText = "ESER ADI"
        Me.ESER.MinimumWidth = 6
        Me.ESER.Name = "ESER"
        Me.ESER.ReadOnly = True
        Me.ESER.Width = 91
        '
        'YAZAR
        '
        Me.YAZAR.HeaderText = "KİTAP YAZARI"
        Me.YAZAR.MinimumWidth = 6
        Me.YAZAR.Name = "YAZAR"
        Me.YAZAR.ReadOnly = True
        Me.YAZAR.Width = 115
        '
        'BOLUM
        '
        Me.BOLUM.HeaderText = "B. BÖLÜM"
        Me.BOLUM.MinimumWidth = 6
        Me.BOLUM.Name = "BOLUM"
        Me.BOLUM.ReadOnly = True
        Me.BOLUM.Width = 91
        '
        'TUR
        '
        Me.TUR.HeaderText = "KİTAP TÜRÜ"
        Me.TUR.MinimumWidth = 6
        Me.TUR.Name = "TUR"
        Me.TUR.ReadOnly = True
        Me.TUR.Width = 107
        '
        'YAYINEVI
        '
        Me.YAYINEVI.HeaderText = "YAYIN EVİ"
        Me.YAYINEVI.MinimumWidth = 6
        Me.YAYINEVI.Name = "YAYINEVI"
        Me.YAYINEVI.ReadOnly = True
        Me.YAYINEVI.Width = 92
        '
        'ODUNC
        '
        Me.ODUNC.HeaderText = "ÖDÜNÇ"
        Me.ODUNC.MinimumWidth = 6
        Me.ODUNC.Name = "ODUNC"
        Me.ODUNC.ReadOnly = True
        Me.ODUNC.Width = 85
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(63, 110)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 16)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Barkod"
        '
        'txtKitapNo
        '
        Me.txtKitapNo.Location = New System.Drawing.Point(125, 76)
        Me.txtKitapNo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtKitapNo.Name = "txtKitapNo"
        Me.txtKitapNo.Size = New System.Drawing.Size(160, 22)
        Me.txtKitapNo.TabIndex = 2
        '
        'txtBarkod
        '
        Me.txtBarkod.Location = New System.Drawing.Point(125, 107)
        Me.txtBarkod.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBarkod.Name = "txtBarkod"
        Me.txtBarkod.Size = New System.Drawing.Size(160, 22)
        Me.txtBarkod.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(53, 80)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Kitap No"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtOgrenciTamAdi)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtOgrenciNo)
        Me.GroupBox1.Controls.Add(Me.dgOgrenciListe)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(15, 73)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(1391, 245)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Öğrenci Seç"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(55, 130)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 16)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Adı Soyadı"
        '
        'txtOgrenciTamAdi
        '
        Me.txtOgrenciTamAdi.Location = New System.Drawing.Point(141, 126)
        Me.txtOgrenciTamAdi.Margin = New System.Windows.Forms.Padding(4)
        Me.txtOgrenciTamAdi.Name = "txtOgrenciTamAdi"
        Me.txtOgrenciTamAdi.Size = New System.Drawing.Size(160, 22)
        Me.txtOgrenciTamAdi.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(52, 92)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 16)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Öğrenci No"
        '
        'txtOgrenciNo
        '
        Me.txtOgrenciNo.Location = New System.Drawing.Point(141, 88)
        Me.txtOgrenciNo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtOgrenciNo.Name = "txtOgrenciNo"
        Me.txtOgrenciNo.Size = New System.Drawing.Size(160, 22)
        Me.txtOgrenciNo.TabIndex = 2
        '
        'dgOgrenciListe
        '
        Me.dgOgrenciListe.AllowUserToAddRows = False
        Me.dgOgrenciListe.AllowUserToDeleteRows = False
        Me.dgOgrenciListe.AllowUserToResizeColumns = False
        Me.dgOgrenciListe.AllowUserToResizeRows = False
        Me.dgOgrenciListe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgOgrenciListe.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgOgrenciListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgOgrenciListe.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.ADSOYAD, Me.SINIF, Me.OKULNO})
        Me.dgOgrenciListe.Location = New System.Drawing.Point(362, 23)
        Me.dgOgrenciListe.Margin = New System.Windows.Forms.Padding(4)
        Me.dgOgrenciListe.Name = "dgOgrenciListe"
        Me.dgOgrenciListe.ReadOnly = True
        Me.dgOgrenciListe.RowHeadersWidth = 51
        Me.dgOgrenciListe.Size = New System.Drawing.Size(1003, 203)
        Me.dgOgrenciListe.TabIndex = 16
        '
        'ID
        '
        Me.ID.HeaderText = "ID"
        Me.ID.MinimumWidth = 6
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        Me.ID.Width = 49
        '
        'ADSOYAD
        '
        Me.ADSOYAD.HeaderText = "ADI SOYADI"
        Me.ADSOYAD.MinimumWidth = 6
        Me.ADSOYAD.Name = "ADSOYAD"
        Me.ADSOYAD.ReadOnly = True
        Me.ADSOYAD.Width = 111
        '
        'SINIF
        '
        Me.SINIF.HeaderText = "SINIFI"
        Me.SINIF.MinimumWidth = 6
        Me.SINIF.Name = "SINIF"
        Me.SINIF.ReadOnly = True
        Me.SINIF.Width = 72
        '
        'OKULNO
        '
        Me.OKULNO.HeaderText = "OKUL NO"
        Me.OKULNO.MinimumWidth = 6
        Me.OKULNO.Name = "OKULNO"
        Me.OKULNO.ReadOnly = True
        Me.OKULNO.Width = 94
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ÖğrenciİşlemleriToolStripMenuItem, Me.KitapİşlemleriToolStripMenuItem, Me.RaporlarToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(15, 15)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1391, 28)
        Me.MenuStrip1.TabIndex = 20
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ÖğrenciİşlemleriToolStripMenuItem
        '
        Me.ÖğrenciİşlemleriToolStripMenuItem.Name = "ÖğrenciİşlemleriToolStripMenuItem"
        Me.ÖğrenciİşlemleriToolStripMenuItem.Size = New System.Drawing.Size(135, 24)
        Me.ÖğrenciİşlemleriToolStripMenuItem.Text = "Öğrenci İşlemleri"
        '
        'KitapİşlemleriToolStripMenuItem
        '
        Me.KitapİşlemleriToolStripMenuItem.Name = "KitapİşlemleriToolStripMenuItem"
        Me.KitapİşlemleriToolStripMenuItem.Size = New System.Drawing.Size(118, 24)
        Me.KitapİşlemleriToolStripMenuItem.Text = "Kitap İşlemleri"
        '
        'RaporlarToolStripMenuItem
        '
        Me.RaporlarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GecikenKitaplarToolStripMenuItem})
        Me.RaporlarToolStripMenuItem.Name = "RaporlarToolStripMenuItem"
        Me.RaporlarToolStripMenuItem.Size = New System.Drawing.Size(80, 24)
        Me.RaporlarToolStripMenuItem.Text = "Raporlar"
        '
        'Panel1
        '
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(15, 43)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1391, 30)
        Me.Panel1.TabIndex = 21
        '
        'Panel2
        '
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(15, 318)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1391, 30)
        Me.Panel2.TabIndex = 22
        '
        'Panel3
        '
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(15, 595)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1391, 30)
        Me.Panel3.TabIndex = 23
        '
        'Panel4
        '
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(15, 908)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1391, 30)
        Me.Panel4.TabIndex = 24
        '
        'GecikenKitaplarToolStripMenuItem
        '
        Me.GecikenKitaplarToolStripMenuItem.Name = "GecikenKitaplarToolStripMenuItem"
        Me.GecikenKitaplarToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.GecikenKitaplarToolStripMenuItem.Text = "Geciken Kitaplar"
        '
        'main_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1421, 953)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "main_form"
        Me.Padding = New System.Windows.Forms.Padding(15)
        Me.Text = "Kütüphanem Ana Sayfa"
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.dgOdunc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgKitapListe, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgOgrenciListe, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnKitapAl As Button
    Friend WithEvents btnOduncKitapVer As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtKitapAdi As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtKitapNo As TextBox
    Friend WithEvents txtBarkod As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtOgrenciTamAdi As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtOgrenciNo As TextBox
    Friend WithEvents dgOdunc As DataGridView
    Friend WithEvents OID As DataGridViewTextBoxColumn
    Friend WithEvents OOGRENCIID As DataGridViewTextBoxColumn
    Friend WithEvents OKITAPID As DataGridViewTextBoxColumn
    Friend WithEvents OATARIH As DataGridViewTextBoxColumn
    Friend WithEvents OGTARIH As DataGridViewTextBoxColumn
    Friend WithEvents dgKitapListe As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DNO As DataGridViewTextBoxColumn
    Friend WithEvents BARKOD As DataGridViewTextBoxColumn
    Friend WithEvents ESER As DataGridViewTextBoxColumn
    Friend WithEvents YAZAR As DataGridViewTextBoxColumn
    Friend WithEvents BOLUM As DataGridViewTextBoxColumn
    Friend WithEvents TUR As DataGridViewTextBoxColumn
    Friend WithEvents YAYINEVI As DataGridViewTextBoxColumn
    Friend WithEvents ODUNC As DataGridViewTextBoxColumn
    Friend WithEvents dgOgrenciListe As DataGridView
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents ADSOYAD As DataGridViewTextBoxColumn
    Friend WithEvents SINIF As DataGridViewTextBoxColumn
    Friend WithEvents OKULNO As DataGridViewTextBoxColumn
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ÖğrenciİşlemleriToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KitapİşlemleriToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RaporlarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents GecikenKitaplarToolStripMenuItem As ToolStripMenuItem
End Class
