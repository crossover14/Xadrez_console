using System;
using tabuleiro;
using xadrez;

namespace Xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {

            PosicaoXadrez pos = new PosicaoXadrez('d', 8);
            Console.WriteLine(pos);
            Console.WriteLine(pos.ToPosicao());
          
            Console.ReadLine();

        }
    }
}
