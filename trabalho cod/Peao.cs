public class Peao : Peca
{
    public Peao(string cor, int x, int y)
        : base(cor, x, y, Image.FromFile($"Resources/{cor}_peao.png")) {}

    public override bool VerificarMovimentacao(int novoX, int novoY)
    {
        int direcao = (Cor == "branco") ? -1 : 1;
        return (novoX == X + direcao && novoY == Y);
    }
}
