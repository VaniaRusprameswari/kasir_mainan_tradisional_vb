<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPelanggan
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        TextBoxCari = New TextBox()
        Cari = New Label()
        BtnKosongkan = New Button()
        BtnHapus = New Button()
        BtnUbah = New Button()
        BtnTambah = New Button()
        NoTlp = New Label()
        TextBoxAlamat = New TextBox()
        Alamat = New Label()
        TextBoxNama = New TextBox()
        DataPelanggan = New Label()
        NamaLengkap = New Label()
        TextBoxID = New TextBox()
        IDPelanggan = New Label()
        TambahPelanggan = New GroupBox()
        RadioButtonP = New RadioButton()
        RadioButtonL = New RadioButton()
        JK = New Label()
        TextBoxTlp = New TextBox()
        DataGridView1 = New DataGridView()
        TambahPelanggan.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TextBoxCari
        ' 
        TextBoxCari.Location = New Point(290, 89)
        TextBoxCari.Name = "TextBoxCari"
        TextBoxCari.PlaceholderText = "Cari Nama Pelanggan"
        TextBoxCari.Size = New Size(540, 23)
        TextBoxCari.TabIndex = 24
        ' 
        ' Cari
        ' 
        Cari.AutoSize = True
        Cari.Location = New Point(290, 71)
        Cari.Name = "Cari"
        Cari.Size = New Size(28, 15)
        Cari.TabIndex = 23
        Cari.Text = "Cari"
        ' 
        ' BtnKosongkan
        ' 
        BtnKosongkan.BackColor = Color.DarkGray
        BtnKosongkan.Location = New Point(129, 314)
        BtnKosongkan.Name = "BtnKosongkan"
        BtnKosongkan.Size = New Size(117, 41)
        BtnKosongkan.TabIndex = 17
        BtnKosongkan.Text = "Kosongkan"
        BtnKosongkan.UseVisualStyleBackColor = False
        ' 
        ' BtnHapus
        ' 
        BtnHapus.BackColor = Color.Red
        BtnHapus.Location = New Point(6, 316)
        BtnHapus.Name = "BtnHapus"
        BtnHapus.Size = New Size(117, 41)
        BtnHapus.TabIndex = 16
        BtnHapus.Text = "Hapus"
        BtnHapus.UseVisualStyleBackColor = False
        ' 
        ' BtnUbah
        ' 
        BtnUbah.BackColor = Color.Yellow
        BtnUbah.Location = New Point(129, 269)
        BtnUbah.Name = "BtnUbah"
        BtnUbah.Size = New Size(117, 41)
        BtnUbah.TabIndex = 15
        BtnUbah.Text = "Ubah"
        BtnUbah.UseVisualStyleBackColor = False
        ' 
        ' BtnTambah
        ' 
        BtnTambah.BackColor = Color.Lime
        BtnTambah.Location = New Point(6, 269)
        BtnTambah.Name = "BtnTambah"
        BtnTambah.Size = New Size(117, 41)
        BtnTambah.TabIndex = 14
        BtnTambah.Text = "Tambah"
        BtnTambah.UseVisualStyleBackColor = False
        ' 
        ' NoTlp
        ' 
        NoTlp.AutoSize = True
        NoTlp.Location = New Point(6, 207)
        NoTlp.Name = "NoTlp"
        NoTlp.Size = New Size(42, 15)
        NoTlp.TabIndex = 12
        NoTlp.Text = "No Tlp"
        ' 
        ' TextBoxAlamat
        ' 
        TextBoxAlamat.Location = New Point(6, 179)
        TextBoxAlamat.Name = "TextBoxAlamat"
        TextBoxAlamat.Size = New Size(240, 23)
        TextBoxAlamat.TabIndex = 11
        ' 
        ' Alamat
        ' 
        Alamat.AutoSize = True
        Alamat.Location = New Point(6, 161)
        Alamat.Name = "Alamat"
        Alamat.Size = New Size(45, 15)
        Alamat.TabIndex = 10
        Alamat.Text = "Alamat"
        ' 
        ' TextBoxNama
        ' 
        TextBoxNama.Location = New Point(6, 83)
        TextBoxNama.Name = "TextBoxNama"
        TextBoxNama.Size = New Size(240, 23)
        TextBoxNama.TabIndex = 9
        ' 
        ' DataPelanggan
        ' 
        DataPelanggan.AutoSize = True
        DataPelanggan.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataPelanggan.Location = New Point(12, 13)
        DataPelanggan.Name = "DataPelanggan"
        DataPelanggan.Size = New Size(256, 45)
        DataPelanggan.TabIndex = 21
        DataPelanggan.Text = "Data Pelanggan"
        ' 
        ' NamaLengkap
        ' 
        NamaLengkap.AutoSize = True
        NamaLengkap.Location = New Point(6, 65)
        NamaLengkap.Name = "NamaLengkap"
        NamaLengkap.Size = New Size(87, 15)
        NamaLengkap.TabIndex = 8
        NamaLengkap.Text = "Nama Lengkap"
        ' 
        ' TextBoxID
        ' 
        TextBoxID.Location = New Point(6, 37)
        TextBoxID.Name = "TextBoxID"
        TextBoxID.Size = New Size(240, 23)
        TextBoxID.TabIndex = 1
        ' 
        ' IDPelanggan
        ' 
        IDPelanggan.AutoSize = True
        IDPelanggan.Location = New Point(6, 19)
        IDPelanggan.Name = "IDPelanggan"
        IDPelanggan.Size = New Size(77, 15)
        IDPelanggan.TabIndex = 0
        IDPelanggan.Text = "ID Pelanggan"
        ' 
        ' TambahPelanggan
        ' 
        TambahPelanggan.Controls.Add(RadioButtonP)
        TambahPelanggan.Controls.Add(RadioButtonL)
        TambahPelanggan.Controls.Add(JK)
        TambahPelanggan.Controls.Add(BtnKosongkan)
        TambahPelanggan.Controls.Add(BtnHapus)
        TambahPelanggan.Controls.Add(BtnUbah)
        TambahPelanggan.Controls.Add(BtnTambah)
        TambahPelanggan.Controls.Add(TextBoxTlp)
        TambahPelanggan.Controls.Add(NoTlp)
        TambahPelanggan.Controls.Add(TextBoxAlamat)
        TambahPelanggan.Controls.Add(Alamat)
        TambahPelanggan.Controls.Add(TextBoxNama)
        TambahPelanggan.Controls.Add(NamaLengkap)
        TambahPelanggan.Controls.Add(TextBoxID)
        TambahPelanggan.Controls.Add(IDPelanggan)
        TambahPelanggan.Location = New Point(18, 61)
        TambahPelanggan.Name = "TambahPelanggan"
        TambahPelanggan.Size = New Size(254, 370)
        TambahPelanggan.TabIndex = 22
        TambahPelanggan.TabStop = False
        TambahPelanggan.Text = "Tambah Pelanggan"
        ' 
        ' RadioButtonP
        ' 
        RadioButtonP.AutoSize = True
        RadioButtonP.Location = New Point(101, 136)
        RadioButtonP.Name = "RadioButtonP"
        RadioButtonP.Size = New Size(86, 19)
        RadioButtonP.TabIndex = 25
        RadioButtonP.TabStop = True
        RadioButtonP.Text = "Perempuan"
        RadioButtonP.UseVisualStyleBackColor = True
        ' 
        ' RadioButtonL
        ' 
        RadioButtonL.AutoSize = True
        RadioButtonL.Location = New Point(6, 136)
        RadioButtonL.Name = "RadioButtonL"
        RadioButtonL.Size = New Size(72, 19)
        RadioButtonL.TabIndex = 24
        RadioButtonL.TabStop = True
        RadioButtonL.Text = "Laki-Laki"
        RadioButtonL.UseVisualStyleBackColor = True
        ' 
        ' JK
        ' 
        JK.AutoSize = True
        JK.Location = New Point(6, 115)
        JK.Name = "JK"
        JK.Size = New Size(78, 15)
        JK.TabIndex = 18
        JK.Text = "Jenis Kelamin"
        ' 
        ' TextBoxTlp
        ' 
        TextBoxTlp.Location = New Point(6, 225)
        TextBoxTlp.Name = "TextBoxTlp"
        TextBoxTlp.Size = New Size(240, 23)
        TextBoxTlp.TabIndex = 13
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(290, 118)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(540, 314)
        DataGridView1.TabIndex = 20
        ' 
        ' FormPelanggan
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightGreen
        ClientSize = New Size(842, 443)
        Controls.Add(TextBoxCari)
        Controls.Add(Cari)
        Controls.Add(DataPelanggan)
        Controls.Add(TambahPelanggan)
        Controls.Add(DataGridView1)
        Name = "FormPelanggan"
        Text = "Form Pelanggan"
        TambahPelanggan.ResumeLayout(False)
        TambahPelanggan.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBoxCari As TextBox
    Friend WithEvents Cari As Label
    Friend WithEvents BtnKosongkan As Button
    Friend WithEvents BtnHapus As Button
    Friend WithEvents BtnUbah As Button
    Friend WithEvents BtnTambah As Button
    Friend WithEvents NoTlp As Label
    Friend WithEvents TextBoxAlamat As TextBox
    Friend WithEvents Alamat As Label
    Friend WithEvents TextBoxNama As TextBox
    Friend WithEvents DataPelanggan As Label
    Friend WithEvents NamaLengkap As Label
    Friend WithEvents TextBoxID As TextBox
    Friend WithEvents IDPelanggan As Label
    Friend WithEvents TambahPelanggan As GroupBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents JK As Label
    Friend WithEvents RadioButtonP As RadioButton
    Friend WithEvents RadioButtonL As RadioButton
    Friend WithEvents TextBoxTlp As TextBox
End Class
