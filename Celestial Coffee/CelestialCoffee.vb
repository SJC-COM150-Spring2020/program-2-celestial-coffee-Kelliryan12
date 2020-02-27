Public Class CelestialCoffee
    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click

        'Declare Regular and Decaf as Doubles
        Dim Regular, Decaf As Double

        'Declare Tax as Constant 
        Const Tax As Double = 0.08875

        'Cast Value in both Textboxes to Doubles 
        Regular = CDbl(txtRegular.Text * 6.98)
        Decaf = CDbl(txtDecaf.Text * 5.98)

        'Declare Amount Due as Double 
        Dim AmountDue As Double

        'Calculate the Toltal Amount Due 
        AmountDue = CDbl((Regular + Decaf) * Tax + (Regular + Decaf))

        'When user clicks enter display AmountDue to text box 
        txtOut.Text = FormatCurrency(AmountDue, 2)

        'After user clicks enter, clear textboxes
        txtRegular.Clear()
        txtDecaf.Clear()

    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        txtSubmit.Text = "Thank you " & txtName.Text & "for your order! " & "Your order will now be processed and shipped to " & txtAddress.Text & txtCity.Text & ", " & txtState.Text & ", " & txtZip.Text & ", " & "Expected delivery will be 5-8 business days."

        'When user clicks button clear textbox information 
        txtName.Clear()
        txtAddress.Clear()
        txtCity.Clear()
        txtState.Clear()
        txtZip.Clear()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub
End Class
