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
        If btnDificultad.Visible = True Then
            Me.Close()
            FrmConfiguracionDeJuego.Show()
        Else
        End If
        lstRanking.Items.Clear()
        lblRanking.Text = "RANKING FÁCIL"
        btnDificultad.Text = "Dificultad: Media"
        If gestionUsrs.Usuarios Is Nothing Then
            MessageBox.Show("No hay usuarios todavía")
        Else
            For Each per In gestionUsrs.Usuarios
                lstRanking.Items.Add($"{per.Nombre} ...............{per.MejorTiempoFacil}")
            Next
        End If
        btnDificultad.Visible = True
        btnDificultad.Location = New Point(56, 384)
        btnVolver.Location = New Point(346, 386)

    End Sub
    Private Sub lstRanking_DoubleClick(sender As Object, e As EventArgs) Handles lstRanking.DoubleClick
        If lstRanking.SelectedItem = "" OrElse lstRanking.SelectedItem Is Nothing Then
            MessageBox.Show($"No has seleccionado a nadie", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            btnDificultad.Visible = False
            btnVolver.Location = New Point(217, 386)
            lblRanking.Text = $"RANKING DE {lstRanking.SelectedItem.ToString.ToUpper}"
            If lstRanking.SelectedItem.ToString.Length > 10 Then
                lblRanking.Location = New Point(225 - (lblRanking.Width / 4), 22)
            Else
                lblRanking.Location = New Point(225 - (lblRanking.Width / 6), 22)
            End If
            If gestionUsrs.Usuarios Is Nothing Then
                MessageBox.Show("No hay usuarios todavía")
            Else
                'Encontrar usuario
                For Each tiempo In gestionUsrs.Usuarios
                    'lstRanking.Items.Add($"{per.Nombre} ...............{per.MejorTiempoFacil}")
                Next
            End If
        End If
    End Sub

    Private Sub lstRanking_MouseHover(sender As Object, e As EventArgs) Handles lstRanking.MouseHover
        Dim linea As Control = TryCast(sender, Control)
        If linea Is Nothing Then
            Exit Sub
        Else
            linea.BackColor = Color.Aquamarine
        End If
    End Sub
    Private Sub lstRanking_MouseLeave(sender As Object, e As EventArgs) Handles lstRanking.MouseLeave

    End Sub
End Class