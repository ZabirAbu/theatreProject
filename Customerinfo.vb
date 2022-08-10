Public Class Customerinfo
    Dim numberofrecords As Integer

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click 'label created 

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnPrintID.Click
        Dim Firstname, Lastname, CustomerID, Postcode As String
        Firstname = txtFirstname.Text 'assign texbox to input customer's firstname
        Lastname = txtLastname.Text 'assign texbox to input customer's lastname
        Postcode = txtPostcode.Text 'assign texbox to input customer's postcode
        CustomerID = Firstname.Substring(0, 3) _ 'the program will take the first 3 letters of firstname
            & Lastname.Substring(0, 3) _ 'the program will take the first 3 letters of lastname 
            & Postcode.Substring(Postcode.Length - 3, 3) 'the program will take only the last 3 characters
        Label8.Text = CustomerID 'label will display a new CustomerID by combining the bits from firstname_
        'lastname and postcode
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        customers.CustomerID = txtCustomerID.Text
        customers.Firstname = txtFirstname.Text
        customers.Lastname = txtLastname.Text
        customers.Addressslineone = txtAddress1.Text 'assign texbox to input address line 1 of customer
        customers.Addressslinetwo = txtAddress2.Text 'address line 2
        FileOpen(1, "customer.txt", OpenMode.Random, , , Len(customers)) 'open file
        FilePut(1, customers, numberofrecords + 1) 'add customer details in a record
        txtCustomerID.Text = "" 'clear customerID for protecting customer's data privacy
        txtCustomerID.Focus()
        FileClose(1)


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        booking.Show() 'take user to booking form
        Me.Hide() 'hide customerInfo form
    End Sub
End Class