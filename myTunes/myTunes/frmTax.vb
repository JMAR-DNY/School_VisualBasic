'Programmed by: Jeffrey Marron
'CRN 1475

Option Explicit On

Public Class frmTax
    Private Sub frmTax_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MaximizeBox = False
        MinimizeBox = False
    End Sub 'Load

    'Button Handlers**********
    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Dim temp As Double = 0

        If Double.TryParse(txtBox1.Text, temp) Then 'determines if txtBox1 value is a double
            If temp <= 10 And temp >= 0 Then 'determines if value in txtBox1 is in range

                taxRate = txtBox1.Text * 0.01 ' calculates taxRate
                tax = subtotal * taxRate ' calculates tax

                FileOpen(1, "PurchaseOrder.txt", OpenMode.Output)
                PrintLine(1, "For Purchases dated: " + DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss tt"))
                WriteLine(1)
                PrintLine(1, PurchaseOrder)
                PrintLine(1, "------")
                PrintLine(1, (subtotal.ToString("C2")).PadRight(10) + "Subtotal")
                PrintLine(1, (tax.ToString("C2")).PadRight(10) + "Tax")
                PrintLine(1, "------")
                PrintLine(1, ((tax + subtotal).ToString("C2")).PadRight(10) + "Total") 'adds tax and subtotal
                FileClose(1)

                Dim result = MessageBox.Show("Purchase Order has been created", "My Tunes", MessageBoxButtons.OK)
                If result = DialogResult.OK Then
                    Me.Close()
                    frmMain.Close()
                End If

            End If
        Else
            Dim result = MessageBox.Show("You must enter a valid numeric tax rate", "Tax Rate Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

    End Sub 'btnOK.Click

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Hide()
    End Sub 'btnCancel.Click
    'END Button Handlers**********

End Class'frmTax