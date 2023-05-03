Imports System
Imports System.IO

Public Class GestionUsuario
    Private _Usuarios As New List(Of Usuario)
    Public ReadOnly Property Usuarios As ObjectModel.ReadOnlyCollection(Of Usuario)
        Get
            Return _Usuarios.AsReadOnly
        End Get
    End Property

    Public Sub New()
        'TODO ¿Que pasa si no existe el fichero
        'TODO Que pasa si no hay asteriscos y solo hay un campo

        Dim ficheroR As New StreamReader(".\Ficheros\TodosLosUsuarios.txt")

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

        For Each usu As Usuario In Usuarios
            'ficheroUsuarios.WriteLine(usu.Nombre & "*" & usu.Contraseña)
        Next
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

    Public Function OrdenarFichero(nombreFichero As String)
        Dim ficheroSinOrdenar As StreamReader(".\Ficheros\" + nombreFichero)

    End Function
    Public Function AnadirPartida(tiempo As String, usuario As String, modoJuego As String)
        'For Each usu As Usuario In Usuarios
        '    ficheroPartidas.WriteLine(tiempo & "*" & usuario & "*" & modoJuego)
        'Next
    End Function

End Class
