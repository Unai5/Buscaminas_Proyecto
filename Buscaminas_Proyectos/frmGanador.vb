Public Class frmGanador
    Private Sub frmGanador_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If dificultad = 1 Then
            Label2.Text += "FÁCIL"
        ElseIf dificultad = 2 Then
            Label2.Text += "MEDIA"
        Else
            Label2.Text += "DIFÍCIL"
        End If

        Label3.Text += $"{Format(tiempoPartida(0), "##00")} : {Format(tiempoPartida(1), "##00")}"

    End Sub
End Class