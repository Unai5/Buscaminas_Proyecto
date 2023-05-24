Public Class FrmConfiguracionDeJuego
    Private cerrarPorBoton As Boolean = False
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
        cerrarPorBoton = True
        FrmJuego.Show()
        Me.Visible = False
        Me.Close()

    End Sub

    Private Sub FrmConfiguracionDeJuego_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If cerrarPorBoton = True Then
            Exit Sub
        End If
        Dim resp As DialogResult
        resp = MessageBox.Show("¿Estas seguro de cerrar el juego?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If resp = Windows.Forms.DialogResult.No Then
            e.Cancel = True
        End If
    End Sub
    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        cerrarPorBoton = True
        FrmInicioDeSesion.Show()
        Me.Close()
    End Sub

    Private Sub FrmConfiguracionDeJuego_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MaximizeBox = False
        AutoSizeMode = AutoSizeMode.GrowAndShrink
    End Sub

    Private Sub btnRanking_Click(sender As Object, e As EventArgs) Handles btnRanking.Click
        cerrarPorBoton = True
        FrmRanking.Show()
        Me.Visible = False
        Me.Close()
    End Sub
End Class