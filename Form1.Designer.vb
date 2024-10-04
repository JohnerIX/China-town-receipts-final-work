<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        txtReceptNo = New TextBox()
        txtDateTime = New TextBox()
        txtCustomerName = New TextBox()
        lblReceiptno = New Label()
        lblDateTime = New Label()
        Label3 = New Label()
        lblItem = New Label()
        lblQuantity = New Label()
        txtQuantity2 = New TextBox()
        txtQuantity1 = New TextBox()
        lblPrice = New Label()
        lblAmount = New Label()
        lblTransactionsId = New Label()
        lblServedby = New Label()
        Label10 = New Label()
        Label11 = New Label()
        Label13 = New Label()
        Label14 = New Label()
        lblChinatownstore = New Label()
        txtAmount1 = New TextBox()
        txtPrice1 = New TextBox()
        txtItem1 = New TextBox()
        txtItem2 = New TextBox()
        txtItem3 = New TextBox()
        txtItem4 = New TextBox()
        txtItem5 = New TextBox()
        txtPrice2 = New TextBox()
        txtQuantity5 = New TextBox()
        txtQuantity4 = New TextBox()
        txtQuantity3 = New TextBox()
        txtAmount5 = New TextBox()
        txtAmount4 = New TextBox()
        txtAmount3 = New TextBox()
        txtAmount2 = New TextBox()
        txtPrice3 = New TextBox()
        txtPrice4 = New TextBox()
        txtPrice5 = New TextBox()
        txtTotalAmount = New TextBox()
        lblTax = New Label()
        Label17 = New Label()
        lblPaymentmethod = New Label()
        lblTotalAmount = New Label()
        lblDiscounts = New Label()
        lblSubtotal = New Label()
        btnDateTime = New Button()
        Label23 = New Label()
        Label24 = New Label()
        Label25 = New Label()
        Label26 = New Label()
        txtTransactionsId = New TextBox()
        txtPaymentmethod = New TextBox()
        txtDiscounts = New TextBox()
        txtTax = New TextBox()
        txtSubtotal = New TextBox()
        Label27 = New Label()
        btnTotalAmount = New Button()
        btnTax = New Button()
        btnSubtotal = New Button()
        btnAmount = New Button()
        txtServedby = New TextBox()
        Label22 = New Label()
        Label28 = New Label()
        btnDiscounts = New Button()
        PrintDocument1 = New Printing.PrintDocument()
        PrintDialog1 = New PrintDialog()
        btnAddItems = New Button()
        btnPrint = New Button()
        txtItem = New TextBox()
        txtPrice = New TextBox()
        txtTotal = New TextBox()
        txtQuantity = New TextBox()
        btnCalculate = New Button()
        txtReceipt = New TextBox()
        SuspendLayout()
        ' 
        ' txtReceptNo
        ' 
        txtReceptNo.Location = New Point(326, 82)
        txtReceptNo.Name = "txtReceptNo"
        txtReceptNo.Size = New Size(175, 23)
        txtReceptNo.TabIndex = 0
        txtReceptNo.Text = " "
        ' 
        ' txtDateTime
        ' 
        txtDateTime.Location = New Point(326, 111)
        txtDateTime.Name = "txtDateTime"
        txtDateTime.Size = New Size(175, 23)
        txtDateTime.TabIndex = 1
        ' 
        ' txtCustomerName
        ' 
        txtCustomerName.Location = New Point(326, 140)
        txtCustomerName.Name = "txtCustomerName"
        txtCustomerName.Size = New Size(175, 23)
        txtCustomerName.TabIndex = 2
        ' 
        ' lblReceiptno
        ' 
        lblReceiptno.AutoSize = True
        lblReceiptno.Location = New Point(118, 90)
        lblReceiptno.Name = "lblReceiptno"
        lblReceiptno.Size = New Size(71, 15)
        lblReceiptno.TabIndex = 4
        lblReceiptno.Text = "RECEIPT NO"
        ' 
        ' lblDateTime
        ' 
        lblDateTime.AutoSize = True
        lblDateTime.Location = New Point(118, 119)
        lblDateTime.Name = "lblDateTime"
        lblDateTime.Size = New Size(68, 15)
        lblDateTime.TabIndex = 5
        lblDateTime.Text = "DATE -TIME"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(113, 148)
        Label3.Name = "Label3"
        Label3.Size = New Size(104, 15)
        Label3.TabIndex = 6
        Label3.Text = "CUSTOMER NAME"
        ' 
        ' lblItem
        ' 
        lblItem.AutoSize = True
        lblItem.Location = New Point(131, 181)
        lblItem.Name = "lblItem"
        lblItem.Size = New Size(33, 15)
        lblItem.TabIndex = 7
        lblItem.Text = "ITEM"
        ' 
        ' lblQuantity
        ' 
        lblQuantity.AutoSize = True
        lblQuantity.Location = New Point(285, 181)
        lblQuantity.Name = "lblQuantity"
        lblQuantity.Size = New Size(63, 15)
        lblQuantity.TabIndex = 8
        lblQuantity.Text = "QUANTITY"
        ' 
        ' txtQuantity2
        ' 
        txtQuantity2.Location = New Point(268, 249)
        txtQuantity2.Name = "txtQuantity2"
        txtQuantity2.Size = New Size(100, 23)
        txtQuantity2.TabIndex = 9
        ' 
        ' txtQuantity1
        ' 
        txtQuantity1.Location = New Point(268, 212)
        txtQuantity1.Name = "txtQuantity1"
        txtQuantity1.Size = New Size(100, 23)
        txtQuantity1.TabIndex = 10
        ' 
        ' lblPrice
        ' 
        lblPrice.AutoSize = True
        lblPrice.Location = New Point(451, 181)
        lblPrice.Name = "lblPrice"
        lblPrice.Size = New Size(38, 15)
        lblPrice.TabIndex = 12
        lblPrice.Text = "PRICE"
        ' 
        ' lblAmount
        ' 
        lblAmount.AutoSize = True
        lblAmount.Location = New Point(593, 181)
        lblAmount.Name = "lblAmount"
        lblAmount.Size = New Size(58, 15)
        lblAmount.TabIndex = 13
        lblAmount.Text = "AMOUNT"
        ' 
        ' lblTransactionsId
        ' 
        lblTransactionsId.AutoSize = True
        lblTransactionsId.Location = New Point(113, 635)
        lblTransactionsId.Name = "lblTransactionsId"
        lblTransactionsId.Size = New Size(103, 15)
        lblTransactionsId.TabIndex = 14
        lblTransactionsId.Text = "TRANSACTION  ID"
        ' 
        ' lblServedby
        ' 
        lblServedby.AutoSize = True
        lblServedby.Location = New Point(118, 664)
        lblServedby.Name = "lblServedby"
        lblServedby.Size = New Size(64, 15)
        lblServedby.TabIndex = 15
        lblServedby.Text = "SERVED BY"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(751, 241)
        Label10.Name = "Label10"
        Label10.Size = New Size(0, 15)
        Label10.TabIndex = 16
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(751, 212)
        Label11.Name = "Label11"
        Label11.Size = New Size(0, 15)
        Label11.TabIndex = 17
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Location = New Point(741, 387)
        Label13.Name = "Label13"
        Label13.Size = New Size(0, 15)
        Label13.TabIndex = 19
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Location = New Point(751, 402)
        Label14.Name = "Label14"
        Label14.Size = New Size(0, 15)
        Label14.TabIndex = 20
        ' 
        ' lblChinatownstore
        ' 
        lblChinatownstore.AutoSize = True
        lblChinatownstore.Font = New Font("Stencil", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblChinatownstore.Location = New Point(269, 19)
        lblChinatownstore.Name = "lblChinatownstore"
        lblChinatownstore.Size = New Size(204, 22)
        lblChinatownstore.TabIndex = 21
        lblChinatownstore.Text = "CHINA TOWN STORE"
        ' 
        ' txtAmount1
        ' 
        txtAmount1.Location = New Point(563, 212)
        txtAmount1.Name = "txtAmount1"
        txtAmount1.Size = New Size(100, 23)
        txtAmount1.TabIndex = 22
        ' 
        ' txtPrice1
        ' 
        txtPrice1.Location = New Point(410, 212)
        txtPrice1.Name = "txtPrice1"
        txtPrice1.Size = New Size(100, 23)
        txtPrice1.TabIndex = 23
        ' 
        ' txtItem1
        ' 
        txtItem1.Location = New Point(113, 209)
        txtItem1.Name = "txtItem1"
        txtItem1.Size = New Size(100, 23)
        txtItem1.TabIndex = 24
        txtItem1.Text = "sausage"
        ' 
        ' txtItem2
        ' 
        txtItem2.Location = New Point(113, 246)
        txtItem2.Name = "txtItem2"
        txtItem2.Size = New Size(100, 23)
        txtItem2.TabIndex = 25
        ' 
        ' txtItem3
        ' 
        txtItem3.Location = New Point(113, 278)
        txtItem3.Name = "txtItem3"
        txtItem3.Size = New Size(100, 23)
        txtItem3.TabIndex = 26
        ' 
        ' txtItem4
        ' 
        txtItem4.Location = New Point(113, 307)
        txtItem4.Name = "txtItem4"
        txtItem4.Size = New Size(100, 23)
        txtItem4.TabIndex = 27
        ' 
        ' txtItem5
        ' 
        txtItem5.Location = New Point(113, 336)
        txtItem5.Name = "txtItem5"
        txtItem5.Size = New Size(100, 23)
        txtItem5.TabIndex = 28
        ' 
        ' txtPrice2
        ' 
        txtPrice2.Location = New Point(410, 246)
        txtPrice2.Name = "txtPrice2"
        txtPrice2.Size = New Size(100, 23)
        txtPrice2.TabIndex = 29
        ' 
        ' txtQuantity5
        ' 
        txtQuantity5.Location = New Point(268, 336)
        txtQuantity5.Name = "txtQuantity5"
        txtQuantity5.Size = New Size(100, 23)
        txtQuantity5.TabIndex = 33
        ' 
        ' txtQuantity4
        ' 
        txtQuantity4.Location = New Point(268, 307)
        txtQuantity4.Name = "txtQuantity4"
        txtQuantity4.Size = New Size(100, 23)
        txtQuantity4.TabIndex = 34
        ' 
        ' txtQuantity3
        ' 
        txtQuantity3.Location = New Point(269, 278)
        txtQuantity3.Name = "txtQuantity3"
        txtQuantity3.Size = New Size(100, 23)
        txtQuantity3.TabIndex = 35
        ' 
        ' txtAmount5
        ' 
        txtAmount5.Location = New Point(563, 336)
        txtAmount5.Name = "txtAmount5"
        txtAmount5.Size = New Size(100, 23)
        txtAmount5.TabIndex = 38
        ' 
        ' txtAmount4
        ' 
        txtAmount4.Location = New Point(563, 307)
        txtAmount4.Name = "txtAmount4"
        txtAmount4.Size = New Size(100, 23)
        txtAmount4.TabIndex = 39
        ' 
        ' txtAmount3
        ' 
        txtAmount3.Location = New Point(563, 278)
        txtAmount3.Name = "txtAmount3"
        txtAmount3.Size = New Size(100, 23)
        txtAmount3.TabIndex = 40
        ' 
        ' txtAmount2
        ' 
        txtAmount2.Location = New Point(563, 249)
        txtAmount2.Name = "txtAmount2"
        txtAmount2.Size = New Size(100, 23)
        txtAmount2.TabIndex = 41
        ' 
        ' txtPrice3
        ' 
        txtPrice3.Location = New Point(410, 278)
        txtPrice3.Name = "txtPrice3"
        txtPrice3.Size = New Size(100, 23)
        txtPrice3.TabIndex = 45
        ' 
        ' txtPrice4
        ' 
        txtPrice4.Location = New Point(410, 307)
        txtPrice4.Name = "txtPrice4"
        txtPrice4.Size = New Size(100, 23)
        txtPrice4.TabIndex = 46
        ' 
        ' txtPrice5
        ' 
        txtPrice5.Location = New Point(410, 336)
        txtPrice5.Name = "txtPrice5"
        txtPrice5.Size = New Size(100, 23)
        txtPrice5.TabIndex = 47
        ' 
        ' txtTotalAmount
        ' 
        txtTotalAmount.Location = New Point(464, 515)
        txtTotalAmount.Name = "txtTotalAmount"
        txtTotalAmount.Size = New Size(199, 23)
        txtTotalAmount.TabIndex = 56
        ' 
        ' lblTax
        ' 
        lblTax.AutoSize = True
        lblTax.Location = New Point(134, 446)
        lblTax.Name = "lblTax"
        lblTax.Size = New Size(30, 15)
        lblTax.TabIndex = 58
        lblTax.Text = " TAX"
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Location = New Point(285, 616)
        Label17.Name = "Label17"
        Label17.Size = New Size(0, 15)
        Label17.TabIndex = 59
        ' 
        ' lblPaymentmethod
        ' 
        lblPaymentmethod.AutoSize = True
        lblPaymentmethod.Location = New Point(106, 595)
        lblPaymentmethod.Name = "lblPaymentmethod"
        lblPaymentmethod.Size = New Size(111, 15)
        lblPaymentmethod.TabIndex = 60
        lblPaymentmethod.Text = "PAYMENT METHOD"
        ' 
        ' lblTotalAmount
        ' 
        lblTotalAmount.AutoSize = True
        lblTotalAmount.Location = New Point(106, 523)
        lblTotalAmount.Name = "lblTotalAmount"
        lblTotalAmount.Size = New Size(93, 15)
        lblTotalAmount.TabIndex = 61
        lblTotalAmount.Text = "TOTAL AMOUNT"
        ' 
        ' lblDiscounts
        ' 
        lblDiscounts.AutoSize = True
        lblDiscounts.Location = New Point(118, 480)
        lblDiscounts.Name = "lblDiscounts"
        lblDiscounts.Size = New Size(70, 15)
        lblDiscounts.TabIndex = 62
        lblDiscounts.Text = "DISCOUNTS"
        ' 
        ' lblSubtotal
        ' 
        lblSubtotal.AutoSize = True
        lblSubtotal.Location = New Point(126, 416)
        lblSubtotal.Name = "lblSubtotal"
        lblSubtotal.Size = New Size(63, 15)
        lblSubtotal.TabIndex = 63
        lblSubtotal.Text = "SUB TOTAL"
        ' 
        ' btnDateTime
        ' 
        btnDateTime.Location = New Point(540, 111)
        btnDateTime.Name = "btnDateTime"
        btnDateTime.Size = New Size(85, 23)
        btnDateTime.TabIndex = 65
        btnDateTime.Text = "DATE-TIME"
        btnDateTime.UseVisualStyleBackColor = True
        ' 
        ' Label23
        ' 
        Label23.AutoSize = True
        Label23.Location = New Point(285, 718)
        Label23.Name = "Label23"
        Label23.Size = New Size(0, 15)
        Label23.TabIndex = 67
        ' 
        ' Label24
        ' 
        Label24.AutoSize = True
        Label24.Location = New Point(285, 718)
        Label24.Name = "Label24"
        Label24.Size = New Size(117, 15)
        Label24.TabIndex = 68
        Label24.Text = "CHINA TOWN STORE"
        ' 
        ' Label25
        ' 
        Label25.AutoSize = True
        Label25.Location = New Point(118, 707)
        Label25.Name = "Label25"
        Label25.Size = New Size(0, 15)
        Label25.TabIndex = 69
        ' 
        ' Label26
        ' 
        Label26.AutoSize = True
        Label26.Location = New Point(360, 674)
        Label26.Name = "Label26"
        Label26.Size = New Size(0, 15)
        Label26.TabIndex = 70
        ' 
        ' txtTransactionsId
        ' 
        txtTransactionsId.Location = New Point(253, 627)
        txtTransactionsId.Name = "txtTransactionsId"
        txtTransactionsId.Size = New Size(168, 23)
        txtTransactionsId.TabIndex = 71
        ' 
        ' txtPaymentmethod
        ' 
        txtPaymentmethod.Location = New Point(253, 595)
        txtPaymentmethod.Name = "txtPaymentmethod"
        txtPaymentmethod.Size = New Size(168, 23)
        txtPaymentmethod.TabIndex = 72
        ' 
        ' txtDiscounts
        ' 
        txtDiscounts.Location = New Point(464, 472)
        txtDiscounts.Name = "txtDiscounts"
        txtDiscounts.Size = New Size(199, 23)
        txtDiscounts.TabIndex = 77
        ' 
        ' txtTax
        ' 
        txtTax.Location = New Point(464, 438)
        txtTax.Name = "txtTax"
        txtTax.Size = New Size(199, 23)
        txtTax.TabIndex = 78
        ' 
        ' txtSubtotal
        ' 
        txtSubtotal.Location = New Point(464, 408)
        txtSubtotal.Name = "txtSubtotal"
        txtSubtotal.Size = New Size(199, 23)
        txtSubtotal.TabIndex = 79
        ' 
        ' Label27
        ' 
        Label27.AutoSize = True
        Label27.Location = New Point(262, 49)
        Label27.Name = "Label27"
        Label27.Size = New Size(135, 15)
        Label27.TabIndex = 80
        Label27.Text = "0755976132 /0772397251"
        ' 
        ' btnTotalAmount
        ' 
        btnTotalAmount.Location = New Point(519, 544)
        btnTotalAmount.Name = "btnTotalAmount"
        btnTotalAmount.Size = New Size(144, 33)
        btnTotalAmount.TabIndex = 64
        btnTotalAmount.Text = "TOTAL AMOUNT"
        btnTotalAmount.UseVisualStyleBackColor = True
        ' 
        ' btnTax
        ' 
        btnTax.Location = New Point(276, 437)
        btnTax.Name = "btnTax"
        btnTax.Size = New Size(92, 24)
        btnTax.TabIndex = 81
        btnTax.Text = "TAX"
        btnTax.UseVisualStyleBackColor = True
        ' 
        ' btnSubtotal
        ' 
        btnSubtotal.Location = New Point(277, 408)
        btnSubtotal.Name = "btnSubtotal"
        btnSubtotal.Size = New Size(92, 23)
        btnSubtotal.TabIndex = 82
        btnSubtotal.Text = "SUBTOTAL"
        btnSubtotal.UseVisualStyleBackColor = True
        ' 
        ' btnAmount
        ' 
        btnAmount.Location = New Point(686, 210)
        btnAmount.Name = "btnAmount"
        btnAmount.Size = New Size(91, 25)
        btnAmount.TabIndex = 83
        btnAmount.Text = "AMOUNT"
        btnAmount.UseVisualStyleBackColor = True
        ' 
        ' txtServedby
        ' 
        txtServedby.Location = New Point(253, 656)
        txtServedby.Name = "txtServedby"
        txtServedby.Size = New Size(168, 23)
        txtServedby.TabIndex = 85
        ' 
        ' Label22
        ' 
        Label22.AutoSize = True
        Label22.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label22.Location = New Point(369, 737)
        Label22.Name = "Label22"
        Label22.Size = New Size(177, 17)
        Label22.TabIndex = 87
        Label22.Text = "chinatown3279@gmail.com"
        ' 
        ' Label28
        ' 
        Label28.AutoSize = True
        Label28.Location = New Point(451, 718)
        Label28.Name = "Label28"
        Label28.Size = New Size(132, 15)
        Label28.TabIndex = 88
        Label28.Text = "0755976132/0772397251"
        ' 
        ' btnDiscounts
        ' 
        btnDiscounts.Location = New Point(277, 467)
        btnDiscounts.Name = "btnDiscounts"
        btnDiscounts.Size = New Size(90, 28)
        btnDiscounts.TabIndex = 89
        btnDiscounts.Text = "DISCOUNT"
        btnDiscounts.UseVisualStyleBackColor = True
        ' 
        ' PrintDocument1
        ' 
        ' 
        ' PrintDialog1
        ' 
        PrintDialog1.UseEXDialog = True
        ' 
        ' btnAddItems
        ' 
        btnAddItems.Location = New Point(502, 636)
        btnAddItems.Name = "btnAddItems"
        btnAddItems.Size = New Size(142, 38)
        btnAddItems.TabIndex = 91
        btnAddItems.Text = "add items"
        btnAddItems.UseVisualStyleBackColor = True
        ' 
        ' btnPrint
        ' 
        btnPrint.Location = New Point(650, 641)
        btnPrint.Name = "btnPrint"
        btnPrint.Size = New Size(142, 38)
        btnPrint.TabIndex = 92
        btnPrint.Text = "print"
        btnPrint.UseVisualStyleBackColor = True
        ' 
        ' txtItem
        ' 
        txtItem.Location = New Point(113, 367)
        txtItem.Name = "txtItem"
        txtItem.Size = New Size(100, 23)
        txtItem.TabIndex = 93
        ' 
        ' txtPrice
        ' 
        txtPrice.Location = New Point(410, 365)
        txtPrice.Name = "txtPrice"
        txtPrice.Size = New Size(100, 23)
        txtPrice.TabIndex = 94
        ' 
        ' txtTotal
        ' 
        txtTotal.Location = New Point(563, 367)
        txtTotal.Name = "txtTotal"
        txtTotal.Size = New Size(100, 23)
        txtTotal.TabIndex = 95
        ' 
        ' txtQuantity
        ' 
        txtQuantity.Location = New Point(269, 365)
        txtQuantity.Name = "txtQuantity"
        txtQuantity.Size = New Size(100, 23)
        txtQuantity.TabIndex = 96
        ' 
        ' btnCalculate
        ' 
        btnCalculate.Location = New Point(285, 544)
        btnCalculate.Name = "btnCalculate"
        btnCalculate.Size = New Size(144, 33)
        btnCalculate.TabIndex = 97
        btnCalculate.Text = "TOTAL AMOUNT"
        btnCalculate.UseVisualStyleBackColor = True
        ' 
        ' txtReceipt
        ' 
        txtReceipt.Location = New Point(540, 140)
        txtReceipt.Name = "txtReceipt"
        txtReceipt.Size = New Size(100, 23)
        txtReceipt.TabIndex = 98
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(800, 749)
        Controls.Add(txtReceipt)
        Controls.Add(btnCalculate)
        Controls.Add(txtQuantity)
        Controls.Add(txtTotal)
        Controls.Add(txtPrice)
        Controls.Add(txtItem)
        Controls.Add(btnPrint)
        Controls.Add(btnAddItems)
        Controls.Add(btnDiscounts)
        Controls.Add(Label28)
        Controls.Add(Label22)
        Controls.Add(txtServedby)
        Controls.Add(btnAmount)
        Controls.Add(btnSubtotal)
        Controls.Add(btnTax)
        Controls.Add(Label27)
        Controls.Add(txtSubtotal)
        Controls.Add(txtTax)
        Controls.Add(txtDiscounts)
        Controls.Add(txtPaymentmethod)
        Controls.Add(txtTransactionsId)
        Controls.Add(Label26)
        Controls.Add(Label25)
        Controls.Add(Label24)
        Controls.Add(Label23)
        Controls.Add(btnDateTime)
        Controls.Add(btnTotalAmount)
        Controls.Add(lblSubtotal)
        Controls.Add(lblDiscounts)
        Controls.Add(lblTotalAmount)
        Controls.Add(lblPaymentmethod)
        Controls.Add(Label17)
        Controls.Add(lblTax)
        Controls.Add(txtTotalAmount)
        Controls.Add(txtPrice5)
        Controls.Add(txtPrice4)
        Controls.Add(txtPrice3)
        Controls.Add(txtAmount2)
        Controls.Add(txtAmount3)
        Controls.Add(txtAmount4)
        Controls.Add(txtAmount5)
        Controls.Add(txtQuantity3)
        Controls.Add(txtQuantity4)
        Controls.Add(txtQuantity5)
        Controls.Add(txtPrice2)
        Controls.Add(txtItem5)
        Controls.Add(txtItem4)
        Controls.Add(txtItem3)
        Controls.Add(txtItem2)
        Controls.Add(txtItem1)
        Controls.Add(txtPrice1)
        Controls.Add(txtAmount1)
        Controls.Add(lblChinatownstore)
        Controls.Add(Label14)
        Controls.Add(Label13)
        Controls.Add(Label11)
        Controls.Add(Label10)
        Controls.Add(lblServedby)
        Controls.Add(lblTransactionsId)
        Controls.Add(lblAmount)
        Controls.Add(lblPrice)
        Controls.Add(txtQuantity1)
        Controls.Add(txtQuantity2)
        Controls.Add(lblQuantity)
        Controls.Add(lblItem)
        Controls.Add(Label3)
        Controls.Add(lblDateTime)
        Controls.Add(lblReceiptno)
        Controls.Add(txtCustomerName)
        Controls.Add(txtDateTime)
        Controls.Add(txtReceptNo)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtReceptNo As TextBox
    Friend WithEvents txtDateTime As TextBox
    Friend WithEvents txtCustomerName As TextBox
    Friend WithEvents lblReceiptno As Label
    Friend WithEvents lblDateTime As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblItem As Label
    Friend WithEvents lblQuantity As Label
    Friend WithEvents txtQuantity2 As TextBox
    Friend WithEvents txtQuantity1 As TextBox
    Friend WithEvents lblPrice As Label
    Friend WithEvents lblAmount As Label
    Friend WithEvents lblTransactionsId As Label
    Friend WithEvents lblServedby As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents lblChinatownstore As Label
    Friend WithEvents txtAmount1 As TextBox
    Friend WithEvents txtPrice1 As TextBox
    Friend WithEvents txtItem1 As TextBox
    Friend WithEvents txtItem2 As TextBox
    Friend WithEvents txtItem3 As TextBox
    Friend WithEvents txtItem4 As TextBox
    Friend WithEvents txtItem5 As TextBox
    Friend WithEvents txtPrice2 As TextBox
    Friend WithEvents txtQuantity5 As TextBox
    Friend WithEvents txtQuantity4 As TextBox
    Friend WithEvents txtQuantity3 As TextBox
    Friend WithEvents txtAmount5 As TextBox
    Friend WithEvents txtAmount4 As TextBox
    Friend WithEvents txtAmount3 As TextBox
    Friend WithEvents txtAmount2 As TextBox
    Friend WithEvents txtPrice3 As TextBox
    Friend WithEvents txtPrice4 As TextBox
    Friend WithEvents txtPrice5 As TextBox
    Friend WithEvents txtTotalAmount As TextBox
    Friend WithEvents lblTax As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents lblPaymentmethod As Label
    Friend WithEvents lblTotalAmount As Label
    Friend WithEvents lblDiscounts As Label
    Friend WithEvents lblSubtotal As Label
    Friend WithEvents btnDateTime As Button
    Friend WithEvents Label23 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents txtTransactionsId As TextBox
    Friend WithEvents txtPaymentmethod As TextBox
    Friend WithEvents txtDiscounts As TextBox
    Friend WithEvents txtTax As TextBox
    Friend WithEvents txtSubtotal As TextBox
    Friend WithEvents Label27 As Label
    Friend WithEvents btnTotalAmount As Button
    Friend WithEvents btnTax As Button
    Friend WithEvents btnSubtotal As Button
    Friend WithEvents btnAmount As Button
    Friend WithEvents txtServedby As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents btnDiscounts As Button
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents btnAddItems As Button
    Friend WithEvents btnPrint As Button
    Friend WithEvents txtItem As TextBox
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents txtReceipt As TextBox

End Class
