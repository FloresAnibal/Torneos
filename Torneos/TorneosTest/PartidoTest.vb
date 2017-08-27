Imports TorneosEntidades

Module PartidoTest

    Sub Main()

        Dim partido_1 As New Partido
        Dim partido_2 As New Partido

        partido_1.Fecha = #08/25/2017#
        partido_1.NuevoGolLocal(8)
        partido_1.NuevoGolLocal(23)
        partido_1.NuevoGolVisitante(36)
        partido_1.NuevoGolLocal(65)

        partido_2.Fecha = #03/06/2017#
        partido_2.NuevoGolLocal(90)

        Console.WriteLine("Fecha de Partido 1: " & partido_1.Fecha)
        Console.WriteLine("Goles Locales: " & partido_1.GolesLocal)
        Console.WriteLine("Goles Visitantes: " & partido_1.GolesVisitante)
        Mostrar_en_Pantalla("Minutos Goles Locales: ", partido_1.MinutosGolesLocales)
        Mostrar_en_Pantalla("Minutos Goles Visitantes: ", partido_1.MinutosGolesVisitantes)
        'modifico fecha de partido antes de finalizar
        partido_1.Fecha = #12/20/1990#
        'agrego un gol antes de finalizar
        partido_1.NuevoGolLocal(78)

        Console.WriteLine(vbCrLf & "MODIFICACIONES ANTES DE FINALIZAR...")

        Console.WriteLine("Fecha de Partido 1: " & partido_1.Fecha)
        Console.WriteLine("Goles Locales: " & partido_1.GolesLocal)
        Console.WriteLine("Goles Visitantes: " & partido_1.GolesVisitante)
        Mostrar_en_Pantalla("Minutos Goles Locales: ", partido_1.MinutosGolesLocales)
        Mostrar_en_Pantalla("Minutos Goles Visitantes: ", partido_1.MinutosGolesVisitantes)
        Console.WriteLine("Partido Finalizado")
        partido_1.Finalizado()

        Console.WriteLine(vbCrLf & "Fecha de Partido 2: " & partido_2.Fecha)
        Console.WriteLine("Goles Locales: " & partido_2.GolesLocal)
        Console.WriteLine("Goles Visitantes: " & partido_2.GolesVisitante)
        Mostrar_en_Pantalla("Minutos Goles Locales: ", partido_2.MinutosGolesLocales)
        Mostrar_en_Pantalla("Minutos Goles Visitantes: ", partido_2.MinutosGolesVisitantes)
        Console.WriteLine("Partido Finalizado")
        partido_2.Finalizado()
        'modificaciones despues de finalizar
        partido_2.Fecha = #03/06/2015#
        partido_2.NuevoGolLocal(93)
        partido_2.NuevoGolVisitante(94)
        partido_2.NuevoGolVisitante(96)

        Console.WriteLine(vbCrLf & "Fecha de Partido 2: " & partido_2.Fecha)
        Console.WriteLine("Goles Locales: " & partido_2.GolesLocal)
        Console.WriteLine("Goles Visitantes: " & partido_2.GolesVisitante)
        Mostrar_en_Pantalla("Minutos Goles Locales: ", partido_2.MinutosGolesLocales)
        Mostrar_en_Pantalla("Minutos Goles Visitantes: ", partido_2.MinutosGolesVisitantes)

        Console.ReadKey()

    End Sub

    Private Sub Mostrar_en_Pantalla(cadena As String, lista As List(Of UShort))
        For Each iterar As UShort In lista
            Console.WriteLine(cadena & iterar)
        Next
    End Sub

End Module
