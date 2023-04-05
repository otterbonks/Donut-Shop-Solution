' Name:         Donut Project
' Purpose:      
' Programmer:   Phillip Nguyen on 04/05/2023
Option Strict On
Option Explicit On
Option Infer Off
Public Class frmMain
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub clearOutput(sender As Object, e As EventArgs) Handles radCappuccino.CheckedChanged, radFilled.CheckedChanged, radGlazed.CheckedChanged, radRegular.CheckedChanged, radSugar.CheckedChanged, radChocolate.CheckedChanged, radNone.CheckedChanged
        lblSalesTax.Text = String.Empty
        lblSubtotal.Text = String.Empty
        lblTotal.Text = String.Empty
    End Sub

    Private Sub Calc()
        Dim dblTotal As Double
        Dim dblSalesTax As Double
        Dim dblSubTotal As Double

        For Each thingy As RadioButton In grpDonutChoices.Controls
            If thingy.Checked = True Then
                dblSubTotal += Val(thingy.Text)
            End If
        Next

        lblSubtotal.Text = dblSubTotal.ToString("C2")
        lblSalesTax.Text = dblSalesTax.ToString("C2")
        lblTotal.Text = dblTotal.ToString("C2")
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Calc()
    End Sub
End Class
