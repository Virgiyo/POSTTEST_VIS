Public Class Form1

    Sub TampilkanBuku()

        DataGridView1.Rows.Clear()

        For i As Integer = 0 To jumlahBuku - 1

            Dim data() As String = daftarBuku(i).Split("|")

            DataGridView1.Rows.Add(data(0), data(1))

        Next

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        TambahBuku(TextBox1.Text, TextBox2.Text)

        TampilkanBuku()

        TextBox1.Clear()
        TextBox2.Clear()

    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim judul As String = TextBox3.Text

        HapusBuku(judul)

        TampilkanBuku()

        TextBox3.Clear()

    End Sub

End Class