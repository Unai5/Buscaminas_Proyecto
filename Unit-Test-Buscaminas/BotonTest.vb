Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class BotonTest

    <TestMethod()> Public Sub BotonConstructorTest()
        Dim target As New BibliotecaDeClases.Boton
        Assert.IsNotNull(target)
    End Sub

End Class