Public Class Signin

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim username As String
        Dim pasword As String
        username = email.Text
        pasword = password.Text
        If username = ("Admin") And pasword = ("1234567") Then
            Home.Show()
            Me.Hide()
        ElseIf username = ("user") And pasword = ("user") Then
            User_interface.Show()
            Me.Hide()
        Else
            MessageBox.Show("Please enter a correct User name and Password!", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
            If MessageBoxButtons.RetryCancel Then
                Application.Restart()
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim iquit As DialogResult
        iquit = MessageBox.Show("Confirm to exit this application", "Kacherede P/S login form", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
        If iquit = DialogResult.Yes Then
            Application.Exit()
        ElseIf iquit = DialogResult.Cancel Then
            Application.Restart()

        End If
    End Sub

    Private Sub showpassword_CheckedChanged(sender As Object, e As EventArgs) Handles showpassword.CheckedChanged
        If password.UseSystemPasswordChar = True Then
            password.UseSystemPasswordChar = False
        Else
            password.UseSystemPasswordChar = True
        End If
    End Sub
End Class
