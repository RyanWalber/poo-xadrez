namespace xadrez;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
        
        for(int i = 0; i < 8 ;i++){
            for(int j = 0; j<8 ;j++){
                int x = j, y = i;
                 tabuleiro[x,y] = new CasaVazia(x*50, y*50,"casaVazia.png");
                 this.Controls.Add(tabuleiro[x,y].pictureBox);
                 tabuleiro[x,y].pictureBox.BringToFront();
                 tabuleiro[x,y].pictureBox.Click += (sender, args) => { cliqueNoTabuleiro(tabuleiro[x,y]); };
            }   
        }
       
/*
       public void InicializarTabuleiro()
{
    for (int i = 0; i < 8; i++)
    {
        for (int j = 0; j < 8; j++)
        {
            int x = j, y = i;
            tabuleiro[x, y] = new CasaVazia(x * 50, y * 50, "");

            // Definindo cor alternada para as casas
            if ((x + y) % 2 == 0)
            {
                tabuleiro[x, y].pictureBox.BackColor = Color.Green; // Casas verdes
            }
            else
            {
                tabuleiro[x, y].pictureBox.BackColor = Color.Red; // Casas vermelhas
            }

            this.Controls.Add(tabuleiro[x, y].pictureBox);
            tabuleiro[x, y].pictureBox.BringToFront();
            tabuleiro[x, y].pictureBox.Click += (sender, args) => { cliqueNoTabuleiro(tabuleiro[x, y]); };
        }
    }
} // <- Aqui estava faltando a chave

*/


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

//aprender a botar do outro lado


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
     // peos 
     
        Peao peaoBranco1 = new Peao(0,50,"peaobranco.png");
        tabuleiro[peaoBranco1.x,peaoBranco1.y] = peaoBranco1;
        this.Controls.Add(peaoBranco1.pictureBox);
        peaoBranco1.pictureBox.BringToFront();
        peaoBranco1.pictureBox.Click += (sender, args) => { cliqueNoTabuleiro(peaoBranco1); };
        
    }
     #endregion

}
