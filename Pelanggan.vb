Imports System.Data.OleDb
Imports System.Drawing.Printing
Imports System.Data
Imports System.Data.Odbc
Public Class Pelanggan
    Dim WithEvents PD As New PrintDocument
    Dim PDD As New PrintPreviewDialog
    Sub Data_Pelanggan()
        Try
            LOKASI = KONEKSI
            CNN = New OleDbConnection(LOKASI)
            If CNN.State = ConnectionState.Closed Then CNN.Open()
            da = New OleDbDataAdapter("Select * from Tbl_Pelanggan ", CNN)
            ds = New DataSet
            ds.Clear()
            da.Fill(ds, "Data_Pelanggan")
            DataGridView1.DataSource = (ds.Tables("Data_Pelanggan"))
        Catch myerror As OleDbException
            MessageBox.Show("Error:", myerror.Message)
        End Try
    End Sub
    Private Sub btnInput_Click(sender As Object, e As EventArgs) Handles btnInput.Click
        If txtKdPlg.Text = "" Or txtNmPlg.Text = "" Or txtNoHP.Text = "" Or rtxAlamat.Text = "" Or rtxStatus.Text = "" Then
            MsgBox("Harap mengisi seluruh data pelanggan!", vbOKOnly + MsgBoxStyle.Exclamation)
        Else
            Call KoneksiUser()
            OLECMD = New OleDbCommand("Select * from Tbl_Pelanggan where Kd_Pelanggan = '" & txtKdPlg.Text & "'", CNN)
            dread = OLECMD.ExecuteReader
            dread.Read()
            If dread.HasRows Then
                MsgBox("Kode pelanggan sudah ada!", MsgBoxStyle.Exclamation)
            Else
                Try
                    CNN = New OleDbConnection(KONEKSI)
                    If CNN.State <> ConnectionState.Closed Then CNN.Close()
                    CNN.Open()
                    OLECMD = New OleDbCommand("insert into Tbl_Pelanggan (Kd_Pelanggan, Nama_Pelanggan, Alamat, No_Tlp, Status) values('" & txtKdPlg.Text & "','" & txtNmPlg.Text & "','" & rtxAlamat.Text & "', '" & txtNoHP.Text & "', '" & rtxStatus.Text & "')", CNN)
                    X = OLECMD.ExecuteNonQuery
                    If X = 1 Then
                        MsgBox("Data berhasil diinput", vbOKOnly + MsgBoxStyle.Information)
                        ClearTextBoxInBox(GroupBox1)
                        rtxAlamat.Text = ""
                        rtxStatus.Text = ""
                    Else
                        MsgBox("Data gagal diinput", vbOKOnly + MsgBoxStyle.Exclamation)
                    End If
                    DataGridView1.Refresh()
                    Call Data_Pelanggan()
                    CNN.Close()
                Catch myerror As OleDbException
                    MessageBox.Show("Error:", myerror.Message)
                End Try
            End If
        End If
    End Sub

    Private Sub Pelanggan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Data_Pelanggan()
        DataGridView1.Refresh()
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
            OLECMD.CommandText = "DELETE from Tbl_Pelanggan where Kd_Pelanggan ='" & Me.DataGridView1.CurrentRow.Cells(0).Value & "'"
            OLECMD.ExecuteNonQuery()
        Finally
            CNN.Close()
            MsgBox("Data berhasil dihapus", vbOKOnly + MsgBoxStyle.Information)
        End Try
        Me.DataGridView1.Rows.Remove(Me.DataGridView1.CurrentRow)
        Call Data_Pelanggan()
        ClearTextBoxInBox(GroupBox1)
        rtxAlamat.Text = ""
        rtxStatus.Text = ""
    End Sub

    Private Sub btnKmbl_Click(sender As Object, e As EventArgs) Handles btnKmbl.Click
        Dashboard.Show()
        Me.Hide()
    End Sub

    Private Sub BtnCtk_Click(sender As Object, e As EventArgs) Handles BtnCtk.Click
        PDD.Document = PD
        PDD.ShowDialog()

    End Sub

    Private Sub PD_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PD.PrintPage
        DataGridView1.AllowUserToAddRows = False

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

        Dim alamat1 As String
        Dim alamat2 As String
        Dim status1 As String
        Dim status2 As String

        alamat1 = Microsoft.VisualBasic.Left(rtxAlamat.Text, 27)
        alamat2 = Mid(rtxAlamat.Text, 28, 64)
        status1 = Microsoft.VisualBasic.Left(rtxStatus.Text, 27)
        status2 = Mid(rtxStatus.Text, 28, 64)

        Dim garis$
        garis = "-----------------------------------------------------------------"

        e.Graphics.DrawString("Maulana Motor Services", f14, Brushes.Black, centermargin, 5, tengah)
        e.Graphics.DrawString("Jl. Cipinang Baru Raya No.1", f10, Brushes.Black, centermargin, 25, tengah)
        e.Graphics.DrawString("Pulo Gadung, Jakarta Timur", f10, Brushes.Black, centermargin, 40, tengah)

        e.Graphics.DrawString("Kode", f10, Brushes.Black, 0, 80)
        e.Graphics.DrawString(":", f10, Brushes.Black, 45, 80)
        e.Graphics.DrawString(txtKdPlg.Text, f10, Brushes.Black, 55, 80)

        e.Graphics.DrawString(garis, f10, Brushes.Black, 0, 100)

        e.Graphics.DrawString("Nama", f10, Brushes.Black, 0, 120)
        e.Graphics.DrawString(":", f10, Brushes.Black, 45, 120)
        e.Graphics.DrawString(txtNmPlg.Text, f10, Brushes.Black, 55, 120)

        e.Graphics.DrawString("No. HP", f10, Brushes.Black, 0, 140)
        e.Graphics.DrawString(":", f10, Brushes.Black, 45, 140)
        e.Graphics.DrawString(txtNoHP.Text, f10, Brushes.Black, 55, 140)

        e.Graphics.DrawString("Alamat", f10, Brushes.Black, 0, 160)
        e.Graphics.DrawString(":", f10, Brushes.Black, 45, 160)
        e.Graphics.DrawString(alamat1, f10, Brushes.Black, 55, 160)
        e.Graphics.DrawString(alamat2, f10, Brushes.Black, 55, 180)

        e.Graphics.DrawString(garis, f10, Brushes.Black, 0, 200)

        e.Graphics.DrawString("Status", f10b, Brushes.Black, 0, 220)
        e.Graphics.DrawString(":", f10b, Brushes.Black, 45, 220)
        e.Graphics.DrawString(status1, f10b, Brushes.Black, 55, 220)
        e.Graphics.DrawString(status2, f10b, Brushes.Black, 55, 240)

        e.Graphics.DrawString("~Kartu Servis~", f10, Brushes.Black, centermargin, 290, tengah)

    End Sub

    Private Sub PD_BeginPrint(sender As Object, e As PrintEventArgs) Handles PD.BeginPrint
        Dim pagesetup As New PageSettings
        pagesetup.PaperSize = New PaperSize("Custom", 250, 340)
        PD.DefaultPageSettings = pagesetup
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        txtKdPlg.Text = Me.DataGridView1.CurrentRow.Cells(0).Value
        txtNmPlg.Text = Me.DataGridView1.CurrentRow.Cells(1).Value
        rtxAlamat.Text = Me.DataGridView1.CurrentRow.Cells(2).Value
        txtNoHP.Text = Me.DataGridView1.CurrentRow.Cells(3).Value
        rtxStatus.Text = Me.DataGridView1.CurrentRow.Cells(4).Value
    End Sub
End Class