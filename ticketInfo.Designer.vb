<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ticketInfo
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnAddRecord = New System.Windows.Forms.Button()
        Me.cboReoderLevel = New System.Windows.Forms.ComboBox()
        Me.txtQuantityInStock = New System.Windows.Forms.TextBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.txtProductID = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lstDisplayFile = New System.Windows.Forms.ListBox()
        Me.btnDisplayFile = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblReorderLevel = New System.Windows.Forms.Label()
        Me.lblQuantityInStock = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.lblProductID = New System.Windows.Forms.Label()
        Me.txtSearchProduct = New System.Windows.Forms.TextBox()
        Me.btnFindProduct = New System.Windows.Forms.Button()
        Me.txtSearchRecord = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnFindRecord = New System.Windows.Forms.Button()
        Me.lblnumRecords = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnStaffPage = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.GroupBox1.Controls.Add(Me.btnAddRecord)
        Me.GroupBox1.Controls.Add(Me.cboReoderLevel)
        Me.GroupBox1.Controls.Add(Me.txtQuantityInStock)
        Me.GroupBox1.Controls.Add(Me.txtPrice)
        Me.GroupBox1.Controls.Add(Me.txtDescription)
        Me.GroupBox1.Controls.Add(Me.txtProductID)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(30, 21)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(363, 139)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Input"
        '
        'btnAddRecord
        '
        Me.btnAddRecord.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnAddRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddRecord.Location = New System.Drawing.Point(275, 93)
        Me.btnAddRecord.Name = "btnAddRecord"
        Me.btnAddRecord.Size = New System.Drawing.Size(75, 23)
        Me.btnAddRecord.TabIndex = 10
        Me.btnAddRecord.Text = "Add Record"
        Me.btnAddRecord.UseVisualStyleBackColor = False
        '
        'cboReoderLevel
        '
        Me.cboReoderLevel.FormattingEnabled = True
        Me.cboReoderLevel.Items.AddRange(New Object() {"10", "50", "100", "200", "50"})
        Me.cboReoderLevel.Location = New System.Drawing.Point(287, 66)
        Me.cboReoderLevel.Name = "cboReoderLevel"
        Me.cboReoderLevel.Size = New System.Drawing.Size(63, 21)
        Me.cboReoderLevel.TabIndex = 9
        '
        'txtQuantityInStock
        '
        Me.txtQuantityInStock.Location = New System.Drawing.Point(200, 64)
        Me.txtQuantityInStock.Name = "txtQuantityInStock"
        Me.txtQuantityInStock.Size = New System.Drawing.Size(35, 20)
        Me.txtQuantityInStock.TabIndex = 8
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(44, 58)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(100, 20)
        Me.txtPrice.TabIndex = 7
        '
        'txtDescription
        '
        Me.txtDescription.Location = New System.Drawing.Point(250, 23)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(100, 20)
        Me.txtDescription.TabIndex = 6
        '
        'txtProductID
        '
        Me.txtProductID.Location = New System.Drawing.Point(71, 20)
        Me.txtProductID.Name = "txtProductID"
        Me.txtProductID.Size = New System.Drawing.Size(100, 20)
        Me.txtProductID.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(241, 61)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 26)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Reorder " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "level"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(150, 58)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 26)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "No. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "in stock"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Price"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(184, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Detail"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ticket ID"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Plum
        Me.GroupBox2.Controls.Add(Me.lstDisplayFile)
        Me.GroupBox2.Controls.Add(Me.btnDisplayFile)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox2.Location = New System.Drawing.Point(30, 243)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(214, 143)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Display File"
        '
        'lstDisplayFile
        '
        Me.lstDisplayFile.FormattingEnabled = True
        Me.lstDisplayFile.Location = New System.Drawing.Point(6, 39)
        Me.lstDisplayFile.Name = "lstDisplayFile"
        Me.lstDisplayFile.Size = New System.Drawing.Size(120, 95)
        Me.lstDisplayFile.Sorted = True
        Me.lstDisplayFile.TabIndex = 1
        '
        'btnDisplayFile
        '
        Me.btnDisplayFile.BackColor = System.Drawing.Color.MediumOrchid
        Me.btnDisplayFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDisplayFile.Location = New System.Drawing.Point(108, 10)
        Me.btnDisplayFile.Name = "btnDisplayFile"
        Me.btnDisplayFile.Size = New System.Drawing.Size(83, 23)
        Me.btnDisplayFile.TabIndex = 0
        Me.btnDisplayFile.Text = "List Products"
        Me.btnDisplayFile.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.PaleVioletRed
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.lblReorderLevel)
        Me.GroupBox3.Controls.Add(Me.lblQuantityInStock)
        Me.GroupBox3.Controls.Add(Me.lblPrice)
        Me.GroupBox3.Controls.Add(Me.lblDescription)
        Me.GroupBox3.Controls.Add(Me.lblProductID)
        Me.GroupBox3.Controls.Add(Me.txtSearchProduct)
        Me.GroupBox3.Controls.Add(Me.btnFindProduct)
        Me.GroupBox3.Controls.Add(Me.txtSearchRecord)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.btnFindRecord)
        Me.GroupBox3.Location = New System.Drawing.Point(466, 104)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(253, 282)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Search"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(70, 245)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(45, 13)
        Me.Label13.TabIndex = 16
        Me.Label13.Text = "Label13"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(76, 217)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(45, 13)
        Me.Label12.TabIndex = 15
        Me.Label12.Text = "Label12"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(76, 187)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(45, 13)
        Me.Label11.TabIndex = 14
        Me.Label11.Text = "Label11"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(76, 155)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(45, 13)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "Label10"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(76, 135)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(39, 13)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "Label9"
        '
        'lblReorderLevel
        '
        Me.lblReorderLevel.AutoSize = True
        Me.lblReorderLevel.Location = New System.Drawing.Point(16, 232)
        Me.lblReorderLevel.Name = "lblReorderLevel"
        Me.lblReorderLevel.Size = New System.Drawing.Size(45, 26)
        Me.lblReorderLevel.TabIndex = 10
        Me.lblReorderLevel.Text = "Reorder" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "level"
        '
        'lblQuantityInStock
        '
        Me.lblQuantityInStock.AutoSize = True
        Me.lblQuantityInStock.Location = New System.Drawing.Point(13, 202)
        Me.lblQuantityInStock.Name = "lblQuantityInStock"
        Me.lblQuantityInStock.Size = New System.Drawing.Size(57, 26)
        Me.lblQuantityInStock.TabIndex = 9
        Me.lblQuantityInStock.Text = "Quantity in" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "stock"
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Location = New System.Drawing.Point(13, 183)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(31, 13)
        Me.lblPrice.TabIndex = 8
        Me.lblPrice.Text = "Price"
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.Location = New System.Drawing.Point(13, 163)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(34, 13)
        Me.lblDescription.TabIndex = 7
        Me.lblDescription.Text = "Detail"
        '
        'lblProductID
        '
        Me.lblProductID.AutoSize = True
        Me.lblProductID.Location = New System.Drawing.Point(10, 135)
        Me.lblProductID.Name = "lblProductID"
        Me.lblProductID.Size = New System.Drawing.Size(51, 13)
        Me.lblProductID.TabIndex = 6
        Me.lblProductID.Text = "Ticket ID"
        '
        'txtSearchProduct
        '
        Me.txtSearchProduct.Location = New System.Drawing.Point(69, 81)
        Me.txtSearchProduct.Name = "txtSearchProduct"
        Me.txtSearchProduct.Size = New System.Drawing.Size(100, 20)
        Me.txtSearchProduct.TabIndex = 5
        '
        'btnFindProduct
        '
        Me.btnFindProduct.BackColor = System.Drawing.Color.Thistle
        Me.btnFindProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFindProduct.Location = New System.Drawing.Point(178, 71)
        Me.btnFindProduct.Name = "btnFindProduct"
        Me.btnFindProduct.Size = New System.Drawing.Size(75, 23)
        Me.btnFindProduct.TabIndex = 4
        Me.btnFindProduct.Text = "Find Product"
        Me.btnFindProduct.UseVisualStyleBackColor = False
        '
        'txtSearchRecord
        '
        Me.txtSearchRecord.Location = New System.Drawing.Point(57, 29)
        Me.txtSearchRecord.Name = "txtSearchRecord"
        Me.txtSearchRecord.Size = New System.Drawing.Size(100, 20)
        Me.txtSearchRecord.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(7, 81)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 13)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "TicketID"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(2, 29)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Record no."
        '
        'btnFindRecord
        '
        Me.btnFindRecord.BackColor = System.Drawing.Color.Thistle
        Me.btnFindRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFindRecord.Location = New System.Drawing.Point(178, 19)
        Me.btnFindRecord.Name = "btnFindRecord"
        Me.btnFindRecord.Size = New System.Drawing.Size(75, 23)
        Me.btnFindRecord.TabIndex = 0
        Me.btnFindRecord.Text = "Find Record"
        Me.btnFindRecord.UseVisualStyleBackColor = False
        '
        'lblnumRecords
        '
        Me.lblnumRecords.AutoSize = True
        Me.lblnumRecords.Location = New System.Drawing.Point(27, 204)
        Me.lblnumRecords.Name = "lblnumRecords"
        Me.lblnumRecords.Size = New System.Drawing.Size(117, 13)
        Me.lblnumRecords.TabIndex = 2
        Me.lblnumRecords.Text = "Number of tickets in file"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(150, 204)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(39, 13)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Label8"
        '
        'btnStaffPage
        '
        Me.btnStaffPage.Location = New System.Drawing.Point(581, 30)
        Me.btnStaffPage.Name = "btnStaffPage"
        Me.btnStaffPage.Size = New System.Drawing.Size(75, 23)
        Me.btnStaffPage.TabIndex = 12
        Me.btnStaffPage.Text = "Back"
        Me.btnStaffPage.UseVisualStyleBackColor = True
        '
        'ticketInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(731, 398)
        Me.Controls.Add(Me.btnStaffPage)
        Me.Controls.Add(Me.lblnumRecords)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label8)
        Me.Name = "ticketInfo"
        Me.Text = "seat available"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtQuantityInStock As TextBox
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents txtProductID As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnAddRecord As Button
    Friend WithEvents cboReoderLevel As ComboBox
    Friend WithEvents lstDisplayFile As ListBox
    Friend WithEvents btnDisplayFile As Button
    Friend WithEvents txtSearchRecord As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnFindRecord As Button
    Friend WithEvents lblnumRecords As Label
    Friend WithEvents lblReorderLevel As Label
    Friend WithEvents lblQuantityInStock As Label
    Friend WithEvents lblPrice As Label
    Friend WithEvents lblDescription As Label
    Friend WithEvents lblProductID As Label
    Friend WithEvents txtSearchProduct As TextBox
    Friend WithEvents btnFindProduct As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents btnStaffPage As Button
End Class
