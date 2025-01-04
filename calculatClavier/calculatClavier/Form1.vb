Public Class Form1
    Dim A As Double
    Dim b As Double
    Dim c As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text = TextBox1.Text + "1"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = TextBox1.Text + "2"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Text = TextBox1.Text + "3"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TextBox1.Text = TextBox1.Text + "4"
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TextBox1.Text = TextBox1.Text + "5"
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        TextBox1.Text = TextBox1.Text + "6"
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        TextBox1.Text = TextBox1.Text + "7"
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        TextBox1.Text = TextBox1.Text + "8"
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        TextBox1.Text = TextBox1.Text + "9"
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        TextBox1.Text = TextBox1.Text + "0"
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        TextBox1.Clear()
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        A = Val(TextBox1.Text)
        TextBox1.Clear()
        c = "+"
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        A = Val(TextBox1.Text)
        TextBox1.Clear()
        c = "-"
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        A = Val(TextBox1.Text)
        TextBox1.Clear()
        c = "*"
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        A = Val(TextBox1.Text)
        TextBox1.Clear()
        c = "/"
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        b = Val(TextBox1.Text)
        TextBox1.Clear()
        If c = "+" Then TextBox1.Text = A + b
        If c = "-" Then TextBox1.Text = A - b
        If c = "*" Then TextBox1.Text = A * b
        If c = "/" Then TextBox1.Text = A / b
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        Me.Close()
    End Sub


    Private Sub Form1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress
        '
        Select Case e.KeyChar
            Case "0"c To "9"c
                TextBox1.Text &= e.KeyChar
                e.Handled = True
            Case "+"c
                Button11.PerformClick()
                e.Handled = True
            Case "-"c
                Button14.PerformClick()
                e.Handled = True
            Case "*"c
                Button15.PerformClick()
                e.Handled = True
            Case "/"c
                Button16.PerformClick()
                e.Handled = True
            Case "="c, ChrW(13)
                Button10.PerformClick()
                e.Handled = True
            Case ChrW(8)
                If TextBox1.Text.Length > 0 Then
                    TextBox1.Text = TextBox1.Text.Substring(0, TextBox1.Text.Length - 1)
                End If
                e.Handled = True
        End Select
    End Sub
End Class
