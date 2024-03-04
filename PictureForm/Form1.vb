Public Class Form1
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Exit()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim newForm As New Form2() ' Assuming "NewForm" is the name of your new form
        newForm.Show()

    End Sub

    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles Me.Resize

        If Me.WindowState = FormWindowState.Maximized Then

            Me.BackColor = Color.Red
        Else

            Me.BackColor = SystemColors.Control
        End If
    End Sub
End Class

