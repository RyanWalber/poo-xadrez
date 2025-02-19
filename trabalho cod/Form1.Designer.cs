using System;
using System.Drawing;
using System.Windows.Forms;

namespace JogoDeXadrez
{
    public partial class Form1 : Form
    {
        private const int Tamanho = 8;
        private Button[,] botoes = new Button[Tamanho, Tamanho];
        private Tabuleiro tabuleiro;

        public Form1()
        {
            InitializeComponent();
            CriarTabuleiro();
        }

        private void CriarTabuleiro()
        {
            tabuleiro = new Tabuleiro();
            for (int linha = 0; linha < Tamanho; linha++)
            {
                for (int coluna = 0; coluna < Tamanho; coluna++)
                {
                    Button botao = new Button();
                    botao.Size = new Size(50, 50);
                    botao.Location = new Point(50 * coluna, 50 * linha);
                    botao.BackColor = (linha + coluna) % 2 == 0 ? Color.White : Color.Gray;

                    // Verifica se há uma peça nessa posição
                    if (tabuleiro.Pecas[linha, coluna] != null)
                    {
                        botao.Image = tabuleiro.Pecas[linha, coluna].Imagem;
                        botao.Tag = tabuleiro.Pecas[linha, coluna]; // Associa a peça ao botão
                    }

                    int x = linha, y = coluna;
                    botao.Click += (sender, args) => MoverPeca(x, y);

                    botoes[linha, coluna] = botao;
                    this.Controls.Add(botao);
                }
            }
        }

        private void MoverPeca(int x, int y)
        {
            MessageBox.Show($"Clique em {x}, {y}");
        }
    }
}
