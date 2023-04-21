Imports System.Collections.Generic
Public Class Usuario
    Implements IEquatable(Of Usuario)
    Public listaTiempos As List(Of TimeSpan)
    Public Property Nombre As String
    Public Property Contraseña As String
    Public ReadOnly Property MejorTiempo As TimeSpan
        Get
            Return listaTiempos.Min
        End Get
    End Property

    Public Sub New(nombre As String, contraseña As String)
        Me.Nombre = nombre
        Me.Contraseña = contraseña
    End Sub
    Public Sub New()
    End Sub


    Public Overrides Function Equals(obj As Object) As Boolean
        Return Equals(TryCast(obj, Usuario))
    End Function

    Public Overloads Function Equals(other As Usuario) As Boolean Implements IEquatable(Of Usuario).Equals
        Return other IsNot Nothing AndAlso
               Nombre = other.Nombre
    End Function

    Public Overrides Function GetHashCode() As Integer
        Dim hashCode As Long = 510151744
        hashCode = (hashCode * -1521134295 + EqualityComparer(Of String).Default.GetHashCode(Nombre)).GetHashCode()
        Return hashCode
    End Function

End Class
