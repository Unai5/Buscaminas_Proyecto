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


End Class
