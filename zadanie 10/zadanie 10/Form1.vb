Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim n As ULong
        Dim bin, output As String


        If IsNumeric(TextBox1.Text) = True Then
            n = CULng(TextBox1.Text)
        Else
            MsgBox("nieprawdidłowa wartosć n")
            Exit Sub
        End If

        While n <> 0
            If n Mod 2 = 0 Then
                bin = 0
            Else
                bin = 1
            End If
            n = n \ 2
            output = Convert.ToString(bin) & output
        End While
        If output Is Nothing Then
            TextBox2.Text = "-"
        Else
            TextBox2.Text = output
        End If

        'Convert.ToString(n, 2)
    End Sub
End Class
