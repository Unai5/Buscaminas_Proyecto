Imports System.Runtime.ConstrainedExecution
Imports BibliotecaDeClases
Public Class FrmRanking
    Private cerrarPorBoton As Boolean = False
    Dim dificultades() As String = {"Fácil", "Medio", "Difícil"}
    Dim difActual As Byte = 0
    Dim difSiguiente As Byte = 1
    Private Sub FrmRanking_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim errores As String = ""
        gestionUsrs = New GestionUsuario(errores)
        btnDificultad.Text = $"Dificultad: {dificultades(difSiguiente)}"
        lblRanking.Text = $"RANKING {dificultades(difActual).ToUpper}"
        lblRanking.Location = New Point(225 - (lblRanking.Width / 6), 22)

        Dim listaRanking = gestionUsrs.OrdenarLista(dificultades(difActual + 1))
        If listaRanking Is Nothing OrElse listaRanking.Count = 0 Then
            lstRanking.Items.Add("    ")
            lstRanking.Items.Add("    ")
            lstRanking.Items.Add("    ")
            lstRanking.Items.Add("          No hay partidas ganadas")
            Exit Sub
        Else
            For Each per In listaRanking
                lstRanking.Items.Add($"{per.Nombre} ........................... {per.MejorTiempoFacil}")
            Next
        End If


    End Sub

    Private Sub btnDificultad_Click(sender As Object, e As EventArgs) Handles btnDificultad.Click
        lstRanking.Items.Clear()
        difActual += 1
        If difActual > 2 Then
            difActual = 0
        End If
        difSiguiente += 1
        If difSiguiente > 2 Then
            difSiguiente = 0
        End If
        lblRanking.Text = $"RANKING {dificultades(difActual).ToUpper}"
        btnDificultad.Text = $"Dificultad: {dificultades(difSiguiente)}"
        Dim listaRanking = gestionUsrs.OrdenarLista(difActual + 1)
        If listaRanking Is Nothing OrElse listaRanking.Count = 0 Then
            lstRanking.Items.Add("    ")
            lstRanking.Items.Add("    ")
            lstRanking.Items.Add("    ")
            lstRanking.Items.Add("          No hay partidas ganadas")
            Exit Sub
        Else
            For Each per In listaRanking
                lstRanking.Items.Add($"{per.Nombre} ........................... {per.MejorTiempoFacil}")
            Next
        End If
        lblRanking.Location = New Point(225 - (lblRanking.Width / 6), 22)
    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        cerrarPorBoton = True
        FrmConfiguracionDeJuego.Show()
        Me.Visible = False
        Me.Close()
    End Sub

    Private Sub FrmRanking_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If cerrarPorBoton = True Then
            Exit Sub
        End If
        Dim resp As DialogResult
        resp = MessageBox.Show("¿Estas seguro de cerrar el juego?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If resp = Windows.Forms.DialogResult.No Then
            e.Cancel = True
        End If
    End Sub
End Class