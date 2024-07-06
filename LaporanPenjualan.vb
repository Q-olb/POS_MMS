Imports System.Data.OleDb
Imports System.Data
Imports System.Data.Odbc
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO
Public Class LaporanPenjualan
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dashboard.Show()
        Me.Hide()
    End Sub

    Private Sub btnCheck_Click(sender As Object, e As EventArgs) Handles btnCheck.Click
        Dim text_bulan, num_bulan, tahun
        text_bulan = cbBulan.Text
        tahun = cbTahun.Text

        If text_bulan = "Januari" Then
            num_bulan = "1"
        ElseIf text_bulan = "Februari" Then
            num_bulan = "2"
        ElseIf text_bulan = "Maret" Then
            num_bulan = "3"
        ElseIf text_bulan = "April" Then
            num_bulan = "4"
        ElseIf text_bulan = "Mei" Then
            num_bulan = "5"
        ElseIf text_bulan = "Juni" Then
            num_bulan = "6"
        ElseIf text_bulan = "Juli" Then
            num_bulan = "7"
        ElseIf text_bulan = "Agustus" Then
            num_bulan = "8"
        ElseIf text_bulan = "September" Then
            num_bulan = "9"
        ElseIf text_bulan = "Oktober" Then
            num_bulan = "10"
        ElseIf text_bulan = "November" Then
            num_bulan = "11"
        Else
            num_bulan = "12"
        End If

        Try
            LOKASI = KONEKSI
            CNN = New OleDbConnection(LOKASI)
            If CNN.State = ConnectionState.Closed Then CNN.Open()
            OLECMD = New OleDbCommand("Select * from Tbl_Penjualan where Month([Tgl_Transaksi]) = '" & num_bulan & "' and  Year([Tgl_Transaksi]) = '" & tahun & "'", CNN)
            dread = OLECMD.ExecuteReader
            dread.Read()
            If dread.HasRows Then
                Try
                    LOKASI = KONEKSI
                    CNN = New OleDbConnection(LOKASI)
                    If CNN.State = ConnectionState.Closed Then CNN.Open()
                    da = New OleDbDataAdapter("Select * from Tbl_Penjualan where Month([Tgl_Transaksi]) = '" & num_bulan & "' and  Year([Tgl_Transaksi]) = '" & tahun & "'", CNN)
                    ds = New DataSet
                    ds.Clear()
                    da.Fill(ds, "Data_Penjualan")
                    DataGridView1.DataSource = (ds.Tables("Data_Penjualan"))

                    Dim keterangan As String = "TOTAL"
                    Dim total As Integer = 0
                    Dim max As Integer = DataGridView1.Rows.Count - 1
                    For Each row As DataGridViewRow In DataGridView1.Rows
                        total = total + row.Cells(4).Value
                    Next
                    DataGridView1.Rows(max).Cells(5).Value = keterangan
                    DataGridView1.Rows(max).Cells(6).Value = total
                Catch myerror As OleDbException
                    MessageBox.Show("Error:", myerror.Message)
                End Try
            Else
                MsgBox("Laporan dengan periode tersebut tidak ditemukan!", vbOKOnly + MsgBoxStyle.Exclamation)
                DataGridView1.DataSource = Nothing
            End If
        Catch myerror As OleDbException
            MessageBox.Show("Error:", myerror.Message)
        End Try
    End Sub
    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        ' Mendapatkan jalur ke folder "Downloads" di sistem operasi Windows
        Dim downloadsFolder As String = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) & "\Downloads"

        ' Menggabungkan jalur folder "Downloads" dengan nama file PDF
        Dim filePath As String = Path.Combine(downloadsFolder, "Laporan_Penjualan.pdf")

        ' Membuat objek Document iTextSharp
        Dim document As New Document()

        Try
            ' Membuat objek PdfWriter untuk menulis ke file PDF
            Dim writer As PdfWriter = PdfWriter.GetInstance(document, New FileStream(filePath, FileMode.Create))
            ' Membuka dokumen
            document.Open()


            ' Membuat teks judul
            Dim title As New Paragraph()
            title.Alignment = Element.ALIGN_CENTER

            ' Menambahkan judul "Laporan Penjualan"
            Dim judul As New Chunk("Maulana Motor Services")
            Dim fontJudul As BaseFont = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.NOT_EMBEDDED)
            judul.Font = New iTextSharp.text.Font(fontJudul, 14, Font.Bold)
            title.Add(judul)

            title.Add(New Paragraph(""))

            ' Menambahkan teks "Maulana Motor Services" di bawah judul
            Dim subJudul As New Paragraph("Laporan Penjualan " & cbBulan.Text & " " & cbTahun.Text)
            subJudul.Font = New iTextSharp.text.Font(fontJudul, 12)
            subJudul.Alignment = Element.ALIGN_CENTER
            title.Add(subJudul)

            ' Menambahkan judul ke dokumen
            document.Add(title)


            ' Spasi antara judul dan tabel
            For i As Integer = 1 To 6 ' Anda dapat menyesuaikan jumlah paragraf sesuai kebutuhan
                Dim spaceParagraph As New Paragraph("")
                spaceParagraph.SpacingBefore = 7 ' Menambahkan spasi sebelum paragraf sebesar 10 poin
                document.Add(spaceParagraph)
            Next


            ' Membuat tabel PDF dengan jumlah kolom yang sama dengan DataGridView
            Dim pdfTable As New PdfPTable(DataGridView1.Columns.Count)

            pdfTable.WidthPercentage = 110

            ' Menambahkan header tabel dari DataGridView
            For Each column As DataGridViewColumn In DataGridView1.Columns
                Dim cell As New PdfPCell(New Phrase(column.HeaderText))
                cell.HorizontalAlignment = PdfPCell.ALIGN_CENTER ' Menyelaraskan teks header ke tengah
                cell.Phrase.Font.Size = 9
                pdfTable.AddCell(cell)
            Next

            ' Menambahkan data dari DataGridView ke dalam tabel PDF
            For Each row As DataGridViewRow In DataGridView1.Rows
                For Each cell As DataGridViewCell In row.Cells
                    If cell.Value IsNot Nothing Then
                        Dim cellText As New PdfPCell(New Phrase(cell.Value.ToString()))
                        cellText.HorizontalAlignment = PdfPCell.ALIGN_CENTER ' Menyelaraskan data ke tengah
                        cellText.Phrase.Font.Size = 9 ' Menetapkan ukuran font
                        pdfTable.AddCell(cellText)
                    Else
                        pdfTable.AddCell("")
                    End If
                Next
            Next

            ' Menambahkan tabel PDF ke dalam dokumen
            document.Add(pdfTable)

            MessageBox.Show("PDF Laporan Penjualan telah didownload.")
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            ' Menutup dokumen
            If document IsNot Nothing Then
                document.Close()
            End If
        End Try
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim i As Integer
        For i = Year(Now) To 2010 Step -1
            cbTahun.Items.Add(i)
        Next
    End Sub
End Class