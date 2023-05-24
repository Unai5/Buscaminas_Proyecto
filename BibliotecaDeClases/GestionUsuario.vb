Imports System
Imports System.IO

Public Class GestionUsuario
    Private _Usuarios As New List(Of Usuario)
    Public ReadOnly Property Usuarios As ObjectModel.ReadOnlyCollection(Of Usuario)
        Get
            Return _Usuarios.AsReadOnly
        End Get
    End Property

    Public Sub New(ByRef errores As String)
        'TODO ¿Que pasa si no existe el fichero
        'TODO Que pasa si no hay asteriscos y solo hay un campo
        Try
            Dim ficheroR As New StreamReader(".\Ficheros\TodosLosUsuarios.txt")
            Do Until ficheroR.EndOfStream
                Dim linea As String = ficheroR.ReadLine
                Dim datosLinea() As String = linea.Split("*")
                If datosLinea.Length < 5 Then
                    errores = "Error, hay una línea que no está bien escrita"
                End If
                _Usuarios.Add(New Usuario(datosLinea(0), datosLinea(1), datosLinea(2), datosLinea(3), datosLinea(4)))
            Loop
            ficheroR.Close()
        Catch ex As FileNotFoundException
            errores = ex.Message
        Catch ex As IOException
            errores = ex.Message
        End Try
    End Sub
    Public Function AñadirUsuario(nombre As String, contraseña As String) As String
        If String.IsNullOrWhiteSpace(nombre) OrElse String.IsNullOrWhiteSpace(contraseña) Then
            Return "Hay elementos vacíos"
        End If
        Dim nuevo As New Usuario(nombre, contraseña, -1, -1, -1)
        For i = 0 To _Usuarios.Count - 1
            If _Usuarios(i).Equals(nuevo) Then
                Return $"Ya existe el usuario {nombre}"
            End If
        Next
        _Usuarios.Add(nuevo)
        Try
            Dim ficheroW As New StreamWriter(".\Ficheros\TodosLosUsuarios.txt", True)
            ficheroW.WriteLine()
            ficheroW.Write(nuevo.Nombre & "*" & nuevo.Contraseña & "*" & nuevo.MejorTiempoFacil & "*" & nuevo.MejorTiempoMedio & "*" & nuevo.MejorTiempoDificil)
            ficheroW.Close()
        Catch ex As FileNotFoundException
            Return ex.Message
        Catch ex As IOException
            Return ex.Message
        End Try

        Return "Usuario creado"
    End Function

    Public Function ValidarUsuario(nombre As String, contraseña As String) As String
        For i = 0 To _Usuarios.Count - 1
            If _Usuarios(i).Nombre = nombre AndAlso _Usuarios(i).Contraseña = contraseña Then
                Return "Sesión iniciada"
            End If
        Next
        Return "Usuario y/o contraseña incorrectos. No se puede iniciar sesión."
    End Function

    Public Function ComprobarTiempo(tiempo As Integer, dificultad As Integer, nombre As String) As Integer
        If dificultad = 1 Then
            For i = 0 To _Usuarios.Count - 1
                If _Usuarios(i).Nombre = nombre Then
                    If tiempo < _Usuarios(i).MejorTiempoFacil OrElse _Usuarios(i).MejorTiempoFacil = -1 Then
                        _Usuarios(i).MejorTiempoFacil = tiempo
                        Return tiempo
                    End If
                End If
            Next
        ElseIf dificultad = 2 Then
            For i = 0 To _Usuarios.Count - 1
                If _Usuarios(i).Nombre = nombre Then
                    If tiempo < _Usuarios(i).MejorTiempoMedio OrElse _Usuarios(i).MejorTiempoMedio = -1 Then
                        _Usuarios(i).MejorTiempoMedio = tiempo
                        Return tiempo
                    End If
                End If
            Next
        Else
            For i = 0 To _Usuarios.Count - 1
                If _Usuarios(i).Nombre = nombre Then
                    If tiempo < _Usuarios(i).MejorTiempoDificil OrElse _Usuarios(i).MejorTiempoDificil = -1 Then
                        _Usuarios(i).MejorTiempoDificil = tiempo
                        Return tiempo
                    End If
                End If
            Next
        End If
        Return -1
    End Function

    Public Function OrdenarLista(dificultad As Integer) As List(Of Usuario)
        Dim rankingFacil As New List(Of Usuario)
        Dim rankingMedio As New List(Of Usuario)
        Dim rankingDificil As New List(Of Usuario)
        Dim rankingVacio As New List(Of Usuario)
        Dim insertado As Boolean = False
        If dificultad = 1 Then
            For i = 0 To _Usuarios.Count - 1 'RECORRE LA LISTA DE USUARIOS
                If _Usuarios(i).MejorTiempoFacil <> -1 Then
                    insertado = False
                    For j = 0 To rankingFacil.Count - 1 'RECORRE EL RANKING
                        If _Usuarios(i).MejorTiempoFacil < rankingFacil(j).MejorTiempoFacil Then
                            rankingFacil.Insert(j, _Usuarios(i))
                            insertado = True
                            Exit For
                        End If
                    Next
                    If insertado = False Then
                        rankingFacil.Add(_Usuarios(i))
                    End If
                End If
            Next
            Return rankingFacil
        ElseIf dificultad = 2 Then
            For i = 0 To _Usuarios.Count - 1 'RECORRE LA LISTA DE USUARIOS
                If _Usuarios(i).MejorTiempoMedio <> -1 Then
                    insertado = False
                    For j = 0 To rankingMedio.Count - 1 'RECORRE EL RANKING
                        If _Usuarios(i).MejorTiempoMedio < rankingMedio(j).MejorTiempoMedio Then
                            rankingMedio.Insert(j, _Usuarios(i))
                            insertado = True
                            Exit For
                        End If
                    Next
                    If insertado = False Then
                        rankingMedio.Add(_Usuarios(i))
                    End If
                End If
            Next
            Return rankingMedio
        Else
            For i = 0 To _Usuarios.Count - 1 'RECORRE LA LISTA DE USUARIOS
                If _Usuarios(i).MejorTiempoDificil <> -1 Then
                    insertado = False
                    For j = 0 To rankingDificil.Count - 1 'RECORRE EL RANKING
                        If _Usuarios(i).MejorTiempoDificil < rankingDificil(j).MejorTiempoDificil Then
                            rankingDificil.Insert(j, _Usuarios(i))
                            insertado = True
                            Exit For
                        End If
                    Next
                    If insertado = False Then
                        rankingDificil.Add(_Usuarios(i))
                    End If
                End If
            Next
            Return rankingDificil
        End If
        Return rankingVacio
    End Function

End Class
