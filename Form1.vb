Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        Dim strName As String

        Dim intlength1 As Integer
        Dim intlength2 As Integer
        Dim intlength3 As Integer
        Dim intwidth1 As Integer
        Dim intwidth2 As Integer
        Dim intwidth3 As Integer

        Dim room1 As Integer
        Dim room2 As Integer
        Dim room3 As Integer

        Dim intTotal As Integer

        strName = txtName.Text

        intlength1 = Val(txtR1length.Text)
        intlength2 = Val(txtR2length.Text)
        intlength3 = Val(txtR3length.Text)
        intwidth1 = Val(txtR1width.Text)
        intwidth2 = Val(txtR2width.Text)
        intwidth3 = Val(txtR3width.Text)

        room1 = intlength1 + intwidth1
        room2 = intlength2 + intwidth2
        room3 = intlength3 + intwidth3

        intTotal = room1 + room2 + room3

        If intTotal < 2000 Then
            lblmsg.Text = "Ahem," & strName & "this is a SMALL house calculator"
            lbltotal.Text = "Sorry " & "," & "no answer for you" & "!!"
        Else
            lblmsg.Text = "The total area of the house is" & ":"
            lbltotal.Text = intTotal & "Square Feet"
        End If


    End Sub
End Class
