﻿Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim num1, num2, num3 As Integer
        num1 = Val(TextBox1.Text)
        num2 = Val(TextBox2.Text)
        num3 = Val(TextBox3.Text)
        If num1 > num2 And num1 > num3 Then
            If num2 > num3 Then
                TextBox4.Text = num1 & "; " & num2 & "; " & num3
            Else
                TextBox4.Text = num1 & "; " & num3 & "; " & num2
            End If
        ElseIf num2 > num3 And num2 > num1 Then
            If num1 > num3 Then
                TextBox4.Text = num2 & "; " & num1 & "; " & num3
            Else
                TextBox4.Text = num2 & "; " & num3 & "; " & num1
            End If
        ElseIf num3 > num2 And num3 > num1 Then
            If num1 > num2 Then
                TextBox4.Text = num3 & "; " & num1 & "; " & num2
            Else
                TextBox4.Text = num3 & "; " & num2 & "; " & num1
            End If
        Else
            TextBox4.Text = "Los numeros son iguales"
        End If
    End Sub
End Class
