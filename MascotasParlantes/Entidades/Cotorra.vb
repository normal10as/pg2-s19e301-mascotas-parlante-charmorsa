Public Class Cotorra
    Inherits Loro
    Private memoria As Queue(Of String)
    Public Sub New()
        MyBase.New()
        Nombre = ""
        FechaNacimiento = Date.Now
        memoria = New Queue(Of String)
    End Sub

    Public ReadOnly Property edadHumana As UShort
        Get
            Return 2 * Edad
        End Get
    End Property

    Dim OnOff As Integer = 0
    Public Overloads Sub Escuchar(frase As String)
        If OnOff Mod 2 = 0 Then
            memoria.Enqueue(frase)
        End If
        OnOff += 1
    End Sub
End Class