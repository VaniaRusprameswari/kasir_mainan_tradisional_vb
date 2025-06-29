Imports MySql.Data.MySqlClient
Imports ZstdSharp.Unsafe

Public Class FormProduk
    Dim i As Integer
    Dim Rd As MySqlDataReader
    Dim Cmd As MySqlCommand

    Public Sub Save()
        Try
            Call Koneksi()
            Dim cmd As New MySqlCommand("INSERT INTO produk (id_produk, nama_produk, stok_produk, harga_produk) VALUES (@id_produk, @nama_produk, @stok_produk, @harga_produk)", Conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@id_produk", TextBoxID.Text)
            cmd.Parameters.AddWithValue("@nama_produk", TextBoxNama.Text)
            cmd.Parameters.AddWithValue("@stok_produk", TextBoxStok.Text)
            cmd.Parameters.AddWithValue("@harga_produk", TextBoxHarga.Text)
            i = cmd.ExecuteNonQuery()
            If i > 0 Then
                MessageBox.Show("Data Berhasil Ditambahkan")
            Else
                MessageBox.Show("Data Gagal Ditambahkan")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Conn.Close()
        End Try
        bersih()
        data_load()
    End Sub

    Public Sub Ubah()
        Try
            Conn.Open()
            Dim cmd As New MySqlCommand("UPDATE produk SET nama_produk=@nama_produk, stok_produk=@stok_produk, harga_produk=@harga_produk WHERE id_produk=@id_produk", Conn)
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("@id_produk", TextBoxID.Text)
            cmd.Parameters.AddWithValue("@nama_produk", TextBoxNama.Text)
            cmd.Parameters.AddWithValue("@stok_produk", TextBoxStok.Text)
            cmd.Parameters.AddWithValue("@harga_produk", TextBoxHarga.Text)
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
                Dim cmd As New MySqlCommand("DELETE FROM produk WHERE id_produk=@id_produk", Conn)
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@id_produk", TextBoxID.Text)
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
        TextBoxStok.Clear()
        TextBoxHarga.Clear()
        TextBoxID.ReadOnly = False
    End Sub

    Public Sub data_load()
        Try
            Dim query As String = "SELECT * FROM produk"
            Dim da As New MySqlDataAdapter(query, Conn)
            Dim dt As New DataTable()
            da.Fill(dt)

            DataGridView1.Columns.Clear()

            DataGridView1.DataSource = Nothing
            DataGridView1.AutoGenerateColumns = False
            DataGridView1.Columns.Add("id_produk", "ID Produk")
            DataGridView1.Columns("id_produk").DataPropertyName = "id_produk"

            DataGridView1.Columns.Add("nama_produk", "Nama Produk")
            DataGridView1.Columns("nama_produk").DataPropertyName = "nama_produk"

            DataGridView1.Columns.Add("stok_produk", "Stok")
            DataGridView1.Columns("stok_produk").DataPropertyName = "stok_produk"

            DataGridView1.Columns.Add("harga_produk", "Harga")
            DataGridView1.Columns("harga_produk").DataPropertyName = "harga_produk"

            For Each row As DataRow In dt.Rows
                Dim newRow As DataGridViewRow = CType(DataGridView1.Rows(DataGridView1.Rows.Add()), DataGridViewRow)
                newRow.Cells("id_produk").Value = row("id_produk")
                newRow.Cells("nama_produk").Value = row("nama_produk")
                newRow.Cells("stok_produk").Value = row("stok_produk")
                newRow.Cells("harga_produk").Value = row("harga_produk")
            Next
        Catch ex As Exception
            MsgBox("Kesalahan saat memuat data: " & ex.Message)
        Finally
            Conn.Close()
        End Try
    End Sub

    Private Sub FormProduk_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Koneksi()
        Call NomorOtomatis()
        Call data_load()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex >= 0 Then
            Debug.WriteLine(DataGridView1)
            TextBoxID.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString()
            TextBoxNama.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString()
            TextBoxStok.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value.ToString()
            TextBoxHarga.Text = DataGridView1.Rows(e.RowIndex).Cells(3).Value.ToString()
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
            Dim query As String = "SELECT * FROM produk WHERE nama_produk LIKE @nama_produk"
            Dim cmd As New MySqlCommand(query, Conn)

            cmd.Parameters.AddWithValue("@nama_produk", "%" & TextBoxCari.Text & "%")
            Dim da As New MySqlDataAdapter(cmd)
            Dim dt As New DataTable()
            da.Fill(dt)

            DataGridView1.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ButtonUnggah_Click(sender As Object, e As EventArgs)
        Try
            If OpenFileDialog1.ShowDialog = DialogResult.OK Then

                Conn.Open()
                Dim query = "INSERT INTO produk (id_produk, nama_produk, stok_produk, harga_produk) VALUES (@id_produk, @nama_produk, @stok_produk, @harga_produk)"
                Using cmd As New MySqlCommand(query, Conn)
                    cmd.Parameters.AddWithValue("@id_produk", TextBoxID.Text)
                    cmd.Parameters.AddWithValue("@nama_produk", TextBoxNama.Text)
                    cmd.Parameters.AddWithValue("@stok_produk", TextBoxStok.Text)
                    cmd.Parameters.AddWithValue("@harga_produk", TextBoxHarga.Text)
                    cmd.ExecuteNonQuery()
                End Using
            End If
        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan: " & ex.Message)
        Finally
            Conn.Close()
        End Try
    End Sub

    Sub NomorOtomatis()
        Try
            Call Koneksi()

            Dim query As String = "SELECT id_produk FROM produk WHERE id_produk IN (SELECT MAX(id_produk) FROM produk)"
            Cmd = New MySqlCommand(query, Conn)
            Rd = Cmd.ExecuteReader()

            Dim Urutankode As String
            Dim Hitung As Long

            If Rd.Read() AndAlso Rd.HasRows Then
                Hitung = CLng(Microsoft.VisualBasic.Right(Rd("id_produk").ToString(), 3)) + 1
                Urutankode = "300" & Microsoft.VisualBasic.Right("000" & Hitung, 3)
            Else
                Urutankode = "300" & "001"
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