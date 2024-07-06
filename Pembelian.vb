Imports System.Data.OleDb
Imports System.Data
Imports System.Data.Odbc
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar
Public Class Pembelian
    Sub Data_Pembelian()
        Try
            LOKASI = KONEKSI
            CNN = New OleDbConnection(LOKASI)
            If CNN.State = ConnectionState.Closed Then CNN.Open()
            da = New OleDbDataAdapter("Select * from Tbl_Pembelian ", CNN)
            ds = New DataSet
            ds.Clear()
            da.Fill(ds, "Data_Pembelian")
            DataGridView1.DataSource = (ds.Tables("Data_Pembelian"))
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
    Sub Data_Supplier()
        Try
            LOKASI = KONEKSI
            CNN = New OleDbConnection(LOKASI)
            If CNN.State = ConnectionState.Closed Then CNN.Open()
            da = New OleDbDataAdapter("Select * from Tbl_Supplier ", CNN)
            ds = New DataSet
            ds.Clear()
            da.Fill(ds, "Data_Supplier")
            DataGridView3.DataSource = (ds.Tables("Data_Supplier"))
        Catch myerror As OleDbException
            MessageBox.Show("Error:", myerror.Message)
        End Try
    End Sub
    Private Sub btnInput_Click(sender As Object, e As EventArgs) Handles btnInput.Click
        'Chek kode supplier jika tidak ditemukan maka return error
        OLECMD = New OleDbCommand("Select * from Tbl_Supplier where Kd_Supplier = '" & txtKdSupp.Text & "'", CNN)
        dread = OLECMD.ExecuteReader
        dread.Read()
        If Not dread.HasRows Then
            MsgBox("Kode supplier tidak ditemukan. Silahkan menambahkan supplier terlebih dahulu!", vbOKOnly + MsgBoxStyle.Exclamation)
            ClearTextBoxInBox(GroupBox1)
            NumericUpDown1.Value = "0"
            DataGridView1.Refresh()
            Return
        End If

        If txtKdBeli.Text = "" Or txtKdBrg.Text = "" Or txtNmBrg.Text = "" Or txtHrgBeli.Text = "" Or txtHrgJual.Text = "" Or NumericUpDown1.Value = "0" Or txtKdSupp.Text = "" Or txtNmSupp.Text = "" Then
            MsgBox("Harap mengisi seluruh data pembelian!", vbOKOnly + MsgBoxStyle.Exclamation)
        Else
            Call KoneksiUser()
            OLECMD = New OleDbCommand("Select * from Tbl_Pembelian where Kd_Pembelian = '" & txtKdBeli.Text & "'", CNN)
            dread = OLECMD.ExecuteReader
            dread.Read()
            If dread.HasRows Then
                MsgBox("Kode pembelian sudah ada!", MsgBoxStyle.Exclamation)
            Else
                Try
                    CNN = New OleDbConnection(KONEKSI)
                    If CNN.State <> ConnectionState.Closed Then CNN.Close()
                    CNN.Open()

                    ' Start a new transaction
                    Dim trans As OleDbTransaction = CNN.BeginTransaction()

                    'Check kode barang, jika ada maka update jumlah barang. Jika tidak ada maka insert data barang
                    OLECMD = New OleDbCommand("Select * from Tbl_Barang where Kd_Barang = '" & txtKdBrg.Text & "'", CNN) With {
                        .Transaction = trans
                    }

                    dread = OLECMD.ExecuteReader
                    dread.Read()
                    If dread.HasRows Then
                        OLECMD = New OleDbCommand("update Tbl_Barang set Stok_Barang = Stok_Barang + '" & NumericUpDown1.Value & "' where Kd_Barang = '" & txtKdBrg.Text & "'", CNN) With {
                            .Transaction = trans
                        }
                        X = OLECMD.ExecuteNonQuery
                    Else
                        OLECMD = New OleDbCommand("insert into Tbl_Barang (Kd_Barang, Nama_Barang, Harga_Barang, Stok_Barang) values('" & txtKdBrg.Text & "', '" & txtNmBrg.Text & "', '" & txtHrgJual.Text & "', '" & NumericUpDown1.Value & "')", CNN) With {
                            .Transaction = trans
                        }
                        X = OLECMD.ExecuteNonQuery
                    End If

                    OLECMD = New OleDbCommand("insert into Tbl_Pembelian (Kd_Pembelian, Tgl_Pembelian, Kd_Barang, Nama_Barang, Harga_Beli, Harga_Jual, Jumlah, Kd_Supplier, Nama_Supplier) 
                    values('" & txtKdBeli.Text & "','" & DateTimePicker1.Value & "','" & txtKdBrg.Text & "', '" & txtNmBrg.Text & "', '" & txtHrgBeli.Text & "','" & txtHrgJual.Text & "', '" & NumericUpDown1.Value & "', '" & txtKdSupp.Text & "', '" & txtNmSupp.Text & "')", CNN) With {
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
                    Call Data_Pembelian()
                    Call Data_Barang()
                    CNN.Close()
                Catch myerror As OleDbException
                    MessageBox.Show($"Error: {myerror.Message}", "ERROR!!")
                End Try
            End If
        End If
    End Sub

    Private Sub Pembelian_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Data_Pembelian()
        Call Data_Barang()
        Call Data_Supplier()
        DataGridView1.Refresh()
        DataGridView2.Refresh()
        DataGridView3.Refresh()
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
            OLECMD.CommandText = "DELETE from Tbl_Pembelian where Kd_Pembelian ='" & Me.DataGridView1.CurrentRow.Cells(0).Value & "'"
            OLECMD.ExecuteNonQuery()
        Finally
            CNN.Close()
            MsgBox("Data berhasil dihapus", vbOKOnly + MsgBoxStyle.Information)
        End Try
        Me.DataGridView1.Rows.Remove(Me.DataGridView1.CurrentRow)
        Call Data_Pembelian()
        ClearTextBoxInBox(GroupBox1)
        NumericUpDown1.Text = "0"
    End Sub

    Private Sub btnKmbl_Click(sender As Object, e As EventArgs) Handles btnKmbl.Click
        Dashboard.Show()
        Me.Hide()

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
                MsgBox("Kode barang ditemukan. Jumlah barang yang diinput akan ditambahkan ke gudang", vbOKOnly + MsgBoxStyle.Information)
                txtNmBrg.ReadOnly = True
                txtHrgBeli.ReadOnly = True
                txtNmBrg.BackColor = Color.LightGray
                txtHrgBeli.BackColor = Color.LightGray

                txtNmBrg.Text = dread.Item("Nama_Barang")
                txtHrgBeli.Text = dread.Item("Harga_Barang")
            Else
                MsgBox("Kode barang tidak ditemukan. Silahkan menambahkan detail barang", vbOKOnly + MsgBoxStyle.Information)
                txtNmBrg.ReadOnly = False
                txtHrgBeli.ReadOnly = False
                txtNmBrg.BackColor = Color.White
                txtHrgBeli.BackColor = Color.White

                txtNmBrg.Text = ""
                txtHrgBeli.Text = ""
            End If
        Catch myerror As OleDbException
            MessageBox.Show("Error:", myerror.Message)
        End Try
    End Sub

    Private Sub CheckSupp_Click(sender As Object, e As EventArgs) Handles CheckSupp.Click
        Dim kodeSupplier
        kodeSupplier = txtKdSupp.Text
        Try
            LOKASI = KONEKSI
            CNN = New OleDbConnection(LOKASI)
            If CNN.State = ConnectionState.Closed Then CNN.Open()
            OLECMD = New OleDbCommand("Select * from Tbl_Supplier where Kd_Supplier = '" & kodeSupplier & "'", CNN)
            dread = OLECMD.ExecuteReader
            dread.Read()
            If dread.HasRows Then
                txtNmSupp.Text = dread.Item("Nama_Supplier")
            Else
                MsgBox("Kode supplier tidak ditemukan. Silahkan menambahkan supplier terlebih dahulu!", vbOKOnly + MsgBoxStyle.Exclamation)
            End If
        Catch myerror As OleDbException
            MessageBox.Show("Error:", myerror.Message)
        End Try
    End Sub
End Class