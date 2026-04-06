Public Class FormKartu

    Private dataAnggota As Dictionary(Of String, String)

    ' Constructor (penerima data dari FormUtama)
    Public Sub New(ByVal data As Dictionary(Of String, String))
        InitializeComponent()
        dataAnggota = data
    End Sub

    ' Saat form kartu dimuat
    Private Sub FormKartu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Tampilkan data di label-label
        lblNama.Text = "Nama: " & dataAnggota("Nama")
        lblID.Text = "ID: " & dataAnggota("ID")
        lblDivisi.Text = "Divisi: " & dataAnggota("Divisi")
        lblKontak.Text = "Telepon: " & dataAnggota("Telepon") & vbCrLf & "Email: " & dataAnggota("Email")
        lblHobby.Text = "Hobby: " & dataAnggota("Hobby")
        lblInfoTambahan.Text = "Tgl Lahir: " & dataAnggota("TanggalLahir") & vbCrLf &
                               "JK: " & dataAnggota("JenisKelamin") & vbCrLf &
                               "Peran: " & dataAnggota("Peran") & vbCrLf &
                               "Alamat: " & dataAnggota("Alamat")
    End Sub

    ' Tombol Cetak Kartu
    Private Sub btnCetakKartu_Click(sender As Object, e As EventArgs) Handles btnCetakKartu.Click
        Dim konfirmasi = MessageBox.Show("Apakah Anda ingin mencetak kartu ini?", "Konfirmasi Cetak",
                                         MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If konfirmasi = DialogResult.Yes Then
            MessageBox.Show("Kartu sedang diproses untuk dicetak...", "Cetak Kartu", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    ' Tombol Tutup
    Private Sub btnTutupKartu_Click(sender As Object, e As EventArgs) Handles btnTutupKartu.Click
        Me.Close()
    End Sub

End Class