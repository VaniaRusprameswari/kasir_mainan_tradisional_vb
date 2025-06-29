Imports MySql.Data.MySqlClient
Imports ZstdSharp.Unsafe

Public Class FormPelanggan
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

            Dim cmd As New MySqlCommand("INSERT INTO pelanggan (id_pelanggan, nama_pelanggan, jenis_kelamin, alamat_pelanggan, no_tlp_pelanggan) VALUES (@id_pelanggan, @nama_pelanggan, @jenis_kelamin, @alamat_pelanggan, @no_tlp_pelanggan)", Conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@id_pelanggan", TextBoxID.Text)
            cmd.Parameters.AddWithValue("@nama_pelanggan", TextBoxNama.Text)

            Dim jenisKelamin As String
            If RadioButtonL.Checked Then
                jenisKelamin = "Laki-Laki"
            ElseIf RadioButtonP.Checked Then
                jenisKelamin = "Perempuan"
            Else
                MessageBox.Show("Silakan pilih jenis kelamin!")
                Exit Sub
            End If
            cmd.Parameters.AddWithValue("@jenis_kelamin", jenisKelamin)
            cmd.Parameters.AddWithValue("@alamat_pelanggan", TextBoxAlamat.Text)
            cmd.Parameters.AddWithValue("@no_tlp_pelanggan", TextBoxTlp.Text)

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
            Dim cmd As New MySqlCommand("UPDATE pelanggan SET nama_pelanggan=@nama_pelanggan, jenis_kelamin=@jenis_kelamin, alamat_pelanggan=@alamat_pelanggan, no_tlp_pelanggan=@no_tlp_pelanggan WHERE id_pelanggan=@id_pelanggan", Conn)
            cmd.Parameters.Clear()

            cmd.Parameters.AddWithValue("@id_pelanggan", TextBoxID.Text)
            cmd.Parameters.AddWithValue("@nama_pelanggan", TextBoxNama.Text)

            Dim jenisKelamin As String
            If RadioButtonL.Checked Then
                jenisKelamin = "Laki-Laki"
            ElseIf RadioButtonP.Checked Then
                jenisKelamin = "Perempuan"
            Else
                MessageBox.Show("Silakan pilih jenis kelamin!")
                Exit Sub
            End If
            cmd.Parameters.AddWithValue("@jenis_kelamin", jenisKelamin)

            cmd.Parameters.AddWithValue("@alamat_pelanggan", TextBoxAlamat.Text)
            cmd.Parameters.AddWithValue("@no_tlp_pelanggan", TextBoxTlp.Text)

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
                Dim cmd As New MySqlCommand("DELETE FROM pelanggan WHERE id_pelanggan=@id_pelanggan", Conn)
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@id_pelanggan", TextBoxID.Text)
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
        TextBoxNama.Clear()
        RadioButtonL.Checked = False
        RadioButtonP.Checked = False
        TextBoxAlamat.Clear()
        TextBoxTlp.Clear()
        TextBoxID.ReadOnly = False
    End Sub

    Public Sub data_load()
        Try
            Dim query As String = "SELECT * FROM pelanggan"
            Dim da As New MySqlDataAdapter(query, Conn)
            Dim dt As New DataTable()
            da.Fill(dt)

            DataGridView1.Columns.Clear()
            DataGridView1.DataSource = Nothing
            DataGridView1.AutoGenerateColumns = False

            DataGridView1.Columns.Add("id_pelanggan", "ID Pelanggan")
            DataGridView1.Columns("id_pelanggan").DataPropertyName = "id_pelanggan"

            DataGridView1.Columns.Add("nama_pelanggan", "Nama Pelanggan")
            DataGridView1.Columns("nama_pelanggan").DataPropertyName = "nama_pelanggan"

            DataGridView1.Columns.Add("jenis_kelamin", "Jenis Kelamin")
            DataGridView1.Columns("jenis_kelamin").DataPropertyName = "jenis_kelamin"

            DataGridView1.Columns.Add("alamat_pelanggan", "Alamat Pelanggan")
            DataGridView1.Columns("alamat_pelanggan").DataPropertyName = "alamat_pelanggan"

            DataGridView1.Columns.Add("no_tlp_pelanggan", "No Tlp Pelanggan")
            DataGridView1.Columns("no_tlp_pelanggan").DataPropertyName = "no_tlp_pelanggan"

            For Each row As DataRow In dt.Rows
                Dim newRow As DataGridViewRow = CType(DataGridView1.Rows(DataGridView1.Rows.Add()), DataGridViewRow)
                newRow.Cells("id_pelanggan").Value = row("id_pelanggan")
                newRow.Cells("nama_pelanggan").Value = row("nama_pelanggan")
                newRow.Cells("jenis_kelamin").Value = row("jenis_kelamin")
                newRow.Cells("alamat_pelanggan").Value = row("alamat_pelanggan")
                newRow.Cells("no_tlp_pelanggan").Value = row("no_tlp_pelanggan")
            Next
        Catch ex As Exception
            MsgBox("Kesalahan saat memuat data: " & ex.Message)
        Finally
            Conn.Close()
        End Try
    End Sub

    Private Sub FormPelanggan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Koneksi()
        Call NomorOtomatis()
        data_load()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex >= 0 Then
            TextBoxID.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString()
            TextBoxNama.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString()

            Dim jenisKelamin As String = DataGridView1.Rows(e.RowIndex).Cells(2).Value.ToString()
            If jenisKelamin = "Laki-Laki" Then
                RadioButtonL.Checked = True
            ElseIf jenisKelamin = "Perempuan" Then
                RadioButtonP.Checked = True
            End If

            TextBoxAlamat.Text = DataGridView1.Rows(e.RowIndex).Cells(3).Value.ToString()
            TextBoxTlp.Text = DataGridView1.Rows(e.RowIndex).Cells(4).Value.ToString()
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
            Dim query As String = "SELECT * FROM pelanggan WHERE nama_pelanggan LIKE @nama_pelanggan"
            Dim cmd As New MySqlCommand(query, Conn)

            cmd.Parameters.AddWithValue("@nama_pelanggan", "%" & TextBoxCari.Text & "%")
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

            Dim query As String = "SELECT id_pelanggan FROM pelanggan WHERE id_pelanggan IN (SELECT MAX(id_pelanggan) FROM pelanggan)"
            Cmd = New MySqlCommand(query, Conn)
            Rd = Cmd.ExecuteReader()

            Dim Urutankode As String
            Dim Hitung As Long

            If Rd.Read() AndAlso Rd.HasRows Then
                Hitung = CLng(Microsoft.VisualBasic.Right(Rd("id_pelanggan").ToString(), 3)) + 1
                Urutankode = "200" & Microsoft.VisualBasic.Right("000" & Hitung, 3)
            Else
                Urutankode = "200" & "001"
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