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
        lblRanking.Location = New Point(225, 22)

        'importar una clase de ejemplo para mostrara al inicio que sea visual
        For Each per In listaEjemplo

            Dim lstColor As DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
            lstRanking.DrawMode = DrawMode.OwnerDrawFixed
            lstRanking.DrawItem += New DrawItemEventHandler(ListBox1_DrawItem)


            lstRanking.Items.Add(per.Nombre)
        Next

    End Sub

    Private Sub btnDificultad_Click(sender As Object, e As EventArgs) Handles btnDificultad.Click
        lstRanking.Items.Clear()

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
            Me.Show()
        End If
    End Sub
End Class