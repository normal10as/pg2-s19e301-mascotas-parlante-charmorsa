﻿Imports Entidades
Module CuentaCorrienteTest
    Sub Hacer()
        Dim cliente1 As New Cliente("Paco Lopez", 43253535)
        Dim cuenta1 As New CuentaCorriente(387584, 0, 1000, cliente1)

        Console.WriteLine("cuenta1.tostring: " & cuenta1.ToString)
        Console.WriteLine("cuenta1.cliente: " & cuenta1.Cliente.ToString)
        Dim cliente2 As New Cliente("Tete Gomez", 43253535)
        cuenta1.Cliente = cliente2
        Console.WriteLine("cuenta1.cliente: " & cuenta1.Cliente.ToString)
        Console.WriteLine("cuenta1.Numero: " & cuenta1.Numero)
        Console.WriteLine("cuenta1.MontoSobregiro: " & cuenta1.MontoSobregiro)
        Console.WriteLine("Saldo: " & cuenta1.Saldo)
        cuenta1.Depositar(1000)
        Console.WriteLine("Saldo: " & cuenta1.Saldo)
        cuenta1.Depositar(5000)
        Console.WriteLine("Saldo: " & cuenta1.Saldo)
        cuenta1.Extraer(5000)
        Console.WriteLine("Saldo: " & cuenta1.Saldo)
        cuenta1.Extraer(1500)
        Console.WriteLine("Saldo: " & cuenta1.Saldo)
        cuenta1.Extraer(1500)
        Console.WriteLine("Saldo: " & cuenta1.Saldo)
    End Sub
End Module
