Imports MySql.Data.MySqlClient
Imports ZstdSharp.Unsafe

Public Class FormAdmin
    Dim i As Integer
    Dim Cmd As MySqlCommand
    Dim Rd As MySqlDataReader

    Public Sub Save()
        Try
            If Conn.State = ConnectionState.Closed Then Conn.Open()

            If String.IsNullOrWhiteSpace(TextBoxID.Text) OrElse String.IsNullOrWhiteSpace(TextBoxNama.Text) Then
                MessageBox.Show("ID dan Nama tidak boleh kosong!")
                Exit Sub
            End If

            Dim cmd As New MySqlCommand("INSERT INTO admin (id_admin, username, email, password, nama_lengkap, jenis_kelamin, alamat, no_tlp, tgl_lahir, level) VALUES (@id_admin, @username, @email, @password, @nama_lengkap, @jenis_kelamin, @alamat, @no_tlp, @tgl_lahir, @level)", Conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@id_admin", TextBoxID.Text)
            cmd.Parameters.AddWithValue("@username", TextBoxUsername.Text)
            cmd.Parameters.AddWithValue("@email", TextBoxEmail.Text)
            cmd.Parameters.AddWithValue("@password", TextBoxPassword.Text)
            cmd.Parameters.AddWithValue("@nama_lengkap", TextBoxNama.Text)
            Dim jenisKelamin As String
            If RadioButtonL.Checked Then
                jenisKelamin = "L"
            ElseIf RadioButtonP.Checked Then
                jenisKelamin = "P"
            Else
                MessageBox.Show("Silakan pilih jenis kelamin!")
                Exit Sub
            End If
            cmd.Parameters.AddWithValue("@jenis_kelamin", jenisKelamin)
            cmd.Parameters.AddWithValue("@alamat", TextBoxAlamat.Text)
            cmd.Parameters.AddWithValue("@no_tlp", TextBoxTlp.Text)
            cmd.Parameters.AddWithValue("@tgl_lahir", DateTimePickerTanggalLahir.Value.Date)
            If String.IsNullOrEmpty(ComboBoxLevel.Text) Then
                MessageBox.Show("Pilih level terlebih dahulu!")
                Exit Sub
            End If
            cmd.Parameters.AddWithValue("@level", ComboBoxLevel.Text)

            Dim result As Integer = cmd.ExecuteNonQuery()
            If result > 0 Then
                MessageBox.Show("Data berhasil ditambahkan.")
            Else
                MessageBox.Show("Data gagal ditambahkan.")
            End If
        Catch ex As Exception
            MsgBox("Kesalahan saat menyimpan data: " & ex.Message)
        Finally
            Conn.Close()
        End Try
        bersih()
        data_load()
    End Sub

    Public Sub Ubah()
        Try
            Conn.Open()
            Dim cmd As New MySqlCommand("UPDATE admin SET username=@username, email=@email, password=@password, nama_lengkap=@nama_lengkap, jenis_kelamin=@jenis_kelamin, alamat=@alamat, no_tlp=@no_tlp, tgl_lahir=@tgl_lahir, level=@level WHERE id_admin=@id_admin", Conn)
            cmd.Parameters.Clear()

            cmd.Parameters.AddWithValue("@id_admin", TextBoxID.Text)
            cmd.Parameters.AddWithValue("@username", TextBoxUsername.Text)
            cmd.Parameters.AddWithValue("@email", TextBoxEmail.Text)
            cmd.Parameters.AddWithValue("@password", TextBoxPassword.Text)
            cmd.Parameters.AddWithValue("@nama_lengkap", TextBoxNama.Text)
            Dim jenisKelamin As String
            If RadioButtonL.Checked Then
                jenisKelamin = "L"
            ElseIf RadioButtonP.Checked Then
                jenisKelamin = "P"
            Else
                MessageBox.Show("Silakan pilih jenis kelamin!")
                Exit Sub
            End If
            cmd.Parameters.AddWithValue("@jenis_kelamin", jenisKelamin)
            cmd.Parameters.AddWithValue("@alamat", TextBoxAlamat.Text)
            cmd.Parameters.AddWithValue("@no_tlp", TextBoxTlp.Text)
            cmd.Parameters.AddWithValue("@tgl_lahir", DateTimePickerTanggalLahir.Value.Date)
            If String.IsNullOrEmpty(ComboBoxLevel.Text) Then
                MessageBox.Show("Pilih level terlebih dahulu!")
                Exit Sub
            End If
            cmd.Parameters.AddWithValue("@level", ComboBoxLevel.Text)

            i = cmd.ExecuteNonQuery()
            If i > 0 Then
                MessageBox.Show("Data Berhasil Diubah")
            Else
                MessageBox.Show("Data Gagal Diubah")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Conn.Close()
        End Try
        bersih()
        data_load()
    End Sub

    Public Sub Hapus()
        If MsgBox("Apakah Anda yakin akan menghapusnya?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Try
                Conn.Open()
                Dim cmd As New MySqlCommand("DELETE FROM admin WHERE id_admin=@id_admin", Conn)
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@id_admin", TextBoxID.Text)
                i = cmd.ExecuteNonQuery()
                If i > 0 Then
                    MessageBox.Show("Data Berhasil Dihapus")
                Else
                    MessageBox.Show("Data Gagal Dihapus")
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                Conn.Close()
            End Try
            bersih()
            data_load()
        End If
    End Sub

    Public Sub bersih()
        TextBoxID.Clear()
        TextBoxUsername.Clear()
        TextBoxEmail.Clear()
        TextBoxPassword.Clear()
        TextBoxNama.Clear()
        RadioButtonL.Checked = False
        RadioButtonP.Checked = False
        TextBoxAlamat.Clear()
        TextBoxTlp.Clear()
        DateTimePickerTanggalLahir.Value = Date.Now
        ComboBoxLevel.SelectedItem = Nothing
        TextBoxID.ReadOnly = False
    End Sub

    Public Sub data_load()
        Try
            Dim query As String = "SELECT * FROM admin"
            Dim da As New MySqlDataAdapter(query, Conn)
            Dim dt As New DataTable()
            da.Fill(dt)

            DataGridView1.Columns.Clear()
            DataGridView1.DataSource = Nothing
            DataGridView1.AutoGenerateColumns = False

            DataGridView1.Columns.Add("id_admin", "ID admin")
            DataGridView1.Columns("id_admin").DataPropertyName = "id_admin"

            DataGridView1.Columns.Add("username", "Username")
            DataGridView1.Columns("username").DataPropertyName = "username"

            DataGridView1.Columns.Add("email", "Email")
            DataGridView1.Columns("email").DataPropertyName = "email"

            DataGridView1.Columns.Add("password", "Password")
            DataGridView1.Columns("password").DataPropertyName = "password"

            DataGridView1.Columns.Add("nama_lengkap", "Nama Lengkap")
            DataGridView1.Columns("nama_lengkap").DataPropertyName = "nama_lengkap"

            DataGridView1.Columns.Add("jenis_kelamin", "Jenis Kelamin")
            DataGridView1.Columns("jenis_kelamin").DataPropertyName = "jenis_kelamin"

            DataGridView1.Columns.Add("alamat", "Alamat")
            DataGridView1.Columns("alamat").DataPropertyName = "alamat"

            DataGridView1.Columns.Add("no_tlp", "No Tlp admin")
            DataGridView1.Columns("no_tlp").DataPropertyName = "no_tlp"

            DataGridView1.Columns.Add("tgl_lahir", "Tanggal Lahir")
            DataGridView1.Columns("tgl_lahir").DataPropertyName = "tgl_lahir"

            DataGridView1.Columns.Add("level", "Level")
            DataGridView1.Columns("level").DataPropertyName = "level"

            For Each row As DataRow In dt.Rows
                Dim newRow As DataGridViewRow = CType(DataGridView1.Rows(DataGridView1.Rows.Add()), DataGridViewRow)
                newRow.Cells("id_admin").Value = row("id_admin")
                newRow.Cells("username").Value = row("username")
                newRow.Cells("email").Value = row("email")
                newRow.Cells("password").Value = row("password")
                newRow.Cells("nama_lengkap").Value = row("nama_lengkap")
                newRow.Cells("jenis_kelamin").Value = row("jenis_kelamin")
                newRow.Cells("alamat").Value = row("alamat")
                newRow.Cells("no_tlp").Value = row("no_tlp")
                newRow.Cells("tgl_lahir").Value = row("tgl_lahir")
                newRow.Cells("level").Value = row("level")
            Next
        Catch ex As Exception
            MsgBox("Kesalahan saat memuat data: " & ex.Message)
        Finally
            Conn.Close()
        End Try
    End Sub

    Private Sub FormAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Koneksi()
        Call NomorOtomatis()
        data_load()

        ComboBoxLevel.Items.Clear()
        ComboBoxLevel.Items.Add("admin")
        ComboBoxLevel.Items.Add("user")
        RadioButtonL.Checked = True
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex >= 0 Then
            TextBoxID.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString()
            TextBoxUsername.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString()
            TextBoxEmail.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value.ToString()
            TextBoxPassword.Text = DataGridView1.Rows(e.RowIndex).Cells(3).Value.ToString()
            TextBoxNama.Text = DataGridView1.Rows(e.RowIndex).Cells(4).Value.ToString()
            Dim jenisKelamin As String = DataGridView1.Rows(e.RowIndex).Cells(5).Value.ToString()
            If jenisKelamin = "L" Then
                RadioButtonL.Checked = True
            ElseIf jenisKelamin = "P" Then
                RadioButtonP.Checked = True
            End If
            TextBoxAlamat.Text = DataGridView1.Rows(e.RowIndex).Cells(6).Value.ToString()
            TextBoxTlp.Text = DataGridView1.Rows(e.RowIndex).Cells(7).Value.ToString()
            DateTimePickerTanggalLahir.Value = Convert.ToDateTime(DataGridView1.Rows(e.RowIndex).Cells(8).Value)
            ComboBoxLevel.Text = DataGridView1.Rows(e.RowIndex).Cells(9).Value.ToString()
            TextBoxID.ReadOnly = True
        End If
    End Sub

    Private Sub BtnTambah_Click(sender As Object, e As EventArgs) Handles BtnTambah.Click
        Save()
    End Sub

    Private Sub BtnUbah_Click(sender As Object, e As EventArgs) Handles BtnUbah.Click
        Ubah()
    End Sub

    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles BtnHapus.Click
        Hapus()
    End Sub

    Private Sub BtnKosongkan_Click(sender As Object, e As EventArgs) Handles BtnKosongkan.Click
        bersih()
    End Sub

    Private Sub TextBoxCari_TextChanged(sender As Object, e As EventArgs) Handles TextBoxCari.TextChanged
        Try
            Dim query As String = "SELECT * FROM admin WHERE nama_lengkap LIKE @nama_lengkap"
            Dim cmd As New MySqlCommand(query, Conn)

            cmd.Parameters.AddWithValue("@nama_lengkap", "%" & TextBoxCari.Text & "%")
            Dim da As New MySqlDataAdapter(cmd)
            Dim dt As New DataTable()
            da.Fill(dt)

            DataGridView1.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub NomorOtomatis()
        Try
            Call Koneksi()

            Dim query As String = "SELECT id_admin FROM admin WHERE id_admin IN (SELECT MAX(id_admin) FROM admin)"
            Cmd = New MySqlCommand(query, Conn)
            Rd = Cmd.ExecuteReader()

            Dim Urutankode As String
            Dim Hitung As Long

            If Rd.Read() AndAlso Rd.HasRows Then
                Hitung = CLng(Microsoft.VisualBasic.Right(Rd("id_admin").ToString(), 3)) + 1
                Urutankode = "100" & Microsoft.VisualBasic.Right("000" & Hitung, 3)
            Else
                Urutankode = "100" & "001"
            End If

            TextBoxID.Text = Urutankode

        Catch ex As Exception
            MsgBox("Terjadi kesalahan: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            If Rd IsNot Nothing AndAlso Not Rd.IsClosed Then
                Rd.Close()
            End If
            If Conn IsNot Nothing AndAlso Conn.State = ConnectionState.Open Then
                Conn.Close()
            End If
        End Try
    End Sub
End Class