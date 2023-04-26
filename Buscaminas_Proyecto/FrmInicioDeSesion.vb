﻿Imports System.IO
Imports BibliotecaDeClases
Public Class FrmInicioDeSesion
    Public gestion1 As New GestionUsuario
    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnIniciarSesion.Click
        If String.IsNullOrWhiteSpace(txtUsuario.Text) Then
            MessageBox.Show("Es necesario introducir un nombre de Usuario", "Error")
            Exit Sub
        End If
        If String.IsNullOrWhiteSpace(txtContraseña.Text) Then
            MessageBox.Show("Es necesario introducir una contraseña", "Error")
            Exit Sub
        End If
        If Not gestion1.ValidarUsuario(txtUsuario.Text, txtContraseña.Text) = "Sesión iniciada" Then
            MessageBox.Show(gestion1.ValidarUsuario(txtUsuario.Text, txtContraseña.Text))
            Exit Sub
        End If
        MessageBox.Show(gestion1.ValidarUsuario(txtUsuario.Text, txtContraseña.Text))
        FrmConfiguracionDeJuego.Show()
    End Sub

    Private Sub FrmInicioSesion_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim resp As DialogResult
        resp = MessageBox.Show("¿Estas seguro de cerrar el juego?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If resp = Windows.Forms.DialogResult.No Then
            e.Cancel = True
        End If
    End Sub

    Private Sub FrmInicioDeSesion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtContraseña.Clear()
        txtUsuario.Clear()
    End Sub

    Private Sub btnRankin_Click(sender As Object, e As EventArgs) Handles btnRegistrarse.Click
        FrmRegistro.Show()
    End Sub
End Class