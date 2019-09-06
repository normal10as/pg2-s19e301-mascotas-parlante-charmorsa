Imports System.DateTime
Public Class Loro
    Public Sub New()
        memoria = New Queue(Of String)
        FechaNacimiento = Date.Now
        Nombre = " "
        memoria = New Queue(Of String)
        memoria.Enqueue("Hola")
    End Sub
    Private memoria As Queue(Of String)

    '--------------------------------------
    Private _edad As Short
    Public ReadOnly Property Edad As Short
        Get
            Return _edad
        End Get
    End Property
    '-----------------------------------------
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
    Public Function CalcularEdad(FechaNacimiento As Date) As UShort
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
        Dim frase As String
        frase = memoria.Dequeue()
        Return frase

    End Function
End Class
