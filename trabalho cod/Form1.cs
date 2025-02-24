using System;
using System.Windows.Forms;

namespace Xadrez
{
    public partial class Form1 : Form
    {
        private PictureBox[,] tabuleiro = new PictureBox[8, 8]; // Garantindo que a variável exista

        public Form1()
        {
            InitializeComponent();
            InicializarTabuleiro();
        }
/*void CriarTabuleiro()
{
    for (int linha = 0; linha < 8; linha++)
    {
        for (int coluna = 0; coluna < 8; coluna++)
        {
            PictureBox casa = new PictureBox();
            casa.Size = new Size(60, 60);
            casa.Location = new Point(coluna * 60, linha * 60);
            casa.BackColor = (linha + coluna) % 2 == 0 ? Color.White : Color.Gray; // Alternância de cores
            casa.BorderStyle = BorderStyle.FixedSingle;

            this.Controls.Add(casa);
        }
    }
}

void CarregarPecas()
{
    string caminhoImagens = @"caminho_para_sua_pasta_de_imagens\"; // Altere para o caminho correto
    string[,] pecasIniciais = {
        { "torre_preta.png", "cavalo_preto.png", "bispo_preto.png", "rainha_preta.png", "rei_preto.png", "bispo_preto.png", "cavalo_preto.png", "torre_preta.png" },
        { "peao_preto.png", "peao_preto.png", "peao_preto.png", "peao_preto.png", "peao_preto.png", "peao_preto.png", "peao_preto.png", "peao_preto.png" },
        { "", "", "", "", "", "", "", "" },
        { "", "", "", "", "", "", "", "" },
        { "", "", "", "", "", "", "", "" },
        { "", "", "", "", "", "", "", "" },
        { "peao_branco.png", "peao_branco.png", "peao_branco.png", "peao_branco.png", "peao_branco.png", "peao_branco.png", "peao_branco.png", "peao_branco.png" },
        { "torre_branca.png", "cavalo_branco.png", "bispo_branco.png", "rainha_branca.png", "rei_branco.png", "bispo_branco.png", "cavalo_branco.png", "torre_branca.png" }
    };

    for (int linha = 0; linha < 8; linha++)
    {
        for (int coluna = 0; coluna < 8; coluna++)
        {
            if (!string.IsNullOrEmpty(pecasIniciais[linha, coluna]))
            {
                PictureBox peca = new PictureBox();
                peca.Size = new Size(60, 60);
                peca.Location = new Point(coluna * 60, linha * 60);
                peca.SizeMode = PictureBoxSizeMode.StretchImage;
                peca.Image = Image.FromFile(caminhoImagens + pecasIniciais[linha, coluna]);

                this.Controls.Add(peca);
            }
        }
    }
}
*/
        private void InicializarTabuleiro()
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    tabuleiro[i, j] = new PictureBox
                    {
                        Width = 60,
                        Height = 60,
                        Left = j * 60,
                        Top = i * 60,
                        BorderStyle = BorderStyle.FixedSingle
                    };
                    Controls.Add(tabuleiro[i, j]);
                }
            }
        }
    }
}
