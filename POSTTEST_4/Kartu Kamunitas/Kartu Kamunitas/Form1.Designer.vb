<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormUtama
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.InputDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LihatKartuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SimpanDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BukaDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KeluarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBoxLogo = New System.Windows.Forms.PictureBox()
        Me.LabelJudul = New System.Windows.Forms.Label()
        Me.line = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabDataUtama = New System.Windows.Forms.TabPage()
        Me.cboDivisi = New System.Windows.Forms.ComboBox()
        Me.rbPerempuan = New System.Windows.Forms.RadioButton()
        Me.rbLaki = New System.Windows.Forms.RadioButton()
        Me.dtpLahir = New System.Windows.Forms.DateTimePicker()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabKontak = New System.Windows.Forms.TabPage()
        Me.txtAlamat = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.mtTelepon = New System.Windows.Forms.MaskedTextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TabProfil = New System.Windows.Forms.TabPage()
        Me.btnCetak = New System.Windows.Forms.Button()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.clbHobby = New System.Windows.Forms.CheckedListBox()
        Me.gbPeran = New System.Windows.Forms.GroupBox()
        Me.rbAdmin = New System.Windows.Forms.RadioButton()
        Me.rbAnggota = New System.Windows.Forms.RadioButton()
        Me.rbKetua = New System.Windows.Forms.RadioButton()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.pbFoto = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBoxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabDataUtama.SuspendLayout()
        Me.TabKontak.SuspendLayout()
        Me.TabProfil.SuspendLayout()
        Me.gbPeran.SuspendLayout()
        CType(Me.pbFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InputDataToolStripMenuItem, Me.LihatKartuToolStripMenuItem, Me.SimpanDataToolStripMenuItem, Me.BukaDataToolStripMenuItem, Me.KeluarToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(784, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'InputDataToolStripMenuItem
        '
        Me.InputDataToolStripMenuItem.Name = "InputDataToolStripMenuItem"
        Me.InputDataToolStripMenuItem.Size = New System.Drawing.Size(74, 20)
        Me.InputDataToolStripMenuItem.Text = "Input Data"
        '
        'LihatKartuToolStripMenuItem
        '
        Me.LihatKartuToolStripMenuItem.Name = "LihatKartuToolStripMenuItem"
        Me.LihatKartuToolStripMenuItem.Size = New System.Drawing.Size(76, 20)
        Me.LihatKartuToolStripMenuItem.Text = "Lihat Kartu"
        '
        'SimpanDataToolStripMenuItem
        '
        Me.SimpanDataToolStripMenuItem.Name = "SimpanDataToolStripMenuItem"
        Me.SimpanDataToolStripMenuItem.Size = New System.Drawing.Size(86, 20)
        Me.SimpanDataToolStripMenuItem.Text = "Simpan Data"
        '
        'BukaDataToolStripMenuItem
        '
        Me.BukaDataToolStripMenuItem.Name = "BukaDataToolStripMenuItem"
        Me.BukaDataToolStripMenuItem.Size = New System.Drawing.Size(72, 20)
        Me.BukaDataToolStripMenuItem.Text = "Buka Data"
        '
        'KeluarToolStripMenuItem
        '
        Me.KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
        Me.KeluarToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.KeluarToolStripMenuItem.Text = "Keluar"
        '
        'PictureBoxLogo
        '
        Me.PictureBoxLogo.BackgroundImage = Global.Kartu_Kamunitas.My.Resources.Resources.Screenshot__2_
        Me.PictureBoxLogo.Location = New System.Drawing.Point(24, 44)
        Me.PictureBoxLogo.Name = "PictureBoxLogo"
        Me.PictureBoxLogo.Size = New System.Drawing.Size(100, 80)
        Me.PictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBoxLogo.TabIndex = 1
        Me.PictureBoxLogo.TabStop = False
        '
        'LabelJudul
        '
        Me.LabelJudul.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelJudul.Location = New System.Drawing.Point(234, 59)
        Me.LabelJudul.Name = "LabelJudul"
        Me.LabelJudul.Size = New System.Drawing.Size(371, 52)
        Me.LabelJudul.TabIndex = 2
        Me.LabelJudul.Text = "APLIKASI KARTU KOMUNITAS"
        Me.LabelJudul.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'line
        '
        Me.line.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.line.Location = New System.Drawing.Point(-41, 24)
        Me.line.Name = "line"
        Me.line.Size = New System.Drawing.Size(962, 127)
        Me.line.TabIndex = 3
        Me.line.Text = " "
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabDataUtama)
        Me.TabControl1.Controls.Add(Me.TabKontak)
        Me.TabControl1.Controls.Add(Me.TabProfil)
        Me.TabControl1.Location = New System.Drawing.Point(12, 163)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(750, 386)
        Me.TabControl1.TabIndex = 4
        '
        'TabDataUtama
        '
        Me.TabDataUtama.Controls.Add(Me.cboDivisi)
        Me.TabDataUtama.Controls.Add(Me.rbPerempuan)
        Me.TabDataUtama.Controls.Add(Me.rbLaki)
        Me.TabDataUtama.Controls.Add(Me.dtpLahir)
        Me.TabDataUtama.Controls.Add(Me.txtID)
        Me.TabDataUtama.Controls.Add(Me.txtNama)
        Me.TabDataUtama.Controls.Add(Me.Label5)
        Me.TabDataUtama.Controls.Add(Me.Label4)
        Me.TabDataUtama.Controls.Add(Me.Label3)
        Me.TabDataUtama.Controls.Add(Me.Label2)
        Me.TabDataUtama.Controls.Add(Me.Label1)
        Me.TabDataUtama.Location = New System.Drawing.Point(4, 22)
        Me.TabDataUtama.Name = "TabDataUtama"
        Me.TabDataUtama.Padding = New System.Windows.Forms.Padding(3)
        Me.TabDataUtama.Size = New System.Drawing.Size(742, 360)
        Me.TabDataUtama.TabIndex = 0
        Me.TabDataUtama.Text = "Data Utama"
        Me.TabDataUtama.UseVisualStyleBackColor = True
        '
        'cboDivisi
        '
        Me.cboDivisi.FormattingEnabled = True
        Me.cboDivisi.Location = New System.Drawing.Point(204, 195)
        Me.cboDivisi.Name = "cboDivisi"
        Me.cboDivisi.Size = New System.Drawing.Size(200, 21)
        Me.cboDivisi.TabIndex = 10
        '
        'rbPerempuan
        '
        Me.rbPerempuan.AutoSize = True
        Me.rbPerempuan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbPerempuan.Location = New System.Drawing.Point(308, 150)
        Me.rbPerempuan.Name = "rbPerempuan"
        Me.rbPerempuan.Size = New System.Drawing.Size(95, 20)
        Me.rbPerempuan.TabIndex = 9
        Me.rbPerempuan.TabStop = True
        Me.rbPerempuan.Text = "Perempuan"
        Me.rbPerempuan.UseVisualStyleBackColor = True
        '
        'rbLaki
        '
        Me.rbLaki.AutoSize = True
        Me.rbLaki.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbLaki.Location = New System.Drawing.Point(204, 150)
        Me.rbLaki.Name = "rbLaki"
        Me.rbLaki.Size = New System.Drawing.Size(81, 20)
        Me.rbLaki.TabIndex = 8
        Me.rbLaki.TabStop = True
        Me.rbLaki.Text = "Laki - laki"
        Me.rbLaki.UseVisualStyleBackColor = True
        '
        'dtpLahir
        '
        Me.dtpLahir.Location = New System.Drawing.Point(204, 106)
        Me.dtpLahir.Name = "dtpLahir"
        Me.dtpLahir.Size = New System.Drawing.Size(200, 20)
        Me.dtpLahir.TabIndex = 7
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(204, 65)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(200, 20)
        Me.txtID.TabIndex = 6
        '
        'txtNama
        '
        Me.txtNama.Location = New System.Drawing.Point(204, 25)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(200, 20)
        Me.txtNama.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(28, 195)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Divisi"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(28, 150)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Jenis Kelamin"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(28, 106)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Tanggal Lahir"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(28, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "ID Anggotta"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(28, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nama Lengkap"
        '
        'TabKontak
        '
        Me.TabKontak.Controls.Add(Me.txtAlamat)
        Me.TabKontak.Controls.Add(Me.txtEmail)
        Me.TabKontak.Controls.Add(Me.mtTelepon)
        Me.TabKontak.Controls.Add(Me.Label8)
        Me.TabKontak.Controls.Add(Me.Label7)
        Me.TabKontak.Controls.Add(Me.Label6)
        Me.TabKontak.Location = New System.Drawing.Point(4, 22)
        Me.TabKontak.Name = "TabKontak"
        Me.TabKontak.Padding = New System.Windows.Forms.Padding(3)
        Me.TabKontak.Size = New System.Drawing.Size(742, 360)
        Me.TabKontak.TabIndex = 1
        Me.TabKontak.Text = "Kontak & Info"
        Me.TabKontak.UseVisualStyleBackColor = True
        '
        'txtAlamat
        '
        Me.txtAlamat.Location = New System.Drawing.Point(222, 133)
        Me.txtAlamat.Multiline = True
        Me.txtAlamat.Name = "txtAlamat"
        Me.txtAlamat.Size = New System.Drawing.Size(171, 78)
        Me.txtAlamat.TabIndex = 5
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(222, 89)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(171, 20)
        Me.txtEmail.TabIndex = 4
        '
        'mtTelepon
        '
        Me.mtTelepon.Location = New System.Drawing.Point(222, 51)
        Me.mtTelepon.Mask = "0000-0000-0000"
        Me.mtTelepon.Name = "mtTelepon"
        Me.mtTelepon.Size = New System.Drawing.Size(171, 20)
        Me.mtTelepon.TabIndex = 3
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(47, 133)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(59, 20)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Alamat"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(47, 89)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 20)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Email"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(47, 49)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(117, 20)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Nomor Telepon"
        '
        'TabProfil
        '
        Me.TabProfil.Controls.Add(Me.btnCetak)
        Me.TabProfil.Controls.Add(Me.btnSimpan)
        Me.TabProfil.Controls.Add(Me.clbHobby)
        Me.TabProfil.Controls.Add(Me.gbPeran)
        Me.TabProfil.Controls.Add(Me.btnBrowse)
        Me.TabProfil.Controls.Add(Me.pbFoto)
        Me.TabProfil.Location = New System.Drawing.Point(4, 22)
        Me.TabProfil.Name = "TabProfil"
        Me.TabProfil.Size = New System.Drawing.Size(742, 360)
        Me.TabProfil.TabIndex = 2
        Me.TabProfil.Text = "Profil & Aktivitas"
        Me.TabProfil.UseVisualStyleBackColor = True
        '
        'btnCetak
        '
        Me.btnCetak.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCetak.Location = New System.Drawing.Point(274, 217)
        Me.btnCetak.Name = "btnCetak"
        Me.btnCetak.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnCetak.Size = New System.Drawing.Size(151, 32)
        Me.btnCetak.TabIndex = 5
        Me.btnCetak.Text = "Cetak Kartu"
        Me.btnCetak.UseVisualStyleBackColor = True
        '
        'btnSimpan
        '
        Me.btnSimpan.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSimpan.Location = New System.Drawing.Point(274, 166)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(151, 32)
        Me.btnSimpan.TabIndex = 4
        Me.btnSimpan.Text = "Simpan Data"
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'clbHobby
        '
        Me.clbHobby.FormattingEnabled = True
        Me.clbHobby.Location = New System.Drawing.Point(24, 166)
        Me.clbHobby.Name = "clbHobby"
        Me.clbHobby.Size = New System.Drawing.Size(149, 94)
        Me.clbHobby.TabIndex = 3
        '
        'gbPeran
        '
        Me.gbPeran.Controls.Add(Me.rbAdmin)
        Me.gbPeran.Controls.Add(Me.rbAnggota)
        Me.gbPeran.Controls.Add(Me.rbKetua)
        Me.gbPeran.Location = New System.Drawing.Point(294, 41)
        Me.gbPeran.Name = "gbPeran"
        Me.gbPeran.Size = New System.Drawing.Size(259, 70)
        Me.gbPeran.TabIndex = 2
        Me.gbPeran.TabStop = False
        Me.gbPeran.Text = "Pilih Peran"
        '
        'rbAdmin
        '
        Me.rbAdmin.AutoSize = True
        Me.rbAdmin.Location = New System.Drawing.Point(178, 36)
        Me.rbAdmin.Name = "rbAdmin"
        Me.rbAdmin.Size = New System.Drawing.Size(54, 17)
        Me.rbAdmin.TabIndex = 2
        Me.rbAdmin.TabStop = True
        Me.rbAdmin.Text = "Admin"
        Me.rbAdmin.UseVisualStyleBackColor = True
        '
        'rbAnggota
        '
        Me.rbAnggota.AutoSize = True
        Me.rbAnggota.Location = New System.Drawing.Point(94, 36)
        Me.rbAnggota.Name = "rbAnggota"
        Me.rbAnggota.Size = New System.Drawing.Size(65, 17)
        Me.rbAnggota.TabIndex = 1
        Me.rbAnggota.TabStop = True
        Me.rbAnggota.Text = "Anggota"
        Me.rbAnggota.UseVisualStyleBackColor = True
        '
        'rbKetua
        '
        Me.rbKetua.AutoSize = True
        Me.rbKetua.Location = New System.Drawing.Point(17, 36)
        Me.rbKetua.Name = "rbKetua"
        Me.rbKetua.Size = New System.Drawing.Size(53, 17)
        Me.rbKetua.TabIndex = 0
        Me.rbKetua.TabStop = True
        Me.rbKetua.Text = "Ketua"
        Me.rbKetua.UseVisualStyleBackColor = True
        '
        'btnBrowse
        '
        Me.btnBrowse.Location = New System.Drawing.Point(143, 62)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(75, 23)
        Me.btnBrowse.TabIndex = 1
        Me.btnBrowse.Text = "Browse Foto"
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'pbFoto
        '
        Me.pbFoto.BackgroundImage = Global.Kartu_Kamunitas.My.Resources.Resources.Screenshot__2_
        Me.pbFoto.Location = New System.Drawing.Point(24, 26)
        Me.pbFoto.Name = "pbFoto"
        Me.pbFoto.Size = New System.Drawing.Size(100, 100)
        Me.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbFoto.TabIndex = 0
        Me.pbFoto.TabStop = False
        '
        'FormUtama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.LabelJudul)
        Me.Controls.Add(Me.PictureBoxLogo)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.line)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FormUtama"
        Me.Text = "Aplikasi Komunitas"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBoxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabDataUtama.ResumeLayout(False)
        Me.TabDataUtama.PerformLayout()
        Me.TabKontak.ResumeLayout(False)
        Me.TabKontak.PerformLayout()
        Me.TabProfil.ResumeLayout(False)
        Me.gbPeran.ResumeLayout(False)
        Me.gbPeran.PerformLayout()
        CType(Me.pbFoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents InputDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LihatKartuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SimpanDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BukaDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KeluarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBoxLogo As PictureBox
    Friend WithEvents LabelJudul As Label
    Friend WithEvents line As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabDataUtama As TabPage
    Friend WithEvents TabKontak As TabPage
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TabProfil As TabPage
    Friend WithEvents rbPerempuan As RadioButton
    Friend WithEvents rbLaki As RadioButton
    Friend WithEvents dtpLahir As DateTimePicker
    Friend WithEvents txtID As TextBox
    Friend WithEvents txtNama As TextBox
    Friend WithEvents cboDivisi As ComboBox
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents mtTelepon As MaskedTextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents gbPeran As GroupBox
    Friend WithEvents rbKetua As RadioButton
    Friend WithEvents btnBrowse As Button
    Friend WithEvents btnCetak As Button
    Friend WithEvents btnSimpan As Button
    Friend WithEvents clbHobby As CheckedListBox
    Friend WithEvents rbAdmin As RadioButton
    Friend WithEvents rbAnggota As RadioButton
    Friend WithEvents pbFoto As PictureBox
End Class
