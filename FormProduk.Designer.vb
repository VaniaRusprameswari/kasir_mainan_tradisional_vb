<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormProduk
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        DataGridView1 = New DataGridView()
        DataProduk = New Label()
        TambahProduk = New GroupBox()
        BtnKosongkan = New Button()
        BtnHapus = New Button()
        BtnUbah = New Button()
        BtnTambah = New Button()
        TextBoxHarga = New TextBox()
        Harga = New Label()
        TextBoxStok = New TextBox()
        Stok = New Label()
        TextBoxNama = New TextBox()
        NamaProduk = New Label()
        TextBoxID = New TextBox()
        IDProduk = New Label()
        TextBoxCari = New TextBox()
        Cari = New Label()
        OpenFileDialog1 = New OpenFileDialog()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        TambahProduk.SuspendLayout()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(290, 114)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(451, 282)
        DataGridView1.TabIndex = 0
        ' 
        ' DataProduk
        ' 
        DataProduk.AutoSize = True
        DataProduk.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataProduk.Location = New Point(12, 9)
        DataProduk.Name = "DataProduk"
        DataProduk.Size = New Size(209, 45)
        DataProduk.TabIndex = 1
        DataProduk.Text = "Data Produk"
        ' 
        ' TambahProduk
        ' 
        TambahProduk.Controls.Add(BtnKosongkan)
        TambahProduk.Controls.Add(BtnHapus)
        TambahProduk.Controls.Add(BtnUbah)
        TambahProduk.Controls.Add(BtnTambah)
        TambahProduk.Controls.Add(TextBoxHarga)
        TambahProduk.Controls.Add(Harga)
        TambahProduk.Controls.Add(TextBoxStok)
        TambahProduk.Controls.Add(Stok)
        TambahProduk.Controls.Add(TextBoxNama)
        TambahProduk.Controls.Add(NamaProduk)
        TambahProduk.Controls.Add(TextBoxID)
        TambahProduk.Controls.Add(IDProduk)
        TambahProduk.Location = New Point(18, 57)
        TambahProduk.Name = "TambahProduk"
        TambahProduk.Size = New Size(254, 339)
        TambahProduk.TabIndex = 2
        TambahProduk.TabStop = False
        TambahProduk.Text = "Tambah Produk"
        ' 
        ' BtnKosongkan
        ' 
        BtnKosongkan.BackColor = Color.DarkGray
        BtnKosongkan.Location = New Point(129, 278)
        BtnKosongkan.Name = "BtnKosongkan"
        BtnKosongkan.Size = New Size(117, 41)
        BtnKosongkan.TabIndex = 17
        BtnKosongkan.Text = "Kosongkan"
        BtnKosongkan.UseVisualStyleBackColor = False
        ' 
        ' BtnHapus
        ' 
        BtnHapus.BackColor = Color.Red
        BtnHapus.Location = New Point(6, 278)
        BtnHapus.Name = "BtnHapus"
        BtnHapus.Size = New Size(117, 41)
        BtnHapus.TabIndex = 16
        BtnHapus.Text = "Hapus"
        BtnHapus.UseVisualStyleBackColor = False
        ' 
        ' BtnUbah
        ' 
        BtnUbah.BackColor = Color.Yellow
        BtnUbah.Location = New Point(129, 231)
        BtnUbah.Name = "BtnUbah"
        BtnUbah.Size = New Size(117, 41)
        BtnUbah.TabIndex = 15
        BtnUbah.Text = "Ubah"
        BtnUbah.UseVisualStyleBackColor = False
        ' 
        ' BtnTambah
        ' 
        BtnTambah.BackColor = Color.Lime
        BtnTambah.Location = New Point(6, 231)
        BtnTambah.Name = "BtnTambah"
        BtnTambah.Size = New Size(117, 41)
        BtnTambah.TabIndex = 14
        BtnTambah.Text = "Tambah"
        BtnTambah.UseVisualStyleBackColor = False
        ' 
        ' TextBoxHarga
        ' 
        TextBoxHarga.Location = New Point(6, 182)
        TextBoxHarga.Name = "TextBoxHarga"
        TextBoxHarga.Size = New Size(240, 23)
        TextBoxHarga.TabIndex = 11
        ' 
        ' Harga
        ' 
        Harga.AutoSize = True
        Harga.Location = New Point(6, 164)
        Harga.Name = "Harga"
        Harga.Size = New Size(39, 15)
        Harga.TabIndex = 10
        Harga.Text = "Harga"
        ' 
        ' TextBoxStok
        ' 
        TextBoxStok.Location = New Point(6, 134)
        TextBoxStok.Name = "TextBoxStok"
        TextBoxStok.Size = New Size(240, 23)
        TextBoxStok.TabIndex = 9
        ' 
        ' Stok
        ' 
        Stok.AutoSize = True
        Stok.Location = New Point(6, 116)
        Stok.Name = "Stok"
        Stok.Size = New Size(30, 15)
        Stok.TabIndex = 8
        Stok.Text = "Stok"
        ' 
        ' TextBoxNama
        ' 
        TextBoxNama.Location = New Point(6, 86)
        TextBoxNama.Name = "TextBoxNama"
        TextBoxNama.Size = New Size(240, 23)
        TextBoxNama.TabIndex = 3
        ' 
        ' NamaProduk
        ' 
        NamaProduk.AutoSize = True
        NamaProduk.Location = New Point(6, 68)
        NamaProduk.Name = "NamaProduk"
        NamaProduk.Size = New Size(80, 15)
        NamaProduk.TabIndex = 2
        NamaProduk.Text = "Nama Produk"
        ' 
        ' TextBoxID
        ' 
        TextBoxID.Location = New Point(6, 37)
        TextBoxID.Name = "TextBoxID"
        TextBoxID.Size = New Size(240, 23)
        TextBoxID.TabIndex = 1
        ' 
        ' IDProduk
        ' 
        IDProduk.AutoSize = True
        IDProduk.Location = New Point(6, 19)
        IDProduk.Name = "IDProduk"
        IDProduk.Size = New Size(59, 15)
        IDProduk.TabIndex = 0
        IDProduk.Text = "ID Produk"
        ' 
        ' TextBoxCari
        ' 
        TextBoxCari.Location = New Point(290, 85)
        TextBoxCari.Name = "TextBoxCari"
        TextBoxCari.PlaceholderText = "Cari Nama Produk"
        TextBoxCari.Size = New Size(451, 23)
        TextBoxCari.TabIndex = 19
        ' 
        ' Cari
        ' 
        Cari.AutoSize = True
        Cari.Location = New Point(290, 67)
        Cari.Name = "Cari"
        Cari.Size = New Size(28, 15)
        Cari.TabIndex = 18
        Cari.Text = "Cari"
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' FormProduk
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightGreen
        ClientSize = New Size(754, 409)
        Controls.Add(TextBoxCari)
        Controls.Add(Cari)
        Controls.Add(TambahProduk)
        Controls.Add(DataProduk)
        Controls.Add(DataGridView1)
        Name = "FormProduk"
        Text = "FormProduk"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        TambahProduk.ResumeLayout(False)
        TambahProduk.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DataProduk As Label
    Friend WithEvents TambahProduk As GroupBox
    Friend WithEvents IDProduk As Label
    Friend WithEvents TextBoxID As TextBox
    Friend WithEvents TextBoxNama As TextBox
    Friend WithEvents NamaProduk As Label
    Friend WithEvents TextBoxStok As TextBox
    Friend WithEvents Stok As Label
    Friend WithEvents TextBoxHarga As TextBox
    Friend WithEvents Harga As Label
    Friend WithEvents BtnTambah As Button
    Friend WithEvents BtnUbah As Button
    Friend WithEvents BtnHapus As Button
    Friend WithEvents BtnKosongkan As Button
    Friend WithEvents TextBoxCari As TextBox
    Friend WithEvents Cari As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog

End Class
