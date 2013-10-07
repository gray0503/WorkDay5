Option Strict On
Public Class Form1


    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click

        Dim x As Double
        Dim y As Double
        Dim z As Double


        'Read input from user'
        x = CDbl(txtSideOne.Text)
        y = CDbl(txtSideTwo.Text)
        z = Math.Round(Hyp(x, y), 2)

        txtHyp.Text = CStr(z)

    End Sub

    Function Hyp(ByVal a As Double, ByVal b As Double) As Double
        'Math.SqRt'
        Dim c As Double
        c = ((a ^ 2) + (b ^ 2)) ^ (1 / 2)

        Return c
    End Function
End Class
