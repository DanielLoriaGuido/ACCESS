Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim nint As Integer = Me.txtint.Text  'numero que se ingrese en el textbox
        Dim nsum As Integer = 0  'iniciamos la suma en 0

        For i = 1 To nint  'i inicia en 1 inclusivo
            nsum += i  'el loop se detiene al llegar al valor ingresado
        Next i  'pasamos a la siguiente i

        Me.Label1.Text = nsum.ToString


    End Sub
End Class
