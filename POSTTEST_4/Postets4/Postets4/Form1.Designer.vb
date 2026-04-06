<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtNama = New System.Windows.Forms.TextBox()
        Me.txtUmur = New System.Windows.Forms.TextBox()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.dtpLahir = New System.Windows.Forms.DateTimePicker()
        Me.grpJK = New System.Windows.Forms.GroupBox()
        Me.rdoPerempuan = New System.Windows.Forms.RadioButton()
        Me.rdoLaki = New System.Windows.Forms.RadioButton()
        Me.cmbKomunitas = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.mtxtTelepon = New System.Windows.Forms.MaskedTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtAlamat = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.mnuInput = New System.Windows.Forms.TabPage()
        Me.mnuSimpan = New System.Windows.Forms.Button()
        Me.chkMenulis = New System.Windows.Forms.CheckBox()
        Me.chkOlahraga = New System.Windows.Forms.CheckBox()
        Me.chkFotografi = New System.Windows.Forms.CheckBox()
        Me.chkMusik = New System.Windows.Forms.CheckBox()
        Me.chkGaming = New System.Windows.Forms.CheckBox()
        Me.chkEditing = New System.Windows.Forms.CheckBox()
        Me.chkDesain = New System.Windows.Forms.CheckBox()
        Me.chkCoding = New System.Windows.Forms.CheckBox()
        Me.grpPeran = New System.Windows.Forms.GroupBox()
        Me.rdoKoordinator = New System.Windows.Forms.RadioButton()
        Me.rdoAnggota = New System.Windows.Forms.RadioButton()
        Me.rdoAdmin = New System.Windows.Forms.RadioButton()
        Me.rdoKetua = New System.Windows.Forms.RadioButton()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.picFoto = New System.Windows.Forms.PictureBox()
        Me.mnuBuka = New System.Windows.Forms.Button()
        Me.mnuKeluar = New System.Windows.Forms.Button()
        Me.grpJK.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.mnuInput.SuspendLayout()
        Me.grpPeran.SuspendLayout()
        CType(Me.picFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nama"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "ID Anggota"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 47)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Umur"
        '
        'TxtNama
        '
        Me.TxtNama.Location = New System.Drawing.Point(107, 11)
        Me.TxtNama.Name = "TxtNama"
        Me.TxtNama.Size = New System.Drawing.Size(200, 20)
        Me.TxtNama.TabIndex = 3
        '
        'txtUmur
        '
        Me.txtUmur.Location = New System.Drawing.Point(107, 44)
        Me.txtUmur.Name = "txtUmur"
        Me.txtUmur.Size = New System.Drawing.Size(200, 20)
        Me.txtUmur.TabIndex = 4
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(107, 76)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(200, 20)
        Me.txtID.TabIndex = 5
        '
        'dtpLahir
        '
        Me.dtpLahir.Location = New System.Drawing.Point(107, 106)
        Me.dtpLahir.Name = "dtpLahir"
        Me.dtpLahir.Size = New System.Drawing.Size(200, 20)
        Me.dtpLahir.TabIndex = 6
        '
        'grpJK
        '
        Me.grpJK.Controls.Add(Me.rdoPerempuan)
        Me.grpJK.Controls.Add(Me.rdoLaki)
        Me.grpJK.Location = New System.Drawing.Point(331, 30)
        Me.grpJK.Name = "grpJK"
        Me.grpJK.Size = New System.Drawing.Size(116, 96)
        Me.grpJK.TabIndex = 7
        Me.grpJK.TabStop = False
        Me.grpJK.Text = "Jenis Kelamin"
        '
        'rdoPerempuan
        '
        Me.rdoPerempuan.AutoSize = True
        Me.rdoPerempuan.Location = New System.Drawing.Point(6, 53)
        Me.rdoPerempuan.Name = "rdoPerempuan"
        Me.rdoPerempuan.Size = New System.Drawing.Size(93, 17)
        Me.rdoPerempuan.TabIndex = 9
        Me.rdoPerempuan.TabStop = True
        Me.rdoPerempuan.Text = "PEREMPUAN"
        Me.rdoPerempuan.UseVisualStyleBackColor = True
        '
        'rdoLaki
        '
        Me.rdoLaki.AutoSize = True
        Me.rdoLaki.Location = New System.Drawing.Point(6, 26)
        Me.rdoLaki.Name = "rdoLaki"
        Me.rdoLaki.Size = New System.Drawing.Size(80, 17)
        Me.rdoLaki.TabIndex = 8
        Me.rdoLaki.TabStop = True
        Me.rdoLaki.Text = "LAKI - LAKI"
        Me.rdoLaki.UseVisualStyleBackColor = True
        '
        'cmbKomunitas
        '
        Me.cmbKomunitas.FormattingEnabled = True
        Me.cmbKomunitas.Items.AddRange(New Object() {"Programmer", "Desain Grafis", "Mobile Developer", "Game Developer", "Multimedia", "Cyber Security"})
        Me.cmbKomunitas.Location = New System.Drawing.Point(107, 141)
        Me.cmbKomunitas.Name = "cmbKomunitas"
        Me.cmbKomunitas.Size = New System.Drawing.Size(200, 21)
        Me.cmbKomunitas.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Tanggal Lahir"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 144)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Jenis Komunitas"
        '
        'mtxtTelepon
        '
        Me.mtxtTelepon.Location = New System.Drawing.Point(115, 84)
        Me.mtxtTelepon.Mask = "0000-0000-00000"
        Me.mtxtTelepon.Name = "mtxtTelepon"
        Me.mtxtTelepon.Size = New System.Drawing.Size(200, 20)
        Me.mtxtTelepon.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(15, 90)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Nomor Telpon"
        '
        'txtAlamat
        '
        Me.txtAlamat.Location = New System.Drawing.Point(115, 47)
        Me.txtAlamat.Multiline = True
        Me.txtAlamat.Name = "txtAlamat"
        Me.txtAlamat.Size = New System.Drawing.Size(200, 20)
        Me.txtAlamat.TabIndex = 13
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(115, 13)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(200, 20)
        Me.txtEmail.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(15, 52)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Alamat"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(15, 16)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(32, 13)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Email"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.mnuInput)
        Me.TabControl1.Location = New System.Drawing.Point(158, 5)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(476, 306)
        Me.TabControl1.TabIndex = 17
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.grpJK)
        Me.TabPage1.Controls.Add(Me.TxtNama)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.txtUmur)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.txtID)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.cmbKomunitas)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.dtpLahir)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(468, 280)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "DATA UTAMA"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.mtxtTelepon)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.txtAlamat)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.txtEmail)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(468, 280)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "KONTAK & INFO"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'mnuInput
        '
        Me.mnuInput.Controls.Add(Me.mnuKeluar)
        Me.mnuInput.Controls.Add(Me.mnuBuka)
        Me.mnuInput.Controls.Add(Me.mnuSimpan)
        Me.mnuInput.Controls.Add(Me.chkMenulis)
        Me.mnuInput.Controls.Add(Me.chkOlahraga)
        Me.mnuInput.Controls.Add(Me.chkFotografi)
        Me.mnuInput.Controls.Add(Me.chkMusik)
        Me.mnuInput.Controls.Add(Me.chkGaming)
        Me.mnuInput.Controls.Add(Me.chkEditing)
        Me.mnuInput.Controls.Add(Me.chkDesain)
        Me.mnuInput.Controls.Add(Me.chkCoding)
        Me.mnuInput.Controls.Add(Me.grpPeran)
        Me.mnuInput.Controls.Add(Me.btnBrowse)
        Me.mnuInput.Controls.Add(Me.picFoto)
        Me.mnuInput.Location = New System.Drawing.Point(4, 22)
        Me.mnuInput.Name = "mnuInput"
        Me.mnuInput.Padding = New System.Windows.Forms.Padding(3)
        Me.mnuInput.Size = New System.Drawing.Size(468, 280)
        Me.mnuInput.TabIndex = 2
        Me.mnuInput.Text = "PROFIL & AKTIVITAS"
        Me.mnuInput.UseVisualStyleBackColor = True
        '
        'mnuSimpan
        '
        Me.mnuSimpan.Location = New System.Drawing.Point(146, 246)
        Me.mnuSimpan.Name = "mnuSimpan"
        Me.mnuSimpan.Size = New System.Drawing.Size(180, 23)
        Me.mnuSimpan.TabIndex = 27
        Me.mnuSimpan.Text = "Simpan Dan Cetak Karu"
        Me.mnuSimpan.UseVisualStyleBackColor = True
        '
        'chkMenulis
        '
        Me.chkMenulis.AutoSize = True
        Me.chkMenulis.Location = New System.Drawing.Point(259, 207)
        Me.chkMenulis.Name = "chkMenulis"
        Me.chkMenulis.Size = New System.Drawing.Size(62, 17)
        Me.chkMenulis.TabIndex = 25
        Me.chkMenulis.Text = "Menulis"
        Me.chkMenulis.UseVisualStyleBackColor = True
        '
        'chkOlahraga
        '
        Me.chkOlahraga.AutoSize = True
        Me.chkOlahraga.Location = New System.Drawing.Point(259, 162)
        Me.chkOlahraga.Name = "chkOlahraga"
        Me.chkOlahraga.Size = New System.Drawing.Size(69, 17)
        Me.chkOlahraga.TabIndex = 24
        Me.chkOlahraga.Text = "Olahraga"
        Me.chkOlahraga.UseVisualStyleBackColor = True
        '
        'chkFotografi
        '
        Me.chkFotografi.AutoSize = True
        Me.chkFotografi.Location = New System.Drawing.Point(259, 185)
        Me.chkFotografi.Name = "chkFotografi"
        Me.chkFotografi.Size = New System.Drawing.Size(67, 17)
        Me.chkFotografi.TabIndex = 26
        Me.chkFotografi.Text = "Fotografi"
        Me.chkFotografi.UseVisualStyleBackColor = True
        '
        'chkMusik
        '
        Me.chkMusik.AutoSize = True
        Me.chkMusik.Location = New System.Drawing.Point(259, 139)
        Me.chkMusik.Name = "chkMusik"
        Me.chkMusik.Size = New System.Drawing.Size(54, 17)
        Me.chkMusik.TabIndex = 23
        Me.chkMusik.Text = "Musik"
        Me.chkMusik.UseVisualStyleBackColor = True
        '
        'chkGaming
        '
        Me.chkGaming.AutoSize = True
        Me.chkGaming.Location = New System.Drawing.Point(144, 207)
        Me.chkGaming.Name = "chkGaming"
        Me.chkGaming.Size = New System.Drawing.Size(62, 17)
        Me.chkGaming.TabIndex = 22
        Me.chkGaming.Text = "Gaming"
        Me.chkGaming.UseVisualStyleBackColor = True
        '
        'chkEditing
        '
        Me.chkEditing.AutoSize = True
        Me.chkEditing.Location = New System.Drawing.Point(144, 184)
        Me.chkEditing.Name = "chkEditing"
        Me.chkEditing.Size = New System.Drawing.Size(58, 17)
        Me.chkEditing.TabIndex = 21
        Me.chkEditing.Text = "Editing"
        Me.chkEditing.UseVisualStyleBackColor = True
        '
        'chkDesain
        '
        Me.chkDesain.AutoSize = True
        Me.chkDesain.Location = New System.Drawing.Point(144, 162)
        Me.chkDesain.Name = "chkDesain"
        Me.chkDesain.Size = New System.Drawing.Size(59, 17)
        Me.chkDesain.TabIndex = 20
        Me.chkDesain.Text = "Desain"
        Me.chkDesain.UseVisualStyleBackColor = True
        '
        'chkCoding
        '
        Me.chkCoding.AutoSize = True
        Me.chkCoding.Location = New System.Drawing.Point(144, 139)
        Me.chkCoding.Name = "chkCoding"
        Me.chkCoding.Size = New System.Drawing.Size(59, 17)
        Me.chkCoding.TabIndex = 18
        Me.chkCoding.Text = "Coding"
        Me.chkCoding.UseVisualStyleBackColor = True
        '
        'grpPeran
        '
        Me.grpPeran.Controls.Add(Me.rdoKoordinator)
        Me.grpPeran.Controls.Add(Me.rdoAnggota)
        Me.grpPeran.Controls.Add(Me.rdoAdmin)
        Me.grpPeran.Controls.Add(Me.rdoKetua)
        Me.grpPeran.Location = New System.Drawing.Point(144, 21)
        Me.grpPeran.Name = "grpPeran"
        Me.grpPeran.Size = New System.Drawing.Size(220, 95)
        Me.grpPeran.TabIndex = 18
        Me.grpPeran.TabStop = False
        Me.grpPeran.Text = "Peran"
        '
        'rdoKoordinator
        '
        Me.rdoKoordinator.AutoSize = True
        Me.rdoKoordinator.Location = New System.Drawing.Point(115, 61)
        Me.rdoKoordinator.Name = "rdoKoordinator"
        Me.rdoKoordinator.Size = New System.Drawing.Size(79, 17)
        Me.rdoKoordinator.TabIndex = 3
        Me.rdoKoordinator.TabStop = True
        Me.rdoKoordinator.Text = "Koordinator"
        Me.rdoKoordinator.UseVisualStyleBackColor = True
        '
        'rdoAnggota
        '
        Me.rdoAnggota.AutoSize = True
        Me.rdoAnggota.Location = New System.Drawing.Point(115, 29)
        Me.rdoAnggota.Name = "rdoAnggota"
        Me.rdoAnggota.Size = New System.Drawing.Size(65, 17)
        Me.rdoAnggota.TabIndex = 2
        Me.rdoAnggota.TabStop = True
        Me.rdoAnggota.Text = "Anggota"
        Me.rdoAnggota.UseVisualStyleBackColor = True
        '
        'rdoAdmin
        '
        Me.rdoAdmin.AutoSize = True
        Me.rdoAdmin.Location = New System.Drawing.Point(6, 61)
        Me.rdoAdmin.Name = "rdoAdmin"
        Me.rdoAdmin.Size = New System.Drawing.Size(54, 17)
        Me.rdoAdmin.TabIndex = 1
        Me.rdoAdmin.TabStop = True
        Me.rdoAdmin.Text = "Admin"
        Me.rdoAdmin.UseVisualStyleBackColor = True
        '
        'rdoKetua
        '
        Me.rdoKetua.AutoSize = True
        Me.rdoKetua.Location = New System.Drawing.Point(6, 29)
        Me.rdoKetua.Name = "rdoKetua"
        Me.rdoKetua.Size = New System.Drawing.Size(53, 17)
        Me.rdoKetua.TabIndex = 0
        Me.rdoKetua.TabStop = True
        Me.rdoKetua.Text = "Ketua"
        Me.rdoKetua.UseVisualStyleBackColor = True
        '
        'btnBrowse
        '
        Me.btnBrowse.Location = New System.Drawing.Point(30, 133)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(75, 23)
        Me.btnBrowse.TabIndex = 19
        Me.btnBrowse.Text = "Browse Foto"
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'picFoto
        '
        Me.picFoto.Location = New System.Drawing.Point(17, 21)
        Me.picFoto.Name = "picFoto"
        Me.picFoto.Size = New System.Drawing.Size(100, 95)
        Me.picFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picFoto.TabIndex = 18
        Me.picFoto.TabStop = False
        '
        'mnuBuka
        '
        Me.mnuBuka.Location = New System.Drawing.Point(359, 246)
        Me.mnuBuka.Name = "mnuBuka"
        Me.mnuBuka.Size = New System.Drawing.Size(75, 23)
        Me.mnuBuka.TabIndex = 28
        Me.mnuBuka.Text = "Buka"
        Me.mnuBuka.UseVisualStyleBackColor = True
        '
        'mnuKeluar
        '
        Me.mnuKeluar.Location = New System.Drawing.Point(30, 246)
        Me.mnuKeluar.Name = "mnuKeluar"
        Me.mnuKeluar.Size = New System.Drawing.Size(75, 23)
        Me.mnuKeluar.TabIndex = 29
        Me.mnuKeluar.Text = "Tutup"
        Me.mnuKeluar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.grpJK.ResumeLayout(False)
        Me.grpJK.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.mnuInput.ResumeLayout(False)
        Me.mnuInput.PerformLayout()
        Me.grpPeran.ResumeLayout(False)
        Me.grpPeran.PerformLayout()
        CType(Me.picFoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtNama As TextBox
    Friend WithEvents txtUmur As TextBox
    Friend WithEvents txtID As TextBox
    Friend WithEvents dtpLahir As DateTimePicker
    Friend WithEvents grpJK As GroupBox
    Friend WithEvents rdoPerempuan As RadioButton
    Friend WithEvents rdoLaki As RadioButton
    Friend WithEvents cmbKomunitas As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents mtxtTelepon As MaskedTextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents mnuInput As TabPage
    Friend WithEvents picFoto As PictureBox
    Friend WithEvents btnBrowse As Button
    Friend WithEvents grpPeran As GroupBox
    Friend WithEvents rdoKoordinator As RadioButton
    Friend WithEvents rdoAnggota As RadioButton
    Friend WithEvents rdoAdmin As RadioButton
    Friend WithEvents rdoKetua As RadioButton
    Friend WithEvents chkMenulis As CheckBox
    Friend WithEvents chkOlahraga As CheckBox
    Friend WithEvents chkFotografi As CheckBox
    Friend WithEvents chkMusik As CheckBox
    Friend WithEvents chkGaming As CheckBox
    Friend WithEvents chkEditing As CheckBox
    Friend WithEvents chkDesain As CheckBox
    Friend WithEvents chkCoding As CheckBox
    Friend WithEvents mnuSimpan As Button
    Friend WithEvents mnuBuka As Button
    Friend WithEvents mnuKeluar As Button
End Class
