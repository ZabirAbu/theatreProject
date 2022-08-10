Public Class ticketInfo
    Dim numRecords As Short 'number of records currently stored in file
    Dim Filename As String
    Dim MyFormat As String = "{0, -5}{1, -21}"

    Private Sub ticketInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load 'form load event
        FileOpen(1, "Products.txt", OpenMode.Random, , , Len(Products)) 'create textfile
        numRecords = LOF(1) / Len(Products) 'checks length to say how many records are in the file _'
        'for the next file to be saved'
        FileClose()
    End Sub


    Private Sub btnAddRecord_Click(sender As Object, e As EventArgs) Handles btnAddRecord.Click

        Products.ProductID = txtProductID.Text 'assign textbox to write product ID
        Products.Description = txtDescription.Text 'assign textbox to write any extra description
        Products.Price = txtPrice.Text 'assign textbox to write ticket price
        Products.QuantityInStock = txtQuantityInStock.Text 'assign textbox for ticket stock level
        Products.ReorderLevel = cboReoderLevel.Text 'assign textbox for restock tickets
        FileOpen(1, "Products.txt", OpenMode.Random, , , Len(Products)) 'open file
        FilePut(1, Products, numRecords + 1) 'write a record after the current one
        FileClose(1)
        numRecords += 1
        txtProductID.Text = "" 'clears texbox to make it user friendly
        txtDescription.Text = "" 'clears texbox 
        txtPrice.Text = "" 'clears texbox 
        txtQuantityInStock.Text = "" 'clears texbox to make it user friendly
        txtProductID.Focus()
    End Sub

    Private Sub btnDisplayFile_Click(sender As Object, e As EventArgs) Handles btnDisplayFile.Click
        Dim Index As Integer
        lstDisplayFile.Items.Clear()
        FileOpen(1, "Products.txt", OpenMode.Random, , , Len(Products)) 'open file
        For Index = 1 To numRecords
            FileGet(1, Products)
            lstDisplayFile.Items.Add(String.Format(MyFormat, Format(Products.Price, "currency"), Products.QuantityInStock, Products.ReorderLevel))
        Next Index
        FileClose(1)
    End Sub

    'create procedure DisplayProducts
    Private Sub DisplayProducts(ByVal Products As ProductType)
        lblProductID.Text = Products.ProductID 'display product id
        lblDescription.Text = Products.Description 'display product information
        lblPrice.Text = Products.Price 'display ticket price
        lblQuantityInStock.Text = Products.QuantityInStock 'display number of tickes in stock
        lblReorderLevel.Text = Products.ReorderLevel 'display the number of products in re-order level
    End Sub

    Private Sub btnFindRecord_Click(sender As Object, e As EventArgs) Handles btnFindRecord.Click
        Dim Recordnumber As Integer
        Dim Products As ProductType
        numRecords = txtSearchRecord.Text
        If (Recordnumber > 0) And (Recordnumber <= numRecords) Then
            FileOpen(1, "Products.txt", OpenMode.Random, , , Len(Products)) 'open file
            FileGet(1, Products, Recordnumber)
            Call DisplayProducts(Products) 'pass record as a parameter
            FileClose(1) 'close file
        Else
            MsgBox("Incorrect record number") 'display message box
        End If
    End Sub

    Private Sub btnStaffPage_Click(sender As Object, e As EventArgs) Handles btnStaffPage.Click
        staffPage.Show() 'open staffPage form
    End Sub
End Class


