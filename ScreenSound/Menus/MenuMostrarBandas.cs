﻿using ScreenSound.Modelos;

namespace ScreenSound.Menus;

internal class MenuMostrarBandas : Menu
{
    internal void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        Console.Clear();
        ExibirTituloDaOpcao("Exibindo todas as bandas registradas na nossa aplicação");

        foreach (string banda in bandasRegistradas.Keys)
        {
            Console.WriteLine($"Banda: {banda}");
        }

        Console.WriteLine("\nPressione Enter para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
    }
}
