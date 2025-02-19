public class Torre : Peca
{
    public Torre(string cor, int x, int y)
        : base(cor, x, y, Image.FromFile($"Resources/{cor}_torre.png")) {}

    public override bool VerificarMovimentacao(int novoX, int novoY)
    {
        return (novoX == X || novoY == Y);
    }
}
