Public Class Persona
    'campos
    Private _nombre As String
    Private _fechaNacimiento As Date

    'constructor
    Sub New()
        _nombre = ""
        _fechaNacimiento = Nothing
    End Sub

    'constructor sobrecargado
    Sub New(Nombre As String, FechaNacimiento As Date)
        Me.New()
        Me.Nombre = Nombre
        Me.FechaNacimiento = FechaNacimiento
    End Sub

    'propiedades
    Public Property Nombre() As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            If ValidarCadena(value, 30) Then _nombre = value
        End Set
    End Property

    Public Property FechaNacimiento() As Date
        Get
            Return _fechaNacimiento
        End Get
        Set(value As Date)
            'paso la fecha de nacimiento menos un dia para evitar grabar la fecha si 
            'cumple 16 el dia hoy.
            If CalcularEdad(value.AddDays(-1)) >= 16 Then _fechaNacimiento = value
        End Set
    End Property

    Public ReadOnly Property Edad() As Short
        Get
            'If para evitar que edad devuelva un valor distinto de cero cuando _fechaNacimiento es "Nothing" 
            If _fechaNacimiento = Nothing Then Return 0
            Return CalcularEdad(FechaNacimiento)
        End Get
    End Property

    'metodos

    Private Function CalcularEdad(fechaNacimiento As Date) As UShort
        If fechaNacimiento.Day < Today.Day And fechaNacimiento.Month <= Today.Month Then
            Return DateDiff("yyyy", fechaNacimiento, Date.Now) - 1
        End If
        Return DateDiff("yyyy", fechaNacimiento, Date.Now)
    End Function

    'valida la longitud maxima y minima de un string
    Private Function ValidarCadena(cadena As String, maximo As UShort) As Boolean
        Return If(cadena.Length >= 1 And cadena.Length <= maximo, True, False)
    End Function

End Class
