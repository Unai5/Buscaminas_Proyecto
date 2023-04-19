Imports BibliotecaDeClases
Public Class FrmJuego

    Private Sub FrmJuego_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        GenerarBotones(10, 10)

        For i = 0 To botones.GetLength(0) - 1
            For j = 0 To botones.GetLength(1) - 1
                Controls.Add(botones(i, j))
                botones(i, j).Location = New Point((i + 1) * 23, (j + 1) * 23)
            Next
        Next




    End Sub


    Public Sub GenerarBotones(ancho As Integer, alto As Integer)

        For i = 0 To ancho - 1
            For j = 0 To alto - 1
                botones(i, j) = New Button With {
                    .Text = Nothing,
                    .Name = $"btn{i}{j}",
                    .Size = New Size(23, 23),
                    .Tag = 0
                }
            Next
        Next

        numBombas = 20

        Dim casillasConBomba(numBombas - 1) As String
        Dim rnd As New Random
        For i = 0 To numBombas - 1
            Dim x, y As Integer
            Do
                x = rnd.Next(10)
                y = rnd.Next(10)
            Loop While botones(x, y).Tag = -1

            botones(x, y).Tag = -1

            botones(x, y).Text = "B"
        Next

        Dim bombasAlrededor As Integer
        For i = 0 To botones.GetLength(0) - 1
            For j = 0 To botones.GetLength(1) - 1


                If botones(i, j).Tag <> -1 Then
                    bombasAlrededor = 0
                    If i - 1 >= 0 AndAlso j - 1 >= 0 AndAlso botones(i - 1, j - 1).Tag = -1 Then bombasAlrededor += 1


                End If

            Next
        Next

    End Sub

End Class
