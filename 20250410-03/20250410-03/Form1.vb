Imports System.Net.NetworkInformation

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim note As Integer
        Dim result As String

        note = Me.num1.Text

        If note >= 60 Then

            result = "おめでとう"
            pic1.Visible = True
            pic2.Visible = False

        Else

            result = "頑張って"
            pic1.Visible = False
            pic2.Visible = True

        End If

        Me.labkekka.Text = result
    End Sub
End Class
