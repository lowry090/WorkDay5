﻿Option Strict On
Public Class Form1


    Private Sub btnCalculate_Click(sender As System.Object, e As System.EventArgs) Handles btnCalculate.Click
        Dim x As Double
        Dim y As Double
        Dim z As Double

        x = CDbl(txtSideOne.Text)
        y = CDbl(txtSideTwo.Text)

        z = Hypothenuse(x, y)

        txtHyp.Text = CStr(z)
    End Sub
    Function Hypothenuse(ByVal a As Double, b As Double) As Double
        Dim c As Double

        c = Math.Sqrt(a ^ 2 + b ^ 2)

        Return c
    End Function

End Class
