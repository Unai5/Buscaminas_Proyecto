﻿Imports System.IO
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

        Dim ficheroW As New StreamWriter(".\..\..\Ficheros\TodosLosUsuarios.txt", True)
        ficheroW.WriteLine(nuevo.Nombre & "*" & nuevo.Contraseña)
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

    Public Function OrdenarFichero(dificultad As Integer)
        'Dim ficheroSinOrdenar As StreamReader(".\Ficheros\" + nombreFichero)
        Dim primero As Usuario
        If dificultad = 1 Then
            Dim ficheroW As New StreamWriter(".\..\..\Ficheros\RankingFacil.txt", True)
            ficheroW.Flush()
            For i = 0 To _Usuarios.Count
                For j = i To _Usuarios.Count
                    If j = i Then
                        primero = _Usuarios(j)
                    ElseIf _Usuarios(j).MejorTiempoFacil > primero.MejorTiempoFacil Then
                        primero = _Usuarios(j)
                    End If
                Next
                _Usuarios(i) = primero
                ficheroW.WriteLine(primero.Nombre & "*" & primero.MejorTiempoFacil.ToString)
            Next
            ficheroW.Close()
        ElseIf dificultad = 2 Then
            Dim ficheroW As New StreamWriter(".\..\..\Ficheros\RankingMedio.txt", True)
            ficheroW.Flush()
            For i = 0 To _Usuarios.Count
                For j = i To _Usuarios.Count
                    If j = i Then
                        primero = _Usuarios(j)
                    ElseIf _Usuarios(j).MejorTiempoMedio > primero.MejorTiempoMedio Then
                        primero = _Usuarios(j)
                    End If
                Next
                _Usuarios(i) = primero
                ficheroW.WriteLine(primero.Nombre & "*" & primero.MejorTiempoMedio.ToString)
            Next
            ficheroW.Close()
        Else
            Dim ficheroW As New StreamWriter(".\..\..\Ficheros\RankingDificil.txt", True)
            ficheroW.Flush()
            For i = 0 To _Usuarios.Count
                For j = i To _Usuarios.Count
                    If j = i Then
                        primero = _Usuarios(j)
                    ElseIf _Usuarios(j).MejorTiempoDificil > primero.MejorTiempoDificil Then
                        primero = _Usuarios(j)
                    End If
                Next
                _Usuarios(i) = primero
                ficheroW.WriteLine(primero.Nombre & "*" & primero.MejorTiempoDificil.ToString)
            Next
            ficheroW.Close()
        End If
    End Function
    Public Function OrdenarFicheroPersona(nombre As String)
        Dim ficheroPersonal As New StreamWriter(".\..\..\Ficheros\FicheroPersonal.txt", True)
        Dim ficheroCompleto As New StreamReader(".\..\..\Ficheros\FicheroPartidas.txt")
        ficheroPersonal.Flush()
        For i = 0 To _Usuarios.Count
            If _Usuarios(i).Nombre = nombre Then
                If ficheroCompleto.ReadLine.Contains($"{nombre}") Then
                    ficheroPersonal.WriteLine()
                End If
            End If
            'For j = i To _Usuarios.Count
            '    If j = i Then
            '        primero = _Usuarios(j)
            '    ElseIf _Usuarios(j).MejorTiempoMedio > primero.MejorTiempoMedio Then
            '        primero = _Usuarios(j)
            '    End If
            'Next
            '_Usuarios(i) = primero
            'ficheroW.WriteLine(primero.Nombre & "*" & primero.MejorTiempoMedio.ToString)
        Next
        ficheroPersonal.Close()
        Return ficheroPersonal
    End Function
    Public Function AnadirPartida(tiempo As String, usuario As String, modoJuego As String)
        'For Each usu As Usuario In Usuarios
        '    ficheroPartidas.WriteLine(tiempo & "*" & usuario & "*" & modoJuego)
        'Next
    End Function

End Class
