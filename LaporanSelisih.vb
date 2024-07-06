Imports System.Data.OleDb
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar
Imports Org.BouncyCastle.Asn1.X500

Public Class LaporanSelisih
    Sub Data_Selisih()
        Try
            LOKASI = KONEKSI
            CNN = New OleDbConnection(LOKASI)
            If CNN.State = ConnectionState.Closed Then CNN.Open()
            da = New OleDbDataAdapter("Select * from Tbl_Selisih ", CNN)
            ds = New DataSet
            ds.Clear()
            da.Fill(ds, "Data_Selisih")
            DataGridView1.DataSource = (ds.Tables("Data_Selisih"))
            DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Catch myerror As OleDbException
            MessageBox.Show("Error:", myerror.Message)
        End Try
    End Sub

    Private Sub LaporanSelisih_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Data_Selisih()
        txtNmBrg.ReadOnly = True
        txtHrgJual.ReadOnly = True
        DataGridView1.Refresh()
    End Sub

    Private Sub BtnKmbl_Click(sender As Object, e As EventArgs) Handles BtnKmbl.Click
        Barang.Show()
        Me.Hide()
    End Sub

    Private Sub CheckSls_Click(sender As Object, e As EventArgs) Handles CheckSls.Click
        Dim kodeSelisih
        kodeSelisih = txtKdSls.Text
        Try
            LOKASI = KONEKSI
            CNN = New OleDbConnection(LOKASI)
            If CNN.State = ConnectionState.Closed Then CNN.Open()
            OLECMD = New OleDbCommand("Select * from Tbl_Selisih where Kd_Selisih = '" & kodeSelisih & "'", CNN)
            dread = OLECMD.ExecuteReader
            dread.Read()
            If dread.HasRows Then
                MsgBox("Kode selisih telah digunakan. Silahkan masukkan kode lain.", vbOKOnly + MsgBoxStyle.Exclamation)
                txtKdSls.Text = ""
            Else
                MsgBox("Kode selisih belum digunakan. Silahkan lanjutkan proses.", vbOKOnly + MsgBoxStyle.Information)
            End If
        Catch myerror As OleDbException
            MessageBox.Show("Error:", myerror.Message)
        End Try
    End Sub

    Private Sub BtnInpt_Click(sender As Object, e As EventArgs) Handles BtnInpt.Click
        If txtKdSls.Text = "" Or txtKdBrg.Text = "" Or txtNmBrg.Text = "" Or txtHrgJual.Text = "" Or NumericUpDown1.Value = "0" Then
            MsgBox("Harap mengisi seluruh data pembelian!", vbOKOnly + MsgBoxStyle.Exclamation)
        Else
            Call KoneksiUser()
            OLECMD = New OleDbCommand("Select * from Tbl_Selisih where Kd_Selisih = '" & txtKdSls.Text & "'", CNN)
            dread = OLECMD.ExecuteReader
            dread.Read()
            If dread.HasRows Then
                MsgBox("Kode selisih sudah ada!", MsgBoxStyle.Exclamation)
                txtKdSls.Text = ""
            Else
                Try
                    CNN = New OleDbConnection(KONEKSI)
                    If CNN.State <> ConnectionState.Closed Then CNN.Close()
                    CNN.Open()

                    ' Start a new transaction
                    Dim trans As OleDbTransaction = CNN.BeginTransaction()

                    OLECMD = New OleDbCommand("insert into Tbl_Selisih (Kd_Selisih, Tgl_Selisih, Kd_Barang, Nama_Barang, Harga_Barang, Total_Selisih) 
                    values('" & txtKdSls.Text & "','" & DateTimePicker1.Value & "','" & txtKdBrg.Text & "', '" & txtNmBrg.Text & "', '" & txtHrgJual.Text & "', '" & NumericUpDown1.Value & "')", CNN) With {
                        .Transaction = trans
                    }
                    X = OLECMD.ExecuteNonQuery

                    ' If no exceptions were thrown, commit the transaction
                    trans.Commit()

                    If X = 1 Then
                        MsgBox("Data berhasil diinput", vbOKOnly + MsgBoxStyle.Information)
                        ClearTextBoxInBox(GroupBox1)
                        NumericUpDown1.Value = "0"
                    Else
                        MsgBox("Data gagal diinput", vbOKOnly + MsgBoxStyle.Exclamation)
                    End If
                    DataGridView1.Refresh()
                    Call Data_Selisih()
                    CNN.Close()
                Catch myerror As OleDbException
                    MessageBox.Show($"Error: {myerror.Message}", "ERROR!!")
                End Try
            End If
        End If
    End Sub

    Private Sub BtnCheckBrg_Click(sender As Object, e As EventArgs) Handles BtnCheckBrg.Click
        Call KoneksiUser()
        CNN = New OleDbConnection(KONEKSI)
        If CNN.State <> ConnectionState.Closed Then CNN.Close()
        CNN.Open()
        OLECMD = New OleDbCommand("Select * from Tbl_Barang where Kd_Barang = '" & txtKdBrg.Text & "'", CNN)
        OLECMD.ExecuteNonQuery()
        dread = OLECMD.ExecuteReader()
        If dread.Read Then
            txtNmBrg.Text = dread.GetString(dread.GetOrdinal("Nama_Barang"))
            txtHrgJual.Text = dread.GetDouble(dread.GetOrdinal("Harga_Barang"))
        Else
            MsgBox("Kode barang tidak ditemukan", vbOKOnly + MsgBoxStyle.Exclamation)
            txtKdBrg.Text = ""
            DataGridView1.Refresh()
            Return
        End If
    End Sub

    Private Sub BtnHps_Click(sender As Object, e As EventArgs) Handles BtnHps.Click
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
            OLECMD.CommandText = "DELETE from Tbl_Selisih where Kd_Selisih ='" & Me.DataGridView1.CurrentRow.Cells(0).Value & "'"
            OLECMD.ExecuteNonQuery()
        Finally
            CNN.Close()
            MsgBox("Data berhasil dihapus", vbOKOnly + MsgBoxStyle.Information)
        End Try
        Me.DataGridView1.Rows.Remove(Me.DataGridView1.CurrentRow)
        Call Data_Selisih()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call KoneksiUser()
        OLECMD = New OleDbCommand("select *from Tbl_Selisih where (Kd_Selisih like '%" & txtCari.Text & "%') or (Nama_Barang like '%" & txtCari.Text & "%')", CNN)
        dread = OLECMD.ExecuteReader
        dread.Read()
        If dread.HasRows Then
            Call KoneksiUser()
            da = New OleDbDataAdapter("select *from Tbl_Selisih where (Kd_Selisih like '%" & txtCari.Text & "%') or (Nama_Barang like '%" & txtCari.Text & "%')", CNN)
            ds = New DataSet
            da.Fill(ds, "Ditemukan")
            DataGridView1.DataSource = ds.Tables("Ditemukan")
            DataGridView1.ReadOnly = True
        Else
            MsgBox("Data tidak ditemukan", MsgBoxStyle.Exclamation)
            Call Data_Selisih()
        End If
    End Sub

    Private Sub txtKdSls_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtKdSls.KeyPress
        If (e.KeyChar = Convert.ToChar(Keys.Enter)) Then
            Dim kodeSelisih
            kodeSelisih = txtKdSls.Text
            Try
                LOKASI = KONEKSI
                CNN = New OleDbConnection(LOKASI)
                If CNN.State = ConnectionState.Closed Then CNN.Open()
                OLECMD = New OleDbCommand("Select * from Tbl_Selisih where Kd_Selisih = '" & kodeSelisih & "'", CNN)
                dread = OLECMD.ExecuteReader
                dread.Read()
                If dread.HasRows Then
                    MsgBox("Kode selisih telah digunakan. Silahkan masukkan kode lain.", vbOKOnly + MsgBoxStyle.Exclamation)
                    txtKdSls.Text = ""
                Else
                    MsgBox("Kode selisih belum digunakan. Silahkan lanjutkan proses.", vbOKOnly + MsgBoxStyle.Information)
                End If
            Catch myerror As OleDbException
                MessageBox.Show("Error:", myerror.Message)
            End Try
        End If
    End Sub

    Private Sub txtKdBrg_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtKdBrg.KeyPress
        If (e.KeyChar = Convert.ToChar(Keys.Enter)) Then
            Call KoneksiUser()
            CNN = New OleDbConnection(KONEKSI)
            If CNN.State <> ConnectionState.Closed Then CNN.Close()
            CNN.Open()
            OLECMD = New OleDbCommand("Select * from Tbl_Barang where Kd_Barang = '" & txtKdBrg.Text & "'", CNN)
            OLECMD.ExecuteNonQuery()
            dread = OLECMD.ExecuteReader()
            If dread.Read Then
                txtNmBrg.Text = dread.GetString(dread.GetOrdinal("Nama_Barang"))
                txtHrgJual.Text = dread.GetDouble(dread.GetOrdinal("Harga_Barang"))
            Else
                MsgBox("Kode barang tidak ditemukan", vbOKOnly + MsgBoxStyle.Exclamation)
                txtKdBrg.Text = ""
                DataGridView1.Refresh()
                Return
            End If
        End If
    End Sub

    Private Sub txtCari_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCari.KeyPress
        If (e.KeyChar = Convert.ToChar(Keys.Enter)) Then
            Call KoneksiUser()
            OLECMD = New OleDbCommand("select *from Tbl_Selisih where (Kd_Selisih like '%" & txtCari.Text & "%') or (Nama_Barang like '%" & txtCari.Text & "%')", CNN)
            dread = OLECMD.ExecuteReader
            dread.Read()
            If dread.HasRows Then
                Call KoneksiUser()
                da = New OleDbDataAdapter("select *from Tbl_Selisih where (Kd_Selisih like '%" & txtCari.Text & "%') or (Nama_Barang like '%" & txtCari.Text & "%')", CNN)
                ds = New DataSet
                da.Fill(ds, "Ditemukan")
                DataGridView1.DataSource = ds.Tables("Ditemukan")
                DataGridView1.ReadOnly = True
            Else
                MsgBox("Data tidak ditemukan", MsgBoxStyle.Exclamation)
                Call Data_Selisih()
            End If
        End If
    End Sub
End Class