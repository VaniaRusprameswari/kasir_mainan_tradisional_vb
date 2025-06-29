Imports MySql.Data.MySqlClient

Public Class FormLaporan
    Dim str As String = ""
    Dim tbl As New DataTable
    Dim Conn As MySqlConnection
    Dim Cmd As MySqlCommand

    Sub Koneksi()
        Conn = New MySqlConnection("server=localhost;user=root;password=;database=toko;")
        If Conn.State = ConnectionState.Closed Then
            Conn.Open()
        End If
    End Sub

    Sub Tampil()
        If Conn Is Nothing OrElse Conn.State = ConnectionState.Closed Then
            Koneksi()
        End If

        Select Case cblaporan.SelectedItem.ToString()
            Case "FormTransJual"
                str = "SELECT dp.id_detail_penjualan AS IDDetail, dp.id_penjualan AS IDPenjualan, dp.id_produk AS IDProduk, " &
                      "dp.jumlah_produk AS Jumlah, dp.harga_satuan AS HargaSatuan, dp.total_harga AS TotalHarga " &
                      "FROM detail_penjualan dp " &
                      "JOIN penjualan p ON dp.id_penjualan = p.id_penjualan " &
                      "WHERE p.tanggal_penjualan BETWEEN @tgl_mulai AND @tgl_sampai"
        End Select

        Try
            Dim cmd As New MySqlCommand(str, Conn)
            cmd.Parameters.AddWithValue("@tgl_mulai", tglmulai.Value.ToString("yyyy-MM-dd"))
            cmd.Parameters.AddWithValue("@tgl_sampai", tglsampai.Value.ToString("yyyy-MM-dd"))

            Dim da As New MySqlDataAdapter(cmd)
            tbl.Clear()
            tbl.Columns.Clear()
            da.Fill(tbl)

            dgtampil.DataSource = tbl

            If tbl.Columns.Contains("HargaSatuan") Then
                dgtampil.Columns("HargaSatuan").DefaultCellStyle.Format = "N0"
                dgtampil.Columns("HargaSatuan").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            End If
            If tbl.Columns.Contains("TotalHarga") Then
                dgtampil.Columns("TotalHarga").DefaultCellStyle.Format = "N0"
                dgtampil.Columns("TotalHarga").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            End If
        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan saat mengakses data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Sub TambahDetailPenjualan(row As DataGridViewRow)
        Try
            If Conn Is Nothing OrElse Conn.State = ConnectionState.Closed Then
                Koneksi()
            End If

            Dim queryDetail As String = "INSERT INTO detail_penjualan (id_detail_penjualan, id_penjualan, id_produk, jumlah_produk, harga_satuan, total_harga) " &
                                         "VALUES (@id_detail_penjualan, @id_penjualan, @id_produk, @jumlah_produk, @harga_satuan, @total_harga)"
            Cmd = New MySqlCommand(queryDetail, Conn)

            Cmd.Parameters.AddWithValue("@id_detail_penjualan", Guid.NewGuid().ToString().Substring(0, 8))
            Cmd.Parameters.AddWithValue("@id_penjualan", row.Cells("id_penjualan").Value.ToString())
            Cmd.Parameters.AddWithValue("@id_produk", row.Cells("id_produk").Value.ToString())
            Cmd.Parameters.AddWithValue("@jumlah_produk", row.Cells("jumlah_produk").Value)
            Cmd.Parameters.AddWithValue("@harga_satuan", row.Cells("harga_produk").Value)
            Cmd.Parameters.AddWithValue("@total_harga", row.Cells("total_penjualan").Value)

            Cmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan saat menambahkan data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btntampil_Click(sender As Object, e As EventArgs) Handles btntampil.Click
        If cblaporan.Text <> "" Then
            Tampil()
        Else
            MessageBox.Show("Silakan pilih jenis laporan terlebih dahulu.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub FormLaporan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cblaporan.Items.Clear()
        cblaporan.Items.Add("FormTransJual")
        cblaporan.SelectedIndex = 0
    End Sub
End Class
