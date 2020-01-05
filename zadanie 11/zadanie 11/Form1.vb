Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim pln As Decimal

        Dim banknoty As New List(Of Integer)({200, 100, 50, 20, 10})
        Dim monety As New List(Of Integer)({5, 2, 1})

        If IsNumeric(TextBox1.Text) = True Then
            pln = Int(TextBox1.Text)
        Else
            MsgBox("nieprawidłowa wartość pln")
            Exit Sub
        End If

        Dim iloscBanknotow As New Dictionary(Of Integer, Integer)
        Dim iloscMonet As New Dictionary(Of Integer, Integer)

        For Each banknot In banknoty
            Dim ilosc As Integer = pln \ banknot
            iloscBanknotow.Add(banknot, ilosc)
            pln -= ilosc * banknot
        Next

        For Each moneta In monety
            Dim ilosc As Integer = pln \ moneta
            iloscMonet.Add(moneta, ilosc)
            pln -= ilosc * moneta
        Next

        Dim message As String = $"Banknoty:{Environment.NewLine}"
        message += String.Join(Environment.NewLine, iloscBanknotow.Select(Function(kvp) String.Format("{0}: {1}", kvp.Key, kvp.Value)).ToArray())

        message += $"{Environment.NewLine}Monety:{Environment.NewLine}"
        message += String.Join(Environment.NewLine, iloscMonet.Select(Function(kvp) String.Format("{0}: {1}", kvp.Key, kvp.Value)).ToArray())

        MsgBox(message)

    End Sub
End Class
