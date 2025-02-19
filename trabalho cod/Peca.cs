using System;
using System.Drawing;
using System.Windows.Forms;

public abstract class Peca
{
    public string Cor { get; set; }
    public int X { get; set; }
    public int Y { get; set; }
    public Image Imagem { get; set; }

    public Peca(string cor, int x, int y, Image imagem)
    {
        this.Cor = cor;
        this.X = x;
        this.Y = y;
        this.Imagem = imagem;
    }

    public abstract bool VerificarMovimentacao(int novoX, int novoY);
}
