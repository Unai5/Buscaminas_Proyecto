Public Class Casilla

    Public Property TipoDeCasilla As Integer
    Public Property PosicionX As Integer
    Public Property PosicionY As Integer

    Public Sub New(bomba As Boolean)


        If bomba Then _TipoDeCasilla = -1


    End Sub
End Class
