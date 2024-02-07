<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Delayed_Books_List
    Inherits System.Windows.Forms.Form

    'Form, bileşen listesini temizlemeyi bırakmayı geçersiz kılar.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.datagridview1 = New System.Windows.Forms.DataGridView()
        Me.OID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OOGRENCIID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OKITAPID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OATARIH = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OGTARIH = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.datagridview1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'datagridview1
        '
        Me.datagridview1.AllowUserToAddRows = False
        Me.datagridview1.AllowUserToDeleteRows = False
        Me.datagridview1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.datagridview1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.datagridview1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagridview1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.OID, Me.OOGRENCIID, Me.OKITAPID, Me.OATARIH, Me.OGTARIH})
        Me.datagridview1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.datagridview1.Location = New System.Drawing.Point(0, 0)
        Me.datagridview1.Margin = New System.Windows.Forms.Padding(4)
        Me.datagridview1.Name = "datagridview1"
        Me.datagridview1.ReadOnly = True
        Me.datagridview1.RowHeadersWidth = 51
        Me.datagridview1.Size = New System.Drawing.Size(1248, 583)
        Me.datagridview1.TabIndex = 19
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
        'Delayed_Books_List
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1248, 583)
        Me.Controls.Add(Me.datagridview1)
        Me.Name = "Delayed_Books_List"
        Me.Text = "Geciken Kitaplar"
        Me.TopMost = True
        CType(Me.datagridview1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents datagridview1 As DataGridView
    Friend WithEvents OID As DataGridViewTextBoxColumn
    Friend WithEvents OOGRENCIID As DataGridViewTextBoxColumn
    Friend WithEvents OKITAPID As DataGridViewTextBoxColumn
    Friend WithEvents OATARIH As DataGridViewTextBoxColumn
    Friend WithEvents OGTARIH As DataGridViewTextBoxColumn
End Class
