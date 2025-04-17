Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim valor As Integer
        Dim resultado As String

        If Integer.TryParse(txt1.Text, valor) Then
            If valor >= 0 AndAlso valor <= 100 Then
                Select Case valor
                    Case 0 To 59
                        resultado = "不合格"
                    Case 60 To 69
                        resultado = "合格"
                    Case 70 To 79
                        resultado = "良い"
                    Case 80 To 94
                        resultado = "優秀"
                    Case 95 To 100
                        resultado = "極めて優秀"
                End Select
                lab1.Text = resultado
            Else
                MessageBox.Show("Por favor, ingresa un número entre 0 y 100.")
            End If
        Else
            MessageBox.Show("Por favor, ingresa un número válido.")
        End If
        'Esta bien si se usa If, Elseif, Else o Select Case
    End Sub
End Class
