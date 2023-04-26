Imports System.IO
Public Class GestionUsuario

    Private _Usuarios As New List(Of Usuario)
    Public ReadOnly Property Usuarios As ObjectModel.ReadOnlyCollection(Of Usuario)
        Get
            Return _Usuarios.AsReadOnly
        End Get
    End Property

    Public Sub New()
        Dim ficheroR As New StreamReader("C:\Users\inazi\Source\Repos\Unai5\Buscaminas_Proyecto\Buscaminas_Proyecto\Ficheros\TodosLosUsuarios.txt")
        Do Until ficheroR.EndOfStream
            Dim linea As String = ficheroR.ReadLine
            Dim datosLinea() As String = linea.Split("*")
            _Usuarios.Add(New Usuario(datosLinea(0), datosLinea(1)))
        Loop
        ficheroR.Close()
    End Sub

    Public Function AñadirUsuario(nombre As String, contraseña As String) As String
        If String.IsNullOrWhiteSpace(nombre) OrElse String.IsNullOrWhiteSpace(contraseña) Then
            Return "Hay elementos vacíos"
        End If
        Dim nuevo As New Usuario(nombre, contraseña)
        For i = 0 To _Usuarios.Count - 1
            If _Usuarios(i).Equals(nuevo) Then
                Return $"Ya existe el usuario {nombre}"
            End If
        Next
        _Usuarios.Add(nuevo)
        Dim ficheroW As New StreamWriter("C:\Users\inazi\Source\Repos\Unai5\Buscaminas_Proyecto\Buscaminas_Proyecto\Ficheros\TodosLosUsuarios.txt")
        For Each usu As Usuario In Usuarios
            ficheroW.WriteLine(usu.Nombre & "*" & usu.Contraseña)
        Next
        ficheroW.Close()
        Return "Usuario creado"
    End Function

    Public Function ValidarUsuario(nombre As String, contraseña As String) As String
        For i = 0 To _Usuarios.Count - 1
            If _Usuarios(i).Nombre = nombre AndAlso _Usuarios(i).Contraseña = contraseña Then
                Return "Sesión iniciada"
            End If
        Next
        Return "No existe el usuario, no se puede iniciar sesion"
    End Function




End Class
