Public Class finalenrolment

    Private Sub FinalBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.FinalBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me._grading_systemDataSet)

    End Sub

    Private Sub finalenrolment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_grading_systemDataSet1.final' table. You can move, or remove it, as needed.
        Me.FinalTableAdapter1.Fill(Me._grading_systemDataSet1.final)
        'TODO: This line of code loads data into the '_grading_systemDataSet1.final' table. You can move, or remove it, as needed.
        Me.FinalTableAdapter1.Fill(Me._grading_systemDataSet1.final)
        'TODO: This line of code loads data into the '_grading_systemDataSet1.final' table. You can move, or remove it, as needed.
        'TODO: This line of code loads data into the '_grading_systemDataSet.final' table. You can move, or remove it, as needed.
        Me.FinalTableAdapter1.Fill(Me._grading_systemDataSet1.final)

    End Sub

    Private Sub Student_s_NameLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Registration_NoLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim iquit As DialogResult
        iquit = MessageBox.Show("Do you want to exit final Enrolment page", "Kacherede p/s Grading System", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If iquit = DialogResult.Yes Then
            Home.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Home.Show()
        Me.Hide()
    End Sub

    Private Sub FinalBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs)
        Me.Validate()
        Me.FinalBindingSource.EndEdit()
        Me.TableAdapterManager1.UpdateAll(Me._grading_systemDataSet1)

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Validate()
        Me.FinalBindingSource.EndEdit()
        Me.TableAdapterManager1.UpdateAll(Me._grading_systemDataSet1)
        MsgBox("Saved Successfully")
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        FinalBindingSource.AddNew()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        FinalBindingSource.RemoveCurrent()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Student_s_NameTextBox.Text = ""
        ClassTextBox.Text = ""
        TermTextBox.Text = ""
        GenderTextBox.Text = ""
        Students_LINTextBox.Text = ""
        Registration_NoTextBox.Text = ""
    End Sub
End Class