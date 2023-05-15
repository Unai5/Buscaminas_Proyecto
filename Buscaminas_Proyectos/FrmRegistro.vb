Public Class FrmRegistro
    Private cerrarPorBoton As Boolean = False
    Private jugador = New BibliotecaDeClases.Usuario
    Private Sub btnCompletarRegistro_Click(sender As Object, e As EventArgs) Handles btnCompletarRegistro.Click
        If String.IsNullOrWhiteSpace(txtNuevoUsuario.Text) Then
            MessageBox.Show("Es necesario introducir un nombre de Usuario", "Error")
            Exit Sub
        End If
        If String.IsNullOrWhiteSpace(txtNuevaContraseña.Text) Then
            MessageBox.Show("Es necesario introducir una contraseña", "Error")
            Exit Sub
        End If
        If String.IsNullOrWhiteSpace(txtRepetirContraseña.Text) Then
            MessageBox.Show("Es necesario repetir la contraseña", "Error")
            Exit Sub
        End If
        If Not txtNuevaContraseña.Text.ToUpper = txtRepetirContraseña.Text.ToUpper Then
            MessageBox.Show("Repite la contraseña correctamente", "Error")
            Exit Sub
        End If
        If gestionUsrs.AñadirUsuario(txtNuevoUsuario.Text, txtNuevaContraseña.Text) <> "Usuario creado" Then
            MessageBox.Show($"{gestionUsrs.AñadirUsuario(txtNuevoUsuario.Text, txtNuevaContraseña.Text)}")
            Exit Sub
        End If
        MessageBox.Show($"{gestionUsrs.AñadirUsuario(txtNuevoUsuario.Text, txtNuevaContraseña.Text)}")
        jugador.Nombre = txtNuevoUsuario.Text
        jugador.Contraseña = txtNuevaContraseña.Text
        jugador.MejorTiempoFacil = 0
        jugador.MejorTiempoMedio = 0
        jugador.MejorTiempoDificil = 0
        cerrarPorBoton = True
        FrmInicioDeSesion.Show()
        Me.Visible = False
        Me.Close()
    End Sub

    Private Sub FrmRegistro_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If cerrarPorBoton = True Then
            Exit Sub
        End If
        Dim resp As DialogResult
        resp = MessageBox.Show("¿Estas seguro de cerrar el juego?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If resp = Windows.Forms.DialogResult.No Then
            e.Cancel = True
        End If
    End Sub
    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        cerrarPorBoton = True
        FrmInicioDeSesion.Show()
        Me.Visible = False
        Me.Close()
    End Sub
End Class