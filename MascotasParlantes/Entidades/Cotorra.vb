Public Class Cotorra
    Inherits Loro
    Public Sub New()
        MyBase.New()
    End Sub

    Public ReadOnly Property edadHumana As UShort
        Get
            Return 2 * Edad
        End Get
    End Property

    Private siEscucha As Boolean = True
    Public Overrides Sub escuchar(frase As String)
        If siEscucha Then
            MyBase.escuchar(frase)
        End If
        siEscucha = Not siEscucha
    End Sub

End Class