<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLaporan
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
        Panel1 = New Panel()
        btntampil = New Button()
        tglsampai = New DateTimePicker()
        Label3 = New Label()
        tglmulai = New DateTimePicker()
        Label2 = New Label()
        cblaporan = New ComboBox()
        Label1 = New Label()
        dgtampil = New DataGridView()
        Panel1.SuspendLayout()
        CType(dgtampil, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(btntampil)
        Panel1.Controls.Add(tglsampai)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(tglmulai)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(cblaporan)
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(823, 37)
        Panel1.TabIndex = 0
        ' 
        ' btntampil
        ' 
        btntampil.Location = New Point(739, 6)
        btntampil.Name = "btntampil"
        btntampil.Size = New Size(75, 23)
        btntampil.TabIndex = 6
        btntampil.Text = "Tampil"
        btntampil.UseVisualStyleBackColor = True
        ' 
        ' tglsampai
        ' 
        tglsampai.Format = DateTimePickerFormat.Short
        tglsampai.Location = New Point(579, 6)
        tglsampai.Name = "tglsampai"
        tglsampai.Size = New Size(144, 23)
        tglsampai.TabIndex = 5
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(483, 9)
        Label3.Name = "Label3"
        Label3.Size = New Size(90, 15)
        Label3.TabIndex = 4
        Label3.Text = "Sampai Tanggal"
        ' 
        ' tglmulai
        ' 
        tglmulai.Format = DateTimePickerFormat.Short
        tglmulai.Location = New Point(326, 6)
        tglmulai.Name = "tglmulai"
        tglmulai.Size = New Size(145, 23)
        tglmulai.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(239, 9)
        Label2.Name = "Label2"
        Label2.Size = New Size(81, 15)
        Label2.TabIndex = 2
        Label2.Text = "Mulai Tanggal"
        ' 
        ' cblaporan
        ' 
        cblaporan.DropDownStyle = ComboBoxStyle.DropDownList
        cblaporan.FormattingEnabled = True
        cblaporan.Items.AddRange(New Object() {"Laporan Penjualan"})
        cblaporan.Location = New Point(95, 6)
        cblaporan.Name = "cblaporan"
        cblaporan.Size = New Size(132, 23)
        cblaporan.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(11, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(78, 15)
        Label1.TabIndex = 0
        Label1.Text = "Jenis Laporan"
        ' 
        ' dgtampil
        ' 
        dgtampil.AllowUserToAddRows = False
        dgtampil.AllowUserToDeleteRows = False
        dgtampil.AllowUserToResizeColumns = False
        dgtampil.AllowUserToResizeRows = False
        dgtampil.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgtampil.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgtampil.Dock = DockStyle.Fill
        dgtampil.Location = New Point(0, 37)
        dgtampil.Name = "dgtampil"
        dgtampil.RowHeadersVisible = False
        dgtampil.Size = New Size(823, 413)
        dgtampil.TabIndex = 0
        ' 
        ' FormLaporan
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightGreen
        ClientSize = New Size(823, 450)
        Controls.Add(dgtampil)
        Controls.Add(Panel1)
        Name = "FormLaporan"
        Text = "FormLaporan"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(dgtampil, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents dgtampil As DataGridView
    Friend WithEvents tglmulai As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents cblaporan As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents tglsampai As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents btntampil As Button
End Class
