Imports System.IO

Public Class Form1

    Dim fotoPath As String = ""

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Isi ComboBox komunitas
        cmbKomunitas.Items.Add("Programmer")
        cmbKomunitas.Items.Add("Desain Grafis")
        cmbKomunitas.Items.Add("Mobile Developer")
        cmbKomunitas.Items.Add("Game Developer")
        cmbKomunitas.Items.Add("Multimedia")
        cmbKomunitas.Items.Add("Cyber Security")

        cmbKomunitas.SelectedIndex = -1

        ' Format nomor telepon
        mtxtTelepon.Mask = "0000-0000-00000"

        ' Supaya PictureBox rapi
        picFoto.SizeMode = PictureBoxSizeMode.StretchImage

        ' Default tanggal
        dtpLahir.Value = Date.Now
    End Sub

    ' =========================
    ' VALIDASI INPUT
    ' =========================

    Private Function ValidasiInput() As Boolean
        If TxtNama.Text.Trim = "" Then
            MessageBox.Show("Inputan tidak boleh kosong: Nama", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            TxtNama.Focus()
            Return False
        End If

        If txtID.Text.Trim = "" Then
            MessageBox.Show("Inputan tidak boleh kosong: ID Anggota", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtID.Focus()
            Return False
        End If

        If txtUmur.Text.Trim = "" Then
            MessageBox.Show("Inputan tidak boleh kosong: Umur", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtUmur.Focus()
            Return False
        End If

        If Not IsNumeric(txtUmur.Text) Then
            MessageBox.Show("Umur hanya boleh angka", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtUmur.Focus()
            Return False
        End If

        If Not rdoLaki.Checked And Not rdoPerempuan.Checked Then
            MessageBox.Show("Inputan tidak boleh kosong: Jenis Kelamin", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        If cmbKomunitas.SelectedIndex = -1 Then
            MessageBox.Show("Inputan tidak boleh kosong: Jenis Komunitas", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cmbKomunitas.Focus()
            Return False
        End If

        If Not mtxtTelepon.MaskCompleted Then
            MessageBox.Show("Nomor telepon harus sesuai format", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            mtxtTelepon.Focus()
            Return False
        End If

        If txtEmail.Text.Trim = "" Then
            MessageBox.Show("Inputan tidak boleh kosong: Email", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtEmail.Focus()
            Return False
        End If

        If txtAlamat.Text.Trim = "" Then
            MessageBox.Show("Inputan tidak boleh kosong: Alamat", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtAlamat.Focus()
            Return False
        End If

        If fotoPath = "" Then
            MessageBox.Show("Inputan tidak boleh kosong: Foto Profil", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        If Not rdoKetua.Checked And Not rdoAdmin.Checked And Not rdoAnggota.Checked And Not rdoKoordinator.Checked Then
            MessageBox.Show("Inputan tidak boleh kosong: Peran", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        If GetHobi() = "" Then
            MessageBox.Show("Inputan tidak boleh kosong: Pilih minimal 1 hobby/aktivitas", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        Return True
    End Function

    Private Function GetJenisKelamin() As String
        If rdoLaki.Checked Then
            Return "Laki-Laki"
        ElseIf rdoPerempuan.Checked Then
            Return "Perempuan"
        Else
            Return ""
        End If
    End Function

    Private Function GetPeran() As String
        If rdoKetua.Checked Then
            Return "Ketua"
        ElseIf rdoAdmin.Checked Then
            Return "Admin"
        ElseIf rdoAnggota.Checked Then
            Return "Anggota"
        ElseIf rdoKoordinator.Checked Then
            Return "Koordinator"
        Else
            Return ""
        End If
    End Function

    Private Function GetHobi() As String
        Dim hobi As String = ""

        If chkCoding.Checked Then hobi &= "Coding, "
        If chkDesain.Checked Then hobi &= "Desain, "
        If chkEditing.Checked Then hobi &= "Editing, "
        If chkGaming.Checked Then hobi &= "Gaming, "
        If chkMusik.Checked Then hobi &= "Musik, "
        If chkOlahraga.Checked Then hobi &= "Olahraga, "
        If chkFotografi.Checked Then hobi &= "Fotografi, "
        If chkMenulis.Checked Then hobi &= "Menulis, "

        If hobi <> "" Then
            hobi = hobi.Substring(0, hobi.Length - 2)
        End If

        Return hobi
    End Function

    ' =========================
    ' BATASI INPUT
    ' =========================

    ' Nama hanya huruf
    Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtNama.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not Char.IsWhiteSpace(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    ' Umur hanya angka
    Private Sub txtUmur_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUmur.KeyPress
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    ' ID bisa bebas, tapi kalau mau angka saja tinggal aktifkan ini:
    'Private Sub txtID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtID.KeyPress
    '    If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
    '        e.Handled = True
    '    End If
    'End Sub

    ' =========================
    ' BROWSE FOTO
    ' =========================

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Dim ofd As New OpenFileDialog
        ofd.Filter = "File Gambar|*.jpg;*.jpeg;*.png;*.bmp"

        If ofd.ShowDialog = DialogResult.OK Then
            fotoPath = ofd.FileName
            picFoto.Image = Image.FromFile(fotoPath)
        End If
    End Sub

    ' =========================
    ' LIHAT KARTU
    ' =========================

    Private Sub TampilkanKartu()
        If ValidasiInput() = False Then Exit Sub

        Form2.lblNama.Text = "Nama : " & TxtNama.Text
        Form2.lblID.Text = "ID : " & txtID.Text
        Form2.lblKomunitas.Text = "Komunitas : " & cmbKomunitas.Text
        Form2.lblKontak.Text = "Kontak : " & mtxtTelepon.Text
        Form2.lblHobi.Text = "Hobby : " & GetHobi()
        Form2.lblPeran.Text = "Peran : " & GetPeran()

        If picFoto.Image IsNot Nothing Then
            Form2.picKartuFoto.Image = picFoto.Image
            Form2.picKartuFoto.SizeMode = PictureBoxSizeMode.StretchImage
        End If

        Form2.Show()
        Form2.BringToFront()
    End Sub

    ' =========================
    ' SIMPAN DATA KE FILE TXT
    ' =========================

    Private Sub SimpanData()
        If ValidasiInput() = False Then Exit Sub

        Dim tanya As DialogResult
        tanya = MessageBox.Show("Apakah data ingin disimpan?", "Konfirmasi Simpan", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If tanya = DialogResult.Yes Then
            Dim sfd As New SaveFileDialog
            sfd.Filter = "Text File|*.txt|CSV File|*.csv"
            sfd.FileName = TxtNama.Text & "_kartu"

            If sfd.ShowDialog = DialogResult.OK Then
                Dim sw As New StreamWriter(sfd.FileName)

                sw.WriteLine(TxtNama.Text)
                sw.WriteLine(txtID.Text)
                sw.WriteLine(txtUmur.Text)
                sw.WriteLine(dtpLahir.Value.ToShortDateString)
                sw.WriteLine(GetJenisKelamin())
                sw.WriteLine(cmbKomunitas.Text)
                sw.WriteLine(mtxtTelepon.Text)
                sw.WriteLine(txtEmail.Text)
                sw.WriteLine(txtAlamat.Text)
                sw.WriteLine(GetPeran())
                sw.WriteLine(GetHobi())
                sw.WriteLine(fotoPath)

                sw.Close()

                MessageBox.Show("Data berhasil disimpan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    ' =========================
    ' BUKA DATA DARI FILE TXT
    ' =========================

    Private Sub BukaData()
        Dim ofd As New OpenFileDialog
        ofd.Filter = "Text File|*.txt|CSV File|*.csv"

        If ofd.ShowDialog = DialogResult.OK Then
            Dim sr As New StreamReader(ofd.FileName)

            TxtNama.Text = sr.ReadLine()
            txtID.Text = sr.ReadLine()
            txtUmur.Text = sr.ReadLine()
            dtpLahir.Value = Convert.ToDateTime(sr.ReadLine())

            Dim jk As String = sr.ReadLine()
            If jk = "Laki-Laki" Then
                rdoLaki.Checked = True
            ElseIf jk = "Perempuan" Then
                rdoPerempuan.Checked = True
            End If

            cmbKomunitas.Text = sr.ReadLine()
            mtxtTelepon.Text = sr.ReadLine()
            txtEmail.Text = sr.ReadLine()
            txtAlamat.Text = sr.ReadLine()

            Dim peran As String = sr.ReadLine()
            If peran = "Ketua" Then
                rdoKetua.Checked = True
            ElseIf peran = "Admin" Then
                rdoAdmin.Checked = True
            ElseIf peran = "Anggota" Then
                rdoAnggota.Checked = True
            ElseIf peran = "Koordinator" Then
                rdoKoordinator.Checked = True
            End If

            Dim hobi As String = sr.ReadLine()

            chkCoding.Checked = hobi.Contains("Coding")
            chkDesain.Checked = hobi.Contains("Desain")
            chkEditing.Checked = hobi.Contains("Editing")
            chkGaming.Checked = hobi.Contains("Gaming")
            chkMusik.Checked = hobi.Contains("Musik")
            chkOlahraga.Checked = hobi.Contains("Olahraga")
            chkFotografi.Checked = hobi.Contains("Fotografi")
            chkMenulis.Checked = hobi.Contains("Menulis")

            fotoPath = sr.ReadLine()

            If File.Exists(fotoPath) Then
                picFoto.Image = Image.FromFile(fotoPath)
            End If

            sr.Close()

            MessageBox.Show("Data berhasil dibuka!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    ' =========================
    ' BUTTON SIMPAN & CETAK
    ' =========================

    Private Sub btnSimpanCetak_Click(sender As Object, e As EventArgs) Handles mnuSimpan.Click
        If ValidasiInput() = False Then Exit Sub

        Dim cetak As DialogResult
        cetak = MessageBox.Show("Apakah ingin menampilkan kartu anggota?", "Konfirmasi Cetak", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If cetak = DialogResult.Yes Then
            TampilkanKartu()
        End If
    End Sub

    ' =========================
    ' MENUSTRIP
    ' =========================

    Private Sub mnuInput_Click(sender As Object, e As EventArgs) Handles mnuInput.Click
        TabControl1.SelectedTab = TabPage1
    End Sub

    Private Sub mnuSimpan_Click(sender As Object, e As EventArgs) Handles mnuSimpan.Click
        SimpanData()
    End Sub

End Class
