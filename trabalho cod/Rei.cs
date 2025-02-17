namespace Joguinho_Xadrez;

public class Rei : Peças
{
    public Rei(string cor, int x, int y) : base(cor, x, y) {}
    public override bool VerificarMovimentacao() { return true; }
}
