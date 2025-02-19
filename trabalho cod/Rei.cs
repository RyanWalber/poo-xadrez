public class Rei : Peca
{
    public Rei(string cor, int x, int y)
        : base(cor, x, y, Image.FromFile($"Resources/{cor}_rei.png")) {}

    public override bool VerificarMovimentacao(int novoX, int novoY)
    {
        return Math.Abs(novoX - X) <= 1 && Math.Abs(novoY - Y) <= 1;
    }
}
