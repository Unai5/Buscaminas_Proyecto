Imports BibliotecaDeClases
Public Class FrmInicioDeSesion
    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If String.IsNullOrWhiteSpace(txtUsuario.Text) Then
            MessageBox.Show("Es necesario introducir un nombre de Usuario", "Error")
            Exit Sub
        End If
        If String.IsNullOrWhiteSpace(txtContraseña.Text) Then
            MessageBox.Show("Es necesario introducir una contraseña", "Error")
            Exit Sub
        End If
        Dim nuevoUsuario As New Usuario(txtUsuario.Text, txtContraseña.Text)
        For Each usr In listaJugadores
            If usr.Equals(nuevoUsuario) AndAlso usr.Contraseña = nuevoUsuario.Contraseña Then
                jugador = usr
                Exit Sub
            End If
        Next
        listaJugadores.Add(nuevoUsuario)
        jugador = nuevoUsuario
        MessageBox.Show($"Bienvenido/a {nuevoUsuario.Nombre}")
        FrmConfiguracionDeJuego.Show()
        Close()
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

    Private Sub btnRankin_Click(sender As Object, e As EventArgs) Handles btnRankin.Click

        frmRanking.Show()
        Close()
    End Sub
End Class