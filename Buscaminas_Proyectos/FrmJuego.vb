﻿Imports System.IO
Imports BibliotecaDeClases

Public Enum Dific As Byte
    FACIL = 7
    MEDIO = 10
    DIFICIL = 16
End Enum
Public Class FrmJuego
    Private botones(9, 9) As Button
    Private numBombas As Integer
    Private cerrarPorBoton As Boolean = False
    Private casillasSinBomba As Integer = 0
    Private Sub FrmJuego_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        esPrimerClick = True
        MaximizeBox = False
        AutoSizeMode = AutoSizeMode.GrowAndShrink
        txtReloj.TextAlign = HorizontalAlignment.Center
        txtReloj.Enabled = False


        If dificultad = 1 Then

            Me.Size = New Size(270, 360)
            Me.btnReiniciar.Location = New Point(20, 270)
            Me.btnSalir.Location = New Point(150, 270)
            txtReloj.Location = New Point(80, 10)
            GenerarBotones(Dific.FACIL, Dific.FACIL)

        ElseIf dificultad = 3 Then

            Me.Size = New Size(520, 610)
            Me.btnReiniciar.Location = New Point(60, 520)
            Me.btnSalir.Location = New Point(300, 520)
            txtReloj.Location = New Point(200, 10)
            GenerarBotones(Dific.DIFICIL, Dific.DIFICIL)

        Else
            Me.Size = New Size(350, 450)
            Me.btnReiniciar.Location = New Point(40, 360)
            Me.btnSalir.Location = New Point(200, 360)
            txtReloj.Location = New Point(120, 10)
            GenerarBotones(Dific.MEDIO, Dific.MEDIO)

        End If

        txtReloj.Text = "00:00"
        tmrReloj.Interval = 1000
        tmrReloj.Start()

    End Sub


    Public Sub GenerarBotones(ancho As Integer, alto As Integer)

        ReDim botones(ancho - 1, alto - 1)

        For i = 0 To ancho - 1
            For j = 0 To alto - 1
                botones(i, j) = New Button With {
                    .Text = Nothing,
                    .Name = $"btn{i}{j}",
                    .Size = New Size(28, 28),
                    .Tag = New BibliotecaDeClases.TagBoton(0, i, j),
                    .BackColor = BackColor.LightBlue,
                    .ForeColor = Color.Black,
                    .Enabled = True,
                    .BackgroundImageLayout = ImageLayout.Stretch
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
                    x = rnd.Next(Dific.DIFICIL)
                    y = rnd.Next(Dific.DIFICIL)
                ElseIf dificultad = 2 Then
                    x = rnd.Next(Dific.MEDIO)
                    y = rnd.Next(Dific.MEDIO)
                Else
                    x = rnd.Next(Dific.FACIL)
                    y = rnd.Next(Dific.FACIL)
                End If

            Loop While botones(x, y).Tag.bombasAlrededor = -1 OrElse IndiceInvalido(botones(x, y), xPrimerClic, yPrimerClic)

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

        If xPrimerClic - 1 >= 0 AndAlso yPrimerClic - 1 >= 0 Then Inhabilitar(botones(xPrimerClic - 1, yPrimerClic - 1))

        If yPrimerClic - 1 >= 0 Then Inhabilitar(botones(xPrimerClic, yPrimerClic - 1))

        If xPrimerClic + 1 <= botones.GetLength(0) - 1 AndAlso yPrimerClic - 1 >= 0 Then Inhabilitar(botones(xPrimerClic + 1, yPrimerClic - 1))

        If xPrimerClic + 1 <= botones.GetLength(0) - 1 Then Inhabilitar(botones(xPrimerClic + 1, yPrimerClic))

        If xPrimerClic + 1 <= botones.GetLength(0) - 1 AndAlso yPrimerClic + 1 <= botones.GetLength(1) - 1 Then Inhabilitar(botones(xPrimerClic + 1, yPrimerClic + 1))

        If yPrimerClic + 1 <= botones.GetLength(1) - 1 Then Inhabilitar(botones(xPrimerClic, yPrimerClic + 1))

        If xPrimerClic - 1 >= 0 AndAlso yPrimerClic + 1 <= botones.GetLength(1) - 1 Then Inhabilitar(botones(xPrimerClic - 1, yPrimerClic + 1))

        If xPrimerClic - 1 >= 0 Then Inhabilitar(botones(xPrimerClic - 1, yPrimerClic))

    End Sub

    Private Function IndiceInvalido(boton As Button, x As Integer, y As Integer) As Boolean
        If boton.Equals(botones(x, y)) Then Return True
        If x - 1 >= 0 AndAlso y - 1 >= 0 Then
            If boton.Equals(botones(x - 1, y - 1)) Then Return True
        End If
        If y - 1 >= 0 Then
            If boton.Equals(botones(x, y - 1)) Then Return True
        End If
        If x + 1 <= botones.GetLength(0) - 1 AndAlso y - 1 >= 0 Then
            If boton.Equals(botones(x + 1, y - 1)) Then Return True
        End If
        If x + 1 <= botones.GetLength(0) - 1 Then
            If boton.Equals(botones(x + 1, y)) Then Return True
        End If
        If x + 1 <= botones.GetLength(0) - 1 AndAlso y + 1 <= botones.GetLength(1) - 1 Then
            If boton.Equals(botones(x + 1, y + 1)) Then Return True
        End If
        If y + 1 <= botones.GetLength(1) - 1 Then
            If boton.Equals(botones(x, y + 1)) Then Return True
        End If
        If x - 1 >= 0 AndAlso y + 1 <= botones.GetLength(1) - 1 Then
            If boton.Equals(botones(x - 1, y + 1)) Then Return True
        End If
        If x - 1 >= 0 Then
            If boton.Equals(botones(x - 1, y)) Then Return True
        End If
        Return False
    End Function

    Private Sub Inhabilitar(boton As Button)
        boton.BackColor = Nothing
        boton.Image = Nothing
        If boton.Tag.bombasAlrededor = -1 Then
            If File.Exists(".\img\mina.jpg") Then
                TryCast(boton, Button).BackgroundImage = Image.FromFile(".\img\mina.jpg")
            Else
                TryCast(boton, Button).Text = "B"
            End If
        Else
            If boton.Tag.bombasAlrededor > 0 Then
                TryCast(boton, Button).Text = boton.Tag.bombasalrededor
            End If
        End If
        boton.Tag.clickeada = True
        RemoveHandler TryCast(boton, Button).Click, AddressOf BotonClic
        RemoveHandler TryCast(boton, Button).MouseDown, AddressOf BotonClicDerecho
        boton.Enabled = False
    End Sub

    Private Sub ReiniciarPartida(ancho As Integer, alto As Integer)
        tmrReloj.Stop()
        esPrimerClick = True
        For i = 0 To botones.GetLength(0) - 1
            For j = 0 To botones.GetLength(1) - 1
                Controls.Remove(botones(i, j))
            Next
        Next
        If dificultad = 1 Then
            ReDim botones(Dific.FACIL - 1, Dific.FACIL - 1)
            GenerarBotones(Dific.FACIL, Dific.FACIL)
        ElseIf dificultad = 3 Then
            ReDim botones(15, 15)
            GenerarBotones(16, 16)
        Else
            ReDim botones(Dific.MEDIO - 1, Dific.MEDIO - 1)
            GenerarBotones(Dific.MEDIO, Dific.MEDIO)
        End If
        minutosSegundos(0) = 0
        minutosSegundos(1) = 0
        txtReloj.Text = "00:00"
        tmrReloj.Start()
    End Sub

    Private Sub BotonClic(sender As Object, e As EventArgs)

        If esPrimerClick Then
            GenerarBombas(sender.Tag.posX, sender.Tag.posY)
        End If

        sender.BackColor = Nothing
        sender.tag.clickeada = True
        If sender.Tag.bombasAlrededor > -1 Then
            If sender.Tag.bombasAlrededor > 0 Then
                sender.Text = sender.Tag.bombasAlrededor
            Else
                sender.Text = ""
            End If
            sender.Enabled = False
            If esPrimerClick Then
                esPrimerClick = False
                casillasSinBomba = 0
                For i = 0 To botones.GetLength(0) - 1
                    For j = 0 To botones.GetLength(1) - 1
                        If botones(i, j).Tag.bombasAlrededor > -1 AndAlso botones(i, j).Tag.clickeada = False Then
                            casillasSinBomba += 1
                        End If
                    Next
                Next
            Else
                casillasSinBomba -= 1
            End If
            If casillasSinBomba = 0 Then
                PartidaTerminada(True)
            End If
        End If

        If sender.Tag.bombasAlrededor = -1 Then
            For i = 0 To botones.GetLength(0) - 1
                For j = 0 To botones.GetLength(1) - 1
                    If botones(i, j).Tag.bombasAlrededor = -1 Then
                        If File.Exists(".\img\mina.jpg") Then
                            botones(i, j).BackgroundImage = Image.FromFile(".\img\mina.jpg")
                        Else
                            botones(i, j).Text = "B"
                        End If
                    End If
                    RemoveHandler botones(i, j).Click, AddressOf BotonClic
                    RemoveHandler botones(i, j).MouseDown, AddressOf BotonClicDerecho
                Next
            Next
            PartidaTerminada(False)
        End If

    End Sub

    Private Sub PartidaTerminada(ganador As Boolean)
        tmrReloj.Stop()
        Dim dif As Integer = dificultad
        Dim difStr As String
        If dif = 1 Then
            difStr = "fácil"
        ElseIf dif = 2 Then
            difStr = "intermedia"
        Else
            difStr = "difícil"
        End If
        If ganador Then
            Dim tmp As Integer = gestionUsrs.ComprobarTiempo(minutosSegundos(0) * 60 + minutosSegundos(1), dificultad, usuarioActivo)
            If tmp = -1 Then
                MessageBox.Show($"¡HAS GANADO! {vbCrLf}Sólo has tardado: {Format(minutosSegundos(0), "##00")}:{Format(minutosSegundos(1), "##00")}")
            Else
                tiempoPartida(0) = minutosSegundos(0)
                tiempoPartida(1) = minutosSegundos(1)
                frmGanador.Show()
                Me.Hide()
            End If
        Else
            MessageBox.Show($"GAME OVER! {vbCrLf}En el tiempo: {Format(minutosSegundos(0), "##00")}:{Format(minutosSegundos(1), "##00")}")
        End If
    End Sub

    Private Sub BotonClicDerecho(sender As Object, e As MouseEventArgs)

        If e.Button = System.Windows.Forms.MouseButtons.Right Then

            If sender.ForeColor = Color.Black Then
                If File.Exists("./img/banderita.png") Then
                    sender.BackgroundImage = Image.FromFile("./img/banderita.png")
                Else
                    sender.text = "^^"
                End If

                sender.ForeColor = Color.White
                RemoveHandler TryCast(sender, Button).Click, AddressOf BotonClic
            Else
                sender.BackgroundImage = Nothing
                sender.text = ""
                sender.ForeColor = Color.Black
                AddHandler TryCast(sender, Button).Click, AddressOf BotonClic
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
        cerrarPorBoton = True
        FrmConfiguracionDeJuego.Show()
        Me.Visible = False
        Me.Close()
    End Sub
    Private Sub FrmJuego_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If cerrarPorBoton = True Then
            Exit Sub
        End If
        Dim resp As DialogResult
        resp = MessageBox.Show("¿Estas seguro de cerrar el juego?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If resp = Windows.Forms.DialogResult.No Then
            e.Cancel = True
        End If
    End Sub
    Private minutosSegundos(1) As Byte
    Private Sub tmrReloj_Tick(sender As Object, e As EventArgs) Handles tmrReloj.Tick
        If minutosSegundos(1) = 59 Then
            minutosSegundos(1) = 0
            minutosSegundos(0) += 1
            Exit Sub
        End If
        minutosSegundos(1) += 1
        txtReloj.Text = $"{Format(minutosSegundos(0), "##00")}:{Format(minutosSegundos(1), "##00")}"
    End Sub



End Class
