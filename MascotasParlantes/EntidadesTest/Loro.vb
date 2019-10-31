Imports System
Imports Entidades


Module LoroTest
    Public loro1 As Loro
    Sub Loro()

        loro1 = New Loro()
        loro1.Nombre = "pepe"
        loro1.FechaNacimiento = #08-30-2000#

        Console.WriteLine("Loro")
        Console.WriteLine("Nombre: " & loro1.Nombre)
        Console.WriteLine("Nacimiento: " & loro1.FechaNacimiento)
        Console.WriteLine("Edad: " & loro1.Edad)

        'Cargo a la memoria las frases'
        loro1.escuchar("papita ")
        loro1.escuchar("pa el loro ")
        loro1.escuchar("juan")

        Console.WriteLine("Muestro las frases")
        Console.WriteLine(loro1.hablar())
        Console.WriteLine(loro1.hablar())
        Console.WriteLine(loro1.hablar())
        Console.WriteLine(loro1.hablar())


        Console.WriteLine("ToString():")
        Console.WriteLine(loro1.ToString())
    End Sub
End Module