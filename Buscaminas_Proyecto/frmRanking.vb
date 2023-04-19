Public Class frmRanking
    Private Sub frmRanking_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnRankingIndividual.Visible = False
        btnDificultad.Location = New Point(561, 489)
        lstRanking.Items.Clear()
        btnDificultad.Text = "Dificultad"
    End Sub

    Private Sub lstRanking_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstRanking.SelectedIndexChanged
        btnDificultad.Location = New Point(73, 172)
        btnRankingIndividual.Location = New Point(73, 217)


    End Sub

    Private Sub btnDificultad_Click(sender As Object, e As EventArgs) Handles btnDificultad.Click
        Dim a As String = "Fácil"
        Dim b As String = "Medio"
        Dim c As String = "Difícil"
        If btnDificultad.Text = "Dificultad" Then
            btnDificultad.Text = a
        Else
            If btnDificultad.Text = a Then
                btnDificultad.Text = b
                'Meter los ficheros
            End If
            If btnDificultad.Text = b Then
                btnDificultad.Text = c
            End If
            If btnDificultad.Text = c Then
                btnDificultad.Text = a
            End If
        End If
    End Sub
End Class