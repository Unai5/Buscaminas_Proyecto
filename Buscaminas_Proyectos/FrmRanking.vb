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
            gestionUsrs.OrdenarLista(1)
            If gestionUsrs.OrdenarLista(1) Is Nothing OrElse gestionUsrs.OrdenarLista(1).Count = 0 Then
                MessageBox.Show("No hay usuarios todavía, prueba en otra dificultad")
                Exit Sub
            Else
                For Each per In gestionUsrs.OrdenarLista(1)
                    lstRanking.Items.Add($"{per.Nombre} ........................... {per.MejorTiempoFacil}")
                Next
        End If


    End Sub

    Private Sub btnDificultad_Click(sender As Object, e As EventArgs) Handles btnDificultad.Click
        lstRanking.Items.Clear()
        If lblRanking.Text.Substring(8) = a.ToUpper Then
            btnDificultad.Text = $"Dificultad: {c}"
            lblRanking.Text = $"RANKING {b.ToUpper}"
            If gestionUsrs.OrdenarLista(2) Is Nothing OrElse gestionUsrs.OrdenarLista(2).Count = 0 Then
                MessageBox.Show("No hay usuarios todavía, prueba en otra dificultad")
                Exit Sub
            Else
                For Each per In gestionUsrs.OrdenarLista(2)
                    lstRanking.Items.Add($"{per.Nombre} ........................... {per.MejorTiempoFacil}")
                Next
            End If
        ElseIf lblRanking.Text.Substring(8) = b.ToUpper Then
            btnDificultad.Text = $"Dificultad: {a}"
            lblRanking.Text = $"RANKING {c.ToUpper}"

            If gestionUsrs.OrdenarLista(3) Is Nothing OrElse gestionUsrs.OrdenarLista(3).Count = 0 Then
                MessageBox.Show("No hay usuarios todavía, prueba en otra dificultad")
                Exit Sub
            Else
                For Each per In gestionUsrs.OrdenarLista(3)
                    lstRanking.Items.Add($"{per.Nombre} ........................... {per.MejorTiempoFacil}")
                Next
            End If
        ElseIf lblRanking.Text.Substring(8) = c.ToUpper Then
            btnDificultad.Text = $"Dificultad: {b}"
            lblRanking.Text = $"RANKING {a.ToUpper}"
            If gestionUsrs.OrdenarLista(1) Is Nothing OrElse gestionUsrs.OrdenarLista(1).Count = 0 Then
                MessageBox.Show("No hay usuarios todavía, prueba en otra dificultad")
                Exit Sub
            Else
                For Each per In gestionUsrs.OrdenarLista(1)
                    lstRanking.Items.Add($"{per.Nombre} ........................... {per.MejorTiempoFacil}")
                Next
            End If
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