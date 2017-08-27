Imports TorneosEntidades

Module PersonaTest

    Sub Main()
        Dim persona_1 As New Persona
        Dim persona_2 As New Persona
        Dim persona_3 As New Persona
        Dim persona_4 As New Persona("Alejandro", #03/07/1990#)

        persona_1.Nombre = "Carlos"
        persona_1.FechaNacimiento = #12/01/2000#
        'nombre fuera de rango
        persona_2.Nombre = "RodrigoRodrigoRodrigoRodrigoRodrigo"
        persona_2.FechaNacimiento = #05/30/1999#
        'fecha fuera de rango
        persona_3.Nombre = "Ester"
        persona_3.FechaNacimiento = #08/24/2001#

        Console.WriteLine("Nombre 1: " & persona_1.Nombre)
        Console.WriteLine("Fecha de Nacimiento 1: " & persona_1.FechaNacimiento)
        Console.WriteLine("Edad 1: " & persona_1.Edad & vbCrLf)

        Console.WriteLine("Nombre 2: " & persona_2.Nombre)
        Console.WriteLine("Fecha de Nacimiento 2: " & persona_2.FechaNacimiento)
        Console.WriteLine("Edad 2: " & persona_2.Edad & vbCrLf)

        Console.WriteLine("Nombre 3: " & persona_3.Nombre)
        Console.WriteLine("Fecha de Nacimiento 3: " & persona_3.FechaNacimiento)
        Console.WriteLine("Edad 3: " & persona_3.Edad & vbCrLf)

        Console.WriteLine("Nombre 4: " & persona_4.Nombre)
        Console.WriteLine("Fecha de Nacimiento 4: " & persona_4.FechaNacimiento)
        Console.WriteLine("Edad 4: " & persona_4.Edad & vbCrLf)

        Console.ReadKey()

    End Sub

End Module
