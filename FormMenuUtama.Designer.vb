<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMenuUtama
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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMenuUtama))
        MenuStrip1 = New MenuStrip()
        FileToolStripMenuItem = New ToolStripMenuItem()
        LoginToolStripMenuItem = New ToolStripMenuItem()
        LogoutToolStripMenuItem = New ToolStripMenuItem()
        KeluarToolStripMenuItem = New ToolStripMenuItem()
        DataToolStripMenuItem = New ToolStripMenuItem()
        AToolStripMenuItem = New ToolStripMenuItem()
        PelangganToolStripMenuItem = New ToolStripMenuItem()
        ProdukToolStripMenuItem = New ToolStripSeparator()
        ProdukToolStripMenuItem1 = New ToolStripMenuItem()
        TransaksiToolStripMenuItem = New ToolStripMenuItem()
        PenjualanToolStripMenuItem = New ToolStripMenuItem()
        LaporanToolStripMenuItem = New ToolStripMenuItem()
        LaporanPenjualanToolStripMenuItem = New ToolStripMenuItem()
        StatusStrip1 = New StatusStrip()
        STLabel1 = New ToolStripStatusLabel()
        STLabel2 = New ToolStripStatusLabel()
        STLabel3 = New ToolStripStatusLabel()
        STLabel4 = New ToolStripStatusLabel()
        STLabel5 = New ToolStripStatusLabel()
        STLabel6 = New ToolStripStatusLabel()
        STLabel7 = New ToolStripStatusLabel()
        STLabel8 = New ToolStripStatusLabel()
        STLabel9 = New ToolStripStatusLabel()
        STLabel10 = New ToolStripStatusLabel()
        Timer1 = New Timer(components)
        MenuStrip1.SuspendLayout()
        StatusStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.BackColor = Color.LightGreen
        MenuStrip1.Items.AddRange(New ToolStripItem() {FileToolStripMenuItem, DataToolStripMenuItem, TransaksiToolStripMenuItem, LaporanToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(800, 24)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' FileToolStripMenuItem
        ' 
        FileToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {LoginToolStripMenuItem, LogoutToolStripMenuItem, KeluarToolStripMenuItem})
        FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        FileToolStripMenuItem.Size = New Size(37, 20)
        FileToolStripMenuItem.Text = "File"
        ' 
        ' LoginToolStripMenuItem
        ' 
        LoginToolStripMenuItem.Name = "LoginToolStripMenuItem"
        LoginToolStripMenuItem.Size = New Size(180, 22)
        LoginToolStripMenuItem.Text = "Login"
        ' 
        ' LogoutToolStripMenuItem
        ' 
        LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        LogoutToolStripMenuItem.Size = New Size(180, 22)
        LogoutToolStripMenuItem.Text = "Logout"
        ' 
        ' KeluarToolStripMenuItem
        ' 
        KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
        KeluarToolStripMenuItem.Size = New Size(180, 22)
        KeluarToolStripMenuItem.Text = "Keluar"
        ' 
        ' DataToolStripMenuItem
        ' 
        DataToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {AToolStripMenuItem, PelangganToolStripMenuItem, ProdukToolStripMenuItem, ProdukToolStripMenuItem1})
        DataToolStripMenuItem.Name = "DataToolStripMenuItem"
        DataToolStripMenuItem.Size = New Size(43, 20)
        DataToolStripMenuItem.Text = "Data"
        ' 
        ' AToolStripMenuItem
        ' 
        AToolStripMenuItem.Name = "AToolStripMenuItem"
        AToolStripMenuItem.Size = New Size(130, 22)
        AToolStripMenuItem.Text = "Admin"
        ' 
        ' PelangganToolStripMenuItem
        ' 
        PelangganToolStripMenuItem.Name = "PelangganToolStripMenuItem"
        PelangganToolStripMenuItem.Size = New Size(130, 22)
        PelangganToolStripMenuItem.Text = "Pelanggan"
        ' 
        ' ProdukToolStripMenuItem
        ' 
        ProdukToolStripMenuItem.Name = "ProdukToolStripMenuItem"
        ProdukToolStripMenuItem.Size = New Size(127, 6)
        ' 
        ' ProdukToolStripMenuItem1
        ' 
        ProdukToolStripMenuItem1.Name = "ProdukToolStripMenuItem1"
        ProdukToolStripMenuItem1.Size = New Size(130, 22)
        ProdukToolStripMenuItem1.Text = "Produk"
        ' 
        ' TransaksiToolStripMenuItem
        ' 
        TransaksiToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {PenjualanToolStripMenuItem})
        TransaksiToolStripMenuItem.Name = "TransaksiToolStripMenuItem"
        TransaksiToolStripMenuItem.Size = New Size(66, 20)
        TransaksiToolStripMenuItem.Text = "Transaksi"
        ' 
        ' PenjualanToolStripMenuItem
        ' 
        PenjualanToolStripMenuItem.Name = "PenjualanToolStripMenuItem"
        PenjualanToolStripMenuItem.Size = New Size(126, 22)
        PenjualanToolStripMenuItem.Text = "Penjualan"
        ' 
        ' LaporanToolStripMenuItem
        ' 
        LaporanToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {LaporanPenjualanToolStripMenuItem})
        LaporanToolStripMenuItem.Name = "LaporanToolStripMenuItem"
        LaporanToolStripMenuItem.Size = New Size(62, 20)
        LaporanToolStripMenuItem.Text = "Laporan"
        ' 
        ' LaporanPenjualanToolStripMenuItem
        ' 
        LaporanPenjualanToolStripMenuItem.Name = "LaporanPenjualanToolStripMenuItem"
        LaporanPenjualanToolStripMenuItem.Size = New Size(180, 22)
        LaporanPenjualanToolStripMenuItem.Text = "Laporan Penjualan"
        ' 
        ' StatusStrip1
        ' 
        StatusStrip1.BackColor = Color.LightGreen
        StatusStrip1.Items.AddRange(New ToolStripItem() {STLabel1, STLabel2, STLabel3, STLabel4, STLabel5, STLabel6, STLabel7, STLabel8, STLabel9, STLabel10})
        StatusStrip1.Location = New Point(0, 428)
        StatusStrip1.Name = "StatusStrip1"
        StatusStrip1.Size = New Size(800, 22)
        StatusStrip1.TabIndex = 1
        StatusStrip1.Text = "StatusStrip1"
        ' 
        ' STLabel1
        ' 
        STLabel1.Name = "STLabel1"
        STLabel1.Size = New Size(63, 17)
        STLabel1.Text = "ID Admin :"
        ' 
        ' STLabel2
        ' 
        STLabel2.Name = "STLabel2"
        STLabel2.Size = New Size(0, 17)
        ' 
        ' STLabel3
        ' 
        STLabel3.Name = "STLabel3"
        STLabel3.Size = New Size(45, 17)
        STLabel3.Text = "Nama :"
        ' 
        ' STLabel4
        ' 
        STLabel4.Name = "STLabel4"
        STLabel4.Size = New Size(0, 17)
        ' 
        ' STLabel5
        ' 
        STLabel5.Name = "STLabel5"
        STLabel5.Size = New Size(40, 17)
        STLabel5.Text = "Level :"
        ' 
        ' STLabel6
        ' 
        STLabel6.Name = "STLabel6"
        STLabel6.Size = New Size(0, 17)
        ' 
        ' STLabel7
        ' 
        STLabel7.Name = "STLabel7"
        STLabel7.Size = New Size(34, 17)
        STLabel7.Text = "Jam :"
        ' 
        ' STLabel8
        ' 
        STLabel8.Name = "STLabel8"
        STLabel8.Size = New Size(0, 17)
        ' 
        ' STLabel9
        ' 
        STLabel9.Name = "STLabel9"
        STLabel9.Size = New Size(54, 17)
        STLabel9.Text = "Tanggal :"
        ' 
        ' STLabel10
        ' 
        STLabel10.Name = "STLabel10"
        STLabel10.Size = New Size(0, 17)
        ' 
        ' Timer1
        ' 
        Timer1.Enabled = True
        ' 
        ' FormMenuUtama
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightGreen
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(800, 450)
        Controls.Add(StatusStrip1)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "FormMenuUtama"
        Text = "FormMenuUtama"
        WindowState = FormWindowState.Maximized
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        StatusStrip1.ResumeLayout(False)
        StatusStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LoginToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KeluarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PelangganToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProdukToolStripMenuItem As ToolStripSeparator
    Friend WithEvents ProdukToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents TransaksiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PenjualanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LaporanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LaporanPenjualanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents STLabel1 As ToolStripStatusLabel
    Friend WithEvents STLabel2 As ToolStripStatusLabel
    Friend WithEvents STLabel3 As ToolStripStatusLabel
    Friend WithEvents STLabel4 As ToolStripStatusLabel
    Friend WithEvents STLabel5 As ToolStripStatusLabel
    Friend WithEvents STLabel6 As ToolStripStatusLabel
    Friend WithEvents STLabel7 As ToolStripStatusLabel
    Friend WithEvents STLabel8 As ToolStripStatusLabel
    Friend WithEvents STLabel9 As ToolStripStatusLabel
    Friend WithEvents STLabel10 As ToolStripStatusLabel
    Friend WithEvents Timer1 As Timer

End Class
