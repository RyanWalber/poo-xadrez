using System;

public class Tabuleiro
{
    public Peca[,] Pecas { get; private set; }

    public Tabuleiro()
    {
        Pecas = new Peca[8, 8];
        InicializarTabuleiro();
    }

    private void InicializarTabuleiro()
    {
        // Posicionando Peões
        for (int coluna = 0; coluna < 8; coluna++)
        {
            Pecas[1, coluna] = new Peao("preto", 1, coluna);
            Pecas[6, coluna] = new Peao("branco", 6, coluna);
        }

        // Posicionando Torres
        Pecas[0, 0] = new Torre("preto", 0, 0);
        Pecas[0, 7] = new Torre("preto", 0, 7);
        Pecas[7, 0] = new Torre("branco", 7, 0);
        Pecas[7, 7] = new Torre("branco", 7, 7);

        // Posicionando Cavalos
        Pecas[0, 1] = new Cavalo("preto", 0, 1);
        Pecas[0, 6] = new Cavalo("preto", 0, 6);
        Pecas[7, 1] = new Cavalo("branco", 7, 1);
        Pecas[7, 6] = new Cavalo("branco", 7, 6);

        // Posicionando Bispos
        Pecas[0, 2] = new Bispo("preto", 0, 2);
        Pecas[0, 5] = new Bispo("preto", 0, 5);
        Pecas[7, 2] = new Bispo("branco", 7, 2);
        Pecas[7, 5] = new Bispo("branco", 7, 5);

        // Posicionando Rainhas
        Pecas[0, 3] = new Rainha("preto", 0, 3);
        Pecas[7, 3] = new Rainha("branco", 7, 3);

        // Posicionando Reis
        Pecas[0, 4] = new Rei("preto", 0, 4);
        Pecas[7, 4] = new Rei("branco", 7, 4);
    }

    public bool MoverPeca(int origemX, int origemY, int destinoX, int destinoY)
    {
        Peca peca = Pecas[origemX, origemY];

        if (peca == null)
        {
            Console.WriteLine("Nenhuma peça na posição de origem.");
            return false;
        }

        if (!peca.VerificarMovimentacao(destinoX, destinoY))
        {
            Console.WriteLine("Movimento inválido para essa peça.");
            return false;
        }

        if (Pecas[destinoX, destinoY] != null && Pecas[destinoX, destinoY].Cor == peca.Cor)
        {
            Console.WriteLine("Você não pode capturar sua própria peça.");
            return false;
        }

        // Movimento válido, executa a jogada
        Pecas[origemX, origemY] = null;
        Pecas[destinoX, destinoY] = peca;
        peca.X = destinoX;
        peca.Y = destinoY;

        return true;
    }
}
