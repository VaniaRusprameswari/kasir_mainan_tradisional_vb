<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAdmin
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
        DataAdmin = New Label()
        TambahAdmin = New GroupBox()
        ComboBoxLevel = New ComboBox()
        DateTimePickerTanggalLahir = New DateTimePicker()
        LabelLevel = New Label()
        TanggalLahir = New Label()
        TextBoxPassword = New TextBox()
        Password = New Label()
        TextBoxEmail = New TextBox()
        Email = New Label()
        TextBoxUsername = New TextBox()
        Username = New Label()
        RadioButtonP = New RadioButton()
        RadioButtonL = New RadioButton()
        JK = New Label()
        BtnKosongkan = New Button()
        BtnHapus = New Button()
        BtnUbah = New Button()
        BtnTambah = New Button()
        TextBoxTlp = New TextBox()
        NoTlp = New Label()
        TextBoxAlamat = New TextBox()
        Alamat = New Label()
        TextBoxNama = New TextBox()
        NamaLengkap = New Label()
        TextBoxID = New TextBox()
        IDAdmin = New Label()
        DataGridView1 = New DataGridView()
        TambahAdmin.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TextBoxCari
        ' 
        TextBoxCari.Location = New Point(296, 99)
        TextBoxCari.Name = "TextBoxCari"
        TextBoxCari.PlaceholderText = "Cari Nama Admin"
        TextBoxCari.Size = New Size(1053, 23)
        TextBoxCari.TabIndex = 29
        ' 
        ' Cari
        ' 
        Cari.AutoSize = True
        Cari.Location = New Point(296, 81)
        Cari.Name = "Cari"
        Cari.Size = New Size(28, 15)
        Cari.TabIndex = 28
        Cari.Text = "Cari"
        ' 
        ' DataAdmin
        ' 
        DataAdmin.AutoSize = True
        DataAdmin.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataAdmin.Location = New Point(18, 23)
        DataAdmin.Name = "DataAdmin"
        DataAdmin.Size = New Size(199, 45)
        DataAdmin.TabIndex = 26
        DataAdmin.Text = "Data Admin"
        ' 
        ' TambahAdmin
        ' 
        TambahAdmin.Controls.Add(ComboBoxLevel)
        TambahAdmin.Controls.Add(DateTimePickerTanggalLahir)
        TambahAdmin.Controls.Add(LabelLevel)
        TambahAdmin.Controls.Add(TanggalLahir)
        TambahAdmin.Controls.Add(TextBoxPassword)
        TambahAdmin.Controls.Add(Password)
        TambahAdmin.Controls.Add(TextBoxEmail)
        TambahAdmin.Controls.Add(Email)
        TambahAdmin.Controls.Add(TextBoxUsername)
        TambahAdmin.Controls.Add(Username)
        TambahAdmin.Controls.Add(RadioButtonP)
        TambahAdmin.Controls.Add(RadioButtonL)
        TambahAdmin.Controls.Add(JK)
        TambahAdmin.Controls.Add(BtnKosongkan)
        TambahAdmin.Controls.Add(BtnHapus)
        TambahAdmin.Controls.Add(BtnUbah)
        TambahAdmin.Controls.Add(BtnTambah)
        TambahAdmin.Controls.Add(TextBoxTlp)
        TambahAdmin.Controls.Add(NoTlp)
        TambahAdmin.Controls.Add(TextBoxAlamat)
        TambahAdmin.Controls.Add(Alamat)
        TambahAdmin.Controls.Add(TextBoxNama)
        TambahAdmin.Controls.Add(NamaLengkap)
        TambahAdmin.Controls.Add(TextBoxID)
        TambahAdmin.Controls.Add(IDAdmin)
        TambahAdmin.Location = New Point(24, 71)
        TambahAdmin.Name = "TambahAdmin"
        TambahAdmin.Size = New Size(254, 613)
        TambahAdmin.TabIndex = 27
        TambahAdmin.TabStop = False
        TambahAdmin.Text = "Tambah Admin"
        ' 
        ' ComboBoxLevel
        ' 
        ComboBoxLevel.FormattingEnabled = True
        ComboBoxLevel.Location = New Point(6, 467)
        ComboBoxLevel.Name = "ComboBoxLevel"
        ComboBoxLevel.Size = New Size(240, 23)
        ComboBoxLevel.TabIndex = 37
        ' 
        ' DateTimePickerTanggalLahir
        ' 
        DateTimePickerTanggalLahir.CustomFormat = "yyyy-MM-dd"
        DateTimePickerTanggalLahir.Format = DateTimePickerFormat.Custom
        DateTimePickerTanggalLahir.Location = New Point(6, 419)
        DateTimePickerTanggalLahir.Name = "DateTimePickerTanggalLahir"
        DateTimePickerTanggalLahir.Size = New Size(240, 23)
        DateTimePickerTanggalLahir.TabIndex = 36
        ' 
        ' LabelLevel
        ' 
        LabelLevel.AutoSize = True
        LabelLevel.Location = New Point(6, 449)
        LabelLevel.Name = "LabelLevel"
        LabelLevel.Size = New Size(34, 15)
        LabelLevel.TabIndex = 32
        LabelLevel.Text = "Level"
        ' 
        ' TanggalLahir
        ' 
        TanggalLahir.AutoSize = True
        TanggalLahir.Location = New Point(6, 401)
        TanggalLahir.Name = "TanggalLahir"
        TanggalLahir.Size = New Size(77, 15)
        TanggalLahir.TabIndex = 34
        TanggalLahir.Text = "Tanggal Lahir"
        ' 
        ' TextBoxPassword
        ' 
        TextBoxPassword.Location = New Point(6, 181)
        TextBoxPassword.Name = "TextBoxPassword"
        TextBoxPassword.PasswordChar = "X"c
        TextBoxPassword.Size = New Size(240, 23)
        TextBoxPassword.TabIndex = 31
        ' 
        ' Password
        ' 
        Password.AutoSize = True
        Password.Location = New Point(6, 163)
        Password.Name = "Password"
        Password.Size = New Size(57, 15)
        Password.TabIndex = 30
        Password.Text = "Password"
        ' 
        ' TextBoxEmail
        ' 
        TextBoxEmail.Location = New Point(6, 133)
        TextBoxEmail.Name = "TextBoxEmail"
        TextBoxEmail.Size = New Size(240, 23)
        TextBoxEmail.TabIndex = 29
        ' 
        ' Email
        ' 
        Email.AutoSize = True
        Email.Location = New Point(6, 115)
        Email.Name = "Email"
        Email.Size = New Size(36, 15)
        Email.TabIndex = 28
        Email.Text = "Email"
        ' 
        ' TextBoxUsername
        ' 
        TextBoxUsername.Location = New Point(6, 85)
        TextBoxUsername.Name = "TextBoxUsername"
        TextBoxUsername.Size = New Size(240, 23)
        TextBoxUsername.TabIndex = 27
        ' 
        ' Username
        ' 
        Username.AutoSize = True
        Username.Location = New Point(6, 67)
        Username.Name = "Username"
        Username.Size = New Size(60, 15)
        Username.TabIndex = 26
        Username.Text = "Username"
        ' 
        ' RadioButtonP
        ' 
        RadioButtonP.AutoSize = True
        RadioButtonP.Location = New Point(101, 282)
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
        RadioButtonL.Location = New Point(6, 282)
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
        JK.Location = New Point(6, 261)
        JK.Name = "JK"
        JK.Size = New Size(78, 15)
        JK.TabIndex = 18
        JK.Text = "Jenis Kelamin"
        ' 
        ' BtnKosongkan
        ' 
        BtnKosongkan.BackColor = Color.DarkGray
        BtnKosongkan.Location = New Point(129, 561)
        BtnKosongkan.Name = "BtnKosongkan"
        BtnKosongkan.Size = New Size(117, 41)
        BtnKosongkan.TabIndex = 17
        BtnKosongkan.Text = "Kosongkan"
        BtnKosongkan.UseVisualStyleBackColor = False
        ' 
        ' BtnHapus
        ' 
        BtnHapus.BackColor = Color.Red
        BtnHapus.Location = New Point(6, 563)
        BtnHapus.Name = "BtnHapus"
        BtnHapus.Size = New Size(117, 41)
        BtnHapus.TabIndex = 16
        BtnHapus.Text = "Hapus"
        BtnHapus.UseVisualStyleBackColor = False
        ' 
        ' BtnUbah
        ' 
        BtnUbah.BackColor = Color.Yellow
        BtnUbah.Location = New Point(129, 516)
        BtnUbah.Name = "BtnUbah"
        BtnUbah.Size = New Size(117, 41)
        BtnUbah.TabIndex = 15
        BtnUbah.Text = "Ubah"
        BtnUbah.UseVisualStyleBackColor = False
        ' 
        ' BtnTambah
        ' 
        BtnTambah.BackColor = Color.Lime
        BtnTambah.Location = New Point(6, 516)
        BtnTambah.Name = "BtnTambah"
        BtnTambah.Size = New Size(117, 41)
        BtnTambah.TabIndex = 14
        BtnTambah.Text = "Tambah"
        BtnTambah.UseVisualStyleBackColor = False
        ' 
        ' TextBoxTlp
        ' 
        TextBoxTlp.Location = New Point(6, 371)
        TextBoxTlp.Name = "TextBoxTlp"
        TextBoxTlp.Size = New Size(240, 23)
        TextBoxTlp.TabIndex = 13
        ' 
        ' NoTlp
        ' 
        NoTlp.AutoSize = True
        NoTlp.Location = New Point(6, 353)
        NoTlp.Name = "NoTlp"
        NoTlp.Size = New Size(42, 15)
        NoTlp.TabIndex = 12
        NoTlp.Text = "No Tlp"
        ' 
        ' TextBoxAlamat
        ' 
        TextBoxAlamat.Location = New Point(6, 325)
        TextBoxAlamat.Name = "TextBoxAlamat"
        TextBoxAlamat.Size = New Size(240, 23)
        TextBoxAlamat.TabIndex = 11
        ' 
        ' Alamat
        ' 
        Alamat.AutoSize = True
        Alamat.Location = New Point(6, 307)
        Alamat.Name = "Alamat"
        Alamat.Size = New Size(45, 15)
        Alamat.TabIndex = 10
        Alamat.Text = "Alamat"
        ' 
        ' TextBoxNama
        ' 
        TextBoxNama.Location = New Point(6, 229)
        TextBoxNama.Name = "TextBoxNama"
        TextBoxNama.Size = New Size(240, 23)
        TextBoxNama.TabIndex = 9
        ' 
        ' NamaLengkap
        ' 
        NamaLengkap.AutoSize = True
        NamaLengkap.Location = New Point(6, 211)
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
        ' IDAdmin
        ' 
        IDAdmin.AutoSize = True
        IDAdmin.Location = New Point(6, 19)
        IDAdmin.Name = "IDAdmin"
        IDAdmin.Size = New Size(57, 15)
        IDAdmin.TabIndex = 0
        IDAdmin.Text = "ID Admin"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(296, 128)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(1025, 556)
        DataGridView1.TabIndex = 25
        ' 
        ' FormAdmin
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightGreen
        ClientSize = New Size(1333, 696)
        Controls.Add(TextBoxCari)
        Controls.Add(Cari)
        Controls.Add(DataAdmin)
        Controls.Add(TambahAdmin)
        Controls.Add(DataGridView1)
        Name = "FormAdmin"
        Text = "FormAdmin"
        TambahAdmin.ResumeLayout(False)
        TambahAdmin.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBoxCari As TextBox
    Friend WithEvents Cari As Label
    Friend WithEvents DataAdmin As Label
    Friend WithEvents TambahAdmin As GroupBox
    Friend WithEvents RadioButtonP As RadioButton
    Friend WithEvents RadioButtonL As RadioButton
    Friend WithEvents JK As Label
    Friend WithEvents BtnKosongkan As Button
    Friend WithEvents BtnHapus As Button
    Friend WithEvents BtnUbah As Button
    Friend WithEvents BtnTambah As Button
    Friend WithEvents TextBoxTlp As TextBox
    Friend WithEvents NoTlp As Label
    Friend WithEvents TextBoxAlamat As TextBox
    Friend WithEvents Alamat As Label
    Friend WithEvents TextBoxNama As TextBox
    Friend WithEvents NamaLengkap As Label
    Friend WithEvents TextBoxID As TextBox
    Friend WithEvents IDAdmin As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TextBoxPassword As TextBox
    Friend WithEvents Password As Label
    Friend WithEvents TextBoxEmail As TextBox
    Friend WithEvents Email As Label
    Friend WithEvents TextBoxUsername As TextBox
    Friend WithEvents Username As Label
    Friend WithEvents LabelLevel As Label
    Friend WithEvents TanggalLahir As Label
    Friend WithEvents DateTimePickerTanggalLahir As DateTimePicker
    Friend WithEvents ComboBoxLevel As ComboBox
End Class
