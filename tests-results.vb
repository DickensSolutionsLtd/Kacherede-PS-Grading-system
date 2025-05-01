Public Class tests_results

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        User_interface.Show()
        Me.Hide()
    End Sub

    Private Sub TestsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)

    End Sub




    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Signin.Show()
        Me.Hide()
    End Sub

    Private Sub Tests_gradingBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TestsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me._grading_systemDataSet)
    End Sub

    Private Sub tests_results_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_grading_systemDataSet.Tests_grading' table. You can move, or remove it, as needed.
        Me.Tests_gradingTableAdapter.Fill(Me._grading_systemDataSet.Tests_grading)
        'TODO: This line of code loads data into the '_grading_systemDataSet.tests' table. You can move, or remove it, as needed.
        Me.TestsTableAdapter.Fill(Me._grading_systemDataSet.tests)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TestsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me._grading_systemDataSet)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim iquit As DialogResult
        iquit = MessageBox.Show("Are you sure you want to exit", "Kacherede P/S grading system", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning)
        If iquit = DialogResult.Yes Then
            User_interface.Show()
            Me.Hide()
        End If
    End Sub
End Class