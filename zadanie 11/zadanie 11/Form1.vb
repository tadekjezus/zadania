Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim pln As ULong

        Dim banknoty As New List(Of Integer)({200, 100, 50, 20, 10})
        Dim monety As New List(Of Integer)({5, 2, 1})

        If IsNumeric(TextBox1.Text) = True Then
            pln = CULng(TextBox1.Text)
        Else
            MsgBox("nieprawidłowa wartość pln")
            Exit Sub
        End If

        Dim iloscBanknotow As New Dictionary(Of Integer, Integer)
        Dim iloscMonet As New Dictionary(Of Integer, Integer)

        For Each banknot In banknoty
            Dim ilosc = pln / banknot
            iloscBanknotow.Add(banknot, ilosc)
            pln -= ilosc * banknot
        Next

        'TODO formatowanie
        '"Banknot: " + ilosBanknotow.Key + " ilość: " + iloscBanknotow[key]
        MsgBox(iloscBanknotow.ToString())

    End Sub
End Class
