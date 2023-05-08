Public Class TagBoton

    Public Property bombasAlrededor As Integer
    Public Property posX As Integer
    Public Property posY As Integer

    Public Sub New(bombasAlrededor As Integer, posX As Integer, posY As Integer)
        Me.bombasAlrededor = bombasAlrededor
        Me.posX = posX
        Me.posY = posY
    End Sub

    Public Overrides Function Equals(obj As Object) As Boolean
        Dim boton = TryCast(obj, TagBoton)
        Return boton IsNot Nothing AndAlso
               posX = boton.posX AndAlso
               posY = boton.posY
    End Function
End Class
