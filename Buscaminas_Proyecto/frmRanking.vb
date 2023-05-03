Imports System.Runtime.ConstrainedExecution
Imports BibliotecaDeClases
Public Class frmRanking
    ReadOnly usr1 As New Usuario("Pedro", "AAA")
    ReadOnly usr2 As New Usuario("Paula", "BBB")
    ReadOnly usr3 As New Usuario("Aaaaaaaaaaa", "CCC")
    Public listaEjemplo As New List(Of Usuario) From {usr1, usr2, usr3}

    Private Sub frmRanking_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim nombre As String
        ' Dim partidasDificultadFacil As StreamReader()
        'For i = 0 To partidasDificultadFacil
        'nombre = partidasDificultadFacil(i)
        'Next
        'Controlar si el fichero esta vacio
        For Each per In listaEjemplo
            lstRanking.Items.Add(per.Nombre)
        Next
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
        ElseIf lblRanking.Text.Substring(8) = b.ToUpper Then
            btnDificultad.Text = $"Dificultad: {a}"
            lblRanking.Text = $"RANKING {c.ToUpper}"
        ElseIf lblRanking.Text.Substring(8) = c.ToUpper Then
            btnDificultad.Text = $"Dificultad: {b}"
            lblRanking.Text = $"RANKING {a.ToUpper}"
        End If
        lblRanking.Location = New Point(225 - (lblRanking.Width / 6), 22)
    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        If btnDificultad.Visible = True Then
            Me.Close()
        Else
        End If
        lstRanking.Items.Clear()
        lblRanking.Text = "RANKING FÁCIL"
        btnDificultad.Text = "Dificultad: Media"
        'cargar los datos
        For Each per In listaEjemplo
            lstRanking.Items.Add(per.Nombre)
        Next
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
        End If
    End Sub
End Class