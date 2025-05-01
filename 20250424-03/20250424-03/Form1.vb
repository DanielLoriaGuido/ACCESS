Public Class Form1

    ' BOTÓN 1: Cuadro lleno
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim n As Integer = num1.Value
        Dim output As String = ""

        For i As Integer = 1 To n
            For j As Integer = 1 To n
                output &= "■"
            Next
            output &= vbCrLf
        Next

        txt1.Text = output
    End Sub

    ' BOTÓN 2: Triángulo inferior izquierdo
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim n As Integer = num1.Value
        Dim output As String = ""

        For i As Integer = 1 To n
            For j As Integer = 1 To i
                output &= "■"
            Next
            output &= vbCrLf
        Next

        txt1.Text = output
    End Sub

    ' BOTÓN 3: Triángulo superior izquierdo
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim n As Integer = num1.Value
        Dim output As String = ""

        For i As Integer = n To 1 Step -1
            For j As Integer = 1 To i
                output &= "■"
            Next
            output &= vbCrLf
        Next

        txt1.Text = output
    End Sub

    ' BOTÓN 4: Triángulo inferior derecho
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim n As Integer = num1.Value
        Dim output As String = ""

        For i As Integer = 1 To n
            output &= Space((n - i) * 2)
            For j As Integer = 1 To i
                output &= "■"
            Next
            output &= vbCrLf
        Next

        txt1.Text = output
    End Sub

    ' BOTÓN 5: Triángulo superior derecho
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim n As Integer = num1.Value
        Dim output As String = ""

        For i As Integer = n To 1 Step -1
            output &= Space((n - i) * 2)
            For j As Integer = 1 To i
                output &= "■"
            Next
            output &= vbCrLf
        Next

        txt1.Text = output
    End Sub

    ' BOTÓN 6: Pirámide centrada
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim n As Integer = num1.Value
        Dim output As String = ""

        For i As Integer = 1 To n
            output &= Space((n - i) * 2)
            For j As Integer = 1 To (2 * i - 1)
                output &= "■"
            Next
            output &= vbCrLf
        Next

        txt1.Text = output
    End Sub

    ' BOTÓN 7: Diamante
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim n As Integer = num1.Value
        Dim output As String = ""

        ' Parte superior
        For i As Integer = 1 To n
            output &= Space((n - i) * 2)
            For j As Integer = 1 To (2 * i - 1)
                output &= "■"
            Next
            output &= vbCrLf
        Next

        ' Parte inferior
        For i As Integer = n - 1 To 1 Step -1
            output &= Space((n - i) * 2)
            For j As Integer = 1 To (2 * i - 1)
                output &= "■"
            Next
            output &= vbCrLf
        Next

        txt1.Text = output
    End Sub

End Class
