public class Bispo : Peca
{
    public Bispo(string cor, int x, int y)
        : base(cor, x, y, Image.FromFile($"Resources/{cor}_bispo.png")) {}

    public override bool VerificarMovimentacao(int novoX, int novoY)
    {
        return Math.Abs(novoX - X) == Math.Abs(novoY - Y);
    }
}
