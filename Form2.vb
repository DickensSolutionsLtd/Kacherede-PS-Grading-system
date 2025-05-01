Public Class Form2

    Private Sub TestsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TestsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me._grading_systemDataSet)

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_grading_systemDataSet.tests' table. You can move, or remove it, as needed.
        Me.TestsTableAdapter.Fill(Me._grading_systemDataSet.tests)
        'TODO: This line of code loads data into the '_grading_systemDataSet.tests' table. You can move, or remove it, as needed.
        Me.TestsTableAdapter.Fill(Me._grading_systemDataSet.tests)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Validate()
        Me.TestsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me._grading_systemDataSet)
        MsgBox("Added Succesfully!")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Students_NameTextBox.Text = ""
        ClassTextBox.Text = ""
        TermTextBox.Text = ""
        AgeTextBox.Text = ""
        Students_LINTextBox.Text = ""
        StatusTextBox.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Home.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim iquit As DialogResult
        iquit = MessageBox.Show("Do you want to exit Tests Enrolment page", "Kacherede p/s Grading System", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If iquit = DialogResult.Yes Then
            Home.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TestsBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TestsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me._grading_systemDataSet)

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TestsBindingSource.AddNew()
    End Sub

End Class