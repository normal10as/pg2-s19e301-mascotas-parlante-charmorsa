Imports Entidades
Module JaulaTest
    Sub jaula()
        Dim jaula1 As New Jaula()
        jaula1.Nombre = "Fortaleza"
        Dim loro1 As New Loro()
        loro1.Nombre = "Paco"
        loro1.FechaNacimiento = #10-04-1992#
        ' establece la referencia al loro desde jaula
        jaula1.Loro = loro1
        Console.WriteLine("ToString: " & jaula1.ToString())
        Console.WriteLine("Loro: " & jaula1.Loro.ToString)

        Dim cotorra1 As New Cotorra()
        cotorra1.Nombre = "pepe1"
        Dim cotorra2 As New Cotorra()
        cotorra2.Nombre = "pepe2"
        Dim cotorra3 As New Cotorra()
        cotorra3.Nombre = "pepe3"
        Dim cotorra4 As New Cotorra()
        cotorra4.Nombre = "pepe4"

        jaula1.addCotorra(cotorra1)
        jaula1.addCotorra(cotorra2)
        jaula1.addCotorra(cotorra3)
        jaula1.addCotorra(cotorra4)
        mostrarCotorras(jaula1)
    End Sub

    Sub mostrarCotorras(jaula As Jaula)
        For Each item In jaula.getAllCotorras()
            Console.WriteLine(item)
        Next
    End Sub
End Module