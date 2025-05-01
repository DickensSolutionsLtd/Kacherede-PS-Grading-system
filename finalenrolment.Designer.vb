<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class finalenrolment
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Student_s_NameLabel As System.Windows.Forms.Label
        Dim ClassLabel As System.Windows.Forms.Label
        Dim TermLabel As System.Windows.Forms.Label
        Dim GenderLabel As System.Windows.Forms.Label
        Dim Students_LINLabel As System.Windows.Forms.Label
        Dim Registration_NoLabel As System.Windows.Forms.Label
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me._grading_systemDataSet1 = New Kacherede_PS_Grading_System._grading_systemDataSet()
        Me.FinalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FinalTableAdapter1 = New Kacherede_PS_Grading_System._grading_systemDataSetTableAdapters.finalTableAdapter()
        Me.TableAdapterManager1 = New Kacherede_PS_Grading_System._grading_systemDataSetTableAdapters.TableAdapterManager()
        Me.Student_s_NameTextBox = New System.Windows.Forms.TextBox()
        Me.ClassTextBox = New System.Windows.Forms.TextBox()
        Me.TermTextBox = New System.Windows.Forms.TextBox()
        Me.GenderTextBox = New System.Windows.Forms.TextBox()
        Me.Students_LINTextBox = New System.Windows.Forms.TextBox()
        Me.Registration_NoTextBox = New System.Windows.Forms.TextBox()
        Me.FinalDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Student_s_NameLabel = New System.Windows.Forms.Label()
        ClassLabel = New System.Windows.Forms.Label()
        TermLabel = New System.Windows.Forms.Label()
        GenderLabel = New System.Windows.Forms.Label()
        Students_LINLabel = New System.Windows.Forms.Label()
        Registration_NoLabel = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._grading_systemDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FinalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FinalDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Student_s_NameLabel
        '
        Student_s_NameLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Student_s_NameLabel.AutoSize = True
        Student_s_NameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Student_s_NameLabel.Location = New System.Drawing.Point(109, 79)
        Student_s_NameLabel.Name = "Student_s_NameLabel"
        Student_s_NameLabel.Size = New System.Drawing.Size(127, 20)
        Student_s_NameLabel.TabIndex = 10
        Student_s_NameLabel.Text = "Student's Name:"
        '
        'ClassLabel
        '
        ClassLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ClassLabel.AutoSize = True
        ClassLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ClassLabel.Location = New System.Drawing.Point(109, 111)
        ClassLabel.Name = "ClassLabel"
        ClassLabel.Size = New System.Drawing.Size(52, 20)
        ClassLabel.TabIndex = 12
        ClassLabel.Text = "Class:"
        '
        'TermLabel
        '
        TermLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        TermLabel.AutoSize = True
        TermLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TermLabel.Location = New System.Drawing.Point(109, 147)
        TermLabel.Name = "TermLabel"
        TermLabel.Size = New System.Drawing.Size(49, 20)
        TermLabel.TabIndex = 14
        TermLabel.Text = "Term:"
        '
        'GenderLabel
        '
        GenderLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        GenderLabel.AutoSize = True
        GenderLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        GenderLabel.Location = New System.Drawing.Point(647, 76)
        GenderLabel.Name = "GenderLabel"
        GenderLabel.Size = New System.Drawing.Size(67, 20)
        GenderLabel.TabIndex = 16
        GenderLabel.Text = "Gender:"
        '
        'Students_LINLabel
        '
        Students_LINLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Students_LINLabel.AutoSize = True
        Students_LINLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Students_LINLabel.Location = New System.Drawing.Point(647, 108)
        Students_LINLabel.Name = "Students_LINLabel"
        Students_LINLabel.Size = New System.Drawing.Size(107, 20)
        Students_LINLabel.TabIndex = 18
        Students_LINLabel.Text = "Students LIN:"
        '
        'Registration_NoLabel
        '
        Registration_NoLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Registration_NoLabel.AutoSize = True
        Registration_NoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Registration_NoLabel.Location = New System.Drawing.Point(647, 138)
        Registration_NoLabel.Name = "Registration_NoLabel"
        Registration_NoLabel.Size = New System.Drawing.Size(123, 20)
        Registration_NoLabel.TabIndex = 20
        Registration_NoLabel.Text = "Registration No:"
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(38, 262)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(182, 29)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "DELETE STUDENT"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(38, 214)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(182, 29)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "EXIT"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(38, 118)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(182, 29)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "CLEAR"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(38, 167)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(182, 29)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "BACK"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.Button6)
        Me.GroupBox1.Controls.Add(Me.Button5)
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Location = New System.Drawing.Point(674, 170)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(255, 303)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        '
        'Button6
        '
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(38, 67)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(182, 29)
        Me.Button6.TabIndex = 8
        Me.Button6.Text = "NEW"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(38, 19)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(182, 29)
        Me.Button5.TabIndex = 7
        Me.Button5.Text = "SAVE"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Image = Global.Kacherede_PS_Grading_System.My.Resources.Resources.graduation_exam_color_icon_final_examination_exams_successful_graduation_obtaining_diploma_professional_development_214497096
        Me.PictureBox1.Location = New System.Drawing.Point(12, 25)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(83, 54)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(141, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(661, 29)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "KACHEREDE P/S ENROLMENT FORM FOR FINAL EXAMS"
        '
        '_grading_systemDataSet1
        '
        Me._grading_systemDataSet1.DataSetName = "_grading_systemDataSet"
        Me._grading_systemDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FinalBindingSource
        '
        Me.FinalBindingSource.DataMember = "final"
        Me.FinalBindingSource.DataSource = Me._grading_systemDataSet1
        '
        'FinalTableAdapter1
        '
        Me.FinalTableAdapter1.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.final_gradingTableAdapter = Nothing
        Me.TableAdapterManager1.finalTableAdapter = Me.FinalTableAdapter1
        Me.TableAdapterManager1.Tests_gradingTableAdapter = Nothing
        Me.TableAdapterManager1.testsTableAdapter = Nothing
        Me.TableAdapterManager1.UpdateOrder = Kacherede_PS_Grading_System._grading_systemDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Student_s_NameTextBox
        '
        Me.Student_s_NameTextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Student_s_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FinalBindingSource, "Student's Name", True))
        Me.Student_s_NameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Student_s_NameTextBox.Location = New System.Drawing.Point(242, 76)
        Me.Student_s_NameTextBox.Name = "Student_s_NameTextBox"
        Me.Student_s_NameTextBox.Size = New System.Drawing.Size(373, 26)
        Me.Student_s_NameTextBox.TabIndex = 11
        '
        'ClassTextBox
        '
        Me.ClassTextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ClassTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FinalBindingSource, "Class", True))
        Me.ClassTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClassTextBox.Location = New System.Drawing.Point(242, 108)
        Me.ClassTextBox.Name = "ClassTextBox"
        Me.ClassTextBox.Size = New System.Drawing.Size(155, 26)
        Me.ClassTextBox.TabIndex = 13
        '
        'TermTextBox
        '
        Me.TermTextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TermTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FinalBindingSource, "Term", True))
        Me.TermTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TermTextBox.Location = New System.Drawing.Point(242, 144)
        Me.TermTextBox.Name = "TermTextBox"
        Me.TermTextBox.Size = New System.Drawing.Size(155, 26)
        Me.TermTextBox.TabIndex = 15
        '
        'GenderTextBox
        '
        Me.GenderTextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GenderTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FinalBindingSource, "Gender", True))
        Me.GenderTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GenderTextBox.Location = New System.Drawing.Point(774, 76)
        Me.GenderTextBox.Name = "GenderTextBox"
        Me.GenderTextBox.Size = New System.Drawing.Size(127, 26)
        Me.GenderTextBox.TabIndex = 17
        '
        'Students_LINTextBox
        '
        Me.Students_LINTextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Students_LINTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FinalBindingSource, "Students LIN", True))
        Me.Students_LINTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Students_LINTextBox.Location = New System.Drawing.Point(774, 108)
        Me.Students_LINTextBox.Name = "Students_LINTextBox"
        Me.Students_LINTextBox.Size = New System.Drawing.Size(127, 26)
        Me.Students_LINTextBox.TabIndex = 19
        '
        'Registration_NoTextBox
        '
        Me.Registration_NoTextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Registration_NoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FinalBindingSource, "Registration No", True))
        Me.Registration_NoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Registration_NoTextBox.Location = New System.Drawing.Point(774, 138)
        Me.Registration_NoTextBox.Name = "Registration_NoTextBox"
        Me.Registration_NoTextBox.Size = New System.Drawing.Size(127, 26)
        Me.Registration_NoTextBox.TabIndex = 21
        '
        'FinalDataGridView
        '
        Me.FinalDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FinalDataGridView.AutoGenerateColumns = False
        Me.FinalDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.FinalDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.FinalDataGridView.DataSource = Me.FinalBindingSource
        Me.FinalDataGridView.Location = New System.Drawing.Point(12, 176)
        Me.FinalDataGridView.Name = "FinalDataGridView"
        Me.FinalDataGridView.Size = New System.Drawing.Size(639, 307)
        Me.FinalDataGridView.TabIndex = 21
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Student's Name"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Student's Name"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Class"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Class"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Term"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Term"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Gender"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Gender"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Students LIN"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Students LIN"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Registration No"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Registration No"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'finalenrolment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(949, 503)
        Me.Controls.Add(Me.FinalDataGridView)
        Me.Controls.Add(Student_s_NameLabel)
        Me.Controls.Add(Me.Student_s_NameTextBox)
        Me.Controls.Add(ClassLabel)
        Me.Controls.Add(Me.ClassTextBox)
        Me.Controls.Add(TermLabel)
        Me.Controls.Add(Me.TermTextBox)
        Me.Controls.Add(GenderLabel)
        Me.Controls.Add(Me.GenderTextBox)
        Me.Controls.Add(Students_LINLabel)
        Me.Controls.Add(Me.Students_LINTextBox)
        Me.Controls.Add(Registration_NoLabel)
        Me.Controls.Add(Me.Registration_NoTextBox)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "finalenrolment"
        Me.Text = "finalenrolment"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._grading_systemDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FinalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FinalDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents _grading_systemDataSet As Kacherede_PS_Grading_System._grading_systemDataSet
    Friend WithEvents FinalTableAdapter As Kacherede_PS_Grading_System._grading_systemDataSetTableAdapters.finalTableAdapter
    Friend WithEvents TableAdapterManager As Kacherede_PS_Grading_System._grading_systemDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents _grading_systemDataSet1 As Kacherede_PS_Grading_System._grading_systemDataSet
    Friend WithEvents FinalBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FinalTableAdapter1 As Kacherede_PS_Grading_System._grading_systemDataSetTableAdapters.finalTableAdapter
    Friend WithEvents TableAdapterManager1 As Kacherede_PS_Grading_System._grading_systemDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Student_s_NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ClassTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TermTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GenderTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Students_LINTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Registration_NoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FinalDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
