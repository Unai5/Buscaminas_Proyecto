Imports BibliotecaDeClases
Public Class frmRanking
    Dim usr1 As New Usuario("Pedro", "AAA")
    Dim usr2 As New Usuario("Paula", "BBB")
    Public listaEjemplo As New List(Of Usuario) From {usr1, usr2}
    'meter ejemplos de usuarios y probar con ejemplos en el proyecto
    Private Sub frmRanking_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnRankingIndividual.Visible = False
        btnDificultad.Location = New Point(54, 188)
        lstRanking.Items.Clear()
        btnDificultad.Text = "Dificultad"
        lblRanking.Text = "RANKING"
        'importar una clase de ejemplo para mostrara al inicio que sea visual
        For Each per In listaEjemplo
            lstRanking.Items.Add(per)
        Next
    End Sub

    Private Sub lstRanking_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstRanking.SelectedIndexChanged


    End Sub

    Private Sub btnDificultad_Click(sender As Object, e As EventArgs) Handles btnDificultad.Click
        Dim titulo As String = "RANKING"
        Dim a As String = "Fácil"
        Dim b As String = "Medio"
        Dim c As String = "Difícil"
        If btnDificultad.Text = "Dificultad" Then
            btnDificultad.Text = a
            lblRanking.Text = $"{titulo} {a.ToUpper}"

        Else
            btnDificultad.Location = New Point(54, 153)
            btnRankingIndividual.Location = New Point(54, 232)
            btnRankingIndividual.Visible = True

            If btnDificultad.Text = $"{a}" Then
                btnDificultad.Text = b
                lblRanking.Text = $"{titulo} {b.ToUpper}"
                'Meter los ficheros
                Exit Sub
            End If
            If btnDificultad.Text.Contains(b) Then
                btnDificultad.Text = c
                lblRanking.Text = $"{titulo} {c.ToUpper}"

                Exit Sub
            End If
            If btnDificultad.Text.Contains(c) Then
                btnDificultad.Text = a
                lblRanking.Text = $"{titulo} {a.ToUpper}"

                Exit Sub
            End If
        End If
    End Sub

    Private Sub btnRankingIndividual_Click(sender As Object, e As EventArgs) Handles btnRankingIndividual.Click
        lstRanking.Location = New Point(141, 74)
        lblRanking.Text &= " INDIVIDUAL"
        btnDificultad.Visible = False
        btnRankingIndividual.Visible = False



        If lstRanking.SelectedItem = "" Then
            MessageBox.Show($"No has seleccionado a nadie", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else

        End If
    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        If lblRanking.Text = "RANKING INDIVIDUAL" Then
            btnRankingIndividual.Visible = False
            btnDificultad.Visible = True
            btnDificultad.Location = New Point(54, 188)
            lstRanking.Location = New Point(203, 74)
            lstRanking.Items.Clear()
            btnDificultad.Text = "Dificultad"
            lblRanking.Text = "RANKING"
        Else
            Close()
        End If
    End Sub
End Class