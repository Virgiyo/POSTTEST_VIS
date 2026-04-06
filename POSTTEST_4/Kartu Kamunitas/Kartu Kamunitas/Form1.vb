Imports System.Text
Imports System.IO

Public Class FormUtama

    Private Sub FormUtama_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        mtTelepon.Mask = "0000-0000-0000"

        cboDivisi.Items.Add("Programming")
        cboDivisi.Items.Add("Design")
        cboDivisi.Items.Add("Marketing")
        cboDivisi.Items.Add("HRD")
        cboDivisi.Items.Add("Event Organizer")
        cboDivisi.Items.Add("Public Relation")
        cboDivisi.SelectedIndex = 0

        clbHobby.Items.Add("Membaca")
        clbHobby.Items.Add("Olahraga")
        clbHobby.Items.Add("Musik")
        clbHobby.Items.Add("Traveling")
        clbHobby.Items.Add("Photography")
        clbHobby.Items.Add("Coding")
        clbHobby.Items.Add("Gaming")
        clbHobby.Items.Add("Memasak")
    End Sub

    Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNama.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
            MessageBox.Show("Nama hanya boleh berisi huruf!", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub txtID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtID.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
            MessageBox.Show("ID Anggota hanya boleh berisi angka!", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub mtTelepon_KeyPress(sender As Object, e As KeyPressEventArgs) Handles mtTelepon.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
            MessageBox.Show("Nomor telepon hanya boleh berisi angka!", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Dim openDlg As New OpenFileDialog()
        openDlg.Filter = "File Gambar|.jpg;.jpeg;.png;.bmp"
        openDlg.Title = "Pilih Foto Profil"

        If openDlg.ShowDialog() = DialogResult.OK Then
            pbFoto.Image = Image.FromFile(openDlg.FileName)
            pbFoto.SizeMode = PictureBoxSizeMode.StretchImage
        End If
    End Sub


    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If txtNama.Text.Trim() = "" Then
            MessageBox.Show("Nama tidak boleh kosong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TabControl1.SelectedTab = TabDataUtama
            txtNama.Focus()
            Return
        End If

        If txtID.Text.Trim() = "" Then
            MessageBox.Show("ID Anggota tidak boleh kosong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TabControl1.SelectedTab = TabDataUtama
            txtID.Focus()
            Return
        End If

        If mtTelepon.Text.Trim() = "" OrElse mtTelepon.Text.Length < 12 Then
            MessageBox.Show("Nomor telepon tidak boleh kosong! Format: 08xx-xxxx-xxxx", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TabControl1.SelectedTab = TabKontak
            mtTelepon.Focus()
            Return
        End If

        If txtEmail.Text.Trim() = "" Then
            MessageBox.Show("Email tidak boleh kosong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TabControl1.SelectedTab = TabKontak
            txtEmail.Focus()
            Return
        End If

        If txtAlamat.Text.Trim() = "" Then
            MessageBox.Show("Alamat tidak boleh kosong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TabControl1.SelectedTab = TabKontak
            txtAlamat.Focus()
            Return
        End If

        Dim hobbyDipilih As Boolean = False
        For Each item In clbHobby.CheckedItems
            hobbyDipilih = True
            Exit For
        Next

        If Not hobbyDipilih Then
            MessageBox.Show("Pilih minimal 1 hobby/aktivitas!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TabControl1.SelectedTab = TabProfil
            Return
        End If

        Dim konfirmasi = MessageBox.Show("Apakah Anda yakin ingin menyimpan data?", "Konfirmasi Simpan",
                                         MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If konfirmasi = DialogResult.Yes Then
            MessageBox.Show("Data berhasil disimpan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Dim kartuForm As New FormKartu(AmbilDataDariForm())
            kartuForm.ShowDialog()
        End If
    End Sub

    Private Sub btnCetak_Click(sender As Object, e As EventArgs) Handles btnCetak.Click
        btnSimpan_Click(sender, e)
    End Sub

    Private Function AmbilDataDariForm() As Dictionary(Of String, String)
        Dim data As New Dictionary(Of String, String)

        ' Data Utama
        data.Add("Nama", txtNama.Text)
        data.Add("ID", txtID.Text)
        data.Add("TanggalLahir", dtpLahir.Value.ToString("dd MMMM yyyy"))

        ' Jenis Kelamin
        Dim jk As String = ""
        If rbLaki.Checked Then jk = "Laki-laki"
        If rbPerempuan.Checked Then jk = "Perempuan"
        data.Add("JenisKelamin", jk)

        data.Add("Divisi", cboDivisi.SelectedItem.ToString())

        ' Kontak
        data.Add("Telepon", mtTelepon.Text)
        data.Add("Email", txtEmail.Text)
        data.Add("Alamat", txtAlamat.Text)

        ' Peran
        Dim peran As String = ""
        If rbKetua.Checked Then peran = "Ketua"
        If rbAnggota.Checked Then peran = "Anggota"
        If rbAdmin.Checked Then peran = "Admin"
        data.Add("Peran", peran)

        ' Hobby
        Dim hobbyList As String = ""
        For Each item In clbHobby.CheckedItems
            hobbyList += item.ToString() + ", "
        Next
        If hobbyList.EndsWith(", ") Then hobbyList = hobbyList.Substring(0, hobbyList.Length - 2)
        data.Add("Hobby", hobbyList)

        Return data
    End Function


    Private Sub InputDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InputDataToolStripMenuItem.Click
        TabControl1.SelectedTab = TabDataUtama
    End Sub

    ' Menu: Lihat Kartu
    Private Sub LihatKartuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LihatKartuToolStripMenuItem.Click
        If txtNama.Text.Trim() = "" Then
            MessageBox.Show("Isi data terlebih dahulu!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Dim kartuForm As New FormKartu(AmbilDataDariForm())
        kartuForm.ShowDialog()
    End Sub

    Private Sub SimpanDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SimpanDataToolStripMenuItem.Click
        Dim saveDlg As New SaveFileDialog()
        saveDlg.Filter = "File Teks|.txt|File CSV|.csv"
        saveDlg.Title = "Simpan Data Anggota"

        If saveDlg.ShowDialog() = DialogResult.OK Then
            Dim sb As New StringBuilder()
            Dim data = AmbilDataDariForm()

            For Each kvp As KeyValuePair(Of String, String) In data
                sb.AppendLine(kvp.Key & ": " & kvp.Value)
            Next

            File.WriteAllText(saveDlg.FileName, sb.ToString())
            MessageBox.Show("Data berhasil disimpan ke file!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub BukaDataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BukaDataToolStripMenuItem.Click
        Dim openDlg As New OpenFileDialog()
        openDlg.Filter = "File Teks|.txt|File CSV|.csv"
        openDlg.Title = "Buka Data Anggota"

        If openDlg.ShowDialog() = DialogResult.OK Then
            Dim isiFile As String = File.ReadAllText(openDlg.FileName)
            MessageBox.Show("File berhasil dibuka!" & vbCrLf & vbCrLf & "Isi file:" & vbCrLf & isiFile, "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub KeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem.Click
        Dim konfirmasi = MessageBox.Show("Apakah Anda yakin ingin keluar?", "Konfirmasi Keluar",
                                         MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If konfirmasi = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

End Class