namespace xadrez;

partial class Form1
{
    
    private System.ComponentModel.IContainer components = null;

   
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code
   
    private void InitializeComponent()
    {
        this.components = new System.ComponentModel.Container();
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(500, 500);
        this.Text = "Xadrez";

        InicializarTabuleiro();
        
        
    }

    public void InicializarTabuleiro()
{
    for (int i = 0; i < 8; i++)
    {
        for (int j = 0; j < 8; j++)
        {
            int x = j, y = i;
            tabuleiro[x, y] = new CasaVazia(x * 50, y * 50, "casaVazia.png");
            this.Controls.Add(tabuleiro[x, y].pictureBox);
            tabuleiro[x, y].pictureBox.Click += (sender, args) => { cliqueNoTabuleiro(tabuleiro[x, y]); };

           
            if ((i + j) % 2 == 0)
            {
                tabuleiro[x, y].pictureBox.BackColor = Color.Green; 
            }
            else
            {
                tabuleiro[x, y].pictureBox.BackColor = Color.Red;
            }

            tabuleiro[x, y].pictureBox.SendToBack();
        }
    }

       



        // Reis e Rainhas
        Rei reiBranco = new Rei(150,350,"reibranco.png");
        tabuleiro[reiBranco.x,reiBranco.y] = reiBranco;
        this.Controls.Add(reiBranco.pictureBox);
        reiBranco.pictureBox.BringToFront();
        reiBranco.pictureBox.Click += (sender, args) => { cliqueNoTabuleiro(reiBranco); };

        Rei reiPreto = new Rei(150,0,"reipreto.png");
        tabuleiro[reiPreto.x,reiPreto.y] = reiPreto;
        this.Controls.Add(reiPreto.pictureBox);
        reiPreto.pictureBox.BringToFront();
        reiPreto.pictureBox.Click += (sender, args) => { cliqueNoTabuleiro(reiPreto); };   

        Rainha rainhaBranca = new Rainha(202,350,"rainhabranca.png");
        tabuleiro[rainhaBranca.x,rainhaBranca.y] = rainhaBranca;
        this.Controls.Add(rainhaBranca.pictureBox);
        rainhaBranca.pictureBox.BringToFront();
        rainhaBranca.pictureBox.Click += (sender, args) => { cliqueNoTabuleiro(rainhaBranca); };   

        Rainha rainhaPreta = new Rainha(202,0,"rainhapreta.png");
        tabuleiro[rainhaPreta.x,rainhaPreta.y] = rainhaPreta;
        this.Controls.Add(rainhaPreta.pictureBox);
        rainhaPreta.pictureBox.BringToFront();
        rainhaPreta.pictureBox.Click += (sender, args) => { cliqueNoTabuleiro(rainhaPreta); };   
        // peças brancas
        Bispo bispoBranco = new Bispo(250,350,"bispobranco.png");
        tabuleiro[bispoBranco.x,bispoBranco.y] = bispoBranco;
        this.Controls.Add(bispoBranco.pictureBox);
        bispoBranco.pictureBox.BringToFront();
        bispoBranco.pictureBox.Click += (sender, args) => { cliqueNoTabuleiro(bispoBranco); };

        Cavalo cavaloBranco = new Cavalo(300,350,"cavalobranco.png");
        tabuleiro[cavaloBranco.x,cavaloBranco.y] = cavaloBranco;
        this.Controls.Add(cavaloBranco.pictureBox);
        cavaloBranco.pictureBox.BringToFront();
        cavaloBranco.pictureBox.Click += (sender, args) => { cliqueNoTabuleiro(cavaloBranco); };

        Torre torreBranca = new Torre(350,350,"torrebranca.png");
        tabuleiro[torreBranca.x,torreBranca.y] = torreBranca;
        this.Controls.Add(torreBranca.pictureBox);
        torreBranca.pictureBox.BringToFront();
        torreBranca.pictureBox.Click += (sender, args) => { cliqueNoTabuleiro(torreBranca); };

        Bispo bispoBranco2 = new Bispo(100,350,"bispobranco.png");
        tabuleiro[bispoBranco2.x,bispoBranco2.y] = bispoBranco2;
        this.Controls.Add(bispoBranco2.pictureBox);
        bispoBranco2.pictureBox.BringToFront();
        bispoBranco2.pictureBox.Click += (sender, args) => { cliqueNoTabuleiro(bispoBranco2); };

        Cavalo cavaloBranco2 = new Cavalo(50,350,"cavalobranco.png");
        tabuleiro[cavaloBranco2.x,cavaloBranco2.y] = cavaloBranco2;
        this.Controls.Add(cavaloBranco2.pictureBox);
        cavaloBranco2.pictureBox.BringToFront();
        cavaloBranco2.pictureBox.Click += (sender, args) => { cliqueNoTabuleiro(cavaloBranco2); };

         Torre torreBranca2 = new Torre(0,350,"torrebranca.png");
        tabuleiro[torreBranca2.x,torreBranca2.y] = torreBranca2;
        this.Controls.Add(torreBranca2.pictureBox);
        torreBranca2.pictureBox.BringToFront();
        torreBranca2.pictureBox.Click += (sender, args) => { cliqueNoTabuleiro(torreBranca2); };




       // peças pretas

        Bispo bispoPreto = new Bispo(250,0,"bispopreto.png");
        tabuleiro[bispoPreto.x,bispoPreto.y] = bispoPreto;
        this.Controls.Add(bispoPreto.pictureBox);
        bispoPreto.pictureBox.BringToFront();
        bispoPreto.pictureBox.Click += (sender, args) => { cliqueNoTabuleiro(bispoPreto); };   
        
        Cavalo cavaloPreto = new Cavalo(300,0,"cavalopreto.png");
        tabuleiro[cavaloPreto.x,cavaloPreto.y] = cavaloPreto;
        this.Controls.Add(cavaloPreto.pictureBox);
        cavaloPreto.pictureBox.BringToFront();
        cavaloPreto.pictureBox.Click += (sender, args) => { cliqueNoTabuleiro(cavaloPreto); };

        Torre torrePreta = new Torre(350,0,"torrepreta.png");
        tabuleiro[torrePreta.x,torrePreta.y] = torrePreta;
        this.Controls.Add(torrePreta.pictureBox);
        torrePreta.pictureBox.BringToFront();
        torrePreta.pictureBox.Click += (sender, args) => { cliqueNoTabuleiro(torrePreta); };

        Bispo bispoPreto2 = new Bispo(100,0,"bispopreto.png");
        tabuleiro[bispoPreto2.x,bispoPreto2.y] = bispoPreto2;
        this.Controls.Add(bispoPreto2.pictureBox);
        bispoPreto2.pictureBox.BringToFront();
        bispoPreto2.pictureBox.Click += (sender, args) => { cliqueNoTabuleiro(bispoPreto2); }; 

        Cavalo cavaloPreto2 = new Cavalo(50,0,"cavalopreto.png");
        tabuleiro[cavaloPreto2.x,cavaloPreto2.y] = cavaloPreto2;
        this.Controls.Add(cavaloPreto2.pictureBox);
        cavaloPreto2.pictureBox.BringToFront();
        cavaloPreto2.pictureBox.Click += (sender, args) => { cliqueNoTabuleiro(cavaloPreto2); };

        Torre torrePreta2 = new Torre(0,0,"torrepreta.png");
        tabuleiro[torrePreta2.x,torrePreta2.y] = torrePreta2;
        this.Controls.Add(torrePreta2.pictureBox);
        torrePreta2.pictureBox.BringToFront();
        torrePreta2.pictureBox.Click += (sender, args) => { cliqueNoTabuleiro(torrePreta2); };
     // Peões Pretos
Peao peaoPreto1 = new Peao(0, 50, "peaopreto.png");
tabuleiro[peaoPreto1.x, peaoPreto1.y] = peaoPreto1;
this.Controls.Add(peaoPreto1.pictureBox);
peaoPreto1.pictureBox.BringToFront();
peaoPreto1.pictureBox.Click += (sender, args) => { cliqueNoTabuleiro(peaoPreto1); };

Peao peaoPreto2 = new Peao(50, 50, "peaopreto.png");
tabuleiro[peaoPreto2.x, peaoPreto2.y] = peaoPreto2;
this.Controls.Add(peaoPreto2.pictureBox);
peaoPreto2.pictureBox.BringToFront();
peaoPreto2.pictureBox.Click += (sender, args) => { cliqueNoTabuleiro(peaoPreto2); };

Peao peaoPreto3 = new Peao(100, 50, "peaopreto.png");
tabuleiro[peaoPreto3.x, peaoPreto3.y] = peaoPreto3;
this.Controls.Add(peaoPreto3.pictureBox);
peaoPreto3.pictureBox.BringToFront();
peaoPreto3.pictureBox.Click += (sender, args) => { cliqueNoTabuleiro(peaoPreto3); };

Peao peaoPreto4 = new Peao(150, 50, "peaopreto.png");
tabuleiro[peaoPreto4.x, peaoPreto4.y] = peaoPreto4;
this.Controls.Add(peaoPreto4.pictureBox);
peaoPreto4.pictureBox.BringToFront();
peaoPreto4.pictureBox.Click += (sender, args) => { cliqueNoTabuleiro(peaoPreto4); };

Peao peaoPreto5 = new Peao(200, 50, "peaopreto.png");
tabuleiro[peaoPreto5.x, peaoPreto5.y] = peaoPreto5;
this.Controls.Add(peaoPreto5.pictureBox);
peaoPreto5.pictureBox.BringToFront();
peaoPreto5.pictureBox.Click += (sender, args) => { cliqueNoTabuleiro(peaoPreto5); };

Peao peaoPreto6 = new Peao(250, 50, "peaopreto.png");
tabuleiro[peaoPreto6.x, peaoPreto6.y] = peaoPreto6;
this.Controls.Add(peaoPreto6.pictureBox);
peaoPreto6.pictureBox.BringToFront();
peaoPreto6.pictureBox.Click += (sender, args) => { cliqueNoTabuleiro(peaoPreto6); };

Peao peaoPreto7 = new Peao(300, 50, "peaopreto.png");
tabuleiro[peaoPreto7.x, peaoPreto7.y] = peaoPreto7;
this.Controls.Add(peaoPreto7.pictureBox);
peaoPreto7.pictureBox.BringToFront();
peaoPreto7.pictureBox.Click += (sender, args) => { cliqueNoTabuleiro(peaoPreto7); };

Peao peaoPreto8 = new Peao(350, 50, "peaopreto.png");
tabuleiro[peaoPreto8.x, peaoPreto8.y] = peaoPreto8;
this.Controls.Add(peaoPreto8.pictureBox);
peaoPreto8.pictureBox.BringToFront();
peaoPreto8.pictureBox.Click += (sender, args) => { cliqueNoTabuleiro(peaoPreto8); };

// Peões Brancos
Peao peaoBranco1 = new Peao(0, 300, "peaobranco.png");
tabuleiro[peaoBranco1.x, peaoBranco1.y] = peaoBranco1;
this.Controls.Add(peaoBranco1.pictureBox);
peaoBranco1.pictureBox.BringToFront();
peaoBranco1.pictureBox.Click += (sender, args) => { cliqueNoTabuleiro(peaoBranco1); };

Peao peaoBranco2 = new Peao(50, 300, "peaobranco.png");
tabuleiro[peaoBranco2.x, peaoBranco2.y] = peaoBranco2;
this.Controls.Add(peaoBranco2.pictureBox);
peaoBranco2.pictureBox.BringToFront();
peaoBranco2.pictureBox.Click += (sender, args) => { cliqueNoTabuleiro(peaoBranco2); };

Peao peaoBranco3 = new Peao(100, 300, "peaobranco.png");
tabuleiro[peaoBranco3.x, peaoBranco3.y] = peaoBranco3;
this.Controls.Add(peaoBranco3.pictureBox);
peaoBranco3.pictureBox.BringToFront();
peaoBranco3.pictureBox.Click += (sender, args) => { cliqueNoTabuleiro(peaoBranco3); };

Peao peaoBranco4 = new Peao(150, 300, "peaobranco.png");
tabuleiro[peaoBranco4.x, peaoBranco4.y] = peaoBranco4;
this.Controls.Add(peaoBranco4.pictureBox);
peaoBranco4.pictureBox.BringToFront();
peaoBranco4.pictureBox.Click += (sender, args) => { cliqueNoTabuleiro(peaoBranco4); };

Peao peaoBranco5 = new Peao(200, 300, "peaobranco.png");
tabuleiro[peaoBranco5.x, peaoBranco5.y] = peaoBranco5;
this.Controls.Add(peaoBranco5.pictureBox);
peaoBranco5.pictureBox.BringToFront();
peaoBranco5.pictureBox.Click += (sender, args) => { cliqueNoTabuleiro(peaoBranco5); };

Peao peaoBranco6 = new Peao(250, 300, "peaobranco.png");
tabuleiro[peaoBranco6.x, peaoBranco6.y] = peaoBranco6;
this.Controls.Add(peaoBranco6.pictureBox);
peaoBranco6.pictureBox.BringToFront();
peaoBranco6.pictureBox.Click += (sender, args) => { cliqueNoTabuleiro(peaoBranco6); };

Peao peaoBranco7 = new Peao(300, 300, "peaobranco.png");
tabuleiro[peaoBranco7.x, peaoBranco7.y] = peaoBranco7;
this.Controls.Add(peaoBranco7.pictureBox);
peaoBranco7.pictureBox.BringToFront();
peaoBranco7.pictureBox.Click += (sender, args) => { cliqueNoTabuleiro(peaoBranco7); };

Peao peaoBranco8 = new Peao(350, 300, "peaobranco.png");
tabuleiro[peaoBranco8.x, peaoBranco8.y] = peaoBranco8;
this.Controls.Add(peaoBranco8.pictureBox);
peaoBranco8.pictureBox.BringToFront();
peaoBranco8.pictureBox.Click += (sender, args) => { cliqueNoTabuleiro(peaoBranco8); };
       
        
    }
     #endregion

}

