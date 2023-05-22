Imports BibliotecaDeClases

<TestClass()> Public Class ArchivosConfiguracionTest

    <TestMethod()>
    Public Sub ArchivoConfiguracionExiste()
        Dim rutaArchivoConfig As String = "./Ficheros/TodosLosUsuarios.txt"
        Dim archivoExiste As Boolean = System.IO.File.Exists(rutaArchivoConfig)
        Assert.IsTrue(archivoExiste, "El archivo de configuración no existe.")
    End Sub


    <TestMethod()>
    Public Sub ArchivoNoVacio()
        Dim rutaArchivo As String = "./Ficheros/TodosLosUsuarios.txt"

        Dim contenido As String = System.IO.File.ReadAllText(rutaArchivo)

        Assert.IsFalse(String.IsNullOrEmpty(contenido), "El archivo de configuración está vacío.")
    End Sub

    <TestMethod()>
    Public Sub SinIntroAlFinal()
        Dim rutaArchivo As String = "./Ficheros/TodosLosUsuarios.txt"

        Dim contenido As String = System.IO.File.ReadAllText(rutaArchivo)

        Dim tieneIntroAlFinal As Boolean = contenido.EndsWith(Environment.NewLine)
        Assert.IsFalse(tieneIntroAlFinal, "El archivo de configuración tiene un intro al final.")
    End Sub


End Class