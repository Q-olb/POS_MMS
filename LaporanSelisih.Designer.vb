<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LaporanSelisih
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnCheckBrg = New System.Windows.Forms.Button()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.LbTgl = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.CheckSls = New System.Windows.Forms.Button()
        Me.txtHrgJual = New System.Windows.Forms.TextBox()
        Me.txtNmBrg = New System.Windows.Forms.TextBox()
        Me.txtKdBrg = New System.Windows.Forms.TextBox()
        Me.txtKdSls = New System.Windows.Forms.TextBox()
        Me.LbKdSls = New System.Windows.Forms.Label()
        Me.LbBrg = New System.Windows.Forms.Label()
        Me.LbNmBrg = New System.Windows.Forms.Label()
        Me.LbHrgJual = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.BtnInpt = New System.Windows.Forms.Button()
        Me.BtnHps = New System.Windows.Forms.Button()
        Me.BtnKmbl = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCari = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.DarkSlateGray
        Me.GroupBox1.Controls.Add(Me.BtnCheckBrg)
        Me.GroupBox1.Controls.Add(Me.NumericUpDown1)
        Me.GroupBox1.Controls.Add(Me.LbTgl)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.CheckSls)
        Me.GroupBox1.Controls.Add(Me.txtHrgJual)
        Me.GroupBox1.Controls.Add(Me.txtNmBrg)
        Me.GroupBox1.Controls.Add(Me.txtKdBrg)
        Me.GroupBox1.Controls.Add(Me.txtKdSls)
        Me.GroupBox1.Controls.Add(Me.LbKdSls)
        Me.GroupBox1.Controls.Add(Me.LbBrg)
        Me.GroupBox1.Controls.Add(Me.LbNmBrg)
        Me.GroupBox1.Controls.Add(Me.LbHrgJual)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.LightCyan
        Me.GroupBox1.Location = New System.Drawing.Point(12, 51)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(602, 128)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "INPUT DATA"
        '
        'BtnCheckBrg
        '
        Me.BtnCheckBrg.BackColor = System.Drawing.Color.LightCyan
        Me.BtnCheckBrg.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCheckBrg.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.BtnCheckBrg.Location = New System.Drawing.Point(239, 59)
        Me.BtnCheckBrg.Name = "BtnCheckBrg"
        Me.BtnCheckBrg.Size = New System.Drawing.Size(75, 23)
        Me.BtnCheckBrg.TabIndex = 13
        Me.BtnCheckBrg.Text = "Check"
        Me.BtnCheckBrg.UseVisualStyleBackColor = False
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(407, 90)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(173, 20)
        Me.NumericUpDown1.TabIndex = 15
        '
        'LbTgl
        '
        Me.LbTgl.AutoSize = True
        Me.LbTgl.Location = New System.Drawing.Point(38, 93)
        Me.LbTgl.Name = "LbTgl"
        Me.LbTgl.Size = New System.Drawing.Size(53, 13)
        Me.LbTgl.TabIndex = 13
        Me.LbTgl.Text = "Tanggal"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(133, 90)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(181, 20)
        Me.DateTimePicker1.TabIndex = 14
        '
        'CheckSls
        '
        Me.CheckSls.BackColor = System.Drawing.Color.LightCyan
        Me.CheckSls.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CheckSls.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.CheckSls.Location = New System.Drawing.Point(239, 29)
        Me.CheckSls.Name = "CheckSls"
        Me.CheckSls.Size = New System.Drawing.Size(75, 23)
        Me.CheckSls.TabIndex = 8
        Me.CheckSls.Text = "Check"
        Me.CheckSls.UseVisualStyleBackColor = False
        '
        'txtHrgJual
        '
        Me.txtHrgJual.Location = New System.Drawing.Point(407, 59)
        Me.txtHrgJual.Name = "txtHrgJual"
        Me.txtHrgJual.Size = New System.Drawing.Size(173, 20)
        Me.txtHrgJual.TabIndex = 12
        '
        'txtNmBrg
        '
        Me.txtNmBrg.Location = New System.Drawing.Point(407, 29)
        Me.txtNmBrg.Name = "txtNmBrg"
        Me.txtNmBrg.Size = New System.Drawing.Size(173, 20)
        Me.txtNmBrg.TabIndex = 11
        '
        'txtKdBrg
        '
        Me.txtKdBrg.Location = New System.Drawing.Point(133, 61)
        Me.txtKdBrg.Name = "txtKdBrg"
        Me.txtKdBrg.Size = New System.Drawing.Size(100, 20)
        Me.txtKdBrg.TabIndex = 10
        '
        'txtKdSls
        '
        Me.txtKdSls.Location = New System.Drawing.Point(133, 31)
        Me.txtKdSls.Name = "txtKdSls"
        Me.txtKdSls.Size = New System.Drawing.Size(100, 20)
        Me.txtKdSls.TabIndex = 9
        '
        'LbKdSls
        '
        Me.LbKdSls.AutoSize = True
        Me.LbKdSls.Location = New System.Drawing.Point(38, 34)
        Me.LbKdSls.Name = "LbKdSls"
        Me.LbKdSls.Size = New System.Drawing.Size(77, 13)
        Me.LbKdSls.TabIndex = 8
        Me.LbKdSls.Text = "Kode Selisih"
        '
        'LbBrg
        '
        Me.LbBrg.AutoSize = True
        Me.LbBrg.Location = New System.Drawing.Point(38, 64)
        Me.LbBrg.Name = "LbBrg"
        Me.LbBrg.Size = New System.Drawing.Size(80, 13)
        Me.LbBrg.TabIndex = 1
        Me.LbBrg.Text = "Kode Barang"
        '
        'LbNmBrg
        '
        Me.LbNmBrg.AutoSize = True
        Me.LbNmBrg.Location = New System.Drawing.Point(344, 34)
        Me.LbNmBrg.Name = "LbNmBrg"
        Me.LbNmBrg.Size = New System.Drawing.Size(39, 13)
        Me.LbNmBrg.TabIndex = 2
        Me.LbNmBrg.Text = "Nama"
        '
        'LbHrgJual
        '
        Me.LbHrgJual.AutoSize = True
        Me.LbHrgJual.Location = New System.Drawing.Point(344, 64)
        Me.LbHrgJual.Name = "LbHrgJual"
        Me.LbHrgJual.Size = New System.Drawing.Size(41, 13)
        Me.LbHrgJual.TabIndex = 3
        Me.LbHrgJual.Text = "Harga"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(344, 93)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Selisih"
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.DarkSlateGray
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 215)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(739, 200)
        Me.DataGridView1.TabIndex = 8
        '
        'BtnInpt
        '
        Me.BtnInpt.BackColor = System.Drawing.Color.DarkSlateGray
        Me.BtnInpt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnInpt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnInpt.ForeColor = System.Drawing.Color.LightCyan
        Me.BtnInpt.Location = New System.Drawing.Point(631, 67)
        Me.BtnInpt.Name = "BtnInpt"
        Me.BtnInpt.Size = New System.Drawing.Size(119, 27)
        Me.BtnInpt.TabIndex = 9
        Me.BtnInpt.Text = "INPUT"
        Me.BtnInpt.UseVisualStyleBackColor = False
        '
        'BtnHps
        '
        Me.BtnHps.BackColor = System.Drawing.Color.DarkSlateGray
        Me.BtnHps.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnHps.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnHps.ForeColor = System.Drawing.Color.LightCyan
        Me.BtnHps.Location = New System.Drawing.Point(631, 106)
        Me.BtnHps.Name = "BtnHps"
        Me.BtnHps.Size = New System.Drawing.Size(119, 27)
        Me.BtnHps.TabIndex = 10
        Me.BtnHps.Text = "HAPUS"
        Me.BtnHps.UseVisualStyleBackColor = False
        '
        'BtnKmbl
        '
        Me.BtnKmbl.BackColor = System.Drawing.Color.DarkSlateGray
        Me.BtnKmbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnKmbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnKmbl.ForeColor = System.Drawing.Color.LightCyan
        Me.BtnKmbl.Location = New System.Drawing.Point(631, 144)
        Me.BtnKmbl.Name = "BtnKmbl"
        Me.BtnKmbl.Size = New System.Drawing.Size(119, 27)
        Me.BtnKmbl.TabIndex = 11
        Me.BtnKmbl.Text = "KEMBALI"
        Me.BtnKmbl.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 15)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "DATA SELISIH"
        '
        'txtCari
        '
        Me.txtCari.Location = New System.Drawing.Point(12, 189)
        Me.txtCari.Name = "txtCari"
        Me.txtCari.Size = New System.Drawing.Size(132, 20)
        Me.txtCari.TabIndex = 13
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.LightCyan
        Me.Button1.Location = New System.Drawing.Point(150, 187)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(61, 23)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Cari"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'LaporanSelisih
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightCyan
        Me.ClientSize = New System.Drawing.Size(762, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtCari)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnKmbl)
        Me.Controls.Add(Me.BtnHps)
        Me.Controls.Add(Me.BtnInpt)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "LaporanSelisih"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LaporanSelisih"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents LbBrg As Label
    Friend WithEvents LbNmBrg As Label
    Friend WithEvents LbHrgJual As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents LbKdSls As Label
    Friend WithEvents txtKdSls As TextBox
    Friend WithEvents CheckSls As Button
    Friend WithEvents txtHrgJual As TextBox
    Friend WithEvents txtNmBrg As TextBox
    Friend WithEvents txtKdBrg As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BtnInpt As Button
    Friend WithEvents BtnHps As Button
    Friend WithEvents BtnKmbl As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents LbTgl As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents BtnCheckBrg As Button
    Friend WithEvents txtCari As TextBox
    Friend WithEvents Button1 As Button
End Class
