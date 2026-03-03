Public Class Form1

    Dim listIP As New List(Of Double)

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ip As Double

        If Double.TryParse(TextBox1.Text, ip) Then
            listIP.Add(ip)

            Dim rata As Double = listIP.Average()
            Label3.Text = rata.ToString("0.00")

            If rata <= 2.75 Then
                Label4.Text = "Ihh Bukan Orang Dalam (Cukup)"
            ElseIf rata <= 3.0 Then
                Label4.Text = "Kenalan?? (Memuaskan)"
            Else
                Label4.Text = "Aura Orang Dalamnya Sangat Kuat!! (Sangat Memuaskan)"
            End If

            TextBox1.Clear()
        Else
            MessageBox.Show("Masukkan angka yang valid!")
        End If
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        listIP.Clear()
        Label3.Text = "0"
        Label4.Text = "-"
        TextBox1.Clear()
    End Sub

End Class
