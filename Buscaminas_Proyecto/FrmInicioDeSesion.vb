Imports System.IO
Imports BibliotecaDeClases
Public Class FrmInicioDeSesion
    Public gestion1 As New GestionUsuario
    Const caracteresInvalidos = "*/-+.=)(\^¿?$%&·#@|!¡[]_€"
    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnIniciarSesion.Click
        If String.IsNullOrWhiteSpace(txtUsuario.Text) Then
            MessageBox.Show("Introduce usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        If txtUsuario.Text.Length > 14 Then
            MessageBox.Show("El nombre de usuario supera la longitud máxima", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtUsuario.Clear()
            txtUsuario.Focus()
            Exit Sub
        End If
        If String.IsNullOrWhiteSpace(txtContraseña.Text) Then
            MessageBox.Show("Introduce contraseña", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        For i = 0 To caracteresInvalidos.Length - 1
            If txtContraseña.Text.Contains(caracteresInvalidos(i)) Then
                MessageBox.Show("La contraseña no es válida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtContraseña.Clear()
                txtContraseña.Focus()
                Exit Sub
            End If
        Next
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
        For i = 0 To caracteresInvalidos.Length - 1
            If txtContraseña.Text.Contains(caracteresInvalidos(i)) Then
                MessageBox.Show("La contraseña no es válida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtContraseña.Clear()
                txtContraseña.Focus()
                Exit Sub
            End If
        Next
        If String.IsNullOrWhiteSpace(txtUsuario.Text) Then
            MessageBox.Show("Introduce usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        If String.IsNullOrWhiteSpace(txtContraseña.Text) Then
            MessageBox.Show("Introduce contraseña", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        FrmRegistro.Show()
    End Sub

End Class