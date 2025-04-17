Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim nTeihen, ntakasa As Integer
        Dim nkotae As Integer
        '⇧　Integer は整数型

        ntakasa = Microsoft.VisualBasic.Val(Me.txttakasa.Text)
        '⇧　古い関数ですがAccessVBAではこれを使います
        nTeihen = Integer.Parse(Me.txtteihen.Text)
        '⇧　今の書き方です。　C#なんかはこれです。

        nkotae = nTeihen * ntakasa

        Me.labkotae.Text = nkotae.ToString()
        '⇧　Me.labkotae.Text = Microsoft.VisualBasic.Str(nkotae)
        '⇧ 古い関数を使った場合Str関数　数値→文字

        'nkotae = "12" + "34"
        'nkotae = 12 + 34

    End Sub
End Class
