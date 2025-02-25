public class Tabuleiro
{
    public static int sizeOfTabuleiro = 8;
    public Peca[,] tabuleiro = new Peca[sizeOfTabuleiro, sizeOfTabuleiro];

    public Tabuleiro()
    {
        InicializarTabuleiro();
    }

    public void InicializarTabuleiro()
    {
        for (int i = 0; i < 8; i++)
        {
            tabuleiro[i, 1] = new Peao(i * 50, 1 * 50, "peaobranco.png", true);
            tabuleiro[i, 6] = new Peao(i * 50, 6 * 50, "peaopreto.png", false);
        }

        tabuleiro[0, 0] = new Torre(0, 0, "torrebranca.png");
        tabuleiro[7, 0] = new Torre(7 * 50, 0, "torrebranca.png");
        tabuleiro[0, 7] = new Torre(0, 7 * 50, "torrepreta.png");
        tabuleiro[7, 7] = new Torre(7 * 50, 7 * 50, "torrepreta.png");

        tabuleiro[1, 0] = new Cavalo(1 * 50, 0, "cavalobranco.png");
        tabuleiro[6, 0] = new Cavalo(6 * 50, 0, "cavalobranco.png");
        tabuleiro[1, 7] = new Cavalo(1 * 50, 7 * 50, "cavalopreto.png");
        tabuleiro[6, 7] = new Cavalo(6 * 50, 7 * 50, "cavalopreto.png");

        tabuleiro[2, 0] = new Bispo(2 * 50, 0, "bispobranco.png");
        tabuleiro[5, 0] = new Bispo(5 * 50, 0, "bispobranco.png");
        tabuleiro[2, 7] = new Bispo(2 * 50, 7 * 50, "bispopreto.png");
        tabuleiro[5, 7] = new Bispo(5 * 50, 7 * 50, "bispopreto.png");

        tabuleiro[3, 0] = new Rainha(3 * 50, 0, "rainhabranca.png");
        tabuleiro[3, 7] = new Rainha(3 * 50, 7 * 50, "rainhapreta.png");


        tabuleiro[4, 0] = new Rei(4 * 50, 0, "reibranco.png");
        tabuleiro[4, 7] = new Rei(4 * 50, 7 * 50, "reipreto.png");

        for (int linha = 0; linha < 8; linha++)
{
    for (int coluna = 0; coluna < 8; coluna++)
    {
        PictureBox casa = new PictureBox();
        casa.Size = new Size(50, 50);
        casa.Location = new Point(coluna * 50, linha * 50);
        casa.BackColor = (linha + coluna) % 2 == 0 ? Color.White : Color.Gray;
        casa.BorderStyle = BorderStyle.FixedSingle;

    }
}

        for (int i = 0; i < 8; i++)
        {
            for (int j = 2; j < 6; j++)
            {
                tabuleiro[i, j] = new CasaVazia(i * 50, j * 50, "CasaVazia.png");
            }
        }
    }
}
