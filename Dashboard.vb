Public Class Dashboard
    Private Sub btnJual_Click(sender As Object, e As EventArgs) Handles btnJual.Click
        Penjualan.Data_Penjualan()
        Penjualan.Data_Barang()
        Penjualan.Show()
        Me.Hide()

    End Sub

    Private Sub btnBeli_Click(sender As Object, e As EventArgs) Handles btnBeli.Click
        Pembelian.Data_Pembelian()
        Pembelian.Data_Barang()
        Pembelian.Data_Supplier()
        Pembelian.Show()
        Me.Hide()
    End Sub

    Private Sub btnPelanggan_Click(sender As Object, e As EventArgs) Handles btnPelanggan.Click
        Pelanggan.Data_Pelanggan()
        Pelanggan.Show()
        Me.Hide()
    End Sub

    Private Sub btnBrg_Click(sender As Object, e As EventArgs) Handles btnBrg.Click
        Barang.Data_Barang()
        Barang.Show()
        Me.Hide()
    End Sub

    Private Sub btnAkun_Click(sender As Object, e As EventArgs) Handles btnAkun.Click
        Akun.Show()
        Me.Hide()
    End Sub

    Private Sub btnKembali_Click(sender As Object, e As EventArgs) Handles btnKembali.Click
        Login.Show()
        Me.Hide()
    End Sub

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label2.Text = Login.txtUser.Text
    End Sub

    Private Sub btnSupp_Click(sender As Object, e As EventArgs) Handles btnSupp.Click
        Supplier.Data_Supplier()
        Supplier.Show()
        Me.Hide()
    End Sub

    Private Sub btnLaporanJual_Click(sender As Object, e As EventArgs) Handles btnLaporanJual.Click
        LaporanPenjualan.Show()
        Me.Hide()
    End Sub

    Private Sub btnLaporanBeli_Click(sender As Object, e As EventArgs) Handles btnLaporanBeli.Click
        LaporanPembelian.Show()
        Me.Hide()
    End Sub
End Class