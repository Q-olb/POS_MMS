Imports System.Data.OleDb
Imports System.Data
Imports System.Data.Odbc
Public Class Akun

    Sub Data_Login() 'menampilkan data yg ada di dalam database ke bentuk tabel atau datagridview
        Try
            LOKASI = KONEKSI
            CNN = New OleDbConnection(LOKASI)
            If CNN.State = ConnectionState.Closed Then CNN.Open()
            da = New OleDbDataAdapter("Select * from Tbl_Login", CNN)
            ds = New DataSet
            ds.Clear()
            da.Fill(ds, "Data_Login")
            DataGridView1.DataSource = (ds.Tables("Data_Login"))
        Catch myerror As OleDbException
            MessageBox.Show("Error:", myerror.Message)
        End Try
    End Sub
    Private Sub btnInput_Click(sender As Object, e As EventArgs) Handles btnInput.Click 'menginput data ke dalam database
        If txtUser.Text = "" Or txtPass.Text = "" Then ''validasi textbox harus terisi
            MsgBox("Harap mengisi seluruh data akun!", vbOKOnly + MsgBoxStyle.Exclamation)
        Else
            Call KoneksiUser()
            OLECMD = New OleDbCommand("Select * from Tbl_Login where Username = '" & txtUser.Text & "'", CNN) 'mengecek username
            dread = OLECMD.ExecuteReader
            dread.Read()
            If dread.HasRows Then
                MsgBox("Username sudah ada!", MsgBoxStyle.Exclamation)
            Else
                CNN = New OleDbConnection(KONEKSI)
                If CNN.State <> ConnectionState.Closed Then CNN.Close()
                CNN.Open()
                OLECMD = New OleDbCommand("insert into Tbl_Login ([Username], [Password])  values('" & txtUser.Text & "', '" & txtPass.Text & "')", CNN) 'menginput pengisian ke dalam database
                X = OLECMD.ExecuteNonQuery
                If X = 1 Then
                    MsgBox("Data berhasil diinput", vbOKOnly + MsgBoxStyle.Information)
                    ClearTextBoxInBox(GroupBox1) 'menghapus textbox yang ada di dalam groupbox
                Else
                    MsgBox("Data gagal diinput", vbOKOnly + MsgBoxStyle.Exclamation)
                End If
                DataGridView1.Refresh()
                Call Data_Login() 'memanggil sub codingan data login untuk menampilkan ulang data
                CNN.Close()
            End If
        End If
    End Sub

    Private Sub Akun_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Data_Login()
        DataGridView1.Refresh()
    End Sub

    Private Sub btnHps_Click(sender As Object, e As EventArgs) Handles btnHps.Click 'menghapus data yang ada di dalam database
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
            OLECMD.CommandText = "DELETE from Tbl_Login where Username ='" & Me.DataGridView1.CurrentRow.Cells(0).Value & "'" 'menghapus data dengan acuan Username yang berada di kolom pertama
            OLECMD.ExecuteNonQuery()
        Finally
            CNN.Close()
            MsgBox("Data berhasil dihapus", vbOKOnly + MsgBoxStyle.Information)
        End Try
        Me.DataGridView1.Rows.Remove(Me.DataGridView1.CurrentRow)
        Call Data_Login()
        ClearTextBoxInBox(GroupBox1)
    End Sub

    Private Sub btnKmbl_Click(sender As Object, e As EventArgs) Handles btnKmbl.Click
        Dashboard.Show() 'menampilkan form lain
        Me.Hide() 'menyembunyikan form sendiri
    End Sub
End Class