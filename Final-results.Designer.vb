<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Final_results
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me._grading_systemDataSet = New Kacherede_PS_Grading_System._grading_systemDataSet()
        Me.FinalBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.FinalTableAdapter1 = New Kacherede_PS_Grading_System._grading_systemDataSetTableAdapters.finalTableAdapter()
        Me.TableAdapterManager1 = New Kacherede_PS_Grading_System._grading_systemDataSetTableAdapters.TableAdapterManager()
        Me.Final_gradingBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Final_gradingTableAdapter = New Kacherede_PS_Grading_System._grading_systemDataSetTableAdapters.final_gradingTableAdapter()
        Me.Final_gradingDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._grading_systemDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FinalBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Final_gradingBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Final_gradingDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(273, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(345, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "FINAL EXAMS RESULTS"
        '
        'Button1
        '
        Me.Button1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(397, 405)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(158, 32)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "QUIT"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Image = Global.Kacherede_PS_Grading_System.My.Resources.Resources._9913576
        Me.PictureBox1.Location = New System.Drawing.Point(12, 28)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        '_grading_systemDataSet
        '
        Me._grading_systemDataSet.DataSetName = "_grading_systemDataSet"
        Me._grading_systemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FinalBindingSource1
        '
        Me.FinalBindingSource1.DataMember = "final"
        Me.FinalBindingSource1.DataSource = Me._grading_systemDataSet
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
        'Final_gradingBindingSource
        '
        Me.Final_gradingBindingSource.DataMember = "final grading"
        Me.Final_gradingBindingSource.DataSource = Me._grading_systemDataSet
        '
        'Final_gradingTableAdapter
        '
        Me.Final_gradingTableAdapter.ClearBeforeFill = True
        '
        'Final_gradingDataGridView
        '
        Me.Final_gradingDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Final_gradingDataGridView.AutoGenerateColumns = False
        Me.Final_gradingDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Final_gradingDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Final_gradingDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Final_gradingDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9})
        Me.Final_gradingDataGridView.Cursor = System.Windows.Forms.Cursors.No
        Me.Final_gradingDataGridView.DataSource = Me.Final_gradingBindingSource
        Me.Final_gradingDataGridView.GridColor = System.Drawing.Color.DarkKhaki
        Me.Final_gradingDataGridView.Location = New System.Drawing.Point(12, 84)
        Me.Final_gradingDataGridView.Name = "Final_gradingDataGridView"
        Me.Final_gradingDataGridView.Size = New System.Drawing.Size(946, 307)
        Me.Final_gradingDataGridView.TabIndex = 11
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
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "English"
        Me.DataGridViewTextBoxColumn4.HeaderText = "English"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Maths"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Maths"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "SST"
        Me.DataGridViewTextBoxColumn6.HeaderText = "SST"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Sciense"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Sciense"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Total"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Total"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Comment"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Comment"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'Final_results
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(970, 449)
        Me.Controls.Add(Me.Final_gradingDataGridView)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Final_results"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Final_results"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._grading_systemDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FinalBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Final_gradingBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Final_gradingDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents _grading_systemDataSet As Kacherede_PS_Grading_System._grading_systemDataSet
    Friend WithEvents FinalBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents FinalTableAdapter1 As Kacherede_PS_Grading_System._grading_systemDataSetTableAdapters.finalTableAdapter
    Friend WithEvents TableAdapterManager1 As Kacherede_PS_Grading_System._grading_systemDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Final_gradingBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Final_gradingTableAdapter As Kacherede_PS_Grading_System._grading_systemDataSetTableAdapters.final_gradingTableAdapter
    Friend WithEvents Final_gradingDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
