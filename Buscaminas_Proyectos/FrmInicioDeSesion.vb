Public Class FrmInicioDeSesion
    Const caracteresValidos = "abcdefghijklmnñopqrstuvwxyzABCDEFGHIJKLMNÑOPQRSTUVWXYZ1234567890!¡¿?- "
    'Añadir abecedario mayusculas y minusculas, tildes y numeros
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
        Dim errores As Integer = 0
        For i = 0 To caracteresValidos.Length - 1
            If txtContraseña.Text.Contains(caracteresValidos(i)) = False Then
                errores += 1
            End If
        Next
        If errores > 0 Then
            MessageBox.Show("La contraseña no es válida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtContraseña.Clear()
            txtContraseña.Focus()
            Exit Sub
        End If
        If Not gestionUsrs.ValidarUsuario(txtUsuario.Text, txtContraseña.Text) = "Sesión iniciada" Then
            MessageBox.Show(gestionUsrs.ValidarUsuario(txtUsuario.Text, txtContraseña.Text))
            Exit Sub
        End If
        MessageBox.Show(gestionUsrs.ValidarUsuario(txtUsuario.Text, txtContraseña.Text))
        jugador.Nombre = txtUsuario.Text
        jugador.Contraseña = txtContraseña.Text
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

    Private Sub btnRegisto_Click(sender As Object, e As EventArgs) Handles btnRegisto.Click
        FrmRegistro.Show()
        Me.Close()
    End Sub
End Class