Public Class Jaula
    Inherits Cotorra
    Public Sub New()

    End Sub

    Private _nombreJaula As String
    Public Property NombreJaula As String
        Get
            Return _nombreJaula
        End Get
        Set(value As String)
            _nombreJaula = value
        End Set
    End Property

    Private _cotorra As List(Of Cotorra)
    Private _loro As Loro
End Class