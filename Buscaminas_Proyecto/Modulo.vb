Imports BibliotecaDeClases
Module Modulo

    Public numBombas As Integer
    Public listaJugadores As List(Of Usuario)
    Public jugador As Usuario
    Public botones(9, 9) As Button
    Public dificultad As Integer


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

        For i = 0 To numBombas - 1
            Dim x, y As Integer
            Do
                x = ((9 * Rnd()) + 1)
                y = ((9 * Rnd()) + 1)
            Loop While botones(x - 1, y - 1).Tag = -1

            botones(x - 1, y - 1).Tag = -1

            botones(x - 1, y - 1).Text = "B"
        Next

    End Sub

End Module
