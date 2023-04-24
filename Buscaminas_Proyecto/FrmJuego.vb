Imports System.Drawing.Drawing2D
Imports System.Drawing.Text
Imports System.Linq.Expressions
Imports System.Security.Cryptography.X509Certificates
Imports BibliotecaDeClases

Public Class FrmJuego

    Private Sub FrmJuego_Load(sender As Object, e As EventArgs) Handles MyBase.Load






        Me.Size = New Size(507, 480)
        MaximizeBox = False
        AutoSizeMode = AutoSizeMode.GrowAndShrink

        'If dificultad = 1 Then
        '    ReDim botones(6, 6)
        '    GenerarBotones(7, 7)
        'ElseIf dificultad = 3 Then
        '    ReDim botones(15, 15)
        '    GenerarBotones(16, 16)
        'End If

        GenerarBotones(10, 10)







    End Sub


    Public Sub GenerarBotones(ancho As Integer, alto As Integer)

        ReDim botones(ancho - 1, alto - 1)

        For i = 0 To ancho - 1
            For j = 0 To alto - 1
                botones(i, j) = New Button With {
                    .Text = Nothing,
                    .Name = $"btn{i}{j}",
                    .Size = New Size(23, 23),
                    .Tag = 0,
                    .BackColor = BackColor.LightGreen
                }
                AddHandler botones(i, j).Click, AddressOf BotonClic
                AddHandler botones(i, j).MouseDown, AddressOf BotonClicDerecho
            Next
        Next

        numBombas = (ancho * alto) \ 5

        'Dim casillasConBomba(numBombas - 1) As String
        Dim rnd As New Random
        For i = 0 To numBombas - 1
            Dim x, y As Integer
            Do
                x = rnd.Next(10)
                y = rnd.Next(10)
            Loop While botones(x, y).Tag = -1

            botones(x, y).Tag = -1

        Next

        Dim bombasAlrededor As Integer
        For i = 0 To botones.GetLength(0) - 1
            For j = 0 To botones.GetLength(1) - 1


                If botones(i, j).Tag <> -1 Then
                    bombasAlrededor = 0

                    If i - 1 >= 0 AndAlso j - 1 >= 0 AndAlso botones(i - 1, j - 1).Tag = -1 Then bombasAlrededor += 1

                    If j - 1 >= 0 AndAlso botones(i, j - 1).Tag = -1 Then bombasAlrededor += 1

                    If i + 1 <= botones.GetLength(0) - 1 AndAlso j - 1 >= 0 AndAlso botones(i + 1, j - 1).Tag = -1 Then bombasAlrededor += 1

                    If i + 1 <= botones.GetLength(0) - 1 AndAlso botones(i + 1, j).Tag = -1 Then bombasAlrededor += 1

                    If i + 1 <= botones.GetLength(0) - 1 AndAlso j + 1 <= botones.GetLength(1) - 1 AndAlso botones(i + 1, j + 1).Tag = -1 Then bombasAlrededor += 1

                    If j + 1 <= botones.GetLength(1) - 1 AndAlso botones(i, j + 1).Tag = -1 Then bombasAlrededor += 1

                    If i - 1 >= 0 AndAlso j + 1 <= botones.GetLength(1) - 1 AndAlso botones(i - 1, j + 1).Tag = -1 Then bombasAlrededor += 1

                    If i - 1 >= 0 AndAlso botones(i - 1, j).Tag = -1 Then bombasAlrededor += 1

                    botones(i, j).Tag = bombasAlrededor
                End If

            Next
        Next

        For i = 0 To botones.GetLength(0) - 1
            For j = 0 To botones.GetLength(1) - 1
                Controls.Add(botones(i, j))
                botones(i, j).Location = New Point((i + 1) * 23, (j + 1) * 23)
            Next
        Next

    End Sub

    Private Sub ReiniciarPartida(ancho As Integer, alto As Integer)
        For i = 0 To botones.GetLength(0) - 1
            For j = 0 To botones.GetLength(1) - 1
                Controls.Remove(botones(i, j))
            Next
        Next
        GenerarBotones(ancho, alto)
    End Sub

    Private Sub BotonClicDerecho(sender As Object, e As MouseEventArgs)

        If e.Button = System.Windows.Forms.MouseButtons.Right Then
            sender.backgroundImage = Image.FromFile("../../img/banderita.png")
        End If



    End Sub

    Private Sub BotonClic(sender As Object, e As EventArgs)
        sender.backcolor = Nothing
        If sender.tag > -1 Then
            If sender.tag > 0 Then
                sender.text = sender.tag
            Else
                sender.text = ""
            End If
            sender.enabled = False
        End If
        If sender.tag = -1 Then
            For i = 0 To botones.GetLength(0) - 1
                For j = 0 To botones.GetLength(1) - 1
                    If botones(i, j).Tag = -1 Then
                        botones(i, j).Image = Image.FromFile("..\..\img\mina.jpg")

                    End If
                    RemoveHandler botones(i, j).Click, AddressOf BotonClic
                    RemoveHandler botones(i, j).MouseDown, AddressOf BotonClicDerecho
                Next
            Next

        End If

    End Sub

    Private Sub btnReiniciar_Click(sender As Object, e As EventArgs) Handles btnReiniciar.Click
        ReiniciarPartida(10, 10)
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        FrmConfiguracionDeJuego.Show()
        Me.Close()
    End Sub


End Class
