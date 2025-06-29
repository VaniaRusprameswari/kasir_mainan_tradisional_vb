Imports MySql.Data.MySqlClient

Module Module1
    Public Conn As New MySqlConnection
    Public da As New MySqlDataAdapter
    Public ds As DataSet

    Public Sub Koneksi()
        Try
            Dim Strconn As String = "server=localhost;user=root;password=;database=toko"
            If Conn.State = ConnectionState.Open Then
                Conn.Close()
            End If
            Conn.ConnectionString = Strconn
            Conn.Open()
            MsgBox("Koneksi Berhasil")
        Catch ex As Exception
            MsgBox("Koneksi Gagal: " & ex.Message)
        End Try
    End Sub
End Module
