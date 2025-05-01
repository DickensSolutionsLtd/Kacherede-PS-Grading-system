<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class enrolmentlist
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me._grading_systemDataSet = New Kacherede_PS_Grading_System._grading_systemDataSet()
        Me.TestsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TestsTableAdapter = New Kacherede_PS_Grading_System._grading_systemDataSetTableAdapters.testsTableAdapter()
        Me.TableAdapterManager = New Kacherede_PS_Grading_System._grading_systemDataSetTableAdapters.TableAdapterManager()
        Me.FinalTableAdapter = New Kacherede_PS_Grading_System._grading_systemDataSetTableAdapters.finalTableAdapter()
        Me.TestsDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FinalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FinalDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me._grading_systemDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TestsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TestsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FinalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FinalDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(832, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "KACHEREDE PRIMARY SCHOOL STUDENTS ENROLMENTS"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(281, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(240, 29)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "FOR TESTS EXAMS" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label3
        '
        Me.Label3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(294, 300)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(227, 29)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "FOR FINAL EXAMS" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
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
        Me.TableAdapterManager.finalTableAdapter = Me.FinalTableAdapter
        Me.TableAdapterManager.Tests_gradingTableAdapter = Nothing
        Me.TableAdapterManager.testsTableAdapter = Me.TestsTableAdapter
        Me.TableAdapterManager.UpdateOrder = Kacherede_PS_Grading_System._grading_systemDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'FinalTableAdapter
        '
        Me.FinalTableAdapter.ClearBeforeFill = True
        '
        'TestsDataGridView
        '
        Me.TestsDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TestsDataGridView.AutoGenerateColumns = False
        Me.TestsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TestsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.TestsDataGridView.DataSource = Me.TestsBindingSource
        Me.TestsDataGridView.Location = New System.Drawing.Point(92, 74)
        Me.TestsDataGridView.Name = "TestsDataGridView"
        Me.TestsDataGridView.Size = New System.Drawing.Size(645, 211)
        Me.TestsDataGridView.TabIndex = 4
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
        'FinalBindingSource
        '
        Me.FinalBindingSource.DataMember = "final"
        Me.FinalBindingSource.DataSource = Me._grading_systemDataSet
        '
        'FinalDataGridView
        '
        Me.FinalDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FinalDataGridView.AutoGenerateColumns = False
        Me.FinalDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.FinalDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12})
        Me.FinalDataGridView.DataSource = Me.FinalBindingSource
        Me.FinalDataGridView.Location = New System.Drawing.Point(92, 343)
        Me.FinalDataGridView.Name = "FinalDataGridView"
        Me.FinalDataGridView.Size = New System.Drawing.Size(645, 261)
        Me.FinalDataGridView.TabIndex = 5
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Student's Name"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Student's Name"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Class"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Class"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Term"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Term"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Gender"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Gender"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "Students LIN"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Students LIN"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "Registration No"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Registration No"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'Button1
        '
        Me.Button1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Cursor = System.Windows.Forms.Cursors.PanWest
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Blue
        Me.Button1.Location = New System.Drawing.Point(765, 571)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 33)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "<<Back"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'enrolmentlist
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(852, 619)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.FinalDataGridView)
        Me.Controls.Add(Me.TestsDataGridView)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "enrolmentlist"
        Me.Text = "enrolmentlist"
        CType(Me._grading_systemDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TestsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TestsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FinalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FinalDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents _grading_systemDataSet As Kacherede_PS_Grading_System._grading_systemDataSet
    Friend WithEvents TestsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TestsTableAdapter As Kacherede_PS_Grading_System._grading_systemDataSetTableAdapters.testsTableAdapter
    Friend WithEvents TableAdapterManager As Kacherede_PS_Grading_System._grading_systemDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TestsDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FinalTableAdapter As Kacherede_PS_Grading_System._grading_systemDataSetTableAdapters.finalTableAdapter
    Friend WithEvents FinalBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FinalDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
