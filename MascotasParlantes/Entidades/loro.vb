Public Class Loro
    Private memoria As Queue(Of String)
    Public Sub New()
        memoria = New Queue(Of String)
        Nombre = ""
        FechaNacimiento = Date.Now
    End Sub

    Public ReadOnly Property Edad As Short
        Get
            Return calcularEdad(FechaNacimiento)
        End Get
    End Property

    Private _fechaNacimiento As Date
    Public Property FechaNacimiento As Date
        Get
            Return _fechaNacimiento
        End Get
        Set(value As Date)
            _fechaNacimiento = value
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

    Private Function calcularEdad(value As Date) As UShort
        Dim hoy As Date = Date.Now()
        Dim edad As UShort
        edad = (hoy.Year) - (value.Year)
        If (hoy.Month < value.Month) Then
            edad -= 1
        ElseIf hoy.Month = value.Month And hoy.Day < value.Day Then
            edad -= 1
        End If
        Return edad
    End Function

    Public Overridable Sub escuchar(frase As String)
        memoria.Enqueue(frase)
    End Sub

    Public Overrides Function ToString() As String
        Return Nombre
    End Function

    Private frase As String
    Public Function hablar() As String
        If memoria.Count > 0 Then
            frase += memoria.Dequeue()
        End If
        Return frase
    End Function
End Class
