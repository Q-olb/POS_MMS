﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Supplier
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnKmbl = New System.Windows.Forms.Button()
        Me.btnHps = New System.Windows.Forms.Button()
        Me.btnInput = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rtxCP = New System.Windows.Forms.RichTextBox()
        Me.rtxAlamat = New System.Windows.Forms.RichTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtNoHP = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNmSupp = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtKdSupp = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.DarkSlateGray
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(17, 237)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(796, 174)
        Me.DataGridView1.TabIndex = 22
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(14, 21)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(127, 16)
        Me.Label9.TabIndex = 27
        Me.Label9.Text = "DATA SUPPLIER"
        '
        'btnKmbl
        '
        Me.btnKmbl.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnKmbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnKmbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKmbl.ForeColor = System.Drawing.Color.LightCyan
        Me.btnKmbl.Location = New System.Drawing.Point(690, 158)
        Me.btnKmbl.Name = "btnKmbl"
        Me.btnKmbl.Size = New System.Drawing.Size(123, 31)
        Me.btnKmbl.TabIndex = 26
        Me.btnKmbl.Text = "KEMBALI"
        Me.btnKmbl.UseVisualStyleBackColor = False
        '
        'btnHps
        '
        Me.btnHps.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnHps.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHps.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHps.ForeColor = System.Drawing.Color.LightCyan
        Me.btnHps.Location = New System.Drawing.Point(690, 119)
        Me.btnHps.Name = "btnHps"
        Me.btnHps.Size = New System.Drawing.Size(123, 33)
        Me.btnHps.TabIndex = 25
        Me.btnHps.Text = "HAPUS DATA"
        Me.btnHps.UseVisualStyleBackColor = False
        '
        'btnInput
        '
        Me.btnInput.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnInput.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInput.ForeColor = System.Drawing.Color.LightCyan
        Me.btnInput.Location = New System.Drawing.Point(690, 81)
        Me.btnInput.Name = "btnInput"
        Me.btnInput.Size = New System.Drawing.Size(123, 33)
        Me.btnInput.TabIndex = 24
        Me.btnInput.Text = "INPUT DATA"
        Me.btnInput.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.DarkSlateGray
        Me.GroupBox1.Controls.Add(Me.rtxCP)
        Me.GroupBox1.Controls.Add(Me.rtxAlamat)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtNoHP)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtNmSupp)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtKdSupp)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.LightCyan
        Me.GroupBox1.Location = New System.Drawing.Point(17, 53)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(653, 158)
        Me.GroupBox1.TabIndex = 23
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "INPUT DATA"
        '
        'rtxCP
        '
        Me.rtxCP.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.rtxCP.Location = New System.Drawing.Point(440, 66)
        Me.rtxCP.Name = "rtxCP"
        Me.rtxCP.Size = New System.Drawing.Size(185, 43)
        Me.rtxCP.TabIndex = 23
        Me.rtxCP.Text = ""
        '
        'rtxAlamat
        '
        Me.rtxAlamat.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.rtxAlamat.Location = New System.Drawing.Point(132, 100)
        Me.rtxAlamat.Name = "rtxAlamat"
        Me.rtxAlamat.Size = New System.Drawing.Size(185, 43)
        Me.rtxAlamat.TabIndex = 22
        Me.rtxAlamat.Text = ""
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(339, 66)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Contact Person"
        '
        'txtNoHP
        '
        Me.txtNoHP.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.txtNoHP.Location = New System.Drawing.Point(440, 33)
        Me.txtNoHP.Name = "txtNoHP"
        Me.txtNoHP.Size = New System.Drawing.Size(185, 20)
        Me.txtNoHP.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(339, 36)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Nomor HP"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 103)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Alamat"
        '
        'txtNmSupp
        '
        Me.txtNmSupp.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.txtNmSupp.Location = New System.Drawing.Point(132, 66)
        Me.txtNmSupp.Name = "txtNmSupp"
        Me.txtNmSupp.Size = New System.Drawing.Size(185, 20)
        Me.txtNmSupp.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nama Supplier"
        '
        'txtKdSupp
        '
        Me.txtKdSupp.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.txtKdSupp.Location = New System.Drawing.Point(132, 33)
        Me.txtKdSupp.Name = "txtKdSupp"
        Me.txtKdSupp.Size = New System.Drawing.Size(185, 20)
        Me.txtKdSupp.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kode Supplier"
        '
        'Supplier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightCyan
        Me.ClientSize = New System.Drawing.Size(840, 432)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btnKmbl)
        Me.Controls.Add(Me.btnHps)
        Me.Controls.Add(Me.btnInput)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Supplier"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Supplier"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label9 As Label
    Friend WithEvents btnKmbl As Button
    Friend WithEvents btnHps As Button
    Friend WithEvents btnInput As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rtxCP As RichTextBox
    Friend WithEvents rtxAlamat As RichTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtNoHP As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNmSupp As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtKdSupp As TextBox
    Friend WithEvents Label1 As Label
End Class
