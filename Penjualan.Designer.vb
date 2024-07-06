<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Penjualan
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
        Me.CheckBrg = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtTtlByr = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtTtlHrg = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtHrgBrg = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNmBrg = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtKdBrg = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNoFaktur = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnInput = New System.Windows.Forms.Button()
        Me.btnHps = New System.Windows.Forms.Button()
        Me.btnKmbl = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.txtNmKry = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnCetak = New System.Windows.Forms.Button()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.GroupBox1.SuspendLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.DarkSlateGray
        Me.GroupBox1.Controls.Add(Me.CheckBrg)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtTtlByr)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtTtlHrg)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.NumericUpDown1)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtHrgBrg)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtNmBrg)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtKdBrg)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtNoFaktur)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.LightCyan
        Me.GroupBox1.Location = New System.Drawing.Point(22, 47)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(653, 158)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "INPUT DATA"
        '
        'CheckBrg
        '
        Me.CheckBrg.BackColor = System.Drawing.Color.LightCyan
        Me.CheckBrg.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CheckBrg.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.CheckBrg.Location = New System.Drawing.Point(226, 92)
        Me.CheckBrg.Name = "CheckBrg"
        Me.CheckBrg.Size = New System.Drawing.Size(70, 23)
        Me.CheckBrg.TabIndex = 11
        Me.CheckBrg.Text = "Check"
        Me.CheckBrg.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.LightCyan
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Button1.Location = New System.Drawing.Point(555, 61)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(70, 23)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "TOTAL"
        Me.Button1.UseVisualStyleBackColor = False
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
        'txtTtlByr
        '
        Me.txtTtlByr.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.txtTtlByr.Location = New System.Drawing.Point(440, 123)
        Me.txtTtlByr.Name = "txtTtlByr"
        Me.txtTtlByr.Size = New System.Drawing.Size(185, 20)
        Me.txtTtlByr.TabIndex = 8
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(349, 126)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(73, 13)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Pembulatan"
        '
        'txtTtlHrg
        '
        Me.txtTtlHrg.BackColor = System.Drawing.Color.White
        Me.txtTtlHrg.Enabled = False
        Me.txtTtlHrg.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.txtTtlHrg.Location = New System.Drawing.Point(440, 94)
        Me.txtTtlHrg.Name = "txtTtlHrg"
        Me.txtTtlHrg.ReadOnly = True
        Me.txtTtlHrg.Size = New System.Drawing.Size(185, 20)
        Me.txtTtlHrg.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(349, 97)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Total Harga"
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.NumericUpDown1.Location = New System.Drawing.Point(440, 64)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(109, 20)
        Me.NumericUpDown1.TabIndex = 4
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CalendarForeColor = System.Drawing.Color.DarkSlateGray
        Me.DateTimePicker1.CalendarTitleForeColor = System.Drawing.Color.DarkSlateGray
        Me.DateTimePicker1.Location = New System.Drawing.Point(111, 64)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(185, 20)
        Me.DateTimePicker1.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(349, 66)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Total Item"
        '
        'txtHrgBrg
        '
        Me.txtHrgBrg.BackColor = System.Drawing.Color.White
        Me.txtHrgBrg.Enabled = False
        Me.txtHrgBrg.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.txtHrgBrg.Location = New System.Drawing.Point(440, 33)
        Me.txtHrgBrg.Name = "txtHrgBrg"
        Me.txtHrgBrg.ReadOnly = True
        Me.txtHrgBrg.Size = New System.Drawing.Size(185, 20)
        Me.txtHrgBrg.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(349, 36)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Harga Barang"
        '
        'txtNmBrg
        '
        Me.txtNmBrg.BackColor = System.Drawing.Color.White
        Me.txtNmBrg.Enabled = False
        Me.txtNmBrg.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.txtNmBrg.Location = New System.Drawing.Point(111, 123)
        Me.txtNmBrg.Name = "txtNmBrg"
        Me.txtNmBrg.ReadOnly = True
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
        Me.txtKdBrg.Location = New System.Drawing.Point(111, 94)
        Me.txtKdBrg.Name = "txtKdBrg"
        Me.txtKdBrg.Size = New System.Drawing.Size(109, 20)
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
        'txtNoFaktur
        '
        Me.txtNoFaktur.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.txtNoFaktur.Location = New System.Drawing.Point(111, 33)
        Me.txtNoFaktur.Name = "txtNoFaktur"
        Me.txtNoFaktur.Size = New System.Drawing.Size(185, 20)
        Me.txtNoFaktur.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nomor Faktur"
        '
        'btnInput
        '
        Me.btnInput.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnInput.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInput.ForeColor = System.Drawing.Color.LightCyan
        Me.btnInput.Location = New System.Drawing.Point(695, 53)
        Me.btnInput.Name = "btnInput"
        Me.btnInput.Size = New System.Drawing.Size(123, 33)
        Me.btnInput.TabIndex = 9
        Me.btnInput.Text = "INPUT DATA"
        Me.btnInput.UseVisualStyleBackColor = False
        '
        'btnHps
        '
        Me.btnHps.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnHps.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHps.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHps.ForeColor = System.Drawing.Color.LightCyan
        Me.btnHps.Location = New System.Drawing.Point(695, 91)
        Me.btnHps.Name = "btnHps"
        Me.btnHps.Size = New System.Drawing.Size(123, 33)
        Me.btnHps.TabIndex = 10
        Me.btnHps.Text = "HAPUS DATA"
        Me.btnHps.UseVisualStyleBackColor = False
        '
        'btnKmbl
        '
        Me.btnKmbl.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnKmbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnKmbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKmbl.ForeColor = System.Drawing.Color.LightCyan
        Me.btnKmbl.Location = New System.Drawing.Point(695, 170)
        Me.btnKmbl.Name = "btnKmbl"
        Me.btnKmbl.Size = New System.Drawing.Size(123, 31)
        Me.btnKmbl.TabIndex = 11
        Me.btnKmbl.Text = "KEMBALI"
        Me.btnKmbl.UseVisualStyleBackColor = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(22, 222)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(796, 202)
        Me.TabControl1.TabIndex = 12
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.DataGridView1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(788, 176)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Data Penjualan"
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
        'txtNmKry
        '
        Me.txtNmKry.Enabled = False
        Me.txtNmKry.Location = New System.Drawing.Point(719, 12)
        Me.txtNmKry.Name = "txtNmKry"
        Me.txtNmKry.Size = New System.Drawing.Size(99, 20)
        Me.txtNmKry.TabIndex = 13
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(19, 15)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(141, 16)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "DATA PENJUALAN"
        '
        'btnCetak
        '
        Me.btnCetak.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnCetak.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCetak.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCetak.ForeColor = System.Drawing.Color.LightCyan
        Me.btnCetak.Location = New System.Drawing.Point(695, 130)
        Me.btnCetak.Name = "btnCetak"
        Me.btnCetak.Size = New System.Drawing.Size(123, 33)
        Me.btnCetak.TabIndex = 15
        Me.btnCetak.Text = "CETAK FAKTUR"
        Me.btnCetak.UseVisualStyleBackColor = False
        '
        'Penjualan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightCyan
        Me.ClientSize = New System.Drawing.Size(847, 435)
        Me.Controls.Add(Me.btnCetak)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtNmKry)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.btnKmbl)
        Me.Controls.Add(Me.btnHps)
        Me.Controls.Add(Me.btnInput)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Penjualan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Penjualan"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtTtlByr As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtTtlHrg As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents txtHrgBrg As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtNmBrg As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtKdBrg As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNoFaktur As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnInput As Button
    Friend WithEvents btnHps As Button
    Friend WithEvents btnKmbl As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents txtNmKry As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents btnCetak As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents CheckBrg As Button
End Class
