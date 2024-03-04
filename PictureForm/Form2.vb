Public Class Form2
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim openFileDialog As New OpenFileDialog()


        openFileDialog.Title = "Select a File"
        openFileDialog.Filter = "All Files|*.*"
        openFileDialog.Multiselect = False


        If openFileDialog.ShowDialog() = DialogResult.OK Then

            Dim selectedFilePath As String = openFileDialog.FileName

            MessageBox.Show("Selected file: " & selectedFilePath)

            PictureBox1.Image = Image.FromFile(selectedFilePath)

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked Then
            Dim Garamond As New Font("Garamond", 12, FontStyle.Bold)
            TextBox1.Font = Garamond
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked Then
            Dim Magneto As New Font("Magneto", 12, FontStyle.Bold)
            TextBox1.Font = Magneto
        End If
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        If RadioButton3.Checked Then
            Dim Tahoma As New Font("Tahoma", 12, FontStyle.Bold)
            TextBox1.Font = Tahoma
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            Dim currentFont As Font = TextBox1.Font
            Dim ItalicFont As New Font(currentFont.FontFamily, currentFont.Size, FontStyle.Italic)
            TextBox1.Font = ItalicFont

        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked Then
            Dim currentFont As Font = TextBox1.Font
            Dim BoldFont As New Font(currentFont.FontFamily, currentFont.Size, FontStyle.Bold)
            TextBox1.Font = BoldFont
        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked Then
            Dim currentFont As Font = TextBox1.Font
            Dim ItalicBoldFont As New Font(currentFont.FontFamily, currentFont.Size, FontStyle.Italic Or FontStyle.Bold
                                       )
            TextBox1.Font = ItalicBoldFont
        End If
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        If RadioButton4.Checked Then
            TextBox1.ForeColor = Color.Green
        End If
    End Sub

    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton5.CheckedChanged
        If RadioButton5.Checked Then
            TextBox1.ForeColor = Color.Blue
        End If
    End Sub

    Private Sub RadioButton6_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton6.CheckedChanged
        If RadioButton6.Checked Then
            TextBox1.ForeColor = Color.Red
        End If
    End Sub
End Class