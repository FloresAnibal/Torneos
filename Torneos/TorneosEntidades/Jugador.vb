Public Class Jugador
    'campos
    Private _numero As UShort

    'constructor
    Sub New()
        _numero = 0
    End Sub

    'propiedades
    Public Property Numero() As UShort
        Get
            Return _numero
        End Get
        Set(value As UShort)
            If value >= 1 And value <= 99 Then _numero = value
        End Set
    End Property

    'metodos



End Class
