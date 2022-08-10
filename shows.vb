Public Class shows
    Private Sub shows_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PB1.BackColor = Color.Red 'display pictureboxes red by default
        PB2.BackColor = Color.Red
        PB3.BackColor = Color.Red
        PB4.BackColor = Color.Red
        PB5.BackColor = Color.Red
        PB6.BackColor = Color.Red
        PB7.BackColor = Color.Red
        PB8.BackColor = Color.Red
        PB9.BackColor = Color.Red
        PB10.BackColor = Color.Red
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim NewShow As ShowType
        Dim NoRec As Integer 'number of records


        NewShow.ShowName = TxtShowname.Text
        NewShow.ShowDate = DTShowDate.Value.ToString.Substring(0, 10)
        NewShow.ShowTime = txtTime.Text
        NewShow.Seats1 = False 'put pictureboxes equal to false by default
        NewShow.Seats2 = False
        NewShow.Seats3 = False
        NewShow.Seats4 = False
        NewShow.Seats5 = False
        NewShow.Seats6 = False
        NewShow.Seats7 = False
        NewShow.Seats8 = False
        NewShow.Seats9 = False
        NewShow.Seats10 = False
        Dim FileName As String = "Shows.dat" '.dat file assigned

        FileOpen(1, FileName, OpenMode.Random,,, Len(NewShow)) 'create file
        NoRec = LOF(1) / Len(NewShow) 'check size of record
        NewShow.ShowId = NoRec + 1
        FilePut(1, NewShow, NoRec + 1) 'add record into the file
        FileClose() 'close file
        TxtShowname.Text = "" 'clear both textboxes
        txtTime.Text = ""
    End Sub

    Private Sub txtTime_TextChanged(sender As Object, e As EventArgs) Handles txtTime.TextChanged

    End Sub





    Private Sub PB3_Click(sender As Object, e As EventArgs) Handles PB3.Click 'click events 

    End Sub

    Private Sub PB2_Click(sender As Object, e As EventArgs) Handles PB2.Click

    End Sub

    Private Sub PB1_Click(sender As Object, e As EventArgs) Handles PB1.Click

    End Sub

    Private Sub PB4_Click(sender As Object, e As EventArgs) Handles PB4.Click

    End Sub

    Private Sub PB5_Click(sender As Object, e As EventArgs) Handles PB5.Click

    End Sub

    Private Sub PB6_Click(sender As Object, e As EventArgs) Handles PB6.Click

    End Sub

    Private Sub PB7_Click(sender As Object, e As EventArgs) Handles PB7.Click

    End Sub

    Private Sub PB8_Click(sender As Object, e As EventArgs) Handles PB8.Click

    End Sub

    Private Sub PB9_Click(sender As Object, e As EventArgs) Handles PB9.Click

    End Sub

    Private Sub PB10_Click(sender As Object, e As EventArgs) Handles PB10.Click

    End Sub

    Private Sub DTShowDate_ValueChanged(sender As Object, e As EventArgs) Handles DTShowDate.ValueChanged

    End Sub

    Private Sub TxtShowname_TextChanged(sender As Object, e As EventArgs) Handles TxtShowname.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCustInfo.Click 'button click event
        Customerinfo.Show() 'open customer info form
    End Sub


End Class