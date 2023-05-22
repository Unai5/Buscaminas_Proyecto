Imports BibliotecaDeClases
Public Class FrmRanking
    Private cerrarPorBoton As Boolean = False
    Private Sub FrmRanking_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If gestionUsrs.OrdenarLista(1) Is Nothing Then
            MessageBox.Show("No hay usuarios todavía, prueba en otra dificultad")
            Exit Sub
        Else
            Dim listaUsuarios As List(Of Usuario) = gestionUsrs.OrdenarLista(1)
            For Each per In listaUsuarios
                lstRanking.Items.Add($"{per.Nombre} ........................... {per.MejorTiempoFacil}")
            Next
        End If

        btnDificultad.Text = "Dificultad: Media"
        lblRanking.Text = "RANKING FÁCIL"
        lblRanking.Location = New Point(225 - (lblRanking.Width / 6), 22)
    End Sub

    Private Sub btnDificultad_Click(sender As Object, e As EventArgs) Handles btnDificultad.Click
        Dim a As String = "Fácil"
        Dim b As String = "Medio"
        Dim c As String = "Difícil"
        lstRanking.Items.Clear()
        If lblRanking.Text.Substring(8) = a.ToUpper Then
            btnDificultad.Text = $"Dificultad: {c}"
            lblRanking.Text = $"RANKING {b.ToUpper}"
            If gestionUsrs.OrdenarLista(1) Is Nothing Then
                MessageBox.Show("No hay usuarios todavía, prueba en otra dificultad")
                Exit Sub
            Else
                Dim listaUsuarios As List(Of Usuario) = gestionUsrs.OrdenarLista(2)
                For Each per In listaUsuarios
                    lstRanking.Items.Add($"{per.Nombre} ........................... {per.MejorTiempoFacil}")
                Next
            End If
        ElseIf lblRanking.Text.Substring(8) = b.ToUpper Then
            btnDificultad.Text = $"Dificultad: {a}"
            lblRanking.Text = $"RANKING {c.ToUpper}"

            If gestionUsrs.OrdenarLista(3) Is Nothing Then
                MessageBox.Show("No hay usuarios todavía, prueba en otra dificultad")
                Exit Sub
            Else
                Dim listaUsuarios As List(Of Usuario) = gestionUsrs.OrdenarLista(3)
                For Each per In listaUsuarios
                    lstRanking.Items.Add($"{per.Nombre} ........................... {per.MejorTiempoFacil}")
                Next
            End If
        ElseIf lblRanking.Text.Substring(8) = c.ToUpper Then
            btnDificultad.Text = $"Dificultad: {b}"
            lblRanking.Text = $"RANKING {a.ToUpper}"
            If gestionUsrs.OrdenarLista(1) Is Nothing Then
                MessageBox.Show("No hay usuarios todavía, prueba en otra dificultad")
                Exit Sub
            Else
                Dim listaUsuarios As List(Of Usuario) = gestionUsrs.OrdenarLista(1)
                For Each per In listaUsuarios
                    lstRanking.Items.Add($"{per.Nombre} ........................... {per.MejorTiempoFacil}")
                Next
            End If
        End If
        lblRanking.Location = New Point(225 - (lblRanking.Width / 6), 22)
    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        cerrarPorBoton = True
        FrmInicioDeSesion.Show()
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