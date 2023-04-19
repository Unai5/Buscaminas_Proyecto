Imports BibliotecaDeClases
Public Class frmRanking
    Public listaEjemplo As List(Of Usuario) 'meter ejemplos de usuarios y probar con ejemplos en el proyecto

    Private Sub frmRanking_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnRankingIndividual.Visible = False
        btnDificultad.Location = New Point(561, 489)
        lstRanking.Items.Clear()
        btnDificultad.Text = "Dificultad"
        lblRanking.Text = "RANKING"
    End Sub

    Private Sub lstRanking_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstRanking.SelectedIndexChanged
        btnDificultad.Location = New Point(73, 172)
        btnRankingIndividual.Location = New Point(73, 217)
        btnRankingIndividual.Visible = True

    End Sub

    Private Sub btnDificultad_Click(sender As Object, e As EventArgs) Handles btnDificultad.Click
        Dim a As String = "Fácil"
        Dim b As String = "Medio"
        Dim c As String = "Difícil"
        If btnDificultad.Text = "Dificultad" Then
            btnDificultad.Text = a
            lblRanking.Text &= $" {a.ToUpper}"
        Else
            If btnDificultad.Text = a Then
                btnDificultad.Text = b
                lblRanking.Text &= $" {b.ToUpper}"
                'Meter los ficheros
            End If
            If btnDificultad.Text = b Then
                btnDificultad.Text = c
                lblRanking.Text &= $" {c.ToUpper}"
            End If
            If btnDificultad.Text = c Then
                btnDificultad.Text = a
                lblRanking.Text &= $" {a.ToUpper}"
            End If
        End If
    End Sub

    Private Sub btnRankingIndividual_Click(sender As Object, e As EventArgs) Handles btnRankingIndividual.Click
        lstRanking.Location = New Point(141, 73)
        lblRanking.Text &= " INDIVIDUAL"
    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        If lblRanking.Text = "RANKING INDIVIDUAL" Then
            btnRankingIndividual.Visible = False
            btnDificultad.Location = New Point(561, 489)
            lstRanking.Items.Clear()
            btnDificultad.Text = "Dificultad"
            lblRanking.Text = "RANKING"
        Else
            Close()
        End If
    End Sub
End Class