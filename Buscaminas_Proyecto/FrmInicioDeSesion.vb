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
    End Sub

    Private Sub FrmInicioSesion_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim resp As DialogResult
        resp = MessageBox.Show("¿Estas seguro de cerrar el juego?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If resp = Windows.Forms.DialogResult.No Then
            e.Cancel = True
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblContraseña.Click

    End Sub
End Class