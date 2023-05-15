
Public Class Usuario
    Implements IEquatable(Of Usuario)
    Public Property Nombre As String
    Public Property Contraseña As String
    Public Property MejorTiempoFacil As Integer
    Public Property MejorTiempoMedio As Integer
    Public Property MejorTiempoDificil As Integer

    Public Sub New(nombre As String, contraseña As String, mejorTiempoFacil As Integer, mejorTiempoMedio As Integer, mejorTiempoDificil As Integer)
        Me.Nombre = nombre
        Me.Contraseña = contraseña
        Me.MejorTiempoFacil = mejorTiempoFacil
        Me.MejorTiempoMedio = mejorTiempoMedio
        Me.MejorTiempoDificil = mejorTiempoDificil
    End Sub

    Public Sub New()
    End Sub

    Public Overloads Function Equals(other As Usuario) As Boolean Implements IEquatable(Of Usuario).Equals
        Return other IsNot Nothing AndAlso
               Nombre = other.Nombre
    End Function

End Class
