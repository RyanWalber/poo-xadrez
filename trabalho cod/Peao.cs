public class Peao : Peca
{
    private bool primeiroMovimento = true;

    public Peao(int x, int y, string img) : base(x, y, img)
    {
    }

    public override bool validarMovimento(int destinoX, int destinoY)
    {
        // Peão branco (anda para cima)
        if (img.Contains("branco"))
        {
            // Movimento de uma casa para frente
            if (destinoX == x && destinoY == y - 1)
            {
                primeiroMovimento = false;
                return true;
            }

            // Movimento de duas casas na primeira jogada
            if (primeiroMovimento && destinoX == x && destinoY == y - 2)
            {
                primeiroMovimento = false;
                return true;
            }
        }

        // Peão preto (anda para baixo)
        if (img.Contains("preto"))
        {
            // Movimento de uma casa para frente
            if (destinoX == x && destinoY == y + 1)
            {
                primeiroMovimento = false;
                return true;
            }

            // Movimento de duas casas na primeira jogada
            if (primeiroMovimento && destinoX == x && destinoY == y + 2)
            {
                primeiroMovimento = false;
                return true;
            }
        }

        return false;
    }
}
