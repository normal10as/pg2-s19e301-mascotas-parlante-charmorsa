Imports System.DateTime
Public Class Loro
    Private memoria As Queue(Of String)
    Public Sub New()
        memoria = New Queue(Of String)
        FechaNacimiento = Date.Now
        Nombre = " "
    End Sub

    Public ReadOnly Property Edad As Short
        Get
            Return CalcularEdad(FechaNacimiento)
        End Get
    End Property

    Private _fechanacimiento As Date
    Public Property FechaNacimiento As Date
        Get
            Return _fechanacimiento
        End Get
        Set(value As Date)
            _fechanacimiento = value
        End Set
    End Property

    Private _nombre As String
    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property
    Private Function CalcularEdad(FechaNacimiento As Date) As UShort
        Dim DiferenciaEdad As UShort
        Dim FechaActual As Date = Date.Now()
        DiferenciaEdad = (FechaActual.Year) - (FechaNacimiento.Year)
        If (FechaActual.Month < FechaNacimiento.Month) Then
            DiferenciaEdad = DiferenciaEdad - 1
        ElseIf (FechaActual.Month = FechaNacimiento.Month And FechaActual.Day < FechaNacimiento.Day) Then
            DiferenciaEdad = DiferenciaEdad - 1
        End If
        Return DiferenciaEdad
    End Function
    Public Sub Escuchar(frase As String)
        memoria.Enqueue(frase)
    End Sub
    Public Function Hablar() As String
        Dim frase As String = ""
        If memoria.Count > 0 Then
            frase = memoria.Dequeue()
        End If
        Return frase
    End Function
    Public Overrides Function ToString() As String
        Return Nombre
    End Function
End Class
