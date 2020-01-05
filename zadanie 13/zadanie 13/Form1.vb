Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim n, dzielnik As ULong
        Dim liczba pierwsza As String   

        If IsNumeric(TextBox1.Text) = True Then
            n = CULng(TextBox1.Text)
        Else
            MsgBox("nieprawidlowa wartość n")
            Exit Sub
        End If

        For dzielnik = 1 
    End Sub
End Class
