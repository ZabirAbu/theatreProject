Public Class frmHome
    Dim Attempt As Integer = 1
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim found As Boolean '2 bytes of memory used
        Dim username As String '2 bytes per character
        Dim password As String
        Dim adminpage As New StaffInput
        Dim userpage As New staffPage
        username = txtUsername.Text.PadRight(6) 'this has to be the length of username  this field'
        password = txtPassword.Text.PadRight(6) 'this has to be the length of username  this field'
        found = False
        FileOpen(1, "staff.txt", OpenMode.Random, , , Len(staff)) 'open file
        Do Until EOF(1) Or (found = True)
            FileGet(1, staff)
            If staff.username = username And staff.password = password Then
                found = True
            End If
        Loop
        If found = True Then

            staffPage.Show() 'if username and password credentials are correct, show staffPage form
            Me.Hide() 'hide the current home form

        ElseIf Attempt = 3 Then
            MsgBox("maximum attempt reached, the program will now close")
            'when getting wrong login credentials in the form , messagox will display closure of system
            Close() 'close message box

        Else
            MsgBox("username and password incorrect, you reached attempt " & Attempt & "out of 3")
            Attempt = Attempt + 1 'first and second attempt to input correct login credentials
            txtUsername.Text = "" 'clear textbox 
            txtPassword.Text = "" 'clear textbox
            txtUsername.Focus() 'focus method used to put cursor in textboxread for next username to input
        End If
        FileClose(1) 'close file

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles cbShowPassword.CheckedChanged
        If cbShowPassword.Checked = True Then
            txtPassword.UseSystemPasswordChar = False
        Else 'when first statement doesn't match the requirements go to the next conditional statement
            txtPassword.UseSystemPasswordChar = True
        End If
    End Sub
End Class
