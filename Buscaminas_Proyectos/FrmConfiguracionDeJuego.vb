Imports System.Reflection

Public Class FrmConfiguracionDeJuego
    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If Not radButtFacil.Checked AndAlso Not radButtNormal.Checked AndAlso Not radButtDificil.Checked Then
            MessageBox.Show("Selecciona una dificultad de juego")
            Exit Sub
        End If
        If radButtFacil.Checked Then
            dificultad = 1
        ElseIf radButtNormal.Checked Then
            dificultad = 2
        ElseIf radButtDificil.Checked Then
            dificultad = 3
        End If

        FrmJuego.Show()
        Me.Visible = False
    End Sub

    Private Sub FrmInicioSesion_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        Dim resp As DialogResult
        resp = MessageBox.Show("¿Estas seguro de cerrar el juego?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If resp = Windows.Forms.DialogResult.No Then
            e.Cancel = True
        End If
    End Sub
    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        FrmInicioDeSesion.Show()
        Me.Visible = False
    End Sub
End Class