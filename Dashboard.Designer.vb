<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dashboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dashboard))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnSupp = New System.Windows.Forms.Button()
        Me.btnAkun = New System.Windows.Forms.Button()
        Me.btnBrg = New System.Windows.Forms.Button()
        Me.btnPelanggan = New System.Windows.Forms.Button()
        Me.btnBeli = New System.Windows.Forms.Button()
        Me.btnJual = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnKembali = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnLaporanJual = New System.Windows.Forms.Button()
        Me.btnLaporanBeli = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Panel1.Controls.Add(Me.btnLaporanBeli)
        Me.Panel1.Controls.Add(Me.btnLaporanJual)
        Me.Panel1.Controls.Add(Me.btnSupp)
        Me.Panel1.Controls.Add(Me.btnAkun)
        Me.Panel1.Controls.Add(Me.btnBrg)
        Me.Panel1.Controls.Add(Me.btnPelanggan)
        Me.Panel1.Controls.Add(Me.btnBeli)
        Me.Panel1.Controls.Add(Me.btnJual)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.ForeColor = System.Drawing.Color.Transparent
        Me.Panel1.Location = New System.Drawing.Point(-3, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(375, 579)
        Me.Panel1.TabIndex = 1
        '
        'btnSupp
        '
        Me.btnSupp.BackColor = System.Drawing.Color.LightCyan
        Me.btnSupp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSupp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSupp.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.btnSupp.Location = New System.Drawing.Point(23, 452)
        Me.btnSupp.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnSupp.Name = "btnSupp"
        Me.btnSupp.Size = New System.Drawing.Size(319, 42)
        Me.btnSupp.TabIndex = 15
        Me.btnSupp.Text = "SUPPLIER"
        Me.btnSupp.UseVisualStyleBackColor = False
        '
        'btnAkun
        '
        Me.btnAkun.BackColor = System.Drawing.Color.LightCyan
        Me.btnAkun.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAkun.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAkun.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.btnAkun.Location = New System.Drawing.Point(23, 517)
        Me.btnAkun.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnAkun.Name = "btnAkun"
        Me.btnAkun.Size = New System.Drawing.Size(319, 42)
        Me.btnAkun.TabIndex = 14
        Me.btnAkun.Text = "AKUN"
        Me.btnAkun.UseVisualStyleBackColor = False
        '
        'btnBrg
        '
        Me.btnBrg.BackColor = System.Drawing.Color.LightCyan
        Me.btnBrg.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBrg.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBrg.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.btnBrg.Location = New System.Drawing.Point(23, 385)
        Me.btnBrg.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnBrg.Name = "btnBrg"
        Me.btnBrg.Size = New System.Drawing.Size(319, 42)
        Me.btnBrg.TabIndex = 13
        Me.btnBrg.Text = "BARANG"
        Me.btnBrg.UseVisualStyleBackColor = False
        '
        'btnPelanggan
        '
        Me.btnPelanggan.BackColor = System.Drawing.Color.LightCyan
        Me.btnPelanggan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPelanggan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPelanggan.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.btnPelanggan.Location = New System.Drawing.Point(23, 317)
        Me.btnPelanggan.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnPelanggan.Name = "btnPelanggan"
        Me.btnPelanggan.Size = New System.Drawing.Size(319, 42)
        Me.btnPelanggan.TabIndex = 12
        Me.btnPelanggan.Text = "PELANGGAN"
        Me.btnPelanggan.UseVisualStyleBackColor = False
        '
        'btnBeli
        '
        Me.btnBeli.BackColor = System.Drawing.Color.LightCyan
        Me.btnBeli.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBeli.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBeli.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.btnBeli.Location = New System.Drawing.Point(23, 250)
        Me.btnBeli.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnBeli.Name = "btnBeli"
        Me.btnBeli.Size = New System.Drawing.Size(319, 42)
        Me.btnBeli.TabIndex = 11
        Me.btnBeli.Text = "PEMBELIAN"
        Me.btnBeli.UseVisualStyleBackColor = False
        '
        'btnJual
        '
        Me.btnJual.BackColor = System.Drawing.Color.LightCyan
        Me.btnJual.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnJual.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnJual.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.btnJual.Location = New System.Drawing.Point(23, 186)
        Me.btnJual.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnJual.Name = "btnJual"
        Me.btnJual.Size = New System.Drawing.Size(319, 42)
        Me.btnJual.TabIndex = 10
        Me.btnJual.Text = "PENJUALAN"
        Me.btnJual.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.LightCyan
        Me.Label3.Location = New System.Drawing.Point(19, 23)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 20)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "MENU"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(713, 11)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 18)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Selamat datang,"
        '
        'btnKembali
        '
        Me.btnKembali.BackColor = System.Drawing.Color.DarkSlateGray
        Me.btnKembali.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnKembali.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKembali.ForeColor = System.Drawing.Color.LightCyan
        Me.btnKembali.Location = New System.Drawing.Point(744, 526)
        Me.btnKembali.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnKembali.Name = "btnKembali"
        Me.btnKembali.Size = New System.Drawing.Size(164, 41)
        Me.btnKembali.TabIndex = 8
        Me.btnKembali.Text = "KEMBALI"
        Me.btnKembali.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(840, 11)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 18)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Label2"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(400, 59)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(508, 443)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'btnLaporanJual
        '
        Me.btnLaporanJual.BackColor = System.Drawing.Color.LightCyan
        Me.btnLaporanJual.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLaporanJual.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLaporanJual.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.btnLaporanJual.Location = New System.Drawing.Point(23, 59)
        Me.btnLaporanJual.Margin = New System.Windows.Forms.Padding(4)
        Me.btnLaporanJual.Name = "btnLaporanJual"
        Me.btnLaporanJual.Size = New System.Drawing.Size(319, 42)
        Me.btnLaporanJual.TabIndex = 16
        Me.btnLaporanJual.Text = "LAPORAN PENJUALAN"
        Me.btnLaporanJual.UseVisualStyleBackColor = False
        '
        'btnLaporanBeli
        '
        Me.btnLaporanBeli.BackColor = System.Drawing.Color.LightCyan
        Me.btnLaporanBeli.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLaporanBeli.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLaporanBeli.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.btnLaporanBeli.Location = New System.Drawing.Point(23, 123)
        Me.btnLaporanBeli.Margin = New System.Windows.Forms.Padding(4)
        Me.btnLaporanBeli.Name = "btnLaporanBeli"
        Me.btnLaporanBeli.Size = New System.Drawing.Size(319, 42)
        Me.btnLaporanBeli.TabIndex = 17
        Me.btnLaporanBeli.Text = "LAPORAN PEMBELIAN"
        Me.btnLaporanBeli.UseVisualStyleBackColor = False
        '
        'Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightCyan
        Me.ClientSize = New System.Drawing.Size(927, 580)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnKembali)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Dashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dashboard"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents btnAkun As Button
    Friend WithEvents btnBrg As Button
    Friend WithEvents btnPelanggan As Button
    Friend WithEvents btnBeli As Button
    Friend WithEvents btnJual As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents btnKembali As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents btnSupp As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnLaporanBeli As Button
    Friend WithEvents btnLaporanJual As Button
End Class
