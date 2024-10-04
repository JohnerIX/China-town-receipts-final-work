Imports System.Drawing.Printing
Imports System.Net.Sockets
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Tab

Public Class Form1

    Private items As New List(Of String)()
    Private total As Decimal = 0D

    Private Sub txtReceptNo_TextChanged(sender As Object, e As EventArgs) Handles txtReceptNo.TextChanged
        'input the Receipt number
        Dim receiptNumber As String = "KY" & Now.ToString(202410)
        'display results in the receiptNo textbox
        txtReceptNo.Text = receiptNumber.ToString

    End Sub
    Private Sub btnAddItems_Click(sender As Object, e As EventArgs) Handles btnAddItems.Click
        Dim itemName As String = txtItem.Text
        Dim itemPrice As Decimal

        If Decimal.TryParse(txtPrice.Text, itemPrice) Then
            items.Add(itemName & " - shs" & itemPrice.ToString("F2"))
            total += itemPrice

            ' Update the receipt display
            txtReceipt.Text &= itemName & " - shs" & itemPrice.ToString("F2") & Environment.NewLine
            txtTotal.Text = total.ToString("F2")

            ' Clear input fields
            txtItem.Clear()
            txtPrice.Clear()
            txtItem.Focus()
        Else
            MessageBox.Show("Please enter a valid price.")
        End If
    End Sub


    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        MessageBox.Show("Total Amount: shs" & total.ToString("F2"))
    End Sub
    Private Sub PrintReceipt()
        Dim printDialog As New PrintDialog()
        printDialog.Document = PrintDocument1

        If printDialog.ShowDialog() = DialogResult.OK Then
            PrintDocument1.Print()
        End If
    End Sub

    Private Sub printDocument_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim font As New Font("calibri", 10)
        Dim x As Single = 100
        Dim y As Single = 100

        ' Print each item in the receipt
        For Each item As String In items
            e.Graphics.DrawString(item, font, Brushes.Black, x, y)
            y += font.GetHeight(e.Graphics) ' Move down for the next line
        Next
    End Sub


    Private Sub btnAmount_Click(sender As Object, e As EventArgs) Handles btnAmount.Click
        'Calculate the amount of each item
        Dim quantity1 As Decimal = CDec(txtQuantity1.Text)
        Dim quantity2 As Decimal = CDec(txtQuantity2.Text)
        Dim quantity3 As Decimal = CDec(txtQuantity3.Text)
        Dim quantity4 As Decimal = CDec(txtQuantity4.Text)
        Dim quantity5 As Decimal = CDec(txtQuantity5.Text)
        Dim price1 As Decimal = CDec(txtPrice1.Text)
        Dim price2 As Decimal = CDec(txtPrice2.Text)
        Dim price3 As Decimal = CDec(txtPrice3.Text)
        Dim price4 As Decimal = CDec(txtPrice4.Text)
        Dim price5 As Decimal = CDec(txtPrice5.Text)
        Dim amount1 As Decimal = (quantity1 * price1)
        'display results in the amount1 textbox
        txtAmount1.Text = amount1.ToString
        Dim amount2 As Decimal = (quantity2 * price2)
        'display results in the amount2 textbox
        txtAmount2.Text = amount2.ToString
        Dim amount3 As Decimal = (quantity3 * price3)
        'display results in the amount3 textbox
        txtAmount3.Text = amount3.ToString
        Dim amount4 As Decimal = (quantity4 * price4)
        'display results in the amount4 textbox
        txtAmount4.Text = amount4.ToString
        Dim amount5 As Decimal = (quantity5 * price5)
        ' display results in the amount5 textbox
        txtAmount5.Text = amount5.ToString

    End Sub

    Private Sub btnSubtotal_Click(sender As Object, e As EventArgs) Handles btnSubtotal.Click
        'calculate the sub total
        Dim quantity1 As Decimal = CDec(txtQuantity1.Text)
        Dim quantity2 As Decimal = CDec(txtQuantity2.Text)
        Dim quantity3 As Decimal = CDec(txtQuantity3.Text)
        Dim quantity4 As Decimal = CDec(txtQuantity4.Text)
        Dim quantity5 As Decimal = CDec(txtQuantity5.Text)
        Dim price1 As Decimal = CDec(txtPrice1.Text)
        Dim price2 As Decimal = CDec(txtPrice2.Text)
        Dim price3 As Decimal = CDec(txtPrice3.Text)
        Dim price4 As Decimal = CDec(txtPrice4.Text)
        Dim price5 As Decimal = CDec(txtPrice5.Text)
        Dim amount1 As Decimal = CDec(quantity1 * price1)
        Dim amount2 As Decimal = CDec(quantity2 * price2)
        Dim amount3 As Decimal = CDec(quantity3 * price3)
        Dim amount4 As Decimal = CDec(quantity4 * price4)
        Dim amount5 As Decimal = CDec(quantity5 * price5)
        'Calculate the sub total
        Dim subtotal = (amount1 + amount2 + amount3 + amount4 + amount5)
        'Display subtotal results in the subtotal textbox
        txtSubtotal.Text = subtotal.ToString()

    End Sub

    Private Sub btnTax_Click(sender As Object, e As EventArgs) Handles btnTax.Click
        'Calculate tax
        Dim quantity1 As Decimal = CDec(txtQuantity1.Text)
        Dim quantity2 As Decimal = CDec(txtQuantity2.Text)
        Dim quantity3 As Decimal = CDec(txtQuantity3.Text)
        Dim quantity4 As Decimal = CDec(txtQuantity4.Text)
        Dim quantity5 As Decimal = CDec(txtQuantity5.Text)
        Dim price1 As Decimal = CDec(txtPrice1.Text)
        Dim price2 As Decimal = CDec(txtPrice2.Text)
        Dim price3 As Decimal = CDec(txtPrice3.Text)
        Dim price4 As Decimal = CDec(txtPrice4.Text)
        Dim price5 As Decimal = CDec(txtPrice5.Text)
        Dim amount1 As Decimal = CDec(quantity1 * price1)
        Dim amount2 As Decimal = CDec(quantity2 * price2)
        Dim amount3 As Decimal = CDec(quantity3 * price3)
        Dim amount4 As Decimal = CDec(quantity4 * price4)
        Dim amount5 As Decimal = CDec(quantity5 * price5)
        Dim subtotal = (amount1 + amount1 + amount2 + amount3 + amount4 + amount5)
        Dim tax As Decimal = (0.18 * subtotal)
        'Display tax results in the tax text box
        txtTax.Text = tax.ToString()
    End Sub

    Private Sub btndiscount_Click(sender As Object, e As EventArgs) Handles btnDiscounts.Click
        'Calculate Discount
        Dim quantity1 As Decimal = CDec(txtQuantity1.Text)
        Dim quantity2 As Decimal = CDec(txtQuantity2.Text)
        Dim quantity3 As Decimal = CDec(txtQuantity3.Text)
        Dim quantity4 As Decimal = CDec(txtQuantity4.Text)
        Dim quantity5 As Decimal = CDec(txtQuantity5.Text)
        Dim price1 As Decimal = CDec(txtPrice1.Text)
        Dim price2 As Decimal = CDec(txtPrice2.Text)
        Dim price3 As Decimal = CDec(txtPrice3.Text)
        Dim price4 As Decimal = CDec(txtPrice4.Text)
        Dim price5 As Decimal = CDec(txtPrice5.Text)
        Dim amount1 As Decimal = CDec(quantity1 * price1)
        Dim amount2 As Decimal = CDec(quantity2 * price2)
        Dim amount3 As Decimal = CDec(quantity3 * price3)
        Dim amount4 As Decimal = CDec(quantity4 * price4)
        Dim amount5 As Decimal = CDec(quantity5 * price5)
        Dim subtotal = (amount1 + amount1 + amount2 + amount3 + amount4 + amount5)
        Dim Discount As Decimal = (0.1 * subtotal)
        'Display Discount results in the dicounts text box
        txtDiscounts.Text = Discount.ToString()
    End Sub

    Private Sub btnTotalAmount_Click(sender As Object, e As EventArgs) Handles btnTotalAmount.Click
        'Calculate Total Amount
        Dim quantity1 As Decimal = CDec(txtQuantity1.Text)
        Dim quantity2 As Decimal = CDec(txtQuantity2.Text)
        Dim quantity3 As Decimal = CDec(txtQuantity3.Text)
        Dim quantity4 As Decimal = CDec(txtQuantity4.Text)
        Dim quantity5 As Decimal = CDec(txtQuantity5.Text)
        Dim price1 As Decimal = CDec(txtPrice1.Text)
        Dim price2 As Decimal = CDec(txtPrice2.Text)
        Dim price3 As Decimal = CDec(txtPrice3.Text)
        Dim price4 As Decimal = CDec(txtPrice4.Text)
        Dim price5 As Decimal = CDec(txtPrice5.Text)
        Dim amount1 As Decimal = CDec(quantity1 * price1)
        Dim amount2 As Decimal = CDec(quantity2 * price2)
        Dim amount3 As Decimal = CDec(quantity3 * price3)
        Dim amount4 As Decimal = CDec(quantity4 * price4)
        Dim amount5 As Decimal = CDec(quantity5 * price5)
        Dim subtotal = (amount1 + amount1 + amount2 + amount3 + amount4 + amount5)
        Dim tax As Decimal = (0.18 * subtotal)
        'Display tax results in the tax text box
        Dim Discount As Decimal = (0.1 * subtotal)
        'Display Discount results in the dicounts text box
        Dim TotalAmount As Decimal = (subtotal + tax - Discount)
        'Display TotalAmount in the total Amount text box
        txtTotalAmount.Text = TotalAmount.ToString()
    End Sub

    Private Sub txtServedby_TextChanged(sender As Object, e As EventArgs) Handles txtServedby.TextChanged
        'input the Sserved by 
        Dim servedby As String = "Receptionist" & Now.ToString()
        'display results in the served by textbox
        txtServedby.Text = servedby.ToString

    End Sub


    Private Sub btnDateTime_Click(sender As Object, e As EventArgs) Handles btnDateTime.Click
        'Input date and time
        Dim DateTime As String
        DateTime = DateAndTime.Now.ToString()
        txtDateTime.Text = DateTime
    End Sub
    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Dim printDialog As New PrintDialog()
        printDialog.Document = PrintDocument1
        txtTransactionsId.Text = Guid.NewGuid().ToString

        If printDialog.ShowDialog() = DialogResult.OK Then
            PrintDocument1.Print()
        End If
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument1.PrintPage
        ' Set the font and other properties

        Dim font As New Font("Arial", 12)
        Dim brush As New SolidBrush(Color.Black)

        ' Define the receipt content
        Dim receiptContent As String = "CHINA TOWN  STORE  RECEIPT" & Environment.NewLine &
                                    "----------------------------------------" & Environment.NewLine &
                                    " Quality as priority" & Environment.NewLine &
                                   "07738555888/0700461140" & Environment.NewLine &
                                   "chinatownkyamulibwa@gmail.com" & Environment.NewLine &
                                   "Transaction ID: " & txtTransactionsId.Text & Environment.NewLine &
                                   "Receipt No: " & txtReceipt.Text & Environment.NewLine &
                                   "Date: " & DateTime.Now.ToString("dddd, d MMMM yyyy") & Environment.NewLine &
                                   "CLIENT DETAILS:" & Environment.NewLine &
                                   "Name:" & txtCustomerName.Text & Environment.NewLine &
                                   "----------------------------------------" & Environment.NewLine &
                                   "ITEMS:" & Environment.NewLine &
                                    "1." & txtItem1.Text & "  " & txtQuantity1.Text & "pcs" & Environment.NewLine &
                                    "2." & txtItem2.Text & "  " & txtQuantity2.Text & "pcs" & Environment.NewLine &
                                    "3." & txtItem3.Text & "  " & txtQuantity3.Text & "pcs" & Environment.NewLine &
                                    "4." & txtItem4.Text & "  " & txtQuantity4.Text & "pcs" & Environment.NewLine

        ' Add item details (example)


        receiptContent &= "----------------------------------------" & Environment.NewLine &
                          "Subtotal: " & txtSubtotal.Text & Environment.NewLine &
                          "VAT: " & txtTax.Text & Environment.NewLine &
                          "Discount: " & txtDiscounts.Text & Environment.NewLine &
                          "Total Amount: " & txtTotal.Text & Environment.NewLine &
                          "----------------------------------------" & Environment.NewLine &
                         "Served By: " & txtServedby.Text

        ' Print the content
        e.Graphics.DrawString(receiptContent, font, brush, 10, 10)
    End Sub


End Class