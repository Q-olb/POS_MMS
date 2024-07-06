<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pembelian
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
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.btnKmbl = New System.Windows.Forms.Button()
        Me.btnHps = New System.Windows.Forms.Button()
        Me.btnInput = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CheckSupp = New System.Windows.Forms.Button()
        Me.CheckBrg = New System.Windows.Forms.Button()
        Me.txtNmSupp = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtKdSupp = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtHrgJual = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtHrgBeli = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNmBrg = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtKdBrg = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtKdBeli = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(30, 14)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(137, 16)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "DATA PEMBELIAN"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(33, 252)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(796, 202)
        Me.TabControl1.TabIndex = 19
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.DataGridView1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(788, 176)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Data Pembelian"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.DarkSlateGray
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(788, 176)
        Me.DataGridView1.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.DataGridView2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(788, 176)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Data Barang"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'DataGridView2
        '
        Me.DataGridView2.BackgroundColor = System.Drawing.Color.DarkSlateGray
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(788, 176)
        Me.DataGridView2.TabIndex = 13
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.DataGridView3)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(788, 176)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Data Supplier"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'DataGridView3
        '
        Me.DataGridView3.BackgroundColor = System.Drawing.Color.DarkSlateGray
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.Size = New System.Drawing.Size(788, 176)
        Me.DataGridView3.TabIndex = 22
        '
        'btnKmbl
        '
        Me.btnKmbl.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnKmbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnKmbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKmbl.ForeColor = System.Drawing.Color.LightCyan
        Me.btnKmbl.Location = New System.Drawing.Point(706, 169)
        Me.btnKmbl.Name = "btnKmbl"
        Me.btnKmbl.Size = New System.Drawing.Size(123, 31)
        Me.btnKmbl.TabIndex = 18
        Me.btnKmbl.Text = "KEMBALI"
        Me.btnKmbl.UseVisualStyleBackColor = False
        '
        'btnHps
        '
        Me.btnHps.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnHps.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHps.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHps.ForeColor = System.Drawing.Color.LightCyan
        Me.btnHps.Location = New System.Drawing.Point(706, 130)
        Me.btnHps.Name = "btnHps"
        Me.btnHps.Size = New System.Drawing.Size(123, 33)
        Me.btnHps.TabIndex = 17
        Me.btnHps.Text = "HAPUS DATA"
        Me.btnHps.UseVisualStyleBackColor = False
        '
        'btnInput
        '
        Me.btnInput.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnInput.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInput.ForeColor = System.Drawing.Color.LightCyan
        Me.btnInput.Location = New System.Drawing.Point(706, 92)
        Me.btnInput.Name = "btnInput"
        Me.btnInput.Size = New System.Drawing.Size(123, 33)
        Me.btnInput.TabIndex = 16
        Me.btnInput.Text = "INPUT DATA"
        Me.btnInput.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.DarkSlateGray
        Me.GroupBox1.Controls.Add(Me.CheckSupp)
        Me.GroupBox1.Controls.Add(Me.CheckBrg)
        Me.GroupBox1.Controls.Add(Me.txtNmSupp)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtKdSupp)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtHrgJual)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.NumericUpDown1)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtHrgBeli)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtNmBrg)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtKdBrg)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtKdBeli)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.LightCyan
        Me.GroupBox1.Location = New System.Drawing.Point(33, 46)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(653, 192)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "INPUT DATA"
        '
        'CheckSupp
        '
        Me.CheckSupp.BackColor = System.Drawing.Color.LightCyan
        Me.CheckSupp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CheckSupp.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.CheckSupp.Location = New System.Drawing.Point(550, 121)
        Me.CheckSupp.Name = "CheckSupp"
        Me.CheckSupp.Size = New System.Drawing.Size(75, 23)
        Me.CheckSupp.TabIndex = 23
        Me.CheckSupp.Text = "Check"
        Me.CheckSupp.UseVisualStyleBackColor = False
        '
        'CheckBrg
        '
        Me.CheckBrg.BackColor = System.Drawing.Color.LightCyan
        Me.CheckBrg.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CheckBrg.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.CheckBrg.Location = New System.Drawing.Point(234, 92)
        Me.CheckBrg.Name = "CheckBrg"
        Me.CheckBrg.Size = New System.Drawing.Size(75, 23)
        Me.CheckBrg.TabIndex = 22
        Me.CheckBrg.Text = "Check"
        Me.CheckBrg.UseVisualStyleBackColor = False
        '
        'txtNmSupp
        '
        Me.txtNmSupp.BackColor = System.Drawing.Color.White
        Me.txtNmSupp.Enabled = False
        Me.txtNmSupp.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.txtNmSupp.Location = New System.Drawing.Point(440, 153)
        Me.txtNmSupp.Name = "txtNmSupp"
        Me.txtNmSupp.ReadOnly = True
        Me.txtNmSupp.Size = New System.Drawing.Size(185, 20)
        Me.txtNmSupp.TabIndex = 11
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(345, 156)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(89, 13)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Nama Supplier"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(20, 66)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(53, 13)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Tanggal"
        '
        'txtKdSupp
        '
        Me.txtKdSupp.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.txtKdSupp.Location = New System.Drawing.Point(440, 123)
        Me.txtKdSupp.Name = "txtKdSupp"
        Me.txtKdSupp.Size = New System.Drawing.Size(104, 20)
        Me.txtKdSupp.TabIndex = 8
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(345, 126)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(86, 13)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Kode Supplier"
        '
        'txtHrgJual
        '
        Me.txtHrgJual.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.txtHrgJual.Location = New System.Drawing.Point(440, 63)
        Me.txtHrgJual.Name = "txtHrgJual"
        Me.txtHrgJual.Size = New System.Drawing.Size(185, 20)
        Me.txtHrgJual.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(345, 97)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Jumlah"
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.NumericUpDown1.Location = New System.Drawing.Point(440, 92)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(185, 20)
        Me.NumericUpDown1.TabIndex = 4
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CalendarForeColor = System.Drawing.Color.DarkSlateGray
        Me.DateTimePicker1.CalendarTitleForeColor = System.Drawing.Color.DarkSlateGray
        Me.DateTimePicker1.Location = New System.Drawing.Point(124, 64)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(185, 20)
        Me.DateTimePicker1.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(345, 66)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Harga Jual"
        '
        'txtHrgBeli
        '
        Me.txtHrgBeli.BackColor = System.Drawing.SystemColors.Window
        Me.txtHrgBeli.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.txtHrgBeli.Location = New System.Drawing.Point(440, 33)
        Me.txtHrgBeli.Name = "txtHrgBeli"
        Me.txtHrgBeli.Size = New System.Drawing.Size(185, 20)
        Me.txtHrgBeli.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(345, 36)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Harga Beli"
        '
        'txtNmBrg
        '
        Me.txtNmBrg.BackColor = System.Drawing.SystemColors.Window
        Me.txtNmBrg.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.txtNmBrg.Location = New System.Drawing.Point(124, 123)
        Me.txtNmBrg.Name = "txtNmBrg"
        Me.txtNmBrg.Size = New System.Drawing.Size(185, 20)
        Me.txtNmBrg.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 126)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nama Barang"
        '
        'txtKdBrg
        '
        Me.txtKdBrg.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.txtKdBrg.Location = New System.Drawing.Point(124, 94)
        Me.txtKdBrg.Name = "txtKdBrg"
        Me.txtKdBrg.Size = New System.Drawing.Size(104, 20)
        Me.txtKdBrg.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Kode Barang"
        '
        'txtKdBeli
        '
        Me.txtKdBeli.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.txtKdBeli.Location = New System.Drawing.Point(124, 33)
        Me.txtKdBeli.Name = "txtKdBeli"
        Me.txtKdBeli.Size = New System.Drawing.Size(185, 20)
        Me.txtKdBeli.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kode Pembelian"
        '
        'Pembelian
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightCyan
        Me.ClientSize = New System.Drawing.Size(859, 464)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.btnKmbl)
        Me.Controls.Add(Me.btnHps)
        Me.Controls.Add(Me.btnInput)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Pembelian"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pembelian"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label9 As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents btnKmbl As Button
    Friend WithEvents btnHps As Button
    Friend WithEvents btnInput As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtKdSupp As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtHrgJual As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents txtHrgBeli As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtNmBrg As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtKdBrg As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtKdBeli As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView3 As DataGridView
    Friend WithEvents txtNmSupp As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents CheckBrg As Button
    Friend WithEvents CheckSupp As Button
End Class
