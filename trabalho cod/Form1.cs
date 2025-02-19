using System;
using System.Drawing;
using System.Windows.Forms;

namespace Xadrez
{
    public partial class Form1 : Form
    {
        private Tabuleiro tabuleiro;
        private Button[,] botoes;
        private Peca pecaSelecionada;
        private int selecionadoX, selecionadoY;

        public Form1()
        {
            InitializeComponent();
            tabuleiro = new Tabuleiro();
            botoes = new Button[8, 8];
            CriarTabuleiroVisual();
        }

        private void CriarTabuleiroVisual()
        {
            for (int x = 0; x < 8; x++)
            {
                for (int y = 0; y < 8; y++)
                {
                    Button btn = new Button
                    {
                        Size = new Size(60, 60),
                        Location = new Point(y * 60, x * 60),
                        BackColor = (x + y) % 2 == 0 ? Color.White : Color.Gray,
                        Tag = new Point(x, y)
                    };
                    btn.Click += Btn_Click;
                    Controls.Add(btn);
                    botoes[x, y] = btn;
                }
            }
            AtualizarTabuleiro();
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            Point posicao = (Point)btn.Tag;
            int x = posicao.X;
            int y = posicao.Y;

            Peca peca = tabuleiro.Pecas[x, y];

            if (pecaSelecionada == null && peca != null)
            {
                // Seleciona uma peça
                pecaSelecionada = peca;
                selecionadoX = x;
                selecionadoY = y;
                btn.BackColor = Color.Yellow;
            }
            else if (pecaSelecionada != null)
            {
                // Tenta mover a peça
                if (tabuleiro.MoverPeca(selecionadoX, selecionadoY, x, y))
                {
                    AtualizarTabuleiro();
                }

                // Reseta a seleção
                pecaSelecionada = null;
                AtualizarTabuleiro();
            }
        }

        private void AtualizarTabuleiro()
        {
            for (int x = 0; x < 8; x++)
            {
                for (int y = 0; y < 8; y++)
                {
                    botoes[x, y].BackgroundImage = null;

                    Peca peca = tabuleiro.Pecas[x, y];
                    if (peca != null)
                    {
                        botoes[x, y].BackgroundImage = peca.Imagem;
                        botoes[x, y].BackgroundImageLayout = ImageLayout.Stretch;
                    }

                    // Restaurar cor do botão
                    botoes[x, y].BackColor = (x + y) % 2 == 0 ? Color.White : Color.Gray;
                }
            }
        }
    }
}
