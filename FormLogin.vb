Imports System.Runtime.Intrinsics.Arm
Imports MySql.Data.MySqlClient

Public Class FormLogin
    Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click
        Me.Hide()
    End Sub

    Sub Terbuka()
        FormMenuUtama.LoginToolStripMenuItem.Enabled = False
        FormMenuUtama.LogoutToolStripMenuItem.Enabled = True
        FormMenuUtama.DataToolStripMenuItem.Enabled = True
        FormMenuUtama.TransaksiToolStripMenuItem.Enabled = True
        FormMenuUtama.LaporanToolStripMenuItem.Enabled = True
    End Sub
    Sub KondisiAwal()
        TextBoxUsername.Text = ""
        TextBoxPassword.Text = ""
    End Sub

    Private Sub ButtonLogin_Click(sender As Object, e As EventArgs) Handles ButtonLogin.Click
        If TextBoxUsername.Text = "" Or TextBoxPassword.Text = "" Then
            MsgBox("Username dan Password Tidak Boleh Kosong!")
        Else
            Call Koneksi()

            Dim query As String = "SELECT * FROM admin WHERE username = @username AND password = @password"
            Dim Cmd As New MySqlCommand(query, Conn)
            Cmd.Parameters.AddWithValue("@username", TextBoxUsername.Text)
            Cmd.Parameters.AddWithValue("@password", TextBoxPassword.Text)

            Dim reader As MySqlDataReader = Cmd.ExecuteReader()

            If reader.HasRows Then
                reader.Read()

                Me.Hide()
                Terbuka()
                FormMenuUtama.STLabel2.Text = reader("id_admin").ToString()
                FormMenuUtama.STLabel4.Text = reader("nama_lengkap").ToString()
                FormMenuUtama.STLabel6.Text = reader("level").ToString()
                If FormMenuUtama.STLabel6.Text = "user" Then
                    FormMenuUtama.AToolStripMenuItem.Enabled = False
                End If
            Else
                MsgBox("Username atau Password Salah!")
            End If

            reader.Close()
            Conn.Close()
        End If
    End Sub

    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call KondisiAwal()
    End Sub
End Class