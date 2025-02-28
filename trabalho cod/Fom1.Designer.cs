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
        
        for(int i = 1; i < 8 ;i++){
            for(int j = 0; j<8 ;j++){
                int x = j, y = i;
                 tabuleiro[x,y] = new CasaVazia(x*50, y*50,"casaVazia.png");
                 this.Controls.Add(tabuleiro[x,y].pictureBox);
                 tabuleiro[x,y].pictureBox.BringToFront();
                 tabuleiro[x,y].pictureBox.Click += (sender, args) => { cliqueNoTabuleiro(tabuleiro[x,y]); };
            }   
        }
       


        // Reis e Rainhas
        Rei reiBranco = new Rei(150,350,"reibranco.png");
        tabuleiro[reiBranco.x,reiBranco.y] = reiBranco;
        this.Controls.Add(reiBranco.pictureBox);
        reiBranco.pictureBox.BringToFront();
        reiBranco.pictureBox.Click += (sender, args) => { cliqueNoTabuleiro(reiBranco); };

        Rei reiPreto = new Rei(150,50,"reipreto.png");
        tabuleiro[reiPreto.x,reiPreto.y] = reiPreto;
        this.Controls.Add(reiPreto.pictureBox);
        reiPreto.pictureBox.BringToFront();
        reiPreto.pictureBox.Click += (sender, args) => { cliqueNoTabuleiro(reiPreto); };   

        Rainha rainhaBranca = new Rainha(202,350,"rainhabranca.png");
        tabuleiro[rainhaBranca.x,rainhaBranca.y] = rainhaBranca;
        this.Controls.Add(rainhaBranca.pictureBox);
        rainhaBranca.pictureBox.BringToFront();
        rainhaBranca.pictureBox.Click += (sender, args) => { cliqueNoTabuleiro(rainhaBranca); };   

        Rainha rainhaPreta = new Rainha(202,50,"rainhapreta.png");
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
//aprender a botar do outro lado


       // peças pretas
/*
        Bispo bispoPreto = new bispo(250,50,"bispopreto.png");
        tabuleiro[bispoPreto.x,bispoPreto.y] = bispoPreto;
        this.Controls.Add(bispoPreto.pictureBox);
        bispoPreto.pictureBox.BringToFront();
        bispoPreto.pictureBox.Click += (sender, args) => { cliqueNoTabuleiro(bispoPreto); };   
            */

        Cavalo cavaloPreto = new Cavalo(300,50,"cavalopreto.png");
        tabuleiro[cavaloPreto.x,cavaloPreto.y] = cavaloPreto;
        this.Controls.Add(cavaloPreto.pictureBox);
        cavaloPreto.pictureBox.BringToFront();
        cavaloPreto.pictureBox.Click += (sender, args) => { cliqueNoTabuleiro(cavaloPreto); };

        Torre torrePreta = new Torre(350,50,"torrepreta.png");
        tabuleiro[torrePreta.x,torrePreta.y] = torrePreta;
        this.Controls.Add(torrePreta.pictureBox);
        torrePreta.pictureBox.BringToFront();
        torrePreta.pictureBox.Click += (sender, args) => { cliqueNoTabuleiro(torrePreta); };
    }
     #endregion

}
