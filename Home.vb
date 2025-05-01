Public Class Home

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim iquit As DialogResult
        iquit = MessageBox.Show("Do you want to exit home page", "Kacherede p/s grading system home page", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
        If iquit = DialogResult.Yes Then
            Application.Exit()
        ElseIf iquit = DialogResult.Cancel Then
            Application.Restart()

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Tests_grading.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        final_grading.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Tests.Show()
        Final.Show()
        Button3.Hide()
    End Sub

    Private Sub Tests_Click(sender As Object, e As EventArgs) Handles Tests.Click
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub Final_Click(sender As Object, e As EventArgs) Handles Final.Click
        finalenrolment.Show()
        Me.Hide()
    End Sub
End Class