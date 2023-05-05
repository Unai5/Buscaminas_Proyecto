Public Class GestionUsuariosTest

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


End Class
