Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim n, dzielnik As ULong

        If IsNumeric(TextBox1.Text) = True Then
            n = CULng(TextBox1.Text)
        Else
            MsgBox("nieprawidlowa wartość n")
            Exit Sub
        End If

        Dim isPrime As Boolean = True

        For dzielnik = 2 To n - 1
            If n Mod dzielnik = 0 Then
                isPrime = False
                Exit For
            End If
        Next

        MsgBox($"Liczba pierwsza: {isPrime.ToString()}")

    End Sub
End Class
