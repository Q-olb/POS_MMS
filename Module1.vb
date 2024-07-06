Imports System.Data.OleDb
Imports System.Data
Imports System.Data.Odbc
Module Module1
    Public ds As DataSet
    Public da As OleDbDataAdapter
    Public OLECMD As OleDbCommand
    Public OLERDR As OleDbDataReader
    Public CNN As OleDbConnection
    Public dread As OleDbDataReader

    'coding untuk mengoneksikan sistem informasi dengan database
    Public KONEKSI As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\Perancangan Penjualan dan Pembelian MMS.accdb;"
    Public X As Integer
    Public LOKASI As String
    Public Sub KoneksiUser()
        LOKASI = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\Perancangan Penjualan dan Pembelian MMS.accdb;"
        CNN = New OleDbConnection(LOKASI)
        If CNN.State = ConnectionState.Closed Then CNN.Open()
    End Sub


    Public Sub ClearTextBoxInBox(ByVal grb As System.Windows.Forms.GroupBox) 'public codingan yg bisa digunakan di semua form untuk menghapus textbox yg ada di dalam groupbox 
        For Each ctl As Control In grb.Controls
            If TypeOf ctl Is TextBox Then
                CType(ctl, TextBox).Text = String.Empty
            End If
        Next
    End Sub

End Module
