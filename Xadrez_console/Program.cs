using System;
using tabuleiro;

namespace Xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro tab = new Tabuleiro(8,8);
            Console.WriteLine(tab.Colunas +","+ tab.Linhas);
            Console.ReadLine();
        }
    }
}
