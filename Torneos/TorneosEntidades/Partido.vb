Public Class Partido
    'campos
    Private _fecha As Date
    Private _golesLocal As UShort
    Private _golesVisitantes As UShort
    Private _minutosGolesLocales As List(Of UShort)
    Private _minutosGolesVisitantes As List(Of UShort)
    Private _estadoPartido As Boolean

    'constructor
    Sub New()
        _fecha = Nothing
        _golesLocal = 0
        _golesVisitantes = 0
        _minutosGolesLocales = New List(Of UShort)
        _minutosGolesVisitantes = New List(Of UShort)
        _estadoPartido = False
    End Sub

    'propiedades
    Public Property Fecha() As Date
        Get
            Return _fecha
        End Get
        Set(value As Date)
            If Not _estadoPartido Then _fecha = value
        End Set
    End Property

    Public ReadOnly Property GolesLocal() As UShort
        Get
            Return _golesLocal
        End Get
    End Property

    Public ReadOnly Property GolesVisitante() As UShort
        Get
            Return _golesVisitantes
        End Get
    End Property

    Public ReadOnly Property MinutosGolesLocales() As List(Of UShort)
        Get
            Return _minutosGolesLocales
        End Get
    End Property

    Public ReadOnly Property MinutosGolesVisitantes() As List(Of UShort)
        Get
            Return _minutosGolesVisitantes
        End Get
    End Property

    'metodos
    Public Sub NuevoGolLocal(Minutos As UShort)
        If Not _estadoPartido Then
            _golesLocal += 1
            _minutosGolesLocales.Add(Minutos)
        End If
    End Sub

    Public Sub NuevoGolVisitante(Minutos As UShort)
        If Not _estadoPartido Then
            _golesVisitantes += 1
            _minutosGolesVisitantes.Add(Minutos)
        End If
    End Sub

    Public Sub Finalizado()
        If _estadoPartido = False Then
            _estadoPartido = True
        End If
    End Sub

End Class
