Imports System.Data.OleDb
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar
Imports Org.BouncyCastle.Asn1.X500

Public Class EditBarang
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
            DataGridView1.AllowUserToAddRows = False
        Catch myerror As OleDbException
            MessageBox.Show("Error:", myerror.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Barang.Show()
        Me.Hide()
        DataGridView1.Refresh()

    End Sub

    Private Sub BtnEdt_Click(sender As Object, e As EventArgs) Handles BtnEdt.Click
        Call KoneksiUser()
        CNN = New OleDbConnection(KONEKSI)
        If CNN.State <> ConnectionState.Closed Then CNN.Close()
        CNN.Open()

        If txtKdBrg.Text = "" Or txtNmBrg.Text = "" Or txtHrgJual.Text = "" Or NumericUpDown1.Value = "0" Then
            MsgBox("Harap mengisi seluruh data!", vbOKOnly + MsgBoxStyle.Exclamation)
        Else

            ' Start a new transaction
            Dim trans As OleDbTransaction = CNN.BeginTransaction()

            'Check kode barang, jika ada maka update jumlah barang. Jika tidak ada maka gagal
            OLECMD = New OleDbCommand("Select * from Tbl_Barang where Kd_Barang = '" & txtKdBrg.Text & "'", CNN) With {
                .Transaction = trans
            }
            dread = OLECMD.ExecuteReader
            dread.Read()
            If dread.HasRows Then
                OLECMD = New OleDbCommand("Update Tbl_Barang set Nama_Barang = '" & txtNmBrg.Text & "', Harga_Barang = '" & txtHrgJual.Text & "', Stok_Barang = '" & NumericUpDown1.Value & "' where Kd_Barang = '" & txtKdBrg.Text & "'", CNN) With {
                .Transaction = trans
                }
                X = OLECMD.ExecuteNonQuery
            Else
                MsgBox("Kode barang tidak ditemukan. Silahkan menambahkan barang terlebih dahulu!", vbOKOnly + MsgBoxStyle.Exclamation)
                ClearTextBoxInBox(GroupBox1)
                NumericUpDown1.Value = "0"
                DataGridView1.Refresh()
                Return
            End If

            ' If no exceptions were thrown, commit the transaction
            trans.Commit()

            If X = 1 Then
                MsgBox("Data berhasil diupdate!", vbOKOnly + MsgBoxStyle.Information)
                ClearTextBoxInBox(GroupBox1)
                NumericUpDown1.Value = "0"
            Else
                MsgBox("Data gagal diupdate", vbOKOnly + MsgBoxStyle.Exclamation)
            End If
            DataGridView1.Refresh()
            Call Data_Barang()
            CNN.Close()
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
                NumericUpDown1.Value = dread.GetDouble(dread.GetOrdinal("Stok_Barang"))
            Else
                MsgBox("Kode barang tidak ditemukan", vbOKOnly + MsgBoxStyle.Exclamation)
                ClearTextBoxInBox(GroupBox1)
                NumericUpDown1.Value = "0"
                DataGridView1.Refresh()
                Return
            End If
        End If
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        txtKdBrg.Text = Me.DataGridView1.CurrentRow.Cells(0).Value
        txtNmBrg.Text = Me.DataGridView1.CurrentRow.Cells(1).Value
        txtHrgJual.Text = Me.DataGridView1.CurrentRow.Cells(2).Value
        NumericUpDown1.Value = Me.DataGridView1.CurrentRow.Cells(3).Value
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
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
            NumericUpDown1.Value = dread.GetDouble(dread.GetOrdinal("Stok_Barang"))
        Else
            MsgBox("Kode barang tidak ditemukan", vbOKOnly + MsgBoxStyle.Exclamation)
            ClearTextBoxInBox(GroupBox1)
            NumericUpDown1.Value = "0"
            DataGridView1.Refresh()
            Return
        End If
    End Sub
End Class