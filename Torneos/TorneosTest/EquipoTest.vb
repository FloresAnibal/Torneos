Imports TorneosEntidades

Module EquipoTest

    Sub Main()
        Dim equipo_1 As New Equipo
        Dim equipo_2 As New Equipo
        Dim equipo_3 As New Equipo
        Dim equipo_4 As New Equipo("Sur")

        equipo_1.Nombre = "Norte"
        equipo_1.Nombre = "NorteNorteNorteNorteNorteNorteNorte"
        equipo_1.Nombre = ""

        Console.WriteLine("Equipo 1: " & equipo_1.Nombre)
        Console.WriteLine("Equipo 2: " & equipo_2.Nombre)
        Console.WriteLine("Equipo 3: " & equipo_3.Nombre)
        Console.WriteLine("Equipo 4: " & equipo_4.Nombre)

        Console.ReadKey()

    End Sub

End Module
