Public Class final_grading

    Private Sub Final_gradingBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Final_gradingBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Final_gradingBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me._grading_systemDataSet)

    End Sub

    Private Sub final_grading_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the '_grading_systemDataSet.final_grading' table. You can move, or remove it, as needed.
        Me.Final_gradingTableAdapter.Fill(Me._grading_systemDataSet.final_grading)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim eng, mat, sci, sst As Integer
        eng = EnglishTextBox.Text
        mat = MathsTextBox.Text
        sci = ScienseTextBox.Text
        sst = SSTTextBox.Text

        TotalTextBox.Text = (eng + mat + sci + sst)

        Me.Validate()
        Me.Final_gradingBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me._grading_systemDataSet)
        MsgBox("Submition successful")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim eb(9)
        eb(0) = (ebot.Text / 100) * 15
        eb(1) = (emot.Text / 100) * 15
        eb(2) = (eeot.Text / 100) * 30

        eb(3) = eb(0) + eb(1) + eb(2)
        etotal.Text = eb(3)

        Dim mb(9)
        mb(0) = (mbot.Text / 100) * 15
        mb(1) = (mmot.Text / 100) * 15
        mb(2) = (meot.Text / 100) * 30

        mb(3) = mb(0) + mb(1) + mb(2)
        mtotal.Text = mb(3)

        Dim sb(9)
        sb(0) = (ssbot.Text / 100) * 15
        sb(1) = (ssmot.Text / 100) * 15
        sb(2) = (sseot.Text / 100) * 30

        sb(3) = sb(0) + sb(1) + sb(2)
        sstotal.Text = sb(3)

        Dim scb(9)
        scb(0) = (scbot.Text / 100) * 15
        scb(1) = (scmot.Text / 100) * 15
        scb(2) = (sceot.Text / 100) * 30

        scb(3) = scb(0) + scb(1) + scb(2)
        sctotal.Text = scb(3)

        Dim engtotal
        engtotal = egrade.Text
        If eb(3) < 39 Then
            egrade.Text = "F9"
        ElseIf eb(3) < 45 Then
            egrade.Text = "P8"
        ElseIf eb(3) < 50 Then
            egrade.Text = "P7"
        ElseIf eb(3) < 55 Then
            egrade.Text = "C6"
        ElseIf eb(3) < 60 Then
            egrade.Text = "C5"
        ElseIf eb(3) < 65 Then
            egrade.Text = "C4"
        ElseIf eb(3) < 70 Then
            egrade.Text = "C3"
        ElseIf eb(3) < 75 Then
            egrade.Text = "D2"
        Else
            egrade.Text = "D1"
        End If

        Dim mathtotal
        mathtotal = mgrade
        If mb(3) < 39 Then
            mgrade.Text = "F9"
        ElseIf mb(3) < 45 Then
            mgrade.Text = "P8"
        ElseIf mb(3) < 50 Then
            mgrade.Text = "P7"
        ElseIf mb(3) < 55 Then
            mgrade.Text = "C6"
        ElseIf mb(3) < 60 Then
            mgrade.Text = "C5"
        ElseIf mb(3) < 65 Then
            mgrade.Text = "C4"
        ElseIf mb(3) < 70 Then
            mgrade.Text = "C3"
        ElseIf mb(3) < 75 Then
            mgrade.Text = "D2"
        Else
            mgrade.Text = "D1"

        End If

        Dim ssttotal
        ssttotal = ssgrade
        If sb(3) < 39 Then
            ssgrade.Text = "F9"
        ElseIf sb(3) < 45 Then
            ssgrade.Text = "P8"
        ElseIf sb(3) < 50 Then
            ssgrade.Text = "P7"
        ElseIf sb(3) < 55 Then
            ssgrade.Text = "C6"
        ElseIf sb(3) < 60 Then
            ssgrade.Text = "C5"
        ElseIf sb(3) < 65 Then
            ssgrade.Text = "C4"
        ElseIf sb(3) < 70 Then
            ssgrade.Text = "C3"
        ElseIf sb(3) < 75 Then
            ssgrade.Text = "D2"
        Else
            ssgrade.Text = "D1"
        End If

        Dim scietotal
        scietotal = scgrade
        If scb(3) < 39 Then
            scgrade.Text = "F9"
        ElseIf scb(3) < 45 Then
            scgrade.Text = "P8"
        ElseIf scb(3) < 50 Then
            scgrade.Text = "P7"
        ElseIf scb(3) < 55 Then
            scgrade.Text = "C6"
        ElseIf scb(3) < 60 Then
            scgrade.Text = "C5"
        ElseIf scb(3) < 65 Then
            scgrade.Text = "C4"
        ElseIf scb(3) < 70 Then
            scgrade.Text = "C3"
        ElseIf scb(3) < 75 Then
            scgrade.Text = "D2"
        Else
            scgrade.Text = "D1"
        End If
        Dim totalcomment
        totalcomment = general
        If scb(3) + sb(3) + mb(3) + eb(3) < 150 Then
            general.Text = "Poor Performance"
        ElseIf scb(3) + sb(3) + mb(3) + eb(3) < 200 Then
            general.Text = "Fair Performance"
        ElseIf scb(3) + sb(3) + mb(3) + eb(3) < 330 Then
            general.Text = "Good Performance"
        Else
            general.Text = "Hard Working"
        End If
    End Sub

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        ebot.Text = ""
        ComboBox1.Text = ""
        ComboBox2.Text = ""
        TextBox1.Text = ""
        mbot.Text = ""
        ssbot.Text = ""
        scbot.Text = ""
        emot.Text = ""
        mmot.Text = ""
        ssmot.Text = ""
        scmot.Text = ""
        eeot.Text = ""
        meot.Text = ""
        sseot.Text = ""
        sceot.Text = ""
        sctotal.Text = ""
        sstotal.Text = ""
        mtotal.Text = ""
        etotal.Text = ""
        scgrade.Text = ""
        ssgrade.Text = ""
        mgrade.Text = ""
        egrade.Text = ""
        general.Text = ""
        Students_NameTextBox.Text = ""
        ClassTextBox.Text = ""
        TermTextBox.Text = ""
        EnglishTextBox.Text = ""
        MathsTextBox.Text = ""
        SSTTextBox.Text = ""
        ScienseTextBox.Text = ""
        TotalTextBox.Text = ""
        CommentTextBox.Text = ""
    End Sub

    Private Sub btncontinue_Click(sender As Object, e As EventArgs) Handles btncontinue.Click
        Final_gradingBindingSource.AddNew()
    End Sub

    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        Dim iquit As DialogResult
        iquit = MessageBox.Show("Are you sure you want to exit", "Kacherede P/S grading system", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning)
        If iquit = DialogResult.Yes Then
            Application.Exit()
        ElseIf iquit = DialogResult.Cancel Then
            Application.Restart()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Home.Show()
        Me.Hide()
    End Sub
End Class