Imports System.Data.OleDb
Imports System.Data
Imports System.Data.Odbc
Imports System.Drawing.Printing
Public Class Penjualan
    Dim WithEvents PD As New PrintDocument 'mendeklarasikan variabel baru
    Dim PPD As New PrintPreviewDialog
    Sub Data_Penjualan()
        Try
            LOKASI = KONEKSI
            CNN = New OleDbConnection(LOKASI)
            If CNN.State = ConnectionState.Closed Then CNN.Open()
            da = New OleDbDataAdapter("Select * from Tbl_Penjualan ", CNN)
            ds = New DataSet
            ds.Clear()
            da.Fill(ds, "Data_Penjualan")
            DataGridView1.DataSource = (ds.Tables("Data_Penjualan"))
        Catch myerror As OleDbException
            MessageBox.Show("Error:", myerror.Message)
        End Try
    End Sub
    Sub Data_Barang()
        Try
            LOKASI = KONEKSI
            CNN = New OleDbConnection(LOKASI)
            If CNN.State = ConnectionState.Closed Then CNN.Open()
            da = New OleDbDataAdapter("Select * from Tbl_Barang ", CNN)
            ds = New DataSet
            ds.Clear()
            da.Fill(ds, "Data_Barang")
            DataGridView2.DataSource = (ds.Tables("Data_Barang"))
        Catch myerror As OleDbException
            MessageBox.Show("Error:", myerror.Message)
        End Try
    End Sub
    Private Sub Penjualan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtNmKry.Text = Login.txtUser.Text
        Call Data_Penjualan()
        Call Data_Barang()
        DataGridView1.Refresh()
        DataGridView2.Refresh()

    End Sub

    'Private Sub btnInput_Click(sender As Object, e As EventArgs) Handles btnInput.Click
    '    If txtNoFaktur.Text = "" Or txtKdBrg.Text = "" Or txtNmBrg.Text = "" Or txtTtlByr.Text = "" Or NumericUpDown1.Value = "0" Or txtTtlHrg.Text = "" Or txtHrgBrg.Text = "" Then
    '        MsgBox("Harap mengisi seluruh data penjualan!", vbOKOnly + MsgBoxStyle.Exclamation)
    '    Else
    '        Call KoneksiUser()
    '        OLECMD = New OleDbCommand("Select * from Tbl_Penjualan where No_Faktur = '" & txtNoFaktur.Text & "'", CNN)
    '        dread = OLECMD.ExecuteReader
    '        dread.Read()
    '        If dread.HasRows Then
    '            MsgBox("Nomor faktur sudah ada!", MsgBoxStyle.Exclamation)
    '        Else
    '            Try
    '                CNN = New OleDbConnection(KONEKSI)
    '                If CNN.State <> ConnectionState.Closed Then CNN.Close()
    '                CNN.Open()
    '                OLECMD = New OleDbCommand("insert into Tbl_Penjualan (No_Faktur, Tgl_Transaksi, Kd_Barang, Nama_Barang, Harga_Barang, Total_Item, Total_Harga, Total_Bayar, Nama_Karyawan) values('" & txtNoFaktur.Text & "','" & DateTimePicker1.Value & "','" & txtKdBrg.Text & "', '" & txtNmBrg.Text & "', '" & txtHrgBrg.Text & "','" & NumericUpDown1.Value & "', '" & txtTtlHrg.Text & "', '" & txtTtlByr.Text & "', '" & txtNmKry.Text & "')", CNN)
    '                X = OLECMD.ExecuteNonQuery
    '                If X = 1 Then
    '                    MsgBox("Data berhasil diinput", vbOKOnly + MsgBoxStyle.Information)
    '                    ClearTextBoxInBox(GroupBox1)
    '                    NumericUpDown1.Value = "0"
    '                Else
    '                    MsgBox("Data gagal diinput", vbOKOnly + MsgBoxStyle.Exclamation)
    '                End If
    '                DataGridView1.Refresh()
    '                Call Data_Penjualan()
    '                CNN.Close()
    '            Catch myerror As OleDbException
    '                MessageBox.Show("Error:", myerror.Message)
    '            End Try
    '        End If
    '    End If
    'End Sub
    Private Sub btnInput_Click(sender As Object, e As EventArgs) Handles btnInput.Click
        If txtNoFaktur.Text = "" Or txtKdBrg.Text = "" Or txtNmBrg.Text = "" Or txtTtlByr.Text = "" Or NumericUpDown1.Value = 0 Or txtTtlHrg.Text = "" Or txtHrgBrg.Text = "" Then
            MsgBox("Harap mengisi seluruh data penjualan!", vbOKOnly + MsgBoxStyle.Exclamation)
        Else
            Call KoneksiUser()
            OLECMD = New OleDbCommand("Select * from Tbl_Penjualan where No_Faktur = '" & txtNoFaktur.Text & "'", CNN)
            dread = OLECMD.ExecuteReader
            dread.Read()
            If dread.HasRows Then
                MsgBox("Nomor faktur sudah ada!", MsgBoxStyle.Exclamation)
            Else
                Try
                    CNN = New OleDbConnection(KONEKSI)
                    If CNN.State <> ConnectionState.Closed Then CNN.Close()
                    CNN.Open()
                    ' Update Tbl_Barang to decrease the total stock
                    OLECMD = New OleDbCommand("Update Tbl_Barang Set Stok_Barang = Stok_Barang - " & NumericUpDown1.Value & " WHERE Kd_Barang = '" & txtKdBrg.Text & "'", CNN)
                    OLECMD.ExecuteNonQuery()
                    Call Data_Barang()

                    ' Insert into Tbl_Penjualan
                    OLECMD = New OleDbCommand("insert into Tbl_Penjualan (No_Faktur, Tgl_Transaksi, Kd_Barang, Nama_Barang, Harga_Barang, Total_Item, Total_Harga, Total_Bayar, Nama_Karyawan) values('" & txtNoFaktur.Text & "','" & DateTimePicker1.Value & "','" & txtKdBrg.Text & "', '" & txtNmBrg.Text & "', '" & txtHrgBrg.Text & "','" & NumericUpDown1.Value & "', '" & txtTtlHrg.Text & "', '" & txtTtlByr.Text & "', '" & txtNmKry.Text & "')", CNN)
                    Dim X As Integer = OLECMD.ExecuteNonQuery
                    If X = 1 Then
                        MsgBox("Data berhasil diinput", vbOKOnly + MsgBoxStyle.Information)
                        ClearTextBoxInBox(GroupBox1)
                        NumericUpDown1.Value = 0
                    Else
                        MsgBox("Data gagal diinput", vbOKOnly + MsgBoxStyle.Exclamation)
                    End If
                    DataGridView1.Refresh()
                    Call Data_Penjualan()
                    CNN.Close()
                Catch myerror As OleDbException
                    MessageBox.Show("Error:", myerror.Message)
                End Try
            End If
        End If
    End Sub



    Private Sub btnHps_Click(sender As Object, e As EventArgs) Handles btnHps.Click
        Dim hapus
        Dim CNN As New OleDbConnection()
        hapus = MsgBox("apakah anda yakin untuk menghapus data?", vbYesNo + vbQuestion, "Konfirmasi")
        If hapus = vbNo Then
            Exit Sub
        End If
        CNN.ConnectionString = KONEKSI
        CNN.Open()
        Try
            Dim OLECMD As New OleDbCommand()
            OLECMD.Connection = CNN
            OLECMD.CommandText = "DELETE from Tbl_Penjualan where No_Faktur ='" & Me.DataGridView1.CurrentRow.Cells(0).Value & "'"
            OLECMD.ExecuteNonQuery()
        Finally
            CNN.Close()
            MsgBox("Data berhasil dihapus", vbOKOnly + MsgBoxStyle.Information)
        End Try
        Me.DataGridView1.Rows.Remove(Me.DataGridView1.CurrentRow)
        Call Data_Penjualan()
        ClearTextBoxInBox(GroupBox1)
        NumericUpDown1.Text = "0"
    End Sub

    Private Sub btnKmbl_Click(sender As Object, e As EventArgs) Handles btnKmbl.Click
        Dashboard.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a 'mendeklarasikan variabel baru
        Dim b
        a = txtHrgBrg.Text
        b = NumericUpDown1.Value
        txtTtlHrg.Text = a * b
    End Sub

    Private Sub btnCetak_Click(sender As Object, e As EventArgs) Handles btnCetak.Click
        If DataGridView1.RowCount = Nothing Then 'validasi harus mengklik salah satu baris di dgv agar bisa mencetak faktur
            MsgBox("Harap mengklik data penjualan yang akan dibuatkan faktur!", MsgBoxStyle.Exclamation)
        Else
            PPD.Document = PD
            PPD.ShowDialog()
        End If
    End Sub
    Private Sub PD_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PD.PrintPage 'coding untuk membuat faktur dalam bentuk pdf
        Dim f10 As New Font("Times New Roman", 10, FontStyle.Regular)
        Dim f10b As New Font("Times New Roman", 10, FontStyle.Bold)
        Dim f14 As New Font("Times New Roman", 14, FontStyle.Bold)

        Dim leftmargin% = PD.DefaultPageSettings.Margins.Left
        Dim centermargin% = PD.DefaultPageSettings.PaperSize.Width / 2
        Dim rightmargin% = PD.DefaultPageSettings.PaperSize.Width

        Dim kanan As New StringFormat
        Dim tengah As New StringFormat
        kanan.Alignment = StringAlignment.Far
        tengah.Alignment = StringAlignment.Center

        Dim garis$
        garis = "--------------------------------------------------"

        e.Graphics.DrawString("Maulana Motor Services", f14, Brushes.Black, centermargin, 5, tengah)
        e.Graphics.DrawString("Jl. Cipinang Baru Raya No.1", f10, Brushes.Black, centermargin, 25, tengah)
        e.Graphics.DrawString("Pulo Gadung, Jakarta Timur", f10, Brushes.Black, centermargin, 40, tengah)

        e.Graphics.DrawString("Kode Penjualan :", f10, Brushes.Black, 0, 80)
        Dim baris%
        e.Graphics.DrawString(DataGridView1.SelectedRows(baris).Cells(0).Value.ToString, f10, Brushes.Black, 110, 80)

        e.Graphics.DrawString("Kode Barang :", f10, Brushes.Black, 0, 100)
        e.Graphics.DrawString(DataGridView1.SelectedRows(baris).Cells(2).Value.ToString, f10, Brushes.Black, 110, 100)

        e.Graphics.DrawString("Tanggal :", f10, Brushes.Black, 0, 120)
        e.Graphics.DrawString(DataGridView1.SelectedRows(baris).Cells(1).Value.ToString, f10, Brushes.Black, 110, 120)

        e.Graphics.DrawString(garis, f10, Brushes.Black, 0, 140)

        e.Graphics.DrawString("Nama Barang :", f10, Brushes.Black, 0, 160)
        e.Graphics.DrawString(DataGridView1.SelectedRows(baris).Cells(3).Value.ToString, f10, Brushes.Black, 110, 160)

        e.Graphics.DrawString("Harga Barang :", f10, Brushes.Black, 0, 180)
        e.Graphics.DrawString(DataGridView1.SelectedRows(baris).Cells(4).Value.ToString, f10, Brushes.Black, 110, 180)

        e.Graphics.DrawString("Total Item :", f10, Brushes.Black, 0, 200)
        e.Graphics.DrawString(DataGridView1.SelectedRows(baris).Cells(5).Value.ToString, f10, Brushes.Black, 110, 200)

        e.Graphics.DrawString("Total Harga :", f10, Brushes.Black, 0, 220)
        e.Graphics.DrawString(DataGridView1.SelectedRows(baris).Cells(6).Value.ToString, f10, Brushes.Black, 110, 220)

        e.Graphics.DrawString(garis, f10, Brushes.Black, 0, 240)

        e.Graphics.DrawString("Total Bayar :", f10, Brushes.Black, 0, 260)
        e.Graphics.DrawString(DataGridView1.SelectedRows(baris).Cells(7).Value.ToString, f10, Brushes.Black, 110, 260)

        e.Graphics.DrawString("~Terima Kasih~", f10, Brushes.Black, centermargin, 330, tengah)

    End Sub

    Private Sub PD_BeginPrint(sender As Object, e As PrintEventArgs) Handles PD.BeginPrint 'coding untuk mengatur ukuran paper
        Dim pagesetup As New PageSettings
        pagesetup.PaperSize = New PaperSize("Custom", 250, 400)
        PD.DefaultPageSettings = pagesetup
    End Sub

    Private Sub CheckBrg_Click(sender As Object, e As EventArgs) Handles CheckBrg.Click
        Dim kodeBarang
        kodeBarang = txtKdBrg.Text
        Try
            LOKASI = KONEKSI
            CNN = New OleDbConnection(LOKASI)
            If CNN.State = ConnectionState.Closed Then CNN.Open()
            OLECMD = New OleDbCommand("Select * from Tbl_Barang where Kd_Barang = '" & kodeBarang & "'", CNN)
            dread = OLECMD.ExecuteReader
            dread.Read()
            If dread.HasRows Then
                txtNmBrg.Text = dread.Item("Nama_Barang")
                txtHrgBrg.Text = dread.Item("Harga_Barang")
            Else
                MsgBox("Kode barang tidak ditemukan!", vbOKOnly + MsgBoxStyle.Exclamation)
            End If
        Catch myerror As OleDbException
            MessageBox.Show("Error:", myerror.Message)
        End Try
    End Sub
End Class