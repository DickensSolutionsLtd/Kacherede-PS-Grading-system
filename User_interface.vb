Public Class User_interface

    Private Sub enroled_Click(sender As Object, e As EventArgs) Handles enroled.Click
        enrolmentlist.Show()
        Me.Hide()
    End Sub

    Private Sub Final_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Final_results.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        tests_results.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click

    End Sub

    Private Sub Final_Click_1(sender As Object, e As EventArgs)
        finalenrolment.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim iquit As DialogResult
        iquit = MessageBox.Show("Confirm to exit this application", "Kacherede P/S login form", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
        If iquit = DialogResult.Yes Then
            Application.Exit()
        ElseIf iquit = DialogResult.Cancel Then
            Application.Restart()

        End If
    End Sub
End Class