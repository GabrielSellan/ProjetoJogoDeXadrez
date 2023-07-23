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

            PosicaoXadrez pos = new PosicaoXadrez('c', 7);

            Console.WriteLine(pos);

            Console.WriteLine(pos.ToPosicao());

            Console.ReadLine();
        }
    }
}
