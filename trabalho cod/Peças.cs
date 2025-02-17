namespace Joguinho_Xadrez;

public abstract class Peças
{
    public string Cor { get; set; }
    public int X { get; set; }
    public int Y { get; set; }

    public Peças(string cor, int x, int y)
    {
        Cor = cor;
        X = x;
        Y = y;
    }
    public abstract bool VerificarMovimentacao();
}