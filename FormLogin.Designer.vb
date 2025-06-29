<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormLogin))
        Panel1 = New Panel()
        PictureBox1 = New PictureBox()
        ButtonCancel = New Button()
        ButtonLogin = New Button()
        password = New Label()
        TextBoxPassword = New TextBox()
        username = New Label()
        TextBoxUsername = New TextBox()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(ButtonCancel)
        Panel1.Controls.Add(ButtonLogin)
        Panel1.Controls.Add(password)
        Panel1.Controls.Add(TextBoxPassword)
        Panel1.Controls.Add(username)
        Panel1.Controls.Add(TextBoxUsername)
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.RightToLeft = RightToLeft.No
        Panel1.Size = New Size(269, 337)
        Panel1.TabIndex = 0
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(51, 45)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(170, 53)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 7
        PictureBox1.TabStop = False
        ' 
        ' ButtonCancel
        ' 
        ButtonCancel.BackColor = Color.Gray
        ButtonCancel.Location = New Point(165, 243)
        ButtonCancel.Name = "ButtonCancel"
        ButtonCancel.Size = New Size(92, 41)
        ButtonCancel.TabIndex = 6
        ButtonCancel.Text = "Cancel"
        ButtonCancel.UseVisualStyleBackColor = False
        ' 
        ' ButtonLogin
        ' 
        ButtonLogin.BackColor = Color.CornflowerBlue
        ButtonLogin.Location = New Point(66, 243)
        ButtonLogin.Name = "ButtonLogin"
        ButtonLogin.Size = New Size(92, 41)
        ButtonLogin.TabIndex = 5
        ButtonLogin.Text = "Login"
        ButtonLogin.UseVisualStyleBackColor = False
        ' 
        ' password
        ' 
        password.AutoSize = True
        password.Location = New Point(11, 186)
        password.Name = "password"
        password.Size = New Size(57, 15)
        password.TabIndex = 4
        password.Text = "Password"
        ' 
        ' TextBoxPassword
        ' 
        TextBoxPassword.Location = New Point(77, 183)
        TextBoxPassword.Name = "TextBoxPassword"
        TextBoxPassword.PasswordChar = "X"c
        TextBoxPassword.PlaceholderText = "Masukkan Password"
        TextBoxPassword.Size = New Size(180, 23)
        TextBoxPassword.TabIndex = 3
        ' 
        ' username
        ' 
        username.AutoSize = True
        username.Location = New Point(12, 132)
        username.Name = "username"
        username.Size = New Size(60, 15)
        username.TabIndex = 1
        username.Text = "Username"
        ' 
        ' TextBoxUsername
        ' 
        TextBoxUsername.Location = New Point(78, 129)
        TextBoxUsername.Name = "TextBoxUsername"
        TextBoxUsername.PlaceholderText = "Masukkan Username"
        TextBoxUsername.Size = New Size(179, 23)
        TextBoxUsername.TabIndex = 0
        ' 
        ' FormLogin
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightGreen
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(595, 337)
        Controls.Add(Panel1)
        DoubleBuffered = True
        Name = "FormLogin"
        Text = "FormLogin"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents TextBoxUsername As TextBox
    Friend WithEvents username As Label
    Friend WithEvents password As Label
    Friend WithEvents TextBoxPassword As TextBox
    Friend WithEvents ButtonLogin As Button
    Friend WithEvents ButtonCancel As Button
    Friend WithEvents PictureBox1 As PictureBox

End Class
