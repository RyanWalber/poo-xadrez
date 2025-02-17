namespace Joguinho_Xadrez;

public class Bispo : Peças
{
    public Bispo(string cor, int x, int y) : base(cor, x, y) {}
    public override bool VerificarMovimentacao() { return true; }
}