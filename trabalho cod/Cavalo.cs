public class Cavalo : Peca
{
    public Cavalo(string cor, int x, int y)
        : base(cor, x, y, Image.FromFile($"Resources/{cor}_cavalo.png")) {}

    public override bool VerificarMovimentacao(int novoX, int novoY)
    {
        int dx = Math.Abs(novoX - X);
        int dy = Math.Abs(novoY - Y);
        return (dx == 2 && dy == 1) || (dx == 1 && dy == 2);
    }
}
