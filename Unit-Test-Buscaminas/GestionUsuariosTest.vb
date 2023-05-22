Imports BibliotecaDeClases
<TestClass()> Public Class GestionUsuariosTest

    <TestMethod()> Public Sub ConstructorTest()
        Dim target As New BibliotecaDeClases.GestionUsuario
        Assert.IsNotNull(target)
    End Sub

    <TestMethod()> Public Sub AñadirUsuarioTest()

        Dim target As New BibliotecaDeClases.GestionUsuario

        Dim expected As String = "Usuario creado"
        Dim actual As String = target.AñadirUsuario("juan", "juan")

        Assert.AreEqual(expected, actual)

    End Sub

    <TestMethod()> Public Sub AñadirUsuarioTestError()

        Dim target As New BibliotecaDeClases.GestionUsuario

        Dim expected As String = "Ya existe el usuario juan"
        Dim actual As String = target.AñadirUsuario("juan", "juan")

        Assert.AreEqual(expected, actual)

    End Sub

    <TestMethod()> Public Sub ValidarUsuarioTest()

        Dim target As New BibliotecaDeClases.GestionUsuario

        Dim expected As String = "Sesión iniciada"
        Dim actual As String = target.ValidarUsuario("juan", "juan")

        Assert.AreEqual(expected, actual)

    End Sub

    <TestMethod()> Public Sub ValidarUsuarioTestError()

        Dim target As New BibliotecaDeClases.GestionUsuario

        Dim expected As String = "No existe el usuario, no se puede iniciar sesion"
        Dim actual As String = target.ValidarUsuario("a", "juan")

        Assert.AreEqual(expected, actual)

    End Sub


End Class
