namespace Joguinho_Xadrez;

public class Peao : Peças
{
    public Peao(string cor, int x, int y) : base(cor, x, y) {}
    public override bool VerificarMovimentacao() { return true; }
}
