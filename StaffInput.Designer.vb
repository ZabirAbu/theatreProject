<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StaffInput
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
        Me.grpInput = New System.Windows.Forms.GroupBox()
        Me.btnSignup = New System.Windows.Forms.Button()
        Me.txtNewPassword = New System.Windows.Forms.TextBox()
        Me.txtNewUsername = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.grpInput.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpInput
        '
        Me.grpInput.Controls.Add(Me.btnSignup)
        Me.grpInput.Controls.Add(Me.txtNewPassword)
        Me.grpInput.Controls.Add(Me.txtNewUsername)
        Me.grpInput.Controls.Add(Me.Label3)
        Me.grpInput.Controls.Add(Me.Label2)
        Me.grpInput.Controls.Add(Me.Label1)
        Me.grpInput.Location = New System.Drawing.Point(32, 21)
        Me.grpInput.Name = "grpInput"
        Me.grpInput.Size = New System.Drawing.Size(182, 209)
        Me.grpInput.TabIndex = 0
        Me.grpInput.TabStop = False
        Me.grpInput.Text = "Staff sign up"
        '
        'btnSignup
        '
        Me.btnSignup.Location = New System.Drawing.Point(59, 150)
        Me.btnSignup.Name = "btnSignup"
        Me.btnSignup.Size = New System.Drawing.Size(75, 23)
        Me.btnSignup.TabIndex = 11
        Me.btnSignup.Text = "Sign Up"
        Me.btnSignup.UseVisualStyleBackColor = True
        '
        'txtNewPassword
        '
        Me.txtNewPassword.Location = New System.Drawing.Point(45, 113)
        Me.txtNewPassword.Name = "txtNewPassword"
        Me.txtNewPassword.Size = New System.Drawing.Size(100, 20)
        Me.txtNewPassword.TabIndex = 10
        '
        'txtNewUsername
        '
        Me.txtNewUsername.Location = New System.Drawing.Point(45, 74)
        Me.txtNewUsername.Name = "txtNewUsername"
        Me.txtNewUsername.Size = New System.Drawing.Size(100, 20)
        Me.txtNewUsername.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(54, 97)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Enter password"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(53, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Enter username"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(41, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 20)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Staff Sign Up"
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnLogin.Location = New System.Drawing.Point(264, 34)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(75, 23)
        Me.btnLogin.TabIndex = 1
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'StaffInput
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(352, 295)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.grpInput)
        Me.Name = "StaffInput"
        Me.Text = "StaffInput"
        Me.grpInput.ResumeLayout(False)
        Me.grpInput.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpInput As GroupBox
    Friend WithEvents btnSignup As Button
    Friend WithEvents txtNewPassword As TextBox
    Friend WithEvents txtNewUsername As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnLogin As Button
End Class
