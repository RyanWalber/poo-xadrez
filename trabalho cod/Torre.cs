namespace Joguinho_Xadrez;

public class Torre : Peças
{
    public Torre(string cor, int x, int y) : base(cor, x, y) {}
    public override bool VerificarMovimentacao() { return true; }
}