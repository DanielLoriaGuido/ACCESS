Public Class Form1
    ' El siguiente proyecto posee como puntos cruciales el aumento o disminucion de los pixeles ( segun canal/color )
    'En la mayoria de los casos podremos observar como los limites son de igual relevancia
    'Tomando en cuenta que haremos uso de RGB los limites son 0 (minimo) y 255 (maximo)0..


    ' Imagen que se usará para cargar y modificar
    Private bmpImg As Bitmap

    Private stImg As New Stack


    ' Cargar una imagen desde el computador y mostrarla en el PictureBox
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim od As New OpenFileDialog

        ' Si el usuario selecciona un archivo correctamente...
        If od.ShowDialog = DialogResult.OK Then
            ' Se guarda la imagen seleccionada y se muestra
            bmpImg = Bitmap.FromFile(od.FileName)
            Me.PictureBox1.Image = bmpImg
        End If
    End Sub

    ' Oscurece ligeramente la imagen reduciendo el valor del canal rojo
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        ' Recorre cada píxel de la imagen
        For nY As Integer = 0 To bmpImg.Height - 1
            For nX As Integer = 0 To bmpImg.Width - 1

                Dim c As Color
                Dim nR, nG, nB As Integer

                ' Obtiene el color actual del píxel
                c = bmpImg.GetPixel(nX, nY)

                ' Extrae los valores RGB
                nR = c.R : nG = c.G : nB = c.B

                ' Reduce el rojo en 15 unidades
                nR -= 15

                ' Si el rojo cae por debajo de 0, lo deja en 0 (para evitar errores)
                If nR < 0 Then nR = 0

                ' Crea el nuevo color con el rojo reducido
                c = Color.FromArgb(nR, nG, nB)

                ' Aplica el nuevo color al píxel
                bmpImg.SetPixel(nX, nY, c)

            Next nX
        Next nY

        ' Actualiza la imagen en pantalla
        Me.PictureBox1.Image = bmpImg
    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        For nY As Integer = 0 To bmpImg.Height - 1
            For nX As Integer = 0 To bmpImg.Width - 1

                Dim c As Color
                Dim nR, nG, nB As Integer

                c = bmpImg.GetPixel(nX, nY)

                nG = c.R : nG = c.G : nB = c.B
                nG -= 15

                If nG < 0 Then nG = 0
                c = Color.FromArgb(nR, nG, nB)
                bmpImg.SetPixel(nX, nY, c)

            Next nX
        Next nY
        Me.PictureBox1.Image = bmpImg
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        For nY As Integer = 0 To bmpImg.Height - 1
            For nX As Integer = 0 To bmpImg.Width - 1

                Dim c As Color
                Dim nR, nG, nB As Integer

                c = bmpImg.GetPixel(nX, nY)

                nB = c.R : nG = c.G : nB = c.B
                nB -= 15

                If nB < 0 Then nB = 0
                c = Color.FromArgb(nR, nG, nB)
                bmpImg.SetPixel(nX, nY, c)

            Next nX
        Next nY
        Me.PictureBox1.Image = bmpImg
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        For nY As Integer = 0 To bmpImg.Height - 1
            For nX As Integer = 0 To bmpImg.Width - 1

                Dim c As Color
                Dim nR, nG, nB As Integer

                c = bmpImg.GetPixel(nX, nY)

                nR = c.R : nG = c.G : nB = c.B

                nR += 15

                If nR > 255 Then nR = 255  ' En este caso estamos aumentando el canal rojo
                ' por lo cual debemos considerar el limite superior

                c = Color.FromArgb(nR, nG, nB)

                bmpImg.SetPixel(nX, nY, c)

            Next nX
        Next nY

        Me.PictureBox1.Image = bmpImg
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        For nY As Integer = 0 To bmpImg.Height - 1
            For nX As Integer = 0 To bmpImg.Width - 1

                Dim c As Color
                Dim nR, nG, nB As Integer

                c = bmpImg.GetPixel(nX, nY)

                nR = c.R : nG = c.G : nB = c.B

                nG += 15

                If nG > 255 Then nG = 255

                c = Color.FromArgb(nR, nG, nB)

                bmpImg.SetPixel(nX, nY, c)

            Next nX
        Next nY

        Me.PictureBox1.Image = bmpImg
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        For nY As Integer = 0 To bmpImg.Height - 1
            For nX As Integer = 0 To bmpImg.Width - 1

                Dim c As Color
                Dim nR, nG, nB As Integer

                c = bmpImg.GetPixel(nX, nY)

                nR = c.R : nG = c.G : nB = c.B

                nB += 15

                If nB > 255 Then nB = 255

                c = Color.FromArgb(nR, nG, nB)

                bmpImg.SetPixel(nX, nY, c)

            Next nX
        Next nY

        Me.PictureBox1.Image = bmpImg
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        For nY As Integer = 0 To bmpImg.Height - 1
            For nX As Integer = 0 To bmpImg.Width - 1
                Dim c As Color
                Dim nR, nG, nB As Integer

                c = bmpImg.GetPixel(nX, nY)

                nR = c.R : nG = c.G : nB = c.B

                ' Aumentamos cada canal
                nR += 15
                nG += 15
                nB += 15

                ' Nos aseguramos de no superar el máximo permitido (255)
                If nR > 255 Then nR = 255
                If nG > 255 Then nG = 255
                If nB > 255 Then nB = 255

                c = Color.FromArgb(nR, nG, nB)
                bmpImg.SetPixel(nX, nY, c)
            Next nX
        Next nY

        Me.PictureBox1.Image = bmpImg
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        For nY As Integer = 0 To bmpImg.Height - 1
            For nX As Integer = 0 To bmpImg.Width - 1
                Dim c As Color
                Dim nR, nG, nB As Integer

                c = bmpImg.GetPixel(nX, nY)

                nR = c.R : nG = c.G : nB = c.B

                ' disminuimos cada canal
                nR -= 15
                nG -= 15
                nB -= 15

                ' Nos aseguramos de no superar el minimo permitido (0)
                If nR < 0 Then nR = 0
                If nG < 0 Then nG = 0
                If nB < 0 Then nB = 0

                c = Color.FromArgb(nR, nG, nB)
                bmpImg.SetPixel(nX, nY, c)
            Next nX
        Next nY

        Me.PictureBox1.Image = bmpImg
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        For nY As Integer = 0 To bmpImg.Height - 1
            For nX As Integer = 0 To bmpImg.Width - 1
                Dim c As Color
                Dim nR, nG, nB As Integer

                c = bmpImg.GetPixel(nX, nY)

                ' Se invierte el valor de cada componente de color
                nR = 255 - c.R
                nG = 255 - c.G
                nB = 255 - c.B

                c = Color.FromArgb(nR, nG, nB)
                bmpImg.SetPixel(nX, nY, c)
            Next nX
        Next nY

        Me.PictureBox1.Image = bmpImg
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        For nY As Integer = 0 To bmpImg.Height - 1
            For nX As Integer = 0 To bmpImg.Width - 1
                Dim c As Color
                Dim nR, nG, nB, avg As Integer

                c = bmpImg.GetPixel(nX, nY)

                nR = c.R
                nG = c.G
                nB = c.B

                ' Calculamos el promedio 
                avg = (nR + nG + nB) \ 3

                ' Asignamos el mismo valor a R, G y B para obtener un gris
                c = Color.FromArgb(avg, avg, avg)  'cambiamos el uso frecuente de nR... por avg
                bmpImg.SetPixel(nX, nY, c)
            Next nX
        Next nY

        Me.PictureBox1.Image = bmpImg

    End Sub

    Private Const MOZAIKU As Integer = 16

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        For nX As Integer = 0 To bmpImg.Width - 1 Step MOZAIKU

            For nY As Integer = 0 To bmpImg.Height - 1 Step MOZAIKU
                Dim c As Color

                Dim mR As Integer = 0
                Dim mG As Integer = 0
                Dim mB As Integer = 0
                Dim nXEnd As Integer = 0
                Dim nYEnd As Integer = 0

                nXEnd = nX + MOZAIKU : nYEnd = nY + MOZAIKU

                If nYEnd > bmpImg.Height - 1 Then nYEnd = bmpImg.Height - 1
                If nXEnd > bmpImg.Width - 1 Then nXEnd = bmpImg.Width - 1

                Dim nMcount As Integer = 0

                For mx As Integer = nX To nXEnd
                    For mY As Integer = nY To nYEnd
                        Dim nR, nG, nB As Integer

                        c = bmpImg.GetPixel(mx, mY)
                        nR = c.R
                        nG = c.G
                        nB = c.B

                        mR += nR
                        mG += nG
                        mB += nB
                        nMcount += 1


                    Next mY
                Next mx
                mR \= nMcount
                mG \= nMcount
                mB \= nMcount
                c = Color.FromArgb(mR, mG, mB)

                For mX As Integer = nX To nXEnd
                    For mY As Integer = nY To nYEnd
                        bmpImg.SetPixel(mX, mY, c)
                    Next mY
                Next mX

            Next nY
        Next nX
        Me.PictureBox1.Image = bmpImg

    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        For nY As Integer = 0 To bmpImg.Height - 1
            For nX As Integer = 0 To bmpImg.Width - 1
                Dim c As Color
                Dim nR, nG, nB, avg As Integer

                c = bmpImg.GetPixel(nX, nY)

                nR = c.R
                nG = c.G
                nB = c.B

                avg = (nR + nG + nB) \ 3
                If avg > 80 Then avg = 255 Else avg = 0

                c = Color.FromArgb(avg, avg, avg)
                bmpImg.SetPixel(nX, nY, c)
            Next nX
        Next nY

        Me.PictureBox1.Image = bmpImg
    End Sub


    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        If stImg IsNot Nothing Then
            bmpImg = CType(stImg.Clone(), Bitmap)
            Me.PictureBox1.Image = bmpImg
        End If
    End Sub
End Class
