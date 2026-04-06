<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.lblJudulKartu = New System.Windows.Forms.Label()
        Me.picKartuFoto = New System.Windows.Forms.PictureBox()
        Me.lblNama = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblID = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblPeran = New System.Windows.Forms.Label()
        Me.lblKomunitas = New System.Windows.Forms.Label()
        Me.lblKontak = New System.Windows.Forms.Label()
        Me.lblHobi = New System.Windows.Forms.Label()
        Me.btnTutup = New System.Windows.Forms.Button()
        CType(Me.picKartuFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblJudulKartu
        '
        Me.lblJudulKartu.AutoSize = True
        Me.lblJudulKartu.Font = New System.Drawing.Font("Trajan Pro", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJudulKartu.Location = New System.Drawing.Point(215, 31)
        Me.lblJudulKartu.Name = "lblJudulKartu"
        Me.lblJudulKartu.Size = New System.Drawing.Size(336, 27)
        Me.lblJudulKartu.TabIndex = 0
        Me.lblJudulKartu.Text = "KARTU MAHASISWA UNMUL"
        '
        'picKartuFoto
        '
        Me.picKartuFoto.Location = New System.Drawing.Point(620, 115)
        Me.picKartuFoto.Name = "picKartuFoto"
        Me.picKartuFoto.Size = New System.Drawing.Size(107, 110)
        Me.picKartuFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picKartuFoto.TabIndex = 1
        Me.picKartuFoto.TabStop = False
        '
        'lblNama
        '
        Me.lblNama.AutoSize = True
        Me.lblNama.Font = New System.Drawing.Font("Trajan Pro", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNama.Location = New System.Drawing.Point(627, 229)
        Me.lblNama.Name = "lblNama"
        Me.lblNama.Size = New System.Drawing.Size(10, 16)
        Me.lblNama.TabIndex = 2
        Me.lblNama.Text = ":"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(223, 124)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 15)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Hobi"
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Font = New System.Drawing.Font("Trajan Pro", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblID.Location = New System.Drawing.Point(627, 251)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(10, 16)
        Me.lblID.TabIndex = 4
        Me.lblID.Text = ":"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(223, 153)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 15)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Kontak"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(223, 179)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 15)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Komunitas"
        '
        'lblPeran
        '
        Me.lblPeran.AutoSize = True
        Me.lblPeran.Font = New System.Drawing.Font("Trajan Pro", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPeran.Location = New System.Drawing.Point(340, 73)
        Me.lblPeran.Name = "lblPeran"
        Me.lblPeran.Size = New System.Drawing.Size(62, 20)
        Me.lblPeran.TabIndex = 7
        Me.lblPeran.Text = "Peran"
        '
        'lblKomunitas
        '
        Me.lblKomunitas.AutoSize = True
        Me.lblKomunitas.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKomunitas.Location = New System.Drawing.Point(331, 179)
        Me.lblKomunitas.Name = "lblKomunitas"
        Me.lblKomunitas.Size = New System.Drawing.Size(66, 15)
        Me.lblKomunitas.TabIndex = 10
        Me.lblKomunitas.Text = "Komunitas"
        '
        'lblKontak
        '
        Me.lblKontak.AutoSize = True
        Me.lblKontak.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKontak.Location = New System.Drawing.Point(331, 153)
        Me.lblKontak.Name = "lblKontak"
        Me.lblKontak.Size = New System.Drawing.Size(47, 15)
        Me.lblKontak.TabIndex = 9
        Me.lblKontak.Text = "Kontak"
        '
        'lblHobi
        '
        Me.lblHobi.AutoSize = True
        Me.lblHobi.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHobi.Location = New System.Drawing.Point(331, 124)
        Me.lblHobi.Name = "lblHobi"
        Me.lblHobi.Size = New System.Drawing.Size(32, 15)
        Me.lblHobi.TabIndex = 8
        Me.lblHobi.Text = "Hobi"
        '
        'btnTutup
        '
        Me.btnTutup.Font = New System.Drawing.Font("Trebuchet MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTutup.Location = New System.Drawing.Point(12, 297)
        Me.btnTutup.Name = "btnTutup"
        Me.btnTutup.Size = New System.Drawing.Size(96, 38)
        Me.btnTutup.TabIndex = 11
        Me.btnTutup.Text = "Tutup"
        Me.btnTutup.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnTutup)
        Me.Controls.Add(Me.lblKomunitas)
        Me.Controls.Add(Me.lblKontak)
        Me.Controls.Add(Me.lblHobi)
        Me.Controls.Add(Me.lblPeran)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblNama)
        Me.Controls.Add(Me.picKartuFoto)
        Me.Controls.Add(Me.lblJudulKartu)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.picKartuFoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblJudulKartu As Label
    Friend WithEvents picKartuFoto As PictureBox
    Friend WithEvents lblNama As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblID As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblPeran As Label
    Friend WithEvents lblKomunitas As Label
    Friend WithEvents lblKontak As Label
    Friend WithEvents lblHobi As Label
    Friend WithEvents btnTutup As Button
End Class
