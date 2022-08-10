<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cancel
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSearchID = New System.Windows.Forms.Button()
        Me.txtSearchID = New System.Windows.Forms.TextBox()
        Me.btnStaffpage = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(75, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CustomerID"
        '
        'btnSearchID
        '
        Me.btnSearchID.Location = New System.Drawing.Point(62, 147)
        Me.btnSearchID.Name = "btnSearchID"
        Me.btnSearchID.Size = New System.Drawing.Size(75, 23)
        Me.btnSearchID.TabIndex = 1
        Me.btnSearchID.Text = "Search"
        Me.btnSearchID.UseVisualStyleBackColor = True
        '
        'txtSearchID
        '
        Me.txtSearchID.Location = New System.Drawing.Point(53, 87)
        Me.txtSearchID.Name = "txtSearchID"
        Me.txtSearchID.Size = New System.Drawing.Size(100, 20)
        Me.txtSearchID.TabIndex = 2
        '
        'btnStaffpage
        '
        Me.btnStaffpage.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnStaffpage.Location = New System.Drawing.Point(201, 117)
        Me.btnStaffpage.Name = "btnStaffpage"
        Me.btnStaffpage.Size = New System.Drawing.Size(75, 23)
        Me.btnStaffpage.TabIndex = 3
        Me.btnStaffpage.Text = "Back"
        Me.btnStaffpage.UseVisualStyleBackColor = False
        '
        'cancel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(318, 313)
        Me.Controls.Add(Me.btnStaffpage)
        Me.Controls.Add(Me.txtSearchID)
        Me.Controls.Add(Me.btnSearchID)
        Me.Controls.Add(Me.Label1)
        Me.Name = "cancel"
        Me.Text = "cancel"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnSearchID As Button
    Friend WithEvents txtSearchID As TextBox
    Friend WithEvents btnStaffpage As Button
End Class
