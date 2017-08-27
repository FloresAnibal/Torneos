Imports TorneosEntidades

Module JugadorTest

    Sub Main()

        Dim jugador_1 As New Jugador
        Dim jugador_2 As New Jugador
        Dim jugador_3 As New Jugador

        jugador_1.Numero = 5
        jugador_2.Numero = 67
        'numero fuera de rango
        jugador_3.Numero = 100

        Console.WriteLine("Numero Jugador 1: " & jugador_1.Numero)
        Console.WriteLine("Numero Jugador 2: " & jugador_2.Numero)
        Console.WriteLine("Numero Jugador 3: " & jugador_3.Numero)

        Console.ReadKey()

    End Sub

End Module
