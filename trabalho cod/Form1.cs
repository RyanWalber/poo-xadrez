/*using System.Windows.Forms;

namespace Joguinho_Xadrez
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); 
        }
    }
}*/

public partial class Form1 : Form
{
    private Button[,] botoes = new Button[8, 8];
    private Tabuleiro tabuleiro;
    private Peca pecaSelecionada = null;

    public Form1()
    {
        InitializeComponent();
        tabuleiro = new Tabuleiro();
        CriarTabuleiro();
    }

    private void CriarTabuleiro()
    {
        tlpTabuleiro.RowCount = 8;
        tlpTabuleiro.ColumnCount = 8;
        tlpTabuleiro.Controls.Clear();
        tlpTabuleiro.RowStyles.Clear();
        tlpTabuleiro.ColumnStyles.Clear();

        for (int i = 0; i < 8; i++)
        {
            tlpTabuleiro.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tlpTabuleiro.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.5F));

            for (int j = 0; j < 8; j++)
            {
                Button botao = new Button
                {
                    Dock = DockStyle.Fill,
                    BackColor = (i + j) % 2 == 0 ? Color.White : Color.Gray,
                    Tag = new Point(i, j)
                };

                botao.Click += Botao_Click;
                botoes[i, j] = botao;
                tlpTabuleiro.Controls.Add(botao, j, i);
            }
        }

        AtualizarTabuleiro();
    }

    private void AtualizarTabuleiro()
    {
        for (int i = 0; i < 8; i++)
        {
            for (int j = 0; j < 8; j++)
            {
                Peca peca = tabuleiro.ObterPeca(i, j);
                botoes[i, j].Text = peca != null ? RepresentacaoPeca(peca) : "";
            }
        }
    }

    private string RepresentacaoPeca(Peca peca)
    {
        if (peca is Torre) return "T";
        if (peca is Bispo) return "B";
        if (peca is Cavalo) return "C";
        if (peca is Rainha) return "D";
        if (peca is Rei) return "R";
        if (peca is Peao) return "P";
        return "?";
    }

    private void Botao_Click(object sender, EventArgs e)
    {
        Button botaoClicado = sender as Button;
        Point posicao = (Point)botaoClicado.Tag;
        int linha = posicao.X;
        int coluna = posicao.Y;

        if (pecaSelecionada == null)
        {
            pecaSelecionada = tabuleiro.ObterPeca(linha, coluna);
        }
        else
        {
            if (tabuleiro.MoverPeca(pecaSelecionada.Linha, pecaSelecionada.Coluna, linha, coluna))
            {
                pecaSelecionada = null;
                AtualizarTabuleiro();
            }
            else
            {
                MessageBox.Show("Movimento inválido!");
                pecaSelecionada = null;
            }
        }
    }
}
