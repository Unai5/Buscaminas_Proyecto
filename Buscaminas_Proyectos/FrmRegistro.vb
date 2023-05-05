Public Class FrmRegistro
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
        MessageBox.Show(gestionUsrs.AñadirUsuario(txtNuevoUsuario.Text, txtNuevaContraseña.Text))
        Me.Close()
    End Sub
End Class