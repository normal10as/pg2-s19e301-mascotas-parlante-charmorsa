Imports Entidades
Public Module CotorraTest
    Sub cotorra()
        Dim cotorra1 As Cotorra
        cotorra1 = New Cotorra()

        cotorra1.Nombre = "juanito"
        cotorra1.FechaNacimiento = #08-30-2000#

        Console.WriteLine("Cotorra")
        Console.WriteLine("Nombre: " & cotorra1.Nombre)
        Console.WriteLine("Nacimiento: " & cotorra1.FechaNacimiento)
        Console.WriteLine("Edad: " & cotorra1.edadHumana)

        cotorra1.escuchar("papita ")
        cotorra1.escuchar("nada")
        cotorra1.escuchar("pa la cotorra ")
        cotorra1.escuchar("nada")

        Console.WriteLine(cotorra1.hablar())
        Console.WriteLine(cotorra1.hablar())
        Console.WriteLine(cotorra1.hablar())
        Console.WriteLine(cotorra1.hablar())
    End Sub


End Module