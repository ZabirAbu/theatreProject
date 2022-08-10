Public Class booking
    Dim SeatChosen(10) As Integer
    Dim NoRec As Integer 'number of records currently stored in file
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        NewBooking.CustomerName = TxtCustomer.Text
        NewBooking.ShowName = txtShowname.Text
        NewBooking.ShowDate = DTShowDate.Value.ToString.Substring(0, 10)
        NewBooking.CustomerID = txtCustomerID.Text

        NewBooking.SeatNo1 = SeatChosen(0)
        NewBooking.SeatNo2 = SeatChosen(1)
        NewBooking.SeatNo3 = SeatChosen(2)
        NewBooking.SeatNo4 = SeatChosen(3)
        NewBooking.SeatNo5 = SeatChosen(4)
        NewBooking.SeatNo6 = SeatChosen(5)
        NewBooking.SeatNo7 = SeatChosen(6)
        NewBooking.SeatNo8 = SeatChosen(7)
        NewBooking.SeatNo9 = SeatChosen(8)
        NewBooking.SeatNo10 = SeatChosen(9)
        NewBooking.ShowTime = TxtShowTime.Text
        Dim Filename As String = "booking.txt"  'file will be found in bin folder

        FileOpen(2, Filename, OpenMode.Random,,, Len(NewBooking)) 'create file
        Dim NoRec As Integer = LOF(2) / Len(NewBooking)
        'checks length to say how many records are in the file _'
        'for the next file to be saved'

        FilePut(2, NewBooking, NoRec + 1) 'add a record in the file
        FileClose(2) 'close file

        Dim OneShow As ShowType
        FileOpen(1, "Shows.dat", OpenMode.Random,,, Len(OneShow)) 'open .dat file to retrieve information
        Dim NoofRec As Integer = LOF(1) / Len(OneShow) 'checks length To say how many records are In the file'
        For x = 1 To NoofRec 'beginning of for loop
            FileGet(1, OneShow, x)
            If OneShow.ShowId = cmbshowId.SelectedItem Then 'start of if statement
                If PB1.BackColor = Color.ForestGreen Then
                    OneShow.Seats1 = True
                Else    'else statement if first criteria isn't met
                    OneShow.Seats1 = False
                End If 'end of if statement to close loop

                If PB2.BackColor = Color.ForestGreen Then

                    OneShow.Seats2 = True
                Else
                    OneShow.Seats2 = False
                End If
                If PB3.BackColor = Color.ForestGreen Then
                    OneShow.Seats3 = True
                Else

                    OneShow.Seats3 = False
                End If
                If PB4.BackColor = Color.ForestGreen Then
                    OneShow.Seats4 = True
                Else
                    OneShow.Seats4 = False
                End If
                If PB5.BackColor = Color.ForestGreen Then
                    OneShow.Seats5 = True
                Else
                    OneShow.Seats5 = False
                End If
                If PB6.BackColor = Color.ForestGreen Then
                    OneShow.Seats6 = True
                Else
                    OneShow.Seats6 = False
                End If
                If PB7.BackColor = Color.ForestGreen Then
                    OneShow.Seats7 = True
                Else
                    OneShow.Seats7 = False
                End If
                If PB8.BackColor = Color.ForestGreen Then
                    OneShow.Seats8 = True
                Else
                    OneShow.Seats8 = False
                End If
                If PB9.BackColor = Color.ForestGreen Then
                    OneShow.Seats9 = True
                Else
                    OneShow.Seats9 = False
                End If
                If PB10.BackColor = Color.ForestGreen Then
                    OneShow.Seats10 = True
                Else
                    OneShow.Seats10 = False
                End If
                FilePut(1, OneShow)
                Exit For
            End If 'overall end if statement
        Next
        FileClose()
    End Sub
    Private Sub PB1_Click(sender As Object, e As EventArgs) Handles PB1.Click
        SeatChosen(0) = 1
        PB1.BackColor = Color.ForestGreen 'display picturebox1 as green

    End Sub


    Private Sub PB2_Click(sender As Object, e As EventArgs) Handles PB2.Click
        SeatChosen(1) = 2
        PB2.BackColor = Color.ForestGreen 'display PB2 as green
    End Sub


    Private Sub PB3_Click(sender As Object, e As EventArgs) Handles PB3.Click
        SeatChosen(2) = 3
        PB3.BackColor = Color.ForestGreen 'display PB3 as green
    End Sub

    Private Sub PB4_Click(sender As Object, e As EventArgs) Handles PB4.Click
        SeatChosen(3) = 4
        PB4.BackColor = Color.ForestGreen 'display PB4 as green
    End Sub

    Private Sub PB5_Click(sender As Object, e As EventArgs) Handles PB5.Click
        SeatChosen(4) = 5
        PB5.BackColor = Color.ForestGreen 'display PB5 as green
    End Sub

    Private Sub PB6_Click(sender As Object, e As EventArgs) Handles PB6.Click
        SeatChosen(5) = 6
        PB6.BackColor = Color.ForestGreen 'display PB6 as green
    End Sub

    Private Sub PB7_Click(sender As Object, e As EventArgs) Handles PB7.Click
        SeatChosen(6) = 7
        PB7.BackColor = Color.ForestGreen 'display PB7 as green
    End Sub

    Private Sub PB8_Click(sender As Object, e As EventArgs) Handles PB8.Click
        SeatChosen(7) = 8
        PB8.BackColor = Color.ForestGreen 'display PB8 as green
    End Sub

    Private Sub PB9_Click(sender As Object, e As EventArgs) Handles PB9.Click
        SeatChosen(8) = 9
        PB9.BackColor = Color.ForestGreen 'display PB9 as green
    End Sub

    Private Sub PB10_Click(sender As Object, e As EventArgs) Handles PB10.Click
        SeatChosen(9) = 10
        PB10.BackColor = Color.ForestGreen 'display PB10 as green
    End Sub


    Private Sub Booking_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim OneShow As ShowType
        FileOpen(1, "Shows.dat", OpenMode.Random,,, Len(OneShow))
        Dim NoRec As Integer = LOF(1) / Len(OneShow)
        For x = 1 To NoRec
            FileGet(1, OneShow)
            cmbshowId.Items.Add(OneShow.ShowId)
        Next


        FileClose(1)
    End Sub

    Private Sub cmbshowId_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbshowId.SelectedIndexChanged
        Dim OneShow As ShowType
        FileOpen(1, "Shows.dat", OpenMode.Random,,, Len(OneShow))
        Dim NoRec As Integer = LOF(1) / Len(OneShow)
        For x = 1 To NoRec
            FileGet(1, OneShow, x)
            If OneShow.ShowId = cmbshowId.SelectedItem Then
                txtShowname.Text = OneShow.ShowName
                TxtShowTime.Text = OneShow.ShowTime
                If OneShow.Seats1 = False Then
                    PB1.BackColor = Color.Red
                Else
                    PB1.BackColor = Color.Green
                End If

                If OneShow.Seats2 = False Then
                    PB2.BackColor = Color.Red
                Else
                    PB2.BackColor = Color.Green
                End If
                If OneShow.Seats3 = False Then
                    PB3.BackColor = Color.Red
                Else
                    PB3.BackColor = Color.Green
                End If
                If OneShow.Seats4 = False Then
                    PB4.BackColor = Color.Red
                Else
                    PB4.BackColor = Color.Green
                End If

                If OneShow.Seats5 = False Then
                    PB5.BackColor = Color.Red
                Else
                    PB5.BackColor = Color.Green
                End If
                If OneShow.Seats6 = False Then
                    PB6.BackColor = Color.Red
                Else
                    PB6.BackColor = Color.Green
                End If
                If OneShow.Seats7 = False Then
                    PB7.BackColor = Color.Red
                Else
                    PB7.BackColor = Color.Green
                End If
                If OneShow.Seats8 = False Then
                    PB8.BackColor = Color.Red
                Else
                    PB8.BackColor = Color.Green
                End If
                If OneShow.Seats9 = False Then
                    PB9.BackColor = Color.Red
                Else
                    PB9.BackColor = Color.Green
                End If
                If OneShow.Seats10 = False Then
                    PB10.BackColor = Color.Red
                Else
                    PB10.BackColor = Color.Green
                End If
            End If
        Next
        FileClose(1)
    End Sub

    Private Sub btnStaffPage_Click(sender As Object, e As EventArgs) Handles btnStaffPage.Click
        Customerinfo.Show() 'open customerinfo form
    End Sub
End Class