Public Class FrmConfiguracionDeJuego
    Private Sub FrmConfiguracionDeJuego_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If Not radButtFacil.Checked AndAlso Not radButtNormal.Checked AndAlso Not radButtDificil.Checked Then
            MessageBox.Show("Selecciona una dificultad de juego")
        End If
        If radButtFacil.Checked Then
            dificultad = 1
        ElseIf radButtNormal.Checked Then
            dificultad = 2
        ElseIf radButtDificil.Checked Then
            dificultad = 3
        End If
    End Sub
    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Me.Close()
    End Sub
End Class