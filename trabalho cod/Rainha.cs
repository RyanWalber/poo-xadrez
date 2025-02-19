public class Rainha : Peca
{
    public Rainha(string cor, int x, int y)
        : base(cor, x, y, Image.FromFile($"Resources/{cor}_rainha.png")) {}

    public override bool VerificarMovimentacao(int novoX, int novoY)
    {
        return (novoX == X || novoY == Y) || (Math.Abs(novoX - X) == Math.Abs(novoY - Y));
    }
}
