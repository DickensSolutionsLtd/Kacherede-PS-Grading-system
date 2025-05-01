Public Class Splash

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        pgb.Minimum = 0
        pgb.Maximum = 100
        pgb.Value = pgb.Value + 1
        If pgb.Value = 100 Then
            Timer1.Enabled = False
        End If
        If pgb.Value = 10 Then
            Label2.Text = "Please Wait..."
        ElseIf pgb.Value = 30 Then
            Label2.Text = "Amoment..."
        ElseIf pgb.Value = 60 Then
            Label2.Text = "LOADING..."
        ElseIf pgb.Value = 100 Then
            Label2.Text = "Welcome"
            Signin.Show()
            Me.Hide()

        End If
    End Sub


End Class