Public Class Tests_grading

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim eng(9)
        eng(0) = (etest1.Text / 100) * 20
        eng(1) = (etest2.Text / 100) * 20
        eng(2) = (etest3.Text / 100) * 20
        eng(3) = (etest4.Text / 100) * 40

        eng(4) = eng(0) + eng(1) + eng(2) + eng(3)
        etotal.Text = eng(4)

        Dim mat(9)
        mat(0) = (mtest1.Text / 100) * 20
        mat(1) = (mtest2.Text / 100) * 20
        mat(2) = (mtest3.Text / 100) * 20
        mat(3) = (mtest4.Text / 100) * 40

        mat(4) = mat(0) + mat(1) + mat(2) + mat(3)
        mtotal.Text = mat(4)

        Dim soc(9)
        soc(0) = (sstest1.Text / 100) * 20
        soc(1) = (sstest2.Text / 100) * 20
        soc(2) = (sstest3.Text / 100) * 20
        soc(3) = (sstest4.Text / 100) * 40

        soc(4) = soc(0) + soc(1) + soc(2) + soc(3)
        sstotal.Text = soc(4)

        Dim sci(9)
        sci(0) = (sctest1.Text / 100) * 20
        sci(1) = (sctest2.Text / 100) * 20
        sci(2) = (sctest3.Text / 100) * 20
        sci(3) = (sctest4.Text / 100) * 40

        sci(4) = sci(0) + sci(1) + sci(2) + sci(3)
        sctotal.Text = sci(4)

        Dim engtotal
        engtotal = egrade
        If eng(4) < 39 Then
            egrade.Text = "F9"
        ElseIf eng(4) < 45 Then
            egrade.Text = "P8"
        ElseIf eng(4) < 50 Then
            egrade.Text = "P7"
        ElseIf eng(4) < 55 Then
            egrade.Text = "C6"
        ElseIf eng(4) < 60 Then
            egrade.Text = "C5"
        ElseIf eng(4) < 65 Then
            egrade.Text = "C4"
        ElseIf eng(4) < 70 Then
            egrade.Text = "C3"
        ElseIf eng(4) < 75 Then
            egrade.Text = "D2"
        Else
            egrade.Text = "D1"
        End If

        Dim mattotal
        mattotal = mgrade
        If mat(4) < 39 Then
            mgrade.Text = "F9"
        ElseIf mat(4) < 45 Then
            mgrade.Text = "P8"
        ElseIf mat(4) < 50 Then
            mgrade.Text = "P7"
        ElseIf mat(4) < 55 Then
            mgrade.Text = "C6"
        ElseIf mat(4) < 60 Then
            mgrade.Text = "C5"
        ElseIf mat(4) < 65 Then
            mgrade.Text = "C4"
        ElseIf mat(4) < 70 Then
            mgrade.Text = "C3"
        ElseIf mat(4) < 75 Then
            mgrade.Text = "D2"
        Else
            mgrade.Text = "D1"
        End If

        Dim ssttotal
        ssttotal = ssgrade
        If soc(4) < 39 Then
            ssgrade.Text = "F9"
        ElseIf soc(4) < 45 Then
            ssgrade.Text = "P8"
        ElseIf soc(4) < 50 Then
            ssgrade.Text = "P7"
        ElseIf soc(4) < 55 Then
            ssgrade.Text = "C6"
        ElseIf soc(4) < 60 Then
            ssgrade.Text = "C5"
        ElseIf soc(4) < 65 Then
            ssgrade.Text = "C4"
        ElseIf soc(4) < 70 Then
            ssgrade.Text = "C3"
        ElseIf soc(4) < 75 Then
            ssgrade.Text = "D2"
        Else
            ssgrade.Text = "D1"
        End If

        Dim scitotal
        scitotal = scgrade
        If sci(4) < 39 Then
            scgrade.Text = "F9"
        ElseIf sci(4) < 45 Then
            scgrade.Text = "P8"
        ElseIf sci(4) < 50 Then
            scgrade.Text = "P7"
        ElseIf sci(4) < 55 Then
            scgrade.Text = "C6"
        ElseIf sci(4) < 60 Then
            scgrade.Text = "C5"
        ElseIf sci(4) < 65 Then
            scgrade.Text = "C4"
        ElseIf sci(4) < 70 Then
            scgrade.Text = "C3"
        ElseIf sci(4) < 75 Then
            scgrade.Text = "D2"
        Else
            scgrade.Text = "D1"
        End If

        Dim totalcomment
        totalcomment = general
        If sci(4) + soc(4) + mat(4) + eng(4) < 250 Then
            general.Text = "Poor Performance"
        ElseIf sci(4) + soc(4) + mat(4) + eng(4) < 300 Then
            general.Text = "Fair Performance"
        ElseIf sci(4) + soc(4) + mat(4) + eng(4) < 370 Then
            general.Text = "Good Performance"
        Else
            general.Text = "Hard Working"
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        etest1.Text = ""
        etest2.Text = ""
        etest3.Text = ""
        etest4.Text = ""
        etotal.Text = ""
        egrade.Text = ""
        mtest1.Text = ""
        mtest2.Text = ""
        mtest3.Text = ""
        mtest4.Text = ""
        mtotal.Text = ""
        mgrade.Text = ""
        sstest1.Text = ""
        sstest2.Text = ""
        sstest3.Text = ""
        sstest4.Text = ""
        sstotal.Text = ""
        ssgrade.Text = ""
        sctest1.Text = ""
        sctest2.Text = ""
        sctest3.Text = ""
        sctest4.Text = ""
        sctotal.Text = ""
        scgrade.Text = ""
        general.Text = ""
        TextBox28.Text = ""
        Student_NameTextBox.Text = ""
        ClassTextBox.Text = ""
        TermTextBox.Text = ""
        EnglishTextBox.Text = ""
        MathsTextBox.Text = ""
        SSTTextBox.Text = ""
        ScienseTextBox.Text = ""
        Total_MarksTextBox.Text = ""
        CommentTextBox.Text = ""
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim iquit As DialogResult
        iquit = MessageBox.Show("Confirm to exit", "Kacherede p/s testes grading", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning)
        If iquit = DialogResult.Yes Then
            Home.Show()
            Me.Hide()

        End If
    End Sub

    Private Sub Tests_gradingBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Tests_gradingBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me._grading_systemDataSet)

    End Sub

    Private Sub Tests_grading_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_grading_systemDataSet.Tests_grading' table. You can move, or remove it, as needed.
        Me.Tests_gradingTableAdapter.Fill(Me._grading_systemDataSet.Tests_grading)

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Tests_gradingBindingSource.AddNew()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim en, ma, ss, sc As Integer
        en = EnglishTextBox.Text
        ma = MathsTextBox.Text
        ss = SSTTextBox.Text
        sc = ScienseTextBox.Text

        Total_MarksTextBox.Text = (en + ma + ss + sc)

        Me.Validate()
        Me.Tests_gradingBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me._grading_systemDataSet)
        MsgBox("Record Submition Successful")
    End Sub
End Class