Public Class cancel
    Dim NoRec As Integer
    Private Sub btnSearchID_Click(sender As Object, e As EventArgs) Handles btnSearchID.Click
        FileOpen(4, "booking.txt", OpenMode.Random,,, Len(NewBooking)) 'open the file in random access mode
        NoRec = LOF(4) / Len(NewBooking) 'calculate number of records in the file
        For x = 1 To NoRec 'loop through the file
            FileGet(4, NewBooking, x) 'read one record at once
            If NewBooking.CustomerID.Trim = txtSearchID.Text.Trim Then 'if recordID matches searchId
                NewBooking.CustomerID = "del" 'mark the record as deleted
                NewBooking.CustomerName = "del" 'mark the record as deleted
                NewBooking.ShowName = "del" 'mark the record as deleted
                NewBooking.ShowDate = "del" 'mark the record as deleted
                NewBooking.ShowTime = "del" 'mark the record as deleted
                FilePut(4, NewBooking, x) 'input te changes on the file
                Exit For 'close loop
            End If
        Next x 'if not found go to the next record
        FileClose(4) 'close the file
    End Sub

    Private Sub btnStaffpage_Click(sender As Object, e As EventArgs) Handles btnStaffpage.Click
        staffPage.Show() ''open staff page form
    End Sub
End Class