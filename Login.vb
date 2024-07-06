Imports System.Data.OleDb
Imports System.Data
Imports System.Data.Odbc
Public Class Login


    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtUser.Text = "" Or txtPass.Text = "" Then
            MsgBox("Data harap diisi!", MsgBoxStyle.Exclamation)
        Else
            Call KoneksiUser()
            OLECMD = New OleDbCommand("select * from Tbl_Login where Username ='" & txtUser.Text & "' and Password = '" & txtPass.Text & "' ", CNN)
            dread = OLECMD.ExecuteReader
            dread.Read()
            If dread.HasRows Then
                MsgBox("Berhasil login", MsgBoxStyle.Information)
                Dashboard.Show()
                Me.Hide()
            End If
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            txtPass.UseSystemPasswordChar = False 'menonaktifkan password char
        Else
            txtPass.UseSystemPasswordChar = True 'mengaktifkan password char
        End If
    End Sub
End Class
