Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim num1 As Single = Val(txt1.Text)
        Dim num2 As Single = Val(txt2.Text)
        Dim Sum As Single = num1 + num2
        txt3.Text = Sum.ToString

    End Sub


End Class
