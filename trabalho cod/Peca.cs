/*namespace Joguinho_Xadrez;

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
}*/

public abstract class Peca
{
    public EnumCor Cor { get; set; }
    public int Linha { get; set; }
    public int Coluna { get; set; }

    public Peca(EnumCor cor, int linha, int coluna)
    {
        Cor = cor;
        Linha = linha;
        Coluna = coluna;
    }

    public abstract bool MovimentoValido(int novaLinha, int novaColuna);
}

Essa classe será a base para todas as peças. Agora, crie o enum para representar as cores:

Enum para Cores (EnumCor.cs)

public enum EnumCor
{
    Branco,
    Preto
}


