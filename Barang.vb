Imports System.Data.OleDb
Imports System.Data
Imports System.Data.Odbc
Public Class Barang
    Sub Data_Barang()
        Try
            LOKASI = KONEKSI
            CNN = New OleDbConnection(LOKASI)
            If CNN.State = ConnectionState.Closed Then CNN.Open()
            da = New OleDbDataAdapter("Select * from Tbl_Barang ", CNN)
            ds = New DataSet
            ds.Clear()
            da.Fill(ds, "Data_Barang")
            DataGridView1.DataSource = (ds.Tables("Data_Barang"))
            DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Catch myerror As OleDbException
            MessageBox.Show("Error:", myerror.Message)
        End Try
    End Sub
    'Private Sub btnInput_Click(sender As Object, e As EventArgs)
    '    If txtKdBrg.Text = "" Or txtNmBrg.Text = "" Or txtHrgBrg.Text = "" Then
    '        MsgBox("Harap mengisi seluruh data barang!", vbOKOnly + MsgBoxStyle.Exclamation)
    '    Else
    '        Call KoneksiUser()
    '        OLECMD = New OleDbCommand("Select * from Tbl_Barang where Kd_Barang = '" & txtKdBrg.Text & "'", CNN)
    '        dread = OLECMD.ExecuteReader
    '        dread.Read()
    '        If dread.HasRows Then
    '            MsgBox("Kode barang sudah ada!", MsgBoxStyle.Exclamation)
    '        Else
    '            Try
    '                CNN = New OleDbConnection(KONEKSI)
    '                If CNN.State <> ConnectionState.Closed Then CNN.Close()
    '                CNN.Open()
    '                OLECMD = New OleDbCommand("insert into Tbl_Barang (Kd_Barang, Nama_Barang, Harga_Barang, Stok_Barang) values('" & txtKdBrg.Text & "','" & txtNmBrg.Text & "','" & txtHrgBrg.Text & "', '" & NumericUpDown1.Value & "')", CNN)
    '                X = OLECMD.ExecuteNonQuery
    '                If X = 1 Then
    '                    MsgBox("Data berhasil diinput", vbOKOnly + MsgBoxStyle.Information)
    '                    ClearTextBoxInBox(GroupBox1)
    '                    NumericUpDown1.Text = "0"
    '                Else
    '                    MsgBox("Data gagal diinput", vbOKOnly + MsgBoxStyle.Exclamation)
    '                End If
    '                DataGridView1.Refresh()
    '                Call Data_Barang()
    '                CNN.Close()
    '            Catch myerror As OleDbException
    '                MessageBox.Show("Error:", myerror.Message)
    '            End Try
    '        End If
    '    End If
    'End Sub

    Private Sub Barang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Data_Barang()
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
            OLECMD.CommandText = "DELETE from Tbl_Barang where Kd_Barang ='" & Me.DataGridView1.CurrentRow.Cells(0).Value & "'"
            OLECMD.ExecuteNonQuery()
        Finally
            CNN.Close()
            MsgBox("Data berhasil dihapus", vbOKOnly + MsgBoxStyle.Information)
        End Try
        Me.DataGridView1.Rows.Remove(Me.DataGridView1.CurrentRow)
        Call Data_Barang()
        'ClearTextBoxInBox(GroupBox1)
        'NumericUpDown1.Text = "0"
    End Sub

    Private Sub btnKmbl_Click(sender As Object, e As EventArgs) Handles btnKmbl.Click
        Dashboard.Show()
        Me.Hide()
    End Sub

    Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click 'mencari data berdasarkan textbox pencarian
        Call KoneksiUser()
        OLECMD = New OleDbCommand("select *from Tbl_Barang where (Kd_Barang like '%" & txtCari.Text & "%') or (Nama_Barang like '%" & txtCari.Text & "%')", CNN)
        dread = OLECMD.ExecuteReader
        dread.Read()
        If dread.HasRows Then
            Call KoneksiUser()
            da = New OleDbDataAdapter("select *from Tbl_Barang where (Kd_Barang like '%" & txtCari.Text & "%') or (Nama_Barang like '%" & txtCari.Text & "%')", CNN)
            ds = New DataSet
            da.Fill(ds, "Ditemukan")
            DataGridView1.DataSource = ds.Tables("Ditemukan")
            DataGridView1.ReadOnly = True
        Else
            MsgBox("Data tidak ditemukan", MsgBoxStyle.Exclamation)
            Call Data_Barang()
        End If
    End Sub

    Private Sub BtnEdt_Click(sender As Object, e As EventArgs) Handles BtnEdt.Click
        EditBarang.Show()
        EditBarang.Data_Barang()
        Me.Hide()
    End Sub

    Private Sub BtnSls_Click(sender As Object, e As EventArgs) Handles BtnSls.Click
        LaporanSelisih.Show()
        Me.Hide()
    End Sub
End Class