Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient

Public Class FormTransJual
    Dim Cmd As MySqlCommand
    Dim Rd As MySqlDataReader

    Sub KondisiAwal()
        LBLNamaPlg.Text = ""
        LBLAlamat.Text = ""
        LBLTelepon.Text = ""
        LBLTanggal.Text = Today
        LBLAdmin.Text = FormMenuUtama.STLabel2.Text
        LBLKembali.Text = ""
        TextBoxID.Text = ""
        LabelNama2.Text = ""
        LabelHarga2.Text = ""
        TextBoxJumlah.Text = ""
    End Sub

    Private Sub Timer1_Tick_1(sender As Object, e As EventArgs) Handles Timer1.Tick
        LBLJam.Text = TimeOfDay
    End Sub

    Private Sub FormTransJual_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call KondisiAwal()
        Call MunculKodePelanggan()
        Call NomorOtomatis()
        Call BuatKolom()
        LabelHarga.Text = "0"
    End Sub

    Sub MunculKodePelanggan()
        Try
            Call Koneksi()

            Dim query As String = "SELECT id_pelanggan FROM pelanggan"
            Cmd = New MySqlCommand(query, Conn)
            Rd = Cmd.ExecuteReader()

            ComboBoxIDP.Items.Clear()

            While Rd.Read()
                ComboBoxIDP.Items.Add(Rd("id_pelanggan").ToString())
            End While

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

    Private Sub ComboBoxIDP_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxIDP.SelectedIndexChanged
        Try
            Call Koneksi()

            Dim query As String = "SELECT * FROM pelanggan WHERE id_pelanggan = @id"
            Cmd = New MySqlCommand(query, Conn)
            Cmd.Parameters.AddWithValue("@id", ComboBoxIDP.Text)

            Rd = Cmd.ExecuteReader()

            If Rd.Read() Then
                LBLNamaPlg.Text = Rd("nama_pelanggan").ToString()
                LBLAlamat.Text = Rd("alamat_pelanggan").ToString()
                LBLTelepon.Text = Rd("no_tlp_pelanggan").ToString()
            Else
                LBLNamaPlg.Text = ""
                LBLAlamat.Text = ""
                LBLTelepon.Text = ""
                MsgBox("Data pelanggan tidak ditemukan!", MsgBoxStyle.Information)
            End If

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

    Sub NomorOtomatis()
        Try
            Call Koneksi()

            Dim lockQuery As String = "LOCK TABLES penjualan WRITE;"
            Cmd = New MySqlCommand(lockQuery, Conn)
            Cmd.ExecuteNonQuery()

            Dim query As String = "SELECT MAX(id_penjualan) AS id_terbesar FROM penjualan"
            Cmd = New MySqlCommand(query, Conn)
            Rd = Cmd.ExecuteReader()

            Dim Urutankode As String
            Dim Hitung As Long

            If Rd.Read() AndAlso Not IsDBNull(Rd("id_terbesar")) Then
                Hitung = CLng(Rd("id_terbesar")) + 1
            Else
                Hitung = 1
            End If
            Urutankode = Hitung.ToString()

            Rd.Close()

            Dim checkQuery As String = "SELECT COUNT(*) FROM penjualan WHERE id_penjualan = @id_penjualan"
            Cmd = New MySqlCommand(checkQuery, Conn)
            Cmd.Parameters.AddWithValue("@id_penjualan", Urutankode)
            Dim count As Integer = Cmd.ExecuteScalar()

            If count > 0 Then
                Throw New Exception("Nomor penjualan duplikat, coba lagi.")
            End If

            LBLNoJual.Text = Urutankode

            Dim unlockQuery As String = "UNLOCK TABLES;"
            Cmd = New MySqlCommand(unlockQuery, Conn)
            Cmd.ExecuteNonQuery()

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

    Sub BuatKolom()
        DataGridView1.Columns.Clear()
        DataGridView1.Columns.Add("id_produk", "ID")
        DataGridView1.Columns.Add("nama_produk", "Nama Produk")
        DataGridView1.Columns.Add("harga_produk", "Harga")
        DataGridView1.Columns.Add("jumlah_produk", "Jumlah")
        DataGridView1.Columns.Add("total_penjualan", "Subtotal")
    End Sub

    Private Sub TextBoxID_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles TextBoxID.KeyPress
        If e.KeyChar = Chr(13) Then
            Try
                Call Koneksi()

                Dim query As String = "SELECT * FROM produk WHERE id_produk = @id_produk"
                Cmd = New MySqlCommand(query, Conn)
                Cmd.Parameters.AddWithValue("@id_produk", TextBoxID.Text)

                Rd = Cmd.ExecuteReader()

                If Rd.Read() Then
                    LabelNama2.Text = Rd("nama_produk").ToString()
                    LabelHarga2.Text = Rd("harga_produk").ToString()
                Else
                    MsgBox("Kode barang tidak ditemukan!", MsgBoxStyle.Exclamation)
                    TextBoxID.Text = ""
                    TextBoxID.Focus()
                End If

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
        End If
    End Sub

    Private Sub ButtonInsert_Click(sender As Object, e As EventArgs) Handles ButtonInsert.Click
        Try
            If String.IsNullOrWhiteSpace(TextBoxID.Text) Then
                MsgBox("ID Produk harus diisi!", MsgBoxStyle.Exclamation)
                TextBoxID.Focus()
                Exit Sub
            End If

            If String.IsNullOrWhiteSpace(ComboBoxIDP.Text) Then
                MsgBox("Silakan pilih pelanggan terlebih dahulu!", MsgBoxStyle.Exclamation)
                ComboBoxIDP.Focus()
                Exit Sub
            End If

            If String.IsNullOrWhiteSpace(TextBoxJumlah.Text) OrElse Not IsNumeric(TextBoxJumlah.Text) Then
                MsgBox("Jumlah produk harus berupa angka!", MsgBoxStyle.Exclamation)
                TextBoxJumlah.Focus()
                Exit Sub
            End If

            If String.IsNullOrWhiteSpace(TextBoxJumlah.Text) OrElse Not IsNumeric(TextBoxJumlah.Text) OrElse Integer.Parse(TextBoxJumlah.Text) <= 0 Then
                MsgBox("Jumlah produk harus berupa angka lebih dari 0!", MsgBoxStyle.Exclamation)
                TextBoxJumlah.Focus()
                Exit Sub
            End If

            Dim idProduk As String = TextBoxID.Text
            Dim namaProduk As String = LabelNama2.Text
            Dim hargaProduk As Decimal = Decimal.Parse(LabelHarga2.Text)
            Dim jumlahProduk As Integer = Integer.Parse(TextBoxJumlah.Text)
            Dim subtotal As Decimal = hargaProduk * jumlahProduk

            Dim idSudahAda As Boolean = False

            For Each row As DataGridViewRow In DataGridView1.Rows
                If row.Cells("id_produk").Value = idProduk Then
                    row.Cells("jumlah_produk").Value = CInt(row.Cells("jumlah_produk").Value) + jumlahProduk
                    row.Cells("total_penjualan").Value = CDec(row.Cells("jumlah_produk").Value) * hargaProduk
                    idSudahAda = True
                    Exit For
                End If
            Next

            If Not idSudahAda Then
                DataGridView1.Rows.Add(idProduk, namaProduk, hargaProduk, jumlahProduk, subtotal)
            End If

            TextBoxID.Clear()
            LabelNama2.Text = ""
            LabelHarga2.Text = ""
            TextBoxJumlah.Clear()
            TextBoxID.Focus()

        Catch ex As Exception
            MsgBox("Terjadi kesalahan: " & ex.Message, MsgBoxStyle.Critical)
        End Try
        Call RumusSubtotal()
    End Sub

    Sub RumusSubtotal()
        Dim hitung As Integer = 0
        For i As Integer = 0 To DataGridView1.Rows.Count - 1
            hitung = hitung + DataGridView1.Rows(i).Cells(4).Value
            LabelHarga.Text = hitung
        Next
    End Sub
    Private Sub TextBoxBayar_TextChanged(sender As Object, e As EventArgs) Handles TextBoxBayar.TextChanged
        If IsNumeric(TextBoxBayar.Text) AndAlso Decimal.Parse(TextBoxBayar.Text) >= 0 Then
            Dim totalBayar As Decimal = Decimal.Parse(LabelHarga.Text)
            Dim bayar As Decimal = Decimal.Parse(TextBoxBayar.Text)
            Dim kembalian As Decimal = bayar - totalBayar
            LBLKembali.Text = If(kembalian < 0, "0", kembalian.ToString("N0"))
        Else
            LBLKembali.Text = "0"
        End If
    End Sub
    Private Sub kurangiJumlahMenuItem_Click(sender As Object, e As EventArgs) Handles KurangiJumlahMenuItem.Click
        Try
            If DataGridView1.CurrentRow Is Nothing Then
                MsgBox("Silakan pilih baris terlebih dahulu.", MsgBoxStyle.Information)
                Exit Sub
            End If

            Dim selectedRow As DataGridViewRow = DataGridView1.CurrentRow
            Dim jumlahSaatIni As Integer = CInt(selectedRow.Cells("jumlah_produk").Value)
            Dim inputJumlah As String = InputBox("Masukkan jumlah yang ingin dikurangi:", "Kurangi Jumlah", "0")

            If String.IsNullOrWhiteSpace(inputJumlah) OrElse Not IsNumeric(inputJumlah) Then
                MsgBox("Jumlah yang dimasukkan tidak valid!", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            Dim jumlahDikurangi As Integer = CInt(inputJumlah)

            If jumlahDikurangi <= 0 Then
                MsgBox("Jumlah yang dikurangi harus lebih dari 0.", MsgBoxStyle.Exclamation)
                Exit Sub
            ElseIf jumlahDikurangi > jumlahSaatIni Then
                MsgBox("Jumlah yang dikurangi melebihi jumlah saat ini!", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            selectedRow.Cells("jumlah_produk").Value = jumlahSaatIni - jumlahDikurangi
            Dim hargaProduk As Decimal = CDec(selectedRow.Cells("harga_produk").Value)
            selectedRow.Cells("total_penjualan").Value = hargaProduk * (jumlahSaatIni - jumlahDikurangi)
            If CInt(selectedRow.Cells("jumlah_produk").Value) = 0 Then
                DataGridView1.Rows.Remove(selectedRow)
            End If
            Call RumusSubtotal()
        Catch ex As Exception
            MsgBox("Terjadi kesalahan: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub HapusProdukMenuItem_Click(sender As Object, e As EventArgs) Handles HapusProdukMenuItem.Click
        If DataGridView1.SelectedRows.Count > 0 Then
            DataGridView1.Rows.Remove(DataGridView1.SelectedRows(0))
            Call RumusSubtotal()
        Else
            MsgBox("Pilih baris terlebih dahulu!", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub DataGridView1_MouseClick(sender As Object, e As MouseEventArgs) Handles DataGridView1.MouseClick
        If e.Button = MouseButtons.Right Then
            Dim hit As DataGridView.HitTestInfo = DataGridView1.HitTest(e.X, e.Y)
            If hit.RowIndex >= 0 Then
                DataGridView1.ClearSelection()
                DataGridView1.Rows(hit.RowIndex).Selected = True
                ContextMenuStrip1.Show(DataGridView1, e.Location)
            End If
        End If
    End Sub

    Private Sub ButtonSimpan_Click(sender As Object, e As EventArgs) Handles ButtonSimpan.Click
        Try
            If String.IsNullOrWhiteSpace(ComboBoxIDP.Text) Then
                MsgBox("Pilih pelanggan terlebih dahulu!", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            If DataGridView1.Rows.Count = 0 Then
                MsgBox("Tidak ada produk yang dipilih!", MsgBoxStyle.Exclamation)
                Exit Sub
            End If

            If Not IsNumeric(TextBoxBayar.Text) OrElse Decimal.Parse(TextBoxBayar.Text) < Decimal.Parse(LabelHarga.Text) Then
                MsgBox("Uang yang dibayar kurang!", MsgBoxStyle.Critical)
                Exit Sub
            End If

            Call Koneksi()

            ' Menghitung total jumlah produk
            Dim totalItemPenjualan As Integer = 0
            For Each row As DataGridViewRow In DataGridView1.Rows
                If Not row.IsNewRow Then
                    totalItemPenjualan += Convert.ToInt32(row.Cells("jumlah_produk").Value)
                End If
            Next

            ' Menyimpan data penjualan ke dalam tabel penjualan
            Dim queryPenjualan As String = "INSERT INTO penjualan (id_penjualan, tanggal_penjualan, jam_penjualan, item_penjualan, total_penjualan, bayar, kembali, id_pelanggan, id_admin) " &
                                       "VALUES (@id_penjualan, @tanggal_penjualan, @jam_penjualan, @item_penjualan, @total_penjualan, @bayar, @kembali, @id_pelanggan, @id_admin)"
            Cmd = New MySqlCommand(queryPenjualan, Conn)
            Cmd.Parameters.AddWithValue("@id_penjualan", LBLNoJual.Text)
            Cmd.Parameters.AddWithValue("@tanggal_penjualan", Today.ToString("yyyy-MM-dd"))
            Cmd.Parameters.AddWithValue("@jam_penjualan", TimeOfDay.ToString("HH:mm:ss"))
            Cmd.Parameters.AddWithValue("@item_penjualan", totalItemPenjualan)
            Cmd.Parameters.AddWithValue("@total_penjualan", Decimal.Parse(LabelHarga.Text))
            Cmd.Parameters.AddWithValue("@bayar", Decimal.Parse(TextBoxBayar.Text))
            Cmd.Parameters.AddWithValue("@kembali", Decimal.Parse(LBLKembali.Text))
            Cmd.Parameters.AddWithValue("@id_pelanggan", ComboBoxIDP.Text)
            Cmd.Parameters.AddWithValue("@id_admin", LBLAdmin.Text)
            Cmd.ExecuteNonQuery()

            ' Menyimpan data detail penjualan ke dalam tabel detail_penjualan
            For Each row As DataGridViewRow In DataGridView1.Rows
                If row.IsNewRow Then
                    Continue For
                End If

                If row.Cells("id_produk").Value Is Nothing OrElse String.IsNullOrWhiteSpace(row.Cells("id_produk").Value.ToString()) Then
                    MsgBox("Nilai 'ID Produk' kosong pada baris " & (row.Index + 1).ToString(), MsgBoxStyle.Critical)
                    Return
                End If

                If row.Cells("nama_produk").Value Is Nothing OrElse String.IsNullOrWhiteSpace(row.Cells("nama_produk").Value.ToString()) Then
                    MsgBox("Nilai 'Nama Produk' kosong pada baris " & (row.Index + 1).ToString(), MsgBoxStyle.Critical)
                    Return
                End If

                If row.Cells("jumlah_produk").Value Is Nothing OrElse String.IsNullOrWhiteSpace(row.Cells("jumlah_produk").Value.ToString()) Then
                    MsgBox("Nilai 'Jumlah' kosong pada baris " & (row.Index + 1).ToString(), MsgBoxStyle.Critical)
                    Return
                End If

                If row.Cells("harga_produk").Value Is Nothing OrElse String.IsNullOrWhiteSpace(row.Cells("harga_produk").Value.ToString()) Then
                    MsgBox("Nilai 'Harga' kosong pada baris " & (row.Index + 1).ToString(), MsgBoxStyle.Critical)
                    Return
                End If

                If row.Cells("total_penjualan").Value Is Nothing OrElse String.IsNullOrWhiteSpace(row.Cells("total_penjualan").Value.ToString()) Then
                    MsgBox("Nilai 'Subtotal' kosong pada baris " & (row.Index + 1).ToString(), MsgBoxStyle.Critical)
                    Return
                End If

                Dim queryDetail As String = "INSERT INTO detail_penjualan (id_detail_penjualan, id_penjualan, id_produk, jumlah_produk, harga_satuan, total_harga) " &
                                        "VALUES (@id_detail_penjualan, @id_penjualan, @id_produk, @jumlah_produk, @harga_satuan, @total_harga)"
                Cmd = New MySqlCommand(queryDetail, Conn)
                Cmd.Parameters.AddWithValue("@id_detail_penjualan", Guid.NewGuid().ToString().Substring(0, 8))
                Cmd.Parameters.AddWithValue("@id_penjualan", LBLNoJual.Text)
                Cmd.Parameters.AddWithValue("@id_produk", row.Cells("id_produk").Value.ToString())
                Cmd.Parameters.AddWithValue("@jumlah_produk", row.Cells("jumlah_produk").Value)
                Cmd.Parameters.AddWithValue("@harga_satuan", row.Cells("harga_produk").Value)
                Cmd.Parameters.AddWithValue("@total_harga", row.Cells("total_penjualan").Value)
                Cmd.ExecuteNonQuery()

                ' Mengurangi stok produk
                Dim queryUpdateStok As String = "UPDATE produk SET stok_produk = stok_produk - @jumlah_produk WHERE id_produk = @id_produk"
                Cmd = New MySqlCommand(queryUpdateStok, Conn)
                Cmd.Parameters.AddWithValue("@jumlah_produk", row.Cells("jumlah_produk").Value)
                Cmd.Parameters.AddWithValue("@id_produk", row.Cells("id_produk").Value)
                Cmd.ExecuteNonQuery()
            Next

            MsgBox("Transaksi berhasil disimpan!", MsgBoxStyle.Information)
            print_nota()
            Call KondisiAwal()

        Catch ex As Exception
            MsgBox("Terjadi kesalahan saat menyimpan data: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            If Conn IsNot Nothing AndAlso Conn.State = ConnectionState.Open Then
                Conn.Close()
            End If
        End Try
    End Sub

    Private Sub ButtonBatal_Click(sender As Object, e As EventArgs) Handles ButtonBatal.Click
        Call KondisiAwal()
        DataGridView1.Rows.Clear()
    End Sub

    Private Sub ButtonTutup_Click(sender As Object, e As EventArgs) Handles ButtonTutup.Click
        Me.Close()
    End Sub

    Private Sub nota_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles nota.PrintPage
        Dim tinggi As Integer = 10
        e.Graphics.DrawString("Toko DOLANANMU", New Drawing.Font("courier new", 8), Brushes.Black, 2, tinggi)

        tinggi = tinggi + 10
        e.Graphics.DrawString("No Tlp: 0895364878963", New Drawing.Font("courier new", 8), Brushes.Black, 2, tinggi)

        tinggi = tinggi + 10
        e.Graphics.DrawString("Jl. Simorejo Sari VI", New Drawing.Font("courier new", 8), Brushes.Black, 2, tinggi)

        tinggi = tinggi + 20
        e.Graphics.DrawString("---------------------------", New Drawing.Font("courier new", 8), Brushes.Black, 2, tinggi)

        tinggi = tinggi + 10
        e.Graphics.DrawString("Produk" & vbTab & vbTab & "Qty" & vbTab & "Total", New Drawing.Font("courier new", 8), Brushes.Black, 2, tinggi)

        tinggi = tinggi + 20
        e.Graphics.DrawString("---------------------------", New Drawing.Font("courier new", 8), Brushes.Black, 2, tinggi)

        For Each erow As DataGridViewRow In DataGridView1.Rows
            If erow.IsNewRow Then Continue For

            tinggi = tinggi + 10
            e.Graphics.DrawString(erow.Cells("nama_produk").Value.ToString(), New Drawing.Font("courier new", 8), Brushes.Black, 2, tinggi)

            tinggi = tinggi + 10
            e.Graphics.DrawString(vbTab & vbTab & erow.Cells("jumlah_produk").Value.ToString() & vbTab & erow.Cells("total_penjualan").Value.ToString(), New Drawing.Font("courier new", 8), Brushes.Black, 2, tinggi)
        Next

        tinggi = tinggi + 10
        e.Graphics.DrawString("---------------------------", New Drawing.Font("courier new", 8), Brushes.Black, 2, tinggi)

        tinggi = tinggi + 10
        e.Graphics.DrawString("Total" & vbTab & vbTab & ":" & TextBoxBayar.Text, New Drawing.Font("courier new", 8), Brushes.Black, 2, tinggi)

        tinggi = tinggi + 10
        e.Graphics.DrawString("Tunai" & vbTab & vbTab & ":" & LabelHarga.Text, New Drawing.Font("courier new", 8), Brushes.Black, 2, tinggi)

        tinggi = tinggi + 10
        e.Graphics.DrawString("Kembali" & vbTab & ":" & LBLKembali.Text, New Drawing.Font("courier new", 8), Brushes.Black, 2, tinggi)

        tinggi = tinggi + 10
        e.Graphics.DrawString("---------------------------", New Drawing.Font("courier new", 8), Brushes.Black, 2, tinggi)

        tinggi = tinggi + 10
        e.Graphics.DrawString("Terimakasih...!!!", New Drawing.Font("courier new", 8), Brushes.Black, 2, tinggi)
    End Sub

    Sub print_nota()
        Try
            nota.PrinterSettings.PrinterName = "Fax"
            nota.Print()
            MsgBox("Nota berhasil diprint!", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox("Terjadi kesalahan saat mencetak nota: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
End Class