Public Class Jaula
    Public Sub New()
        Nombre = ""
        Loro = New Loro()
        _cotorras = New List(Of Cotorra)
    End Sub

    Private _nombre As String
    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property

    Private _loro As Loro
    Public Property Loro As Loro
        Get
            Return _loro
        End Get
        Set(value As Loro)
            _loro = value
        End Set
    End Property

    Private _cotorras As List(Of Cotorra)
    Sub addCotorra(cotorra As Cotorra)
        If _cotorras.Count < 3 Then
            _cotorras.Add(cotorra)
        End If
    End Sub

    Function getAllCotorras() As List(Of Cotorra)
        Return _cotorras
    End Function

    Public Overrides Function ToString() As String
        Return "Esta es la jaula: " & Nombre
    End Function
End Class