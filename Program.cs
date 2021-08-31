using System;
using tabuleiro;
using xadrez;

namespace Xadrez_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro tab = new Tabuleiro(8, 8);
            try
            {
                tab.colocarPeca(new Torre(tab, Cor.Preto), new Posicao(0, 0));
                tab.colocarPeca(new Torre(tab, Cor.Preto), new Posicao(1, 3));
                tab.colocarPeca(new Rei(tab, Cor.Preto), new Posicao(7, 7));

                tab.colocarPeca(new Torre(tab, Cor.Branco), new Posicao(0, 1));
                tab.colocarPeca(new Torre(tab, Cor.Branco), new Posicao(2, 3));
                tab.colocarPeca(new Rei(tab, Cor.Branco), new Posicao(7, 5));

                Tela.imprimirTabuleiro(tab);
            }
            catch (TabuleiroException e)
            {

                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}
