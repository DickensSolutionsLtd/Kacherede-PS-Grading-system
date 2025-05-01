Public Class Final_results


    Private Sub Button2_Click_1(sender As Object, e As EventArgs)
        User_interface.Show()
        Me.Hide()
    End Sub

    Private Sub FinalBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()

    End Sub

    Private Sub Final_results_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_grading_systemDataSet.final_grading' table. You can move, or remove it, as needed.
        Me.Final_gradingTableAdapter.Fill(Me._grading_systemDataSet.final_grading)
        'TODO: This line of code loads data into the '_grading_systemDataSet.final' table. You can move, or remove it, as needed.
        Me.FinalTableAdapter1.Fill(Me._grading_systemDataSet.final)
        'TODO: This line of code loads data into the 'GradingDataSet.final' table. You can move, or remove it, as needed.

    End Sub

    Private Sub FinalDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Signin.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim iquit As DialogResult
        iquit = MessageBox.Show("Are you sure you want to exit", "Kacherede P/S grading system", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning)
        If iquit = DialogResult.Yes Then
            User_interface.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub FinalBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub FinalBindingNavigatorSaveItem_Click_2(sender As Object, e As EventArgs)

    End Sub
End Class