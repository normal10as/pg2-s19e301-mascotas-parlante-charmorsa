Imports System
Imports Entidades
Module LoroTest
    Sub Main(args As String())
        Dim test As New Loro()

        test.FechaNacimiento = #10-02-2001#

        Console.WriteLine("Fecha nacimiento: " & test.FechaNacimiento)
        test.Escuchar("Papita")
        test.Escuchar(" pa el loro")
        test.Escuchar(" Juan")
        test.Nombre = "Juan"

        Console.WriteLine("La Diferencia de edad es: " & test.CalcularEdad(test.FechaNacimiento))
        Console.WriteLine("Nombre: " & test.ToString())
        Console.WriteLine("Hablando: ")

        Console.WriteLine(test.Hablar())
        Console.WriteLine("a." & test.Hablar())
        Console.WriteLine("b." & test.Hablar())
        Console.WriteLine("c" & test.Hablar())
    End Sub
End Module
