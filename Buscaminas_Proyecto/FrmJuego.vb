Imports System.Drawing.Drawing2D
Imports System.Drawing.Text
Imports System.Linq.Expressions
Imports System.Net.Sockets
Imports System.Security.Cryptography.X509Certificates
Imports BibliotecaDeClases

Public Enum NivelDificultad As Byte
    FACIL = 7
    MEDIO = 10
    DIFICIL = 16
End Enum
Public Class FrmJuego

    Private Sub FrmJuego_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        esPrimerClick = True
        MaximizeBox = False
        AutoSizeMode = AutoSizeMode.GrowAndShrink

        If dificultad = 1 Then

            Me.Size = New Size(270, 360)
            Me.btnReiniciar.Location = New Point(20, 270)
            Me.btnSalir.Location = New Point(150, 270)

            GenerarBotones(NivelDificultad.FACIL, NivelDificultad.FACIL)

        ElseIf dificultad = 3 Then

            Me.Size = New Size(520, 610)
            Me.btnReiniciar.Location = New Point(60, 520)
            Me.btnSalir.Location = New Point(300, 520)
            GenerarBotones(16, 16)

        Else
            Me.Size = New Size(350, 450)
            Me.btnReiniciar.Location = New Point(40, 360)
            Me.btnSalir.Location = New Point(200, 360)
            GenerarBotones(10, 10)

        End If


    End Sub


    Public Sub GenerarBotones(ancho As Integer, alto As Integer)

        ReDim botones(ancho - 1, alto - 1)

        For i = 0 To ancho - 1
            For j = 0 To alto - 1
                botones(i, j) = New Button With {
                    .Text = Nothing,
                    .Name = $"btn{i}{j}",
                    .Size = New Size(28, 28),
                    .Tag = New TagBoton(0, i, j),
                    .BackColor = BackColor.LightGreen,
                    .ForeColor = Color.Black,
                    .Enabled = True
                }
                AddHandler botones(i, j).Click, AddressOf BotonClic
                AddHandler botones(i, j).MouseDown, AddressOf BotonClicDerecho
            Next
        Next

        numBombas = Math.Truncate((ancho * alto) / 5)

        For i = 0 To botones.GetLength(0) - 1
            For j = 0 To botones.GetLength(1) - 1
                Controls.Add(botones(i, j))
                botones(i, j).Location = New Point((i + 1) * 28, (j + 1) * 28 + 20)
            Next
        Next

    End Sub

    Private Sub GenerarBombas(xPrimerClic As Integer, yPrimerClic As Integer)

        Dim rnd As New Random
        For i = 0 To numBombas - 1
            Dim x, y As Integer
            Do
                If dificultad = 3 Then
                    x = rnd.Next(NivelDificultad.DIFICIL)
                    y = rnd.Next(NivelDificultad.DIFICIL)
                ElseIf dificultad = 2 Then
                    x = rnd.Next(NivelDificultad.MEDIO)
                    y = rnd.Next(NivelDificultad.MEDIO)
                Else
                    x = rnd.Next(NivelDificultad.FACIL)
                    y = rnd.Next(NivelDificultad.FACIL)
                End If

            Loop While botones(x, y).Tag.bombasAlrededor = -1 AndAlso Not botones(x, y).Equals(botones(xPrimerClic, yPrimerClic))

            botones(x, y).Tag.bombasAlrededor = -1

        Next

        Dim bombasAlrededor As Integer
        For i = 0 To botones.GetLength(0) - 1
            For j = 0 To botones.GetLength(1) - 1


                If botones(i, j).Tag.bombasAlrededor <> -1 Then
                    bombasAlrededor = 0

                    If i - 1 >= 0 AndAlso j - 1 >= 0 AndAlso botones(i - 1, j - 1).Tag.bombasAlrededor = -1 Then bombasAlrededor += 1

                    If j - 1 >= 0 AndAlso botones(i, j - 1).Tag.bombasAlrededor = -1 Then bombasAlrededor += 1

                    If i + 1 <= botones.GetLength(0) - 1 AndAlso j - 1 >= 0 AndAlso botones(i + 1, j - 1).Tag.bombasAlrededor = -1 Then bombasAlrededor += 1

                    If i + 1 <= botones.GetLength(0) - 1 AndAlso botones(i + 1, j).Tag.bombasAlrededor = -1 Then bombasAlrededor += 1

                    If i + 1 <= botones.GetLength(0) - 1 AndAlso j + 1 <= botones.GetLength(1) - 1 AndAlso botones(i + 1, j + 1).Tag.bombasAlrededor = -1 Then bombasAlrededor += 1

                    If j + 1 <= botones.GetLength(1) - 1 AndAlso botones(i, j + 1).Tag.bombasAlrededor = -1 Then bombasAlrededor += 1

                    If i - 1 >= 0 AndAlso j + 1 <= botones.GetLength(1) - 1 AndAlso botones(i - 1, j + 1).Tag.bombasAlrededor = -1 Then bombasAlrededor += 1

                    If i - 1 >= 0 AndAlso botones(i - 1, j).Tag.bombasAlrededor = -1 Then bombasAlrededor += 1

                    botones(i, j).Tag.bombasAlrededor = bombasAlrededor
                End If

            Next
        Next



    End Sub

    Private Sub ReiniciarPartida(ancho As Integer, alto As Integer)
        For i = 0 To botones.GetLength(0) - 1
            For j = 0 To botones.GetLength(1) - 1
                Controls.Remove(botones(i, j))
            Next
        Next
        If dificultad = 1 Then
            ReDim botones(NivelDificultad.FACIL - 1, NivelDificultad.FACIL - 1)
            GenerarBotones(NivelDificultad.FACIL, NivelDificultad.FACIL)
        ElseIf dificultad = 3 Then
            ReDim botones(15, 15)
            GenerarBotones(16, 16)
        Else
            ReDim botones(9, 9)
            GenerarBotones(10, 10)
        End If
    End Sub

    Private Sub BotonClic(sender As Button, e As EventArgs)


        If esPrimerClick Then

            GenerarBombas(sender.Tag.posX, sender.Tag.posY)

            esPrimerClick = False

        End If




        sender.BackColor = Nothing
        If sender.Tag.bombasAlrededor > -1 Then
            If sender.Tag.bombasAlrededor > 0 Then
                sender.Text = sender.Tag.bombasAlrededor
            Else
                sender.Text = ""
            End If
            sender.Enabled = False
        End If

        If sender.Tag.bombasAlrededor = -1 Then
            For i = 0 To botones.GetLength(0) - 1
                For j = 0 To botones.GetLength(1) - 1
                    If botones(i, j).Tag.bombasAlrededor = -1 Then
                        botones(i, j).Image = Image.FromFile("..\..\img\mina.jpg")
                    End If
                    RemoveHandler sender.Click, AddressOf BotonClic
                    RemoveHandler sender.MouseDown, AddressOf BotonClicDerecho
                Next
            Next

        End If

    End Sub


    Private Sub BotonClicDerecho(sender As Button, e As MouseEventArgs)

        If e.Button = System.Windows.Forms.MouseButtons.Right Then

            If sender.ForeColor = Color.Black Then
                sender.BackgroundImage = Image.FromFile("../../img/banderita.png")
                sender.ForeColor = Color.White
                RemoveHandler sender.Click, AddressOf BotonClic
            Else
                sender.BackgroundImage = Nothing
                sender.ForeColor = Color.Black
                AddHandler sender.Click, AddressOf BotonClic
            End If

        End If

    End Sub

    Private Sub btnReiniciar_Click(sender As Object, e As EventArgs) Handles btnReiniciar.Click
        If dificultad = 1 Then
            ReiniciarPartida(7, 7)
        ElseIf dificultad = 2 Then
            ReiniciarPartida(10, 10)
        Else
            ReiniciarPartida(16, 16)
        End If
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        FrmConfiguracionDeJuego.Show()
        Me.Close()
    End Sub

End Class
