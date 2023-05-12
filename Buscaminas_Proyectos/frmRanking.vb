Public Class frmRanking
    Private Sub frmRanking_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If gestionUsrs.Usuarios Is Nothing Then
            MessageBox.Show("No hay usuarios todavía")
        Else
            For Each per In gestionUsrs.Usuarios
                lstRanking.Items.Add($"{per.Nombre} ........................... {per.MejorTiempoFacil}")
            Next
        End If

        btnDificultad.Text = "Dificultad: Media"
        lblRanking.Text = "RANKING FÁCIL"
        lblRanking.Location = New Point(225 - (lblRanking.Width / 6), 22)
    End Sub

    Private Sub btnDificultad_Click(sender As Object, e As EventArgs) Handles btnDificultad.Click
        'lstRanking.Items.Clear()
        Dim a As String = "Fácil"
        Dim b As String = "Medio"
        Dim c As String = "Difícil"
        If lblRanking.Text.Substring(8) = a.ToUpper Then
            btnDificultad.Text = $"Dificultad: {c}"
            lblRanking.Text = $"RANKING {b.ToUpper}"
            If gestionUsrs.Usuarios Is Nothing Then
                MessageBox.Show("No hay usuarios todavía")
            Else
                For Each per In gestionUsrs.Usuarios
                    lstRanking.Items.Add($"{per.Nombre} ...............{per.MejorTiempoMedio}")
                Next
            End If
        ElseIf lblRanking.Text.Substring(8) = b.ToUpper Then
            btnDificultad.Text = $"Dificultad: {a}"
            lblRanking.Text = $"RANKING {c.ToUpper}"
            If gestionUsrs.Usuarios Is Nothing Then
                MessageBox.Show("No hay usuarios todavía")
            Else
                For Each per In gestionUsrs.Usuarios
                    lstRanking.Items.Add($"{per.Nombre} ...............{per.MejorTiempoDificil}")
                Next
            End If
        ElseIf lblRanking.Text.Substring(8) = c.ToUpper Then
            btnDificultad.Text = $"Dificultad: {b}"
            lblRanking.Text = $"RANKING {a.ToUpper}"
            If gestionUsrs.Usuarios Is Nothing Then
                MessageBox.Show("No hay usuarios todavía")
            Else
                For Each per In gestionUsrs.Usuarios
                    lstRanking.Items.Add($"{per.Nombre} ...............{per.MejorTiempoFacil}")
                Next
            End If
        End If
        lblRanking.Location = New Point(225 - (lblRanking.Width / 6), 22)
    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        FrmConfiguracionDeJuego.Show()
        Me.Visible = False
    End Sub

    Private Sub FrmInicioSesion_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        Dim resp As DialogResult
        resp = MessageBox.Show("¿Estas seguro de cerrar el juego?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If resp = Windows.Forms.DialogResult.No Then
            e.Cancel = True
        End If
    End Sub
End Class