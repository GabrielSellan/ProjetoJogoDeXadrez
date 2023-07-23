using System;
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
                tab.ColocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 9));
                tab.ColocarPeca(new Rei(tab, Cor.Preta), new Posicao(0, 2));

                Tela.ImprimirTabuleiro(tab);
            }
            catch (TabuleiroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}

