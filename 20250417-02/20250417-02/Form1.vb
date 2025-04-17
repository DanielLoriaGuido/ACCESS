Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim dblWeight As Double
        Dim dblHeight As Double
        Dim rohrerIndex As Double

        ' Intentamos convertir los valores de los TextBox a tipo Double
        If Double.TryParse(txtWeight.Text, dblWeight) AndAlso Double.TryParse(txtHeight.Text, dblHeight) Then
            ' Calculamos el índice de Rohrer
            rohrerIndex = (dblWeight * 10 ^ 7) / (dblHeight ^ 3)

            ' Mostramos el índice de Rohrer en el primer Label
            lblRohrer.Text = "ローレル指数: " & rohrerIndex.ToString("F2")

            ' Clasificación y juicio en el segundo Label
            If rohrerIndex >= 150 Then
                lblJudge.Text = "肥満です" ' Obesidad
            ElseIf rohrerIndex >= 130 Then
                lblJudge.Text = "やや肥満です" ' Levele de obesidad
            ElseIf rohrerIndex >= 110 Then
                lblJudge.Text = "標準です" ' Normal
            ElseIf rohrerIndex >= 90 Then
                lblJudge.Text = "やや痩せ気味です" ' Levele de delgadez
            Else
                lblJudge.Text = "痩せすぎです" ' Demasiado delgado
            End If
        Else
            ' Si no se pudieron convertir los valores, mostramos un mensaje de error
            lblRohrer.Text = "Por favor ingrese valores válidos."
            lblJudge.Text = ""
        End If
    End Sub
End Class
