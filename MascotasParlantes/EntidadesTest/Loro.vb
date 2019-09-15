Imports Entidades
Module LoroTest

    Sub Loro()
        Dim loro1 As Loro
        loro1 = New Loro()
        loro1.FechaNacimiento = #10-02-2001#
        loro1.Nombre = "lorenzo"

        Console.WriteLine("nombre es {0}", loro1.Nombre)
        Console.WriteLine("Fecha nacimiento: " & loro1.FechaNacimiento)
        Console.WriteLine("la edad es {0}", loro1.Edad)

        loro1.Escuchar("Papita")
        loro1.Escuchar(" pa el loro")
        loro1.Escuchar(" Juan")

        Console.WriteLine("Hablando: ")

        Console.WriteLine(loro1.Hablar())
        Console.WriteLine(loro1.Hablar())
        Console.WriteLine(loro1.Hablar())
        Console.WriteLine(loro1.Hablar())

        Console.Write("   ")
        Console.WriteLine(loro1.ToString())
    End Sub

End Module
