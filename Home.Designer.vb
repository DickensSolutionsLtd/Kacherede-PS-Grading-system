<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Home
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
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Final = New System.Windows.Forms.Button()
        Me.Tests = New System.Windows.Forms.Button()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Stencil", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(233, 335)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(157, 45)
        Me.Button4.TabIndex = 20
        Me.Button4.Text = "EXIT"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Rockwell Extra Bold", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(286, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 19)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "MENU"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(593, 21)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "WELCOME TO KACHEREDE P/S DIGITAL GRADING SYSTEM"
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Rockwell Condensed", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(449, 272)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(143, 27)
        Me.Button3.TabIndex = 14
        Me.Button3.Text = "ENROLL STUDENT"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Rockwell Condensed", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(233, 272)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(173, 27)
        Me.Button2.TabIndex = 15
        Me.Button2.Text = "FINAL EXAMS GRADING"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Rockwell Condensed", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(53, 272)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(131, 27)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "TESTS GRADING"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Final
        '
        Me.Final.Font = New System.Drawing.Font("Rockwell Condensed", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Final.Location = New System.Drawing.Point(424, 353)
        Me.Final.Name = "Final"
        Me.Final.Size = New System.Drawing.Size(168, 27)
        Me.Final.TabIndex = 23
        Me.Final.Text = "FOR FINAL EXAMS"
        Me.Final.UseVisualStyleBackColor = True
        Me.Final.Visible = False
        '
        'Tests
        '
        Me.Tests.Font = New System.Drawing.Font("Rockwell Condensed", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tests.Location = New System.Drawing.Point(424, 315)
        Me.Tests.Name = "Tests"
        Me.Tests.Size = New System.Drawing.Size(168, 27)
        Me.Tests.TabIndex = 24
        Me.Tests.Text = "FOR TESTS EXAMS"
        Me.Tests.UseVisualStyleBackColor = True
        Me.Tests.Visible = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.Kacherede_PS_Grading_System.My.Resources.Resources.open_enrollment_icon_in_logotype_vector
        Me.PictureBox3.Location = New System.Drawing.Point(449, 124)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(143, 142)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 17
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Kacherede_PS_Grading_System.My.Resources.Resources.exam_icon_with_black_design_isolated_on_white_background_vector
        Me.PictureBox2.Location = New System.Drawing.Point(233, 124)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(173, 142)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 18
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Kacherede_PS_Grading_System.My.Resources.Resources.job_exam_test_vector_icon_260nw_1500193907
        Me.PictureBox1.Location = New System.Drawing.Point(28, 124)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(184, 142)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 19
        Me.PictureBox1.TabStop = False
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(640, 386)
        Me.Controls.Add(Me.Final)
        Me.Controls.Add(Me.Tests)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Home"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Home"
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Final As System.Windows.Forms.Button
    Friend WithEvents Tests As System.Windows.Forms.Button
End Class
