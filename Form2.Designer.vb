<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim Students_NameLabel As System.Windows.Forms.Label
        Dim ClassLabel As System.Windows.Forms.Label
        Dim TermLabel As System.Windows.Forms.Label
        Dim AgeLabel As System.Windows.Forms.Label
        Dim Students_LINLabel As System.Windows.Forms.Label
        Dim StatusLabel As System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me._grading_systemDataSet = New Kacherede_PS_Grading_System._grading_systemDataSet()
        Me.TestsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TestsTableAdapter = New Kacherede_PS_Grading_System._grading_systemDataSetTableAdapters.testsTableAdapter()
        Me.TableAdapterManager = New Kacherede_PS_Grading_System._grading_systemDataSetTableAdapters.TableAdapterManager()
        Me.Students_NameTextBox = New System.Windows.Forms.TextBox()
        Me.ClassTextBox = New System.Windows.Forms.TextBox()
        Me.TermTextBox = New System.Windows.Forms.TextBox()
        Me.AgeTextBox = New System.Windows.Forms.TextBox()
        Me.Students_LINTextBox = New System.Windows.Forms.TextBox()
        Me.StatusTextBox = New System.Windows.Forms.TextBox()
        Me.TestsDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button6 = New System.Windows.Forms.Button()
        Students_NameLabel = New System.Windows.Forms.Label()
        ClassLabel = New System.Windows.Forms.Label()
        TermLabel = New System.Windows.Forms.Label()
        AgeLabel = New System.Windows.Forms.Label()
        Students_LINLabel = New System.Windows.Forms.Label()
        StatusLabel = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._grading_systemDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TestsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TestsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Students_NameLabel
        '
        Students_NameLabel.AutoSize = True
        Students_NameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Students_NameLabel.Location = New System.Drawing.Point(202, 84)
        Students_NameLabel.Name = "Students_NameLabel"
        Students_NameLabel.Size = New System.Drawing.Size(124, 20)
        Students_NameLabel.TabIndex = 51
        Students_NameLabel.Text = "Students Name:"
        '
        'ClassLabel
        '
        ClassLabel.AutoSize = True
        ClassLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ClassLabel.Location = New System.Drawing.Point(202, 116)
        ClassLabel.Name = "ClassLabel"
        ClassLabel.Size = New System.Drawing.Size(52, 20)
        ClassLabel.TabIndex = 53
        ClassLabel.Text = "Class:"
        '
        'TermLabel
        '
        TermLabel.AutoSize = True
        TermLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TermLabel.Location = New System.Drawing.Point(202, 151)
        TermLabel.Name = "TermLabel"
        TermLabel.Size = New System.Drawing.Size(49, 20)
        TermLabel.TabIndex = 55
        TermLabel.Text = "Term:"
        '
        'AgeLabel
        '
        AgeLabel.AutoSize = True
        AgeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AgeLabel.Location = New System.Drawing.Point(590, 84)
        AgeLabel.Name = "AgeLabel"
        AgeLabel.Size = New System.Drawing.Size(42, 20)
        AgeLabel.TabIndex = 57
        AgeLabel.Text = "Age:"
        '
        'Students_LINLabel
        '
        Students_LINLabel.AutoSize = True
        Students_LINLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Students_LINLabel.Location = New System.Drawing.Point(590, 113)
        Students_LINLabel.Name = "Students_LINLabel"
        Students_LINLabel.Size = New System.Drawing.Size(107, 20)
        Students_LINLabel.TabIndex = 59
        Students_LINLabel.Text = "Students LIN:"
        '
        'StatusLabel
        '
        StatusLabel.AutoSize = True
        StatusLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        StatusLabel.Location = New System.Drawing.Point(590, 145)
        StatusLabel.Name = "StatusLabel"
        StatusLabel.Size = New System.Drawing.Size(60, 20)
        StatusLabel.TabIndex = 61
        StatusLabel.Text = "Status:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(119, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(722, 36)
        Me.Label1.TabIndex = 47
        Me.Label1.Text = "KACHEREDE P/S ENROLMENT FORM FOR TESTS"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.Button6)
        Me.GroupBox1.Controls.Add(Me.Button5)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(-1, 84)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(197, 415)
        Me.GroupBox1.TabIndex = 50
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "More Options"
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(9, 142)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(179, 31)
        Me.Button5.TabIndex = 7
        Me.Button5.Text = "NEW"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(9, 284)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(179, 31)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "BACK"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(9, 209)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(179, 31)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "CLEAR"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(9, 67)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(179, 31)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "SAVE"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(9, 342)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(179, 31)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "EXIT"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Kacherede_PS_Grading_System.My.Resources.Resources.education_flat_icon_set_flyer_260nw_404364889
        Me.PictureBox1.Location = New System.Drawing.Point(19, 14)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(65, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 48
        Me.PictureBox1.TabStop = False
        '
        '_grading_systemDataSet
        '
        Me._grading_systemDataSet.DataSetName = "_grading_systemDataSet"
        Me._grading_systemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TestsBindingSource
        '
        Me.TestsBindingSource.DataMember = "tests"
        Me.TestsBindingSource.DataSource = Me._grading_systemDataSet
        '
        'TestsTableAdapter
        '
        Me.TestsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.final_gradingTableAdapter = Nothing
        Me.TableAdapterManager.finalTableAdapter = Nothing
        Me.TableAdapterManager.Tests_gradingTableAdapter = Nothing
        Me.TableAdapterManager.testsTableAdapter = Me.TestsTableAdapter
        Me.TableAdapterManager.UpdateOrder = Kacherede_PS_Grading_System._grading_systemDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Students_NameTextBox
        '
        Me.Students_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TestsBindingSource, "Students Name", True))
        Me.Students_NameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Students_NameTextBox.Location = New System.Drawing.Point(361, 78)
        Me.Students_NameTextBox.Name = "Students_NameTextBox"
        Me.Students_NameTextBox.Size = New System.Drawing.Size(223, 26)
        Me.Students_NameTextBox.TabIndex = 52
        '
        'ClassTextBox
        '
        Me.ClassTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TestsBindingSource, "Class", True))
        Me.ClassTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClassTextBox.Location = New System.Drawing.Point(361, 110)
        Me.ClassTextBox.Name = "ClassTextBox"
        Me.ClassTextBox.Size = New System.Drawing.Size(100, 26)
        Me.ClassTextBox.TabIndex = 54
        '
        'TermTextBox
        '
        Me.TermTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TestsBindingSource, "Term", True))
        Me.TermTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TermTextBox.Location = New System.Drawing.Point(361, 145)
        Me.TermTextBox.Name = "TermTextBox"
        Me.TermTextBox.Size = New System.Drawing.Size(100, 26)
        Me.TermTextBox.TabIndex = 56
        '
        'AgeTextBox
        '
        Me.AgeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TestsBindingSource, "Age", True))
        Me.AgeTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AgeTextBox.Location = New System.Drawing.Point(699, 78)
        Me.AgeTextBox.Name = "AgeTextBox"
        Me.AgeTextBox.Size = New System.Drawing.Size(150, 26)
        Me.AgeTextBox.TabIndex = 58
        '
        'Students_LINTextBox
        '
        Me.Students_LINTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TestsBindingSource, "Students LIN", True))
        Me.Students_LINTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Students_LINTextBox.Location = New System.Drawing.Point(699, 107)
        Me.Students_LINTextBox.Name = "Students_LINTextBox"
        Me.Students_LINTextBox.Size = New System.Drawing.Size(150, 26)
        Me.Students_LINTextBox.TabIndex = 60
        '
        'StatusTextBox
        '
        Me.StatusTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TestsBindingSource, "Status", True))
        Me.StatusTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusTextBox.Location = New System.Drawing.Point(699, 139)
        Me.StatusTextBox.Name = "StatusTextBox"
        Me.StatusTextBox.Size = New System.Drawing.Size(150, 26)
        Me.StatusTextBox.TabIndex = 62
        '
        'TestsDataGridView
        '
        Me.TestsDataGridView.AutoGenerateColumns = False
        Me.TestsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TestsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.TestsDataGridView.DataSource = Me.TestsBindingSource
        Me.TestsDataGridView.Location = New System.Drawing.Point(206, 191)
        Me.TestsDataGridView.Name = "TestsDataGridView"
        Me.TestsDataGridView.Size = New System.Drawing.Size(643, 308)
        Me.TestsDataGridView.TabIndex = 62
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Students Name"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Students Name"
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
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Age"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Age"
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
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Status"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Status"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'Button6
        '
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(6, 104)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(179, 31)
        Me.Button6.TabIndex = 8
        Me.Button6.Text = "EDIT"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(916, 488)
        Me.Controls.Add(Me.TestsDataGridView)
        Me.Controls.Add(Students_NameLabel)
        Me.Controls.Add(Me.Students_NameTextBox)
        Me.Controls.Add(ClassLabel)
        Me.Controls.Add(Me.ClassTextBox)
        Me.Controls.Add(TermLabel)
        Me.Controls.Add(Me.TermTextBox)
        Me.Controls.Add(AgeLabel)
        Me.Controls.Add(Me.AgeTextBox)
        Me.Controls.Add(Students_LINLabel)
        Me.Controls.Add(Me.Students_LINTextBox)
        Me.Controls.Add(StatusLabel)
        Me.Controls.Add(Me.StatusTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._grading_systemDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TestsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TestsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents _grading_systemDataSet As Kacherede_PS_Grading_System._grading_systemDataSet
    Friend WithEvents TestsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TestsTableAdapter As Kacherede_PS_Grading_System._grading_systemDataSetTableAdapters.testsTableAdapter
    Friend WithEvents TableAdapterManager As Kacherede_PS_Grading_System._grading_systemDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Students_NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ClassTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TermTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AgeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Students_LINTextBox As System.Windows.Forms.TextBox
    Friend WithEvents StatusTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents TestsDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button6 As System.Windows.Forms.Button
End Class
