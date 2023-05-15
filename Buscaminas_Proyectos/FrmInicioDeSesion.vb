Public Class FrmInicioDeSesion
    Private cerrarPorBoton As Boolean = False
    Const caracteresValidos = "abcdefghijklmnñopqrstuvwxyzABCDEFGHIJKLMNÑOPQRSTUVWXYZ1234567890!¡¿?- "
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
        Dim comprobacionCaracteresNombre As Integer = 0
        Dim comprobacionCaracteresContrasena As Integer = 0
        For i = 0 To txtUsuario.Text.Length - 1
            If caracteresValidos.Contains(txtUsuario.Text.Substring(i, 1)) Then
                comprobacionCaracteresNombre += 1
            End If
        Next
        For i = 0 To txtContraseña.Text.Length - 1
            If caracteresValidos.Contains(txtContraseña.Text.Substring(i, 1)) Then
                comprobacionCaracteresContrasena += 1
            End If
        Next
        If comprobacionCaracteresContrasena <> txtContraseña.Text.Length Then
            MessageBox.Show("La contraseña no es válida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtContraseña.Clear()
            txtContraseña.Focus()
            Exit Sub
        End If
        If comprobacionCaracteresContrasena <> txtContraseña.Text.Length Then
            MessageBox.Show("El usuario no es válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtUsuario.Clear()
            txtUsuario.Focus()
            Exit Sub
        End If
        If gestionUsrs.ValidarUsuario(txtUsuario.Text, txtContraseña.Text) <> "Sesión iniciada" Then
            MessageBox.Show($"{gestionUsrs.ValidarUsuario(txtUsuario.Text, txtContraseña.Text)}")
            Exit Sub
        End If
        'jugador.Nombre = txtUsuario.Text
        'jugador.Contraseña = txtContraseña.Text
        cerrarPorBoton = True
        FrmConfiguracionDeJuego.Show()
        Me.Visible = False
        Me.Close()
    End Sub
    Private Sub FrmRanking_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If cerrarPorBoton = True Then
            Exit Sub
        End If
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

    Private Sub btnRegisto_Click(sender As Object, e As EventArgs) Handles btnRegisto.Click
        cerrarPorBoton = True
        FrmRegistro.Show()
        Me.Visible = False
        Me.Close()
    End Sub
End Class