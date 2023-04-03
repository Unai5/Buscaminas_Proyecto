Public Class Mina : Inherits Casilla

    Public Overrides Function Equals(obj As Object) As Boolean
        Dim mina = TryCast(obj, Mina)
        Return mina IsNot Nothing AndAlso
               Nombre = mina.Nombre AndAlso
               Posicion = mina.Posicion
    End Function

    'Foto de la propia mina
End Class
