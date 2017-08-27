Imports TorneosEntidades

Module TorneoTest

    Sub Main()
        Dim torneo_1 As New Torneo
        Dim torneo_2 As New Torneo
        Dim torneo_3 As New Torneo
        Dim torneo_4 As New Torneo("Invierno")

        torneo_1.Nombre = "Verano"
        torneo_2.Nombre = "VeranoVeranoVeranoVeranoVeranoVeranoVeranoVeranoVerano"
        torneo_3.Nombre = ""

        Console.WriteLine("Nombre de Torneo 1: " & torneo_1.Nombre)
        Console.WriteLine("Nombre de Torneo 2: " & torneo_2.Nombre)
        Console.WriteLine("Nombre de Torneo 3: " & torneo_3.Nombre)
        Console.WriteLine("Nombre de Torneo 4: " & torneo_4.Nombre)

        Console.ReadKey()

    End Sub

End Module
