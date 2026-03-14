Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim open As New OpenFileDialog

        If open.ShowDialog = DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(open.FileName)
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim hobby As String = ""

        If CheckBox1.Checked Then hobby &= CheckBox1.Text & ", "
        If CheckBox2.Checked Then hobby &= CheckBox2.Text & ", "
        If CheckBox3.Checked Then hobby &= CheckBox3.Text & ", "
        If CheckBox4.Checked Then hobby &= CheckBox4.Text & ", "
        If CheckBox5.Checked Then hobby &= CheckBox5.Text & ", "
        If CheckBox6.Checked Then hobby &= CheckBox6.Text & ", "
        If CheckBox7.Checked Then hobby &= CheckBox7.Text & ", "
        If CheckBox8.Checked Then hobby &= CheckBox8.Text & ", "
        If CheckBox9.Checked Then hobby &= CheckBox9.Text & ", "
        If CheckBox10.Checked Then hobby &= CheckBox10.Text & ", "

        Dim jk As String = ""

        If RadioButton1.Checked Then
            jk = RadioButton1.Text
        ElseIf RadioButton2.Checked Then
            jk = RadioButton2.Text
        End If

        Form2.Label1.Text = TextBox1.Text
        Form2.Label2.Text = TextBox2.Text
        Form2.Label3.Text = DateTimePicker1.Text
        Form2.Label4.Text = TextBox3.Text
        Form2.Label5.Text = jk
        Form2.Label6.Text = hobby
        Form2.Label7.Text = TextBox4.Text

        Form2.PictureBox1.Image = PictureBox1.Image

        Form2.Show()

    End Sub

End Class