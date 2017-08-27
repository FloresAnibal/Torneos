Public Class Torneo
    'campos
    Private _nombre As String

    'constructor
    Sub New()
        _nombre = ""
    End Sub

    'constructor sobrecargado
    Sub New(Nombre As String)
        Me.New()
        Me.Nombre = Nombre
    End Sub

    'propiedades
    Public Property Nombre() As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            If ValidarCadena(value, 50) Then _nombre = value
        End Set
    End Property

    'metodos


    'valida la longitud maxima y minima de un string
    Private Function ValidarCadena(cadena As String, maximo As UShort) As Boolean
        If cadena.Length >= 1 And cadena.Length <= maximo Then
            Return True
        End If
        Return False
    End Function

End Class
