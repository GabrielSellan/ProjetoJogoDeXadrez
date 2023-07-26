﻿using System;
using tabuleiro;
using Xadrez_game;
using xadrez;

namespace xadrez_console // Note: actual namespace depends on the project name.
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Tabuleiro tab = new Tabuleiro(8, 8);

                tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
                tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 3));
                tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 2));
                tab.ColocarPeca(new Torre(tab, Cor.Branca), new Posicao(3, 5));
                tab.ColocarPeca(new Torre(tab, Cor.Branca), new Posicao(0, 3));
                tab.ColocarPeca(new Torre(tab, Cor.Branca), new Posicao(2, 7));

                Tela.ImprimirTabuleiro(tab);
            }catch (TabuleiroException e) 
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }
    }
}
