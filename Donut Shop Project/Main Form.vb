Option Strict On
Option Explicit On
Option Infer Off
' Name:         Donut Project
' Purpose:      Use Methods to display amount due for Donut Shope Orders
' Programmer:   Phillip Nguyen on 04/05/2023

Public Class frmMain
    Dim dblSalesTax As Double
    Dim dblTotal As Double
    Dim dblSubTotal As Double
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub clearOutput(sender As Object, e As EventArgs) Handles radCappuccino.CheckedChanged, radFilled.CheckedChanged, radGlazed.CheckedChanged, radRegular.CheckedChanged, radSugar.CheckedChanged, radChocolate.CheckedChanged, radNone.CheckedChanged
        lblSalesTax.Text = String.Empty
        lblSubtotal.Text = String.Empty
        lblTotal.Text = String.Empty
    End Sub

    Private Sub Calc()

        If radGlazed.Checked = True Then
            dblSubTotal += 1.05
        ElseIf radFilled.Checked = True Then
            dblSubTotal += 1.5
        ElseIf radSugar.Checked = True Then
            dblSubTotal += 1.05
        ElseIf radChocolate.Checked = True Then
            dblSubTotal += 1.25
        End If

        If radCappuccino.Checked = True Then
            dblSubTotal += 2.75
        ElseIf radRegular.Checked = True Then
            dblSubTotal += 1.5
        End If

    End Sub

    Private Function salesTax(ByRef Tax As Double) As Double
        dblSalesTax = dblSubTotal * 0.06
        Return dblSalesTax
    End Function

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Calc()
        salesTax(dblSalesTax)
        dblTotal = dblSalesTax + dblSubTotal
        lblSubtotal.Text = dblSubTotal.ToString("C2")
        lblSalesTax.Text = dblSalesTax.ToString("C2")
        lblTotal.Text = dblTotal.ToString("C2")
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblSalesTax.Text = String.Empty
        lblSubtotal.Text = String.Empty
        lblTotal.Text = String.Empty
    End Sub
End Class
