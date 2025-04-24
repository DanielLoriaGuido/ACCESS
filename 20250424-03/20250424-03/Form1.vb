Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim nsize As Integer = Me.NumericUpDown1.Value  'ingresar un numero
        Dim sOut As String = ""  'inicio vacio

        For i As Integer = 1 To nsize
            For j = 1 To nsize
                sOut &= "■"
            Next j
            sOut &= ControlChars.CrLf
        Next i

        Me.TextBox1.Text = sOut
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim nsize As Integer = Me.NumericUpDown1.Value  'ingresar un numero
        Dim sOut As String = ""  'inicio vacio

        For i As Integer = 1 To nsize
            For j = 1 To (i - 1) ' agregamos un espacio vacio al frente 
                sOut &= "  "

            Next j

            For j = 1 To nsize
                sOut &= "■"
            Next j


            sOut &= ControlChars.CrLf
        Next i

        Me.TextBox1.Text = sOut
    End Sub
End Class
