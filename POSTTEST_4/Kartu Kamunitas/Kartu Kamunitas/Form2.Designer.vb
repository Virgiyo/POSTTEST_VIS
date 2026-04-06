<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormKartu
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblNama = New System.Windows.Forms.Label()
        Me.lblID = New System.Windows.Forms.Label()
        Me.lblDivisi = New System.Windows.Forms.Label()
        Me.lblKontak = New System.Windows.Forms.Label()
        Me.lblHobby = New System.Windows.Forms.Label()
        Me.lblInfoTambahan = New System.Windows.Forms.Label()
        Me.btnTutupKartu = New System.Windows.Forms.Button()
        Me.btnCetakKartu = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightGray
        Me.Panel1.Controls.Add(Me.btnCetakKartu)
        Me.Panel1.Controls.Add(Me.btnTutupKartu)
        Me.Panel1.Controls.Add(Me.lblInfoTambahan)
        Me.Panel1.Controls.Add(Me.lblHobby)
        Me.Panel1.Controls.Add(Me.lblKontak)
        Me.Panel1.Controls.Add(Me.lblDivisi)
        Me.Panel1.Controls.Add(Me.lblID)
        Me.Panel1.Controls.Add(Me.lblNama)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(400, 450)
        Me.Panel1.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(15, 18)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(80, 80)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'lblNama
        '
        Me.lblNama.AutoSize = True
        Me.lblNama.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNama.Location = New System.Drawing.Point(163, 36)
        Me.lblNama.Name = "lblNama"
        Me.lblNama.Size = New System.Drawing.Size(128, 20)
        Me.lblNama.TabIndex = 1
        Me.lblNama.Text = "Virgiyo Lahang"
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblID.Location = New System.Drawing.Point(172, 61)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(108, 20)
        Me.lblID.TabIndex = 2
        Me.lblID.Text = "23091066112"
        '
        'lblDivisi
        '
        Me.lblDivisi.AutoSize = True
        Me.lblDivisi.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDivisi.Location = New System.Drawing.Point(25, 140)
        Me.lblDivisi.Name = "lblDivisi"
        Me.lblDivisi.Size = New System.Drawing.Size(139, 20)
        Me.lblDivisi.TabIndex = 3
        Me.lblDivisi.Text = "Teknik Informatika"
        '
        'lblKontak
        '
        Me.lblKontak.AutoSize = True
        Me.lblKontak.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKontak.Location = New System.Drawing.Point(25, 173)
        Me.lblKontak.Name = "lblKontak"
        Me.lblKontak.Size = New System.Drawing.Size(117, 20)
        Me.lblKontak.TabIndex = 4
        Me.lblKontak.Text = "081321595155"
        '
        'lblHobby
        '
        Me.lblHobby.AutoSize = True
        Me.lblHobby.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHobby.Location = New System.Drawing.Point(25, 207)
        Me.lblHobby.Name = "lblHobby"
        Me.lblHobby.Size = New System.Drawing.Size(269, 20)
        Me.lblHobby.TabIndex = 5
        Me.lblHobby.Text = "Baca Manga China 500 CHP/3 HARI"
        '
        'lblInfoTambahan
        '
        Me.lblInfoTambahan.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfoTambahan.Location = New System.Drawing.Point(25, 246)
        Me.lblInfoTambahan.Name = "lblInfoTambahan"
        Me.lblInfoTambahan.Size = New System.Drawing.Size(323, 123)
        Me.lblInfoTambahan.TabIndex = 6
        Me.lblInfoTambahan.Text = "Info lain"
        '
        'btnTutupKartu
        '
        Me.btnTutupKartu.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTutupKartu.Location = New System.Drawing.Point(29, 411)
        Me.btnTutupKartu.Name = "btnTutupKartu"
        Me.btnTutupKartu.Size = New System.Drawing.Size(75, 23)
        Me.btnTutupKartu.TabIndex = 7
        Me.btnTutupKartu.Text = "Tutup"
        Me.btnTutupKartu.UseVisualStyleBackColor = True
        '
        'btnCetakKartu
        '
        Me.btnCetakKartu.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCetakKartu.Location = New System.Drawing.Point(273, 411)
        Me.btnCetakKartu.Name = "btnCetakKartu"
        Me.btnCetakKartu.Size = New System.Drawing.Size(75, 23)
        Me.btnCetakKartu.TabIndex = 8
        Me.btnCetakKartu.Text = "Cetak Kartu"
        Me.btnCetakKartu.UseVisualStyleBackColor = True
        '
        'FormKartu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(434, 511)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FormKartu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Kartu Komunitas"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblID As Label
    Friend WithEvents lblNama As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblHobby As Label
    Friend WithEvents lblKontak As Label
    Friend WithEvents lblDivisi As Label
    Friend WithEvents btnCetakKartu As Button
    Friend WithEvents btnTutupKartu As Button
    Friend WithEvents lblInfoTambahan As Label
End Class
