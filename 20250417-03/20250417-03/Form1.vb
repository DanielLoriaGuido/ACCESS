Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim nnennrei As Integer
        Dim nshinchou As Integer
        Dim result As String

        nnennrei = Me.txt1.Text
        nshinchou = Me.txt2.Text

        If nnennrei >= 10 Or nshinchou >= 110 Then
            result = "OK"
            pic1.Visible = False
            pic2.Visible = True
        Else
            result = "残念ですが次は乗りましょう"
            pic1.Visible = True
            pic2.Visible = False
        End If

        Me.labkekka.Text = result
    End Sub
    Private Sub txt1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt1.KeyPress
        'The keypressed method uses the KeyChar property to check whether the ENTER key pressed.
        'If the ENTER key is pressed, the Handled property is set to true, which indicates the event is handled.
        Select Case e.KeyChar
            Case "0"c To "9"c 'Determina los caracteres a utilizar
            Case ChrW(8) 'Permite la accion de borrado
            Case Else
                e.Handled = True ' No permite otros caracteres
        End Select
    End Sub

    Private Sub txt2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt2.KeyPress
        Select Case e.KeyChar
            Case "0"c To "9"c
            Case ChrW(8)
            Case Else
                e.Handled = True
        End Select
    End Sub
End Class
