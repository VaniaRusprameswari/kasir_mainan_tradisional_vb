<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormTransJual
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        LabelJual = New Label()
        LabelIDP = New Label()
        LabelNama = New Label()
        LabelAlamat = New Label()
        LabelTelepon = New Label()
        LBLNoJual = New Label()
        ComboBoxIDP = New ComboBox()
        LBLNamaPlg = New Label()
        LBLAlamat = New Label()
        LBLTelepon = New Label()
        LabelTanggal = New Label()
        LabelJam = New Label()
        LabelAdmin = New Label()
        LBLTanggal = New Label()
        LBLAdmin = New Label()
        LBLJam = New Label()
        LabelHarga = New Label()
        LabelTotal = New Label()
        DataGridView1 = New DataGridView()
        ContextMenuStrip1 = New ContextMenuStrip(components)
        KurangiJumlahMenuItem = New ToolStripMenuItem()
        HapusProdukMenuItem = New ToolStripMenuItem()
        ButtonTutup = New Button()
        Column1 = New DataGridViewTextBoxColumn()
        LabelBayar = New Label()
        LabelKembali = New Label()
        TextBoxBayar = New TextBox()
        LBLKembali = New Label()
        ButtonSimpan = New Button()
        ButtonBatal = New Button()
        Timer1 = New Timer(components)
        ID = New Label()
        LabelNama2 = New Label()
        Nama = New Label()
        LabelHarga2 = New Label()
        Harga = New Label()
        Jumlah = New Label()
        ButtonInsert = New Button()
        TextBoxID = New TextBox()
        TextBoxJumlah = New TextBox()
        nota = New Printing.PrintDocument()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        ContextMenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' LabelJual
        ' 
        LabelJual.BorderStyle = BorderStyle.Fixed3D
        LabelJual.Location = New Point(18, 17)
        LabelJual.Margin = New Padding(2, 0, 2, 0)
        LabelJual.Name = "LabelJual"
        LabelJual.Size = New Size(141, 27)
        LabelJual.TabIndex = 0
        LabelJual.Text = "Nomor Jual"
        ' 
        ' LabelIDP
        ' 
        LabelIDP.BorderStyle = BorderStyle.Fixed3D
        LabelIDP.Location = New Point(18, 43)
        LabelIDP.Margin = New Padding(2, 0, 2, 0)
        LabelIDP.Name = "LabelIDP"
        LabelIDP.Size = New Size(141, 27)
        LabelIDP.TabIndex = 1
        LabelIDP.Text = "ID Pelanggan"
        ' 
        ' LabelNama
        ' 
        LabelNama.BorderStyle = BorderStyle.Fixed3D
        LabelNama.Location = New Point(18, 69)
        LabelNama.Margin = New Padding(2, 0, 2, 0)
        LabelNama.Name = "LabelNama"
        LabelNama.Size = New Size(141, 27)
        LabelNama.TabIndex = 2
        LabelNama.Text = "Nama"
        ' 
        ' LabelAlamat
        ' 
        LabelAlamat.BorderStyle = BorderStyle.Fixed3D
        LabelAlamat.Location = New Point(18, 95)
        LabelAlamat.Margin = New Padding(2, 0, 2, 0)
        LabelAlamat.Name = "LabelAlamat"
        LabelAlamat.Size = New Size(141, 27)
        LabelAlamat.TabIndex = 3
        LabelAlamat.Text = "Alamat"
        ' 
        ' LabelTelepon
        ' 
        LabelTelepon.BorderStyle = BorderStyle.Fixed3D
        LabelTelepon.Location = New Point(18, 122)
        LabelTelepon.Margin = New Padding(2, 0, 2, 0)
        LabelTelepon.Name = "LabelTelepon"
        LabelTelepon.Size = New Size(141, 27)
        LabelTelepon.TabIndex = 4
        LabelTelepon.Text = "Telepon"
        ' 
        ' LBLNoJual
        ' 
        LBLNoJual.BorderStyle = BorderStyle.Fixed3D
        LBLNoJual.Location = New Point(172, 19)
        LBLNoJual.Margin = New Padding(2, 0, 2, 0)
        LBLNoJual.Name = "LBLNoJual"
        LBLNoJual.Size = New Size(141, 27)
        LBLNoJual.TabIndex = 5
        ' 
        ' ComboBoxIDP
        ' 
        ComboBoxIDP.FormattingEnabled = True
        ComboBoxIDP.Location = New Point(172, 48)
        ComboBoxIDP.Margin = New Padding(2)
        ComboBoxIDP.Name = "ComboBoxIDP"
        ComboBoxIDP.Size = New Size(142, 23)
        ComboBoxIDP.TabIndex = 6
        ' 
        ' LBLNamaPlg
        ' 
        LBLNamaPlg.BorderStyle = BorderStyle.Fixed3D
        LBLNamaPlg.Location = New Point(172, 71)
        LBLNamaPlg.Margin = New Padding(2, 0, 2, 0)
        LBLNamaPlg.Name = "LBLNamaPlg"
        LBLNamaPlg.Size = New Size(274, 24)
        LBLNamaPlg.TabIndex = 7
        ' 
        ' LBLAlamat
        ' 
        LBLAlamat.BorderStyle = BorderStyle.Fixed3D
        LBLAlamat.Location = New Point(172, 98)
        LBLAlamat.Margin = New Padding(2, 0, 2, 0)
        LBLAlamat.Name = "LBLAlamat"
        LBLAlamat.Size = New Size(274, 24)
        LBLAlamat.TabIndex = 8
        ' 
        ' LBLTelepon
        ' 
        LBLTelepon.BorderStyle = BorderStyle.Fixed3D
        LBLTelepon.Location = New Point(172, 122)
        LBLTelepon.Margin = New Padding(2, 0, 2, 0)
        LBLTelepon.Name = "LBLTelepon"
        LBLTelepon.Size = New Size(179, 27)
        LBLTelepon.TabIndex = 9
        ' 
        ' LabelTanggal
        ' 
        LabelTanggal.BorderStyle = BorderStyle.Fixed3D
        LabelTanggal.Location = New Point(450, 71)
        LabelTanggal.Margin = New Padding(2, 0, 2, 0)
        LabelTanggal.Name = "LabelTanggal"
        LabelTanggal.Size = New Size(66, 27)
        LabelTanggal.TabIndex = 10
        LabelTanggal.Text = "Tanggal"
        ' 
        ' LabelJam
        ' 
        LabelJam.BorderStyle = BorderStyle.Fixed3D
        LabelJam.Location = New Point(450, 97)
        LabelJam.Margin = New Padding(2, 0, 2, 0)
        LabelJam.Name = "LabelJam"
        LabelJam.Size = New Size(66, 27)
        LabelJam.TabIndex = 11
        LabelJam.Text = "Jam"
        ' 
        ' LabelAdmin
        ' 
        LabelAdmin.BorderStyle = BorderStyle.Fixed3D
        LabelAdmin.Location = New Point(450, 123)
        LabelAdmin.Margin = New Padding(2, 0, 2, 0)
        LabelAdmin.Name = "LabelAdmin"
        LabelAdmin.Size = New Size(66, 27)
        LabelAdmin.TabIndex = 12
        LabelAdmin.Text = "Admin"
        ' 
        ' LBLTanggal
        ' 
        LBLTanggal.BorderStyle = BorderStyle.Fixed3D
        LBLTanggal.Location = New Point(520, 71)
        LBLTanggal.Margin = New Padding(2, 0, 2, 0)
        LBLTanggal.Name = "LBLTanggal"
        LBLTanggal.Size = New Size(208, 27)
        LBLTanggal.TabIndex = 13
        ' 
        ' LBLAdmin
        ' 
        LBLAdmin.BorderStyle = BorderStyle.Fixed3D
        LBLAdmin.Location = New Point(519, 123)
        LBLAdmin.Margin = New Padding(2, 0, 2, 0)
        LBLAdmin.Name = "LBLAdmin"
        LBLAdmin.Size = New Size(209, 27)
        LBLAdmin.TabIndex = 14
        ' 
        ' LBLJam
        ' 
        LBLJam.BorderStyle = BorderStyle.Fixed3D
        LBLJam.Location = New Point(519, 98)
        LBLJam.Margin = New Padding(2, 0, 2, 0)
        LBLJam.Name = "LBLJam"
        LBLJam.Size = New Size(209, 27)
        LBLJam.TabIndex = 15
        ' 
        ' LabelHarga
        ' 
        LabelHarga.BorderStyle = BorderStyle.Fixed3D
        LabelHarga.Font = New Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LabelHarga.Location = New Point(490, 24)
        LabelHarga.Margin = New Padding(2, 0, 2, 0)
        LabelHarga.Name = "LabelHarga"
        LabelHarga.Size = New Size(239, 42)
        LabelHarga.TabIndex = 16
        LabelHarga.Text = "Rp. 25000"
        ' 
        ' LabelTotal
        ' 
        LabelTotal.BorderStyle = BorderStyle.Fixed3D
        LabelTotal.Font = New Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LabelTotal.Location = New Point(317, 24)
        LabelTotal.Margin = New Padding(2, 0, 2, 0)
        LabelTotal.Name = "LabelTotal"
        LabelTotal.Size = New Size(169, 42)
        LabelTotal.TabIndex = 17
        LabelTotal.Text = "TOTAL : Rp."
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.ContextMenuStrip = ContextMenuStrip1
        DataGridView1.Location = New Point(18, 202)
        DataGridView1.Margin = New Padding(2)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 62
        DataGridView1.RowTemplate.Height = 28
        DataGridView1.Size = New Size(710, 183)
        DataGridView1.TabIndex = 18
        ' 
        ' ContextMenuStrip1
        ' 
        ContextMenuStrip1.Items.AddRange(New ToolStripItem() {KurangiJumlahMenuItem, HapusProdukMenuItem})
        ContextMenuStrip1.Name = "ContextMenuStrip1"
        ContextMenuStrip1.Size = New Size(198, 48)
        ' 
        ' KurangiJumlahMenuItem
        ' 
        KurangiJumlahMenuItem.Name = "KurangiJumlahMenuItem"
        KurangiJumlahMenuItem.Size = New Size(197, 22)
        KurangiJumlahMenuItem.Text = "Kurangi Jumlah Produk"
        ' 
        ' HapusProdukMenuItem
        ' 
        HapusProdukMenuItem.Name = "HapusProdukMenuItem"
        HapusProdukMenuItem.Size = New Size(197, 22)
        HapusProdukMenuItem.Text = "Hapus Produk"
        ' 
        ' ButtonTutup
        ' 
        ButtonTutup.BackColor = Color.DarkGray
        ButtonTutup.Location = New Point(272, 404)
        ButtonTutup.Margin = New Padding(2)
        ButtonTutup.Name = "ButtonTutup"
        ButtonTutup.Size = New Size(113, 46)
        ButtonTutup.TabIndex = 25
        ButtonTutup.Text = "TUTUP"
        ButtonTutup.UseVisualStyleBackColor = False
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "Kode"
        Column1.MinimumWidth = 8
        Column1.Name = "Column1"
        Column1.Width = 150
        ' 
        ' LabelBayar
        ' 
        LabelBayar.BorderStyle = BorderStyle.Fixed3D
        LabelBayar.Location = New Point(481, 397)
        LabelBayar.Margin = New Padding(2, 0, 2, 0)
        LabelBayar.Name = "LabelBayar"
        LabelBayar.Size = New Size(97, 27)
        LabelBayar.TabIndex = 19
        LabelBayar.Text = "Di Bayar"
        ' 
        ' LabelKembali
        ' 
        LabelKembali.BorderStyle = BorderStyle.Fixed3D
        LabelKembali.Location = New Point(481, 424)
        LabelKembali.Margin = New Padding(2, 0, 2, 0)
        LabelKembali.Name = "LabelKembali"
        LabelKembali.Size = New Size(97, 27)
        LabelKembali.TabIndex = 20
        LabelKembali.Text = "Kembali"
        ' 
        ' TextBoxBayar
        ' 
        TextBoxBayar.Location = New Point(581, 399)
        TextBoxBayar.Margin = New Padding(2)
        TextBoxBayar.Name = "TextBoxBayar"
        TextBoxBayar.Size = New Size(137, 23)
        TextBoxBayar.TabIndex = 21
        ' 
        ' LBLKembali
        ' 
        LBLKembali.BorderStyle = BorderStyle.Fixed3D
        LBLKembali.Location = New Point(582, 426)
        LBLKembali.Margin = New Padding(2, 0, 2, 0)
        LBLKembali.Name = "LBLKembali"
        LBLKembali.Size = New Size(136, 24)
        LBLKembali.TabIndex = 22
        ' 
        ' ButtonSimpan
        ' 
        ButtonSimpan.BackColor = Color.Lime
        ButtonSimpan.Location = New Point(18, 404)
        ButtonSimpan.Margin = New Padding(2)
        ButtonSimpan.Name = "ButtonSimpan"
        ButtonSimpan.Size = New Size(113, 46)
        ButtonSimpan.TabIndex = 23
        ButtonSimpan.Text = "SIMPAN"
        ButtonSimpan.UseVisualStyleBackColor = False
        ' 
        ' ButtonBatal
        ' 
        ButtonBatal.BackColor = Color.Red
        ButtonBatal.Location = New Point(144, 404)
        ButtonBatal.Margin = New Padding(2)
        ButtonBatal.Name = "ButtonBatal"
        ButtonBatal.Size = New Size(113, 46)
        ButtonBatal.TabIndex = 24
        ButtonBatal.Text = "BATAL"
        ButtonBatal.UseVisualStyleBackColor = False
        ' 
        ' Timer1
        ' 
        Timer1.Enabled = True
        ' 
        ' ID
        ' 
        ID.BorderStyle = BorderStyle.FixedSingle
        ID.Location = New Point(18, 163)
        ID.Margin = New Padding(2, 0, 2, 0)
        ID.Name = "ID"
        ID.Size = New Size(29, 27)
        ID.TabIndex = 26
        ID.Text = "ID :"
        ' 
        ' LabelNama2
        ' 
        LabelNama2.BorderStyle = BorderStyle.Fixed3D
        LabelNama2.Location = New Point(202, 163)
        LabelNama2.Margin = New Padding(2, 0, 2, 0)
        LabelNama2.Name = "LabelNama2"
        LabelNama2.Size = New Size(157, 27)
        LabelNama2.TabIndex = 29
        ' 
        ' Nama
        ' 
        Nama.BorderStyle = BorderStyle.FixedSingle
        Nama.Location = New Point(141, 163)
        Nama.Margin = New Padding(2, 0, 2, 0)
        Nama.Name = "Nama"
        Nama.Size = New Size(51, 27)
        Nama.TabIndex = 28
        Nama.Text = "Nama :"
        ' 
        ' LabelHarga2
        ' 
        LabelHarga2.BorderStyle = BorderStyle.Fixed3D
        LabelHarga2.Location = New Point(430, 163)
        LabelHarga2.Margin = New Padding(2, 0, 2, 0)
        LabelHarga2.Name = "LabelHarga2"
        LabelHarga2.Size = New Size(91, 27)
        LabelHarga2.TabIndex = 31
        ' 
        ' Harga
        ' 
        Harga.BorderStyle = BorderStyle.FixedSingle
        Harga.Location = New Point(369, 163)
        Harga.Margin = New Padding(2, 0, 2, 0)
        Harga.Name = "Harga"
        Harga.Size = New Size(51, 27)
        Harga.TabIndex = 30
        Harga.Text = "Harga :"
        ' 
        ' Jumlah
        ' 
        Jumlah.BorderStyle = BorderStyle.FixedSingle
        Jumlah.Location = New Point(531, 163)
        Jumlah.Margin = New Padding(2, 0, 2, 0)
        Jumlah.Name = "Jumlah"
        Jumlah.Size = New Size(55, 27)
        Jumlah.TabIndex = 32
        Jumlah.Text = "Jumlah :"
        ' 
        ' ButtonInsert
        ' 
        ButtonInsert.BackColor = Color.Lime
        ButtonInsert.Location = New Point(653, 163)
        ButtonInsert.Name = "ButtonInsert"
        ButtonInsert.Size = New Size(75, 27)
        ButtonInsert.TabIndex = 34
        ButtonInsert.Text = "Insert"
        ButtonInsert.UseVisualStyleBackColor = False
        ' 
        ' TextBoxID
        ' 
        TextBoxID.Location = New Point(57, 165)
        TextBoxID.Margin = New Padding(2)
        TextBoxID.Name = "TextBoxID"
        TextBoxID.Size = New Size(74, 23)
        TextBoxID.TabIndex = 35
        ' 
        ' TextBoxJumlah
        ' 
        TextBoxJumlah.Location = New Point(597, 165)
        TextBoxJumlah.Margin = New Padding(2)
        TextBoxJumlah.Name = "TextBoxJumlah"
        TextBoxJumlah.Size = New Size(39, 23)
        TextBoxJumlah.TabIndex = 36
        ' 
        ' nota
        ' 
        ' 
        ' FormTransJual
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightGreen
        ClientSize = New Size(738, 465)
        Controls.Add(TextBoxJumlah)
        Controls.Add(TextBoxID)
        Controls.Add(ButtonInsert)
        Controls.Add(Jumlah)
        Controls.Add(LabelHarga2)
        Controls.Add(Harga)
        Controls.Add(LabelNama2)
        Controls.Add(Nama)
        Controls.Add(ID)
        Controls.Add(ButtonTutup)
        Controls.Add(ButtonBatal)
        Controls.Add(ButtonSimpan)
        Controls.Add(LBLKembali)
        Controls.Add(TextBoxBayar)
        Controls.Add(LabelKembali)
        Controls.Add(LabelBayar)
        Controls.Add(DataGridView1)
        Controls.Add(LabelTotal)
        Controls.Add(LabelHarga)
        Controls.Add(LBLJam)
        Controls.Add(LBLAdmin)
        Controls.Add(LBLTanggal)
        Controls.Add(LabelAdmin)
        Controls.Add(LabelJam)
        Controls.Add(LabelTanggal)
        Controls.Add(LBLTelepon)
        Controls.Add(LBLAlamat)
        Controls.Add(LBLNamaPlg)
        Controls.Add(ComboBoxIDP)
        Controls.Add(LBLNoJual)
        Controls.Add(LabelTelepon)
        Controls.Add(LabelAlamat)
        Controls.Add(LabelNama)
        Controls.Add(LabelIDP)
        Controls.Add(LabelJual)
        Margin = New Padding(2)
        Name = "FormTransJual"
        Text = "FormTransJual"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ContextMenuStrip1.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents LabelJual As Label
    Friend WithEvents LabelIDP As Label
    Friend WithEvents LabelNama As Label
    Friend WithEvents LabelAlamat As Label
    Friend WithEvents LabelTelepon As Label
    Friend WithEvents LBLNoJual As Label
    Friend WithEvents ComboBoxIDP As ComboBox
    Friend WithEvents LBLNamaPlg As Label
    Friend WithEvents LBLAlamat As Label
    Friend WithEvents LBLTelepon As Label
    Friend WithEvents LabelTanggal As Label
    Friend WithEvents LabelJam As Label
    Friend WithEvents LabelAdmin As Label
    Friend WithEvents LBLTanggal As Label
    Friend WithEvents LBLAdmin As Label
    Friend WithEvents LBLJam As Label
    Friend WithEvents LabelHarga As Label
    Friend WithEvents LabelTotal As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ButtonTutup As Button
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents LabelBayar As Label
    Friend WithEvents LabelKembali As Label
    Friend WithEvents TextBoxBayar As TextBox
    Friend WithEvents LBLKembali As Label
    Friend WithEvents ButtonSimpan As Button
    Friend WithEvents ButtonBatal As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents ID As Label
    Friend WithEvents LabelNama2 As Label
    Friend WithEvents Nama As Label
    Friend WithEvents LabelHarga2 As Label
    Friend WithEvents Harga As Label
    Friend WithEvents Jumlah As Label
    Friend WithEvents ButtonInsert As Button
    Friend WithEvents TextBoxID As TextBox
    Friend WithEvents TextBoxJumlah As TextBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents KurangiJumlahMenuItem As ToolStripMenuItem
    Friend WithEvents HapusProdukMenuItem As ToolStripMenuItem
    Friend WithEvents nota As Printing.PrintDocument
End Class