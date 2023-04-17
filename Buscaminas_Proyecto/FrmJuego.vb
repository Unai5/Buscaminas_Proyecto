Imports BibliotecaDeClases
Public Class FrmJuego

    Private botones As Button(9)(9)



    Private Sub FrmJuego_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        tabla = New TableLayoutPanel

        For i = 0 To botones.length - 1
            For j = 0 To botones.length - 1
                Public btn & i & j As New Button 
            Next
        Next



    End Sub





    Private Sub tlpJjuego_Paint(sender As Object, e As PaintEventArgs)
        tlpJuego.GetCellPosition(sender)

End Class
