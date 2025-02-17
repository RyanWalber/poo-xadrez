namespace Joguinho_Xadrez;

public class Rainha : Peças
{
    public Rainha(string cor, int x, int y) : base(cor, x, y) {}
    public override bool VerificarMovimentacao() { return true; }
}