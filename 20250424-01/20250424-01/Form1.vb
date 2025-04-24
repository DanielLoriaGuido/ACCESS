Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sMsg As String = ""

        For i As Integer = 10 To 1 Step -1   'Tomese que i va de x a x numero en tantos saltos
            'For ル－プ　変数　初期値　to 終了直　step　増分
            'a = 10
            ' a += 20
            'a → 30

            sMsg &= (i.ToString & " , ")     'division que aparecera entre cada numero

            If (i Mod 10) = 0 Then
                sMsg &= ControlChars.CrLf   'con el siguiente codigo permitimos que por "guion" solo aparezcan 10 numeros,despues de eso se hace un salto de linea
            End If                          'tomese en cuenta que solo se puede usar con ciertos numeros, E.G  si utilizamos    1 to 10000 no funcionara (debido a que el mod es a 10)

            ' &  文字連接演算子
            ' ”AB”　＆　”CD”　＝　”ABCD”
            ' ”AB"　+　”CD”　→　”ABCD”　これもOKです
        Next

        Me.Label1.Text = sMsg
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim nsum As Integer = 0

        For i As Integer = 1 To 5  'se suman todos los valores que se iteren de i ( en este caso inicia en el 1 y ternmina en 5 inclusivo)
            nsum += i    ' de igual manera se puede hacer uso de step si asi se desea
        Next

        Me.Label1.Text = nsum.ToString

    End Sub
End Class
