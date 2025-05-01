Public Class enrolmentlist

    Private Sub TestsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TestsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me._grading_systemDataSet)

    End Sub

    Private Sub enrolmentlist_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_grading_systemDataSet.final' table. You can move, or remove it, as needed.
        Me.FinalTableAdapter.Fill(Me._grading_systemDataSet.final)
        'TODO: This line of code loads data into the '_grading_systemDataSet.tests' table. You can move, or remove it, as needed.
        Me.TestsTableAdapter.Fill(Me._grading_systemDataSet.tests)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        User_interface.Show()
        Me.Hide()
    End Sub
End Class