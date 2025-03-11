using System.CodeDom.Compiler;

namespace xadrez;

public partial class Form1 : Form
{
        public static int sizeOfTabuleiro = 8;
    
    private PictureBox pecaSelecionada = null; 
    private int origemX = -1, origemY = -1; 
    public Peca[,] tabuleiro = new Peca[sizeOfTabuleiro,sizeOfTabuleiro];
    public Form1()
    {
        InitializeComponent();
    }
    public void cliqueNoTabuleiro(Peca peca)
{

    if (origemX == -1 && origemY == -1) 
    {
        if (peca is not CasaVazia){
            pecaSelecionada = peca.pictureBox;
            origemX = peca.x;
            origemY = peca.y;
            MessageBox.Show($"Peça selecionada em ({peca.x}, {peca.y})");
        }
    }
    else 
    {
        Peca pecaOrigem = tabuleiro[origemX, origemY];
        Peca pecaDestino = tabuleiro[peca.x, peca.y];

        
        if (!pecaOrigem.validarMovimento(peca.x, peca.y))
        {
            MessageBox.Show("Movimento Inválido!");
            pecaSelecionada = null;
            origemX = -1;
            origemY = -1;
            return;
        }

        if (pecaDestino is CasaVazia) 
        {
           
                tabuleiro[origemX, origemY] = new CasaVazia(origemX * 50, origemY * 50, "casaVazia.png");
                tabuleiro[peca.x, peca.y] = pecaOrigem;

               
                pecaOrigem.x = peca.x;
                pecaOrigem.y = peca.y;

                
                pecaOrigem.pictureBox.Location = new Point(peca.x * 50, peca.y * 50);
        }
        else 
        {
                
                this.Controls.Remove(pecaDestino.pictureBox);

              
                tabuleiro[peca.x, peca.y] = pecaOrigem;
                tabuleiro[origemX, origemY] = new CasaVazia(origemX * 50, origemY * 50, "casaVazia.png");

                
                pecaOrigem.x = peca.x;
                pecaOrigem.y = peca.y;
                pecaOrigem.pictureBox.Location = new Point(peca.x * 50, peca.y * 50);
            
        }

        this.Refresh();

        pecaSelecionada = null;
        origemX = -1;
        origemY = -1;
    }
}
}


