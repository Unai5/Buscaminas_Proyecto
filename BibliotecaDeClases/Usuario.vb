
Public Class Usuario
    Implements IEquatable(Of Usuario)
    Public Property Nombre As String
    Public Property Contraseña As String
    Public Property MejorTiempoFacil As TimeSpan
    Public Property MejorTiempoMedio As TimeSpan
    Public Property MejorTiempoDificil As TimeSpan

    Public Sub New(nombre As String, contraseña As String)
        Me.Nombre = nombre
        Me.Contraseña = contraseña
    End Sub

    Public Sub New()
    End Sub

    Public Overloads Function Equals(other As Usuario) As Boolean Implements IEquatable(Of Usuario).Equals
        Return other IsNot Nothing AndAlso
               Nombre = other.Nombre
    End Function

End Class
