Public Class Tabla
    Public Property CantidadMinas As Integer
    Public Property Lado As Integer
    Public Sub New(lado As Integer, minas As Integer)
        _Lado = lado
        CantidadMinas = minas
        Dim botonesHorizontales() As Object = {}
        Dim botonesVerticales() As Object = {}
        For i = 0 To lado - 1
            Array.Resize(botonesHorizontales, botonesHorizontales.Length + 1)
            botonesHorizontales(botonesHorizontales.Length - 1) = New Casilla
            For z = 0 To lado - 1
                Array.Resize(botonesVerticales, botonesVerticales.Length + 1)
                botonesVerticales(botonesVerticales.Length - 1) = New Casilla
            Next
        Next
    End Sub



End Class
