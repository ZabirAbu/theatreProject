Public Class StaffInput
    Dim numberofrecords As Integer 'this is the number of records currently stored in file
    Private Sub btnSignup_Click(sender As Object, e As EventArgs) Handles btnSignup.Click
        staff.username = txtNewUsername.Text
        staff.password = txtNewPassword.Text
        FileOpen(1, "staff.txt", OpenMode.Random, , , Len(staff))
        FilePut(1, staff, numberofrecords + 1)
        txtNewUsername.Text = "" 'clear input for next new username 
        txtNewPassword.Text = "" 'clear input for next new passport
        txtNewUsername.Focus() 'focus method used to point cursor to username textbox for next input
    End Sub

    Private Sub StaffInput_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FileOpen(1, "staff.txt", OpenMode.Random, , , Len(staff)) 'create file
        numberofrecords = LOF(1) / Len(staff) 'check length of record
        FileClose(1) 'close file
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        frmHome.Show() 'open login form
    End Sub
End Class