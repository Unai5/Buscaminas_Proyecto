﻿Imports BibliotecaDeClases
<TestClass()> Public Class GestionUsuariosTest
    Dim target As New BibliotecaDeClases.GestionUsuario("")
    <TestMethod()> Public Sub ConstructorTest()
        Assert.IsNotNull(target)
    End Sub

    <TestMethod()> Public Sub AñadirUsuarioTest()

        Dim expected As String = "Usuario creado"
        Dim actual As String = target.AñadirUsuario("juan", "juan")

        Assert.AreEqual(expected, actual)

    End Sub

    <TestMethod()> Public Sub AñadirUsuarioTestError()

        Dim expected As String = "Ya existe el usuario juan"
        Dim actual As String = target.AñadirUsuario("juan", "juan")

        Assert.AreEqual(expected, actual)

    End Sub

    <TestMethod()> Public Sub AñadirUsuarioTestError2()

        Dim expected As String = "Hay elementos vacíos"
        Dim actual As String = target.AñadirUsuario("", "juan")

        Assert.AreEqual(expected, actual)

    End Sub

    <TestMethod()> Public Sub ValidarUsuarioTest()

        Dim expected As String = "Sesión iniciada"
        Dim actual As String = target.ValidarUsuario("juan", "juan")

        Assert.AreEqual(expected, actual)

    End Sub

    <TestMethod()> Public Sub ValidarUsuarioTestError()

        Dim expected As String = "Usuario y/o contraseña incorrectos. No se puede iniciar sesión."
        Dim actual As String = target.ValidarUsuario("a", "juan")

        Assert.AreEqual(expected, actual)

    End Sub



End Class
