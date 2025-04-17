Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim totalSegundos As Integer

        If Integer.TryParse(txttime.Text, totalSegundos) Then
            Dim horas As Integer = totalSegundos \ 3600
            Dim minutos As Integer = (totalSegundos Mod 3600) \ 60
            Dim segundos As Integer = totalSegundos Mod 60
            Me.labkotae.Text = $"{horas:D2}時間{minutos:D2}分{segundos:D2}秒"
        Else
            MessageBox.Show("Por favor, ingresa un número.")
        End If

    End Sub


    'Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
    'Dim nByou As Integer =(Microsoft.VisualBasic.Val(Me.txttime.Text)
    'Dim nFun, nJikan As Integer
    'Dim sKotae As String

    'Si se quisiera usar un NumericUpDown se podria escribir    nByou= Me.NumericUpDown1.Value

    'nJikan = nByou \ 3600         \整数割り算演算子　　　／　　　実数割り算演算子
    'nByou = nByou Mod 3600        MOD 剰余　あまり演算子

    'nFun = nByou \ 60
    'nByou = nByou Mod 60

    'sKotae = nJikan.ToString & "時間"
    'sKotae = nFun.ToString & "分"
    'sKotae = nByou.ToString & "秒"

    'Me.labkotae.Text = sKotae
    'End sub
End Class
