<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Signin
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
        Me.showpassword = New System.Windows.Forms.CheckBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.password = New System.Windows.Forms.TextBox()
        Me.email = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'showpassword
        '
        Me.showpassword.AutoSize = True
        Me.showpassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.showpassword.Location = New System.Drawing.Point(364, 250)
        Me.showpassword.Name = "showpassword"
        Me.showpassword.Size = New System.Drawing.Size(141, 24)
        Me.showpassword.TabIndex = 14
        Me.showpassword.Text = "Show Password"
        Me.showpassword.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Red
        Me.Button2.Location = New System.Drawing.Point(485, 296)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(131, 44)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Aqua
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.DialogResult = System.Windows.Forms.DialogResult.Yes
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Blue
        Me.Button1.FlatAppearance.BorderSize = 5
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Blue
        Me.Button1.Location = New System.Drawing.Point(254, 296)
        Me.Button1.Margin = New System.Windows.Forms.Padding(5)
        Me.Button1.Name = "Button1"
        Me.Button1.Padding = New System.Windows.Forms.Padding(2, 2, 2, 3)
        Me.Button1.Size = New System.Drawing.Size(126, 44)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Login"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'password
        '
        Me.password.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.password.Location = New System.Drawing.Point(382, 187)
        Me.password.Name = "password"
        Me.password.Size = New System.Drawing.Size(232, 26)
        Me.password.TabIndex = 9
        Me.password.UseSystemPasswordChar = True
        '
        'email
        '
        Me.email.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.email.Location = New System.Drawing.Point(382, 129)
        Me.email.Name = "email"
        Me.email.Size = New System.Drawing.Size(232, 26)
        Me.email.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(250, 193)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 20)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Password:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(250, 132)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "User Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(314, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(149, 20)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Sign-in to continue.."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Rockwell Extra Bold", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(31, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(650, 22)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "KACHEREDE PRIMARY SCHOOL DIGITAL GRADING SYSTEM"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Kacherede_PS_Grading_System.My.Resources.Resources._272354
        Me.PictureBox1.Location = New System.Drawing.Point(35, 49)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(170, 262)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        '
        'Signin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(693, 362)
        Me.Controls.Add(Me.showpassword)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.password)
        Me.Controls.Add(Me.email)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Signin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Signin interface"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents showpassword As System.Windows.Forms.CheckBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents password As System.Windows.Forms.TextBox
    Friend WithEvents email As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
