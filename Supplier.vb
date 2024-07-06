Imports System.Data.OleDb
Imports System.Data
Imports System.Data.Odbc
Public Class Supplier
    Sub Data_Supplier()
        Try
            LOKASI = KONEKSI
            CNN = New OleDbConnection(LOKASI)
            If CNN.State = ConnectionState.Closed Then CNN.Open()
            da = New OleDbDataAdapter("Select * from Tbl_Supplier ", CNN)
            ds = New DataSet
            ds.Clear()
            da.Fill(ds, "Data_Supplier")
            DataGridView1.DataSource = (ds.Tables("Data_Supplier"))
        Catch myerror As OleDbException
            MessageBox.Show("Error:", myerror.Message)
        End Try
    End Sub
    Private Sub Supplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Data_Supplier()
        DataGridView1.Refresh()
    End Sub

    Private Sub btnInput_Click(sender As Object, e As EventArgs) Handles btnInput.Click
        If txtKdSupp.Text = "" Or txtNmSupp.Text = "" Or txtNoHP.Text = "" Or rtxAlamat.Text = "" Or rtxCP.Text = "" Then
            MsgBox("Harap mengisi seluruh data pelanggan!", vbOKOnly + MsgBoxStyle.Exclamation)
        Else
            Call KoneksiUser()
            OLECMD = New OleDbCommand("Select * from Tbl_Supplier where Kd_Supplier = '" & txtKdSupp.Text & "'", CNN)
            dread = OLECMD.ExecuteReader
            dread.Read()
            If dread.HasRows Then
                MsgBox("Kode pelanggan sudah ada!", MsgBoxStyle.Exclamation)
            Else
                Try
                    CNN = New OleDbConnection(KONEKSI)
                    If CNN.State <> ConnectionState.Closed Then CNN.Close()
                    CNN.Open()
                    OLECMD = New OleDbCommand("insert into Tbl_Supplier (Kd_Supplier, Nama_Supplier, Alamat, No_Tlp, Contact_Person) values('" & txtKdSupp.Text & "','" & txtNmSupp.Text & "','" & rtxAlamat.Text & "', '" & txtNoHP.Text & "', '" & rtxCP.Text & "')", CNN)
                    X = OLECMD.ExecuteNonQuery
                    If X = 1 Then
                        MsgBox("Data berhasil diinput", vbOKOnly + MsgBoxStyle.Information)
                        ClearTextBoxInBox(GroupBox1)
                        rtxAlamat.Text = ""
                        rtxCP.Text = ""
                    Else
                        MsgBox("Data gagal diinput", vbOKOnly + MsgBoxStyle.Exclamation)
                    End If
                    DataGridView1.Refresh()
                    Call Data_Supplier()
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
            OLECMD.CommandText = "DELETE from Tbl_Supplier where Kd_Supplier ='" & Me.DataGridView1.CurrentRow.Cells(0).Value & "'"
            OLECMD.ExecuteNonQuery()
        Finally
            CNN.Close()
            MsgBox("Data berhasil dihapus", vbOKOnly + MsgBoxStyle.Information)
        End Try
        Me.DataGridView1.Rows.Remove(Me.DataGridView1.CurrentRow)
        Call Data_Supplier()
        ClearTextBoxInBox(GroupBox1)
        rtxAlamat.Text = ""
        rtxCP.Text = ""
    End Sub

    Private Sub btnKmbl_Click(sender As Object, e As EventArgs) Handles btnKmbl.Click
        Dashboard.Show()
        Me.Hide()
    End Sub
End Class