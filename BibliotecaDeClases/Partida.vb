Public Class Partida : Inherits Usuario
    Public Property Tiempo As TimeSpan
    Public Property ModoJuego As Integer
    Public Sub New(nombre As String, contrasena As String, modojuego As Integer)
        MyBase.New(nombre, contrasena)
        Me.ModoJuego = modojuego
    End Sub
End Class
