namespace Xadrez
{
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
/*
        private void InitializeComponent()
        {
            this.SuspendLayout();
           
            this.ClientSize = new System.Drawing.Size(500, 500);
            this.Name = "Form1";
            this.Text = "Xadrez";
            this.ResumeLayout(false);
        }
    }
}
*/
private void InitializeComponent()
    {
        this.components = new System.ComponentModel.Container();
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(450, 450);
        this.Text = "Xadrez";

        InicializarTabuleiro();
        
        
    }

    public void InicializarTabuleiro()
    {
        for(int i = 2; i < 6 ;i++){
            for(int j = 0; j<8 ;j++){
                int x = j, y = i;
                 tabuleiro[x,y] = new CasaVazia(x*50, y*50,"casaVazia.png");
                 this.Controls.Add(tabuleiro[x,y].pictureBox);
                 tabuleiro[x,y].pictureBox.BringToFront();
                 tabuleiro[x,y].pictureBox.Click += (sender, args) => { cliqueNoTabuleiro(tabuleiro[x,y]); };
            }   
        }
        Rei reiBranco = new Rei(100,150,"reibranco.png");
        tabuleiro[reiBranco.x,reiBranco.y] = reiBranco;
        this.Controls.Add(reiBranco.pictureBox);
        reiBranco.pictureBox.BringToFront();
        reiBranco.pictureBox.Click += (sender, args) => { cliqueNoTabuleiro(reiBranco); };

        Rei reiPreto = new Rei(100,100,"reipreto.png");
        tabuleiro[reiPreto.x,reiPreto.y] = reiPreto;
        this.Controls.Add(reiPreto.pictureBox);
        reiPreto.pictureBox.BringToFront();
        reiPreto.pictureBox.Click += (sender, args) => { cliqueNoTabuleiro(reiPreto); };             
    }
     #endregion
}

    }
