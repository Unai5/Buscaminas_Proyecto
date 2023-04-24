Imports System.Runtime.ConstrainedExecution
Imports BibliotecaDeClases
Public Class frmRanking
    ReadOnly usr1 As New Usuario("Pedro", "AAA")
    ReadOnly usr2 As New Usuario("Paula", "BBB")
    ReadOnly usr3 As New Usuario("Paco", "CCC")
    ''' <summary>
    ''' Ejemplo de lista, luego se importará la información de los ficheros
    ''' </summary>
    Public listaEjemplo As New List(Of Usuario) From {usr1, usr2, usr3}
    Private Sub frmRanking_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'lstRanking.Items.Clear()
        btnRankingIndividual.Visible = False
        btnDificultad.Location = New Point(54, 188)
        btnDificultad.Text = "Dificultad"
        lblRanking.Text = "RANKING"
        lblRanking.Location = New Point(225, 22)

        For Each per In listaEjemplo
            lstRanking.Items.Add(per.Nombre)
        Next
    End Sub

    Private Sub btnDificultad_Click(sender As Object, e As EventArgs) Handles btnDificultad.Click
        'lstRanking.Items.Clear()

        Dim titulo As String = "RANKING"
        Dim a As String = "Fácil"
        Dim b As String = "Medio"
        Dim c As String = "Difícil"
        If btnDificultad.Text = "Dificultad" Then
            btnDificultad.Text = a
            lblRanking.Text = $"{titulo} {a.ToUpper}"
            btnRankingIndividual.Visible = True
            btnDificultad.Location = New Point(54, 153)
            btnRankingIndividual.Location = New Point(54, 232)
        Else
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
        If lstRanking.SelectedItem = "" OrElse lstRanking.SelectedItem Is Nothing Then
            MessageBox.Show($"No has seleccionado a nadie", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            btnDificultad.Visible = False
            btnRankingIndividual.Visible = False
            lstRanking.Location = New Point(141, 74)
            lblRanking.Text = $"RANKING DE {lstRanking.SelectedItem}"
            lblRanking.Location = New Point(225 - (93 / 2), 22)
            'Ahora funciona, con ficheros no, sacar el nombre de la persona selecionada de otro sitio

            'importar todos los resultados
        End If
    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        If lblRanking.Text = "RANKING" Then
            Me.Close()
        Else
            lblRanking.Location = New Point()
            btnRankingIndividual.Visible = False
            btnDificultad.Visible = True
            btnDificultad.Location = New Point(54, 188)
            lstRanking.Location = New Point(203, 74)
            lstRanking.Items.Clear()
            btnDificultad.Text = "Dificultad"
            lblRanking.Text = "RANKING"

            'Agregar el ranking de inicio 

        End If
    End Sub
End Class