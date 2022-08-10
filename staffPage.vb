Public Class staffPage
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        shows.Show() 'take user to show form
        Me.Hide() 'hide staffPage form
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        cancel.Show() 'show user the cancel form
        Me.Hide() 'hide staffPage form
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ticketInfo.Show() 'show user the ticketInfo form
        Me.Hide() 'hide staffPage form
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Customerinfo.Show() 'show user the customerinfo form
        Me.Hide() 'hide staffPage form
    End Sub
End Class