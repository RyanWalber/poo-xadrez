/*
namespace Joguinho_Xadrez;

public class Tabuleiro
{
    public Peças[,] Peças { get; private set; }
    
    public Tabuleiro()
    {
        Peças = new Peças[8, 8];
        InicializarTabuleiro();
    }
    
    private void InicializarTabuleiro()
    {
        
        Peças[0, 0] = new Torre("preto", 0, 0);
        Peças[7, 7] = new Torre("branco", 7, 7);
    }
}


using System;


public class Tabuleiro
{
    public Peças[,] Pecas { get; private set; }
    public Rainha[] Rainhas { get; private set; }
    public Rei[] reis { get; private set; }
    public Torre[] torres { get; private set; }
    public Bispo[] bispos { get; private set; }
    public Cavalo[] cavalos { get; private set; }
    public Peao[] peaos { get; private set; }


    public Tabuleiro()
    {
        Pecas = new Peças[8, 8];
        Rainhas = new Rainha[2];
        cavalos = new Cavalo[4];
        reis = new Rei[2]; 
        torres = new Torre[4]; 
        bispos = new Bispo[4]; 
        peaos = new Peao[16]; 


        InicializarTabuleiro();
    }


    private void InicializarTabuleiro()
    {
        Pecas[1, 1] = new Torre("preto", 1, 1); 
        Pecas[1, 2] = new Cavalo("black", 1, 2); 
        Pecas[1, 3] = new Bispo("preto", 1, 3);
        Pecas[1, 4] = new Rainha("black", 1, 4); 
        Pecas[1, 5] = new Rei("preto", 1, 5); 
        Pecas[1, 6] = new Bispo("preto", 1, 6); 
        Pecas[1, 7] = new Cavalo("black", 1, 7); 
        Pecas[1, 8] = new Torre("preto", 1, 8);


        for (int i = 2; i < 9; i++)
        {
            Pecas[2, i] = new Peao("black", 2, i); 
        }



        Pecas[8, 1] = new Torre("white", 8, 1); 
        Pecas[8, 2] = new Cavalo("white", 8, 2); 
        Pecas[8, 3] = new Bispo("white", 8, 3); 
        Pecas[8, 4] = new Rainha("white", 8, 4);
        Pecas[8, 5] = new Rei("white", 8, 5); 
        Pecas[8, 6] = new Bispo("white", 8, 6); 
        Pecas[8, 7] = new Cavalo("white", 8, 7);
        Pecas[8, 8] = new Torre("white", 8, 8); 


        
        for (int i = 7; i < 9; i++)
        {
            Pecas[7, i] = new Peao("white", 7, i); 
        }


       
        Rainhas[1] = new Rainha("black", 1, 4); 
        Rainhas[2] = new Rainha("branco", 8, 4); 


        reis[1] = new Rei("preto", 1, 5);
        reis[2] = new Rei("white", 8, 5);


        torres[1] = new Torre("black", 1, 1); 
        torres[2] = new Torre("preto", 1, 8); 
        torres[3] = new Torre("white", 8, 1); 
        torres[4] = new Torre("branco", 8, 8);


        
        cavalos[1] = new Cavalo("preto", 1, 2); 
        cavalos[2] = new Cavalo("black", 1, 7); 
        cavalos[3] = new Cavalo("white", 8, 2); 
        cavalos[4] = new Cavalo("branca", 8, 7); 


    
        bispos[1] = new Bispo("black", 1, 3); 
        bispos[2] = new Bispo("preto", 1, 6);
        bispos[3] = new Bispo("white", 8, 3); 
        bispos[4] = new Bispo("branca", 8, 6); 
    }
}

/*

namespace Joguinho_Xadrez;


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


    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        this.components = new System.ComponentModel.Container();
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(850, 850);
        this.Text = "xadrez";


        PictureBox rei = new PictureBox();
        rei.Location = new Point(50, 50);
        rei.Size = new Size(50, 50);
        rei.SizeMode = PictureBoxSizeMode.StretchImage;


        try{
            string path = Path.Combine(Application.StartupPath, "imagens", "rei.png");
            MessageBox.Show("Tentando carregar: " + path);
            rei.Image = Image.FromFile(path);


        }


        catch (Exception ex){
            MessageBox.Show("Erro ao carregar imagem: " + ex.Message);
        }


        this.Controls.Add(rei);


        PictureBox rainha = new PictureBox();
        rainha.Location = new Point(50, 50);
        rainha.Size = new Size(50, 50);
        rainha.SizeMode = PictureBoxSizeMode.StretchImage;


        try{
            string path = Path.Combine(Application.StartupPath, "imagens", "rainha.png");
            MessageBox.Show("Tentando carregar: " + path);
            rainha.Image = Image.FromFile(path);


        }


        catch (Exception ex){
            MessageBox.Show("Erro ao carregar imagem: " + ex.Message);
        }


        this.Controls.Add(rainha);


        PictureBox torre = new PictureBox();
        torre.Location = new Point(50, 50);
        torre.Size = new Size(50, 50);
        torre.SizeMode = PictureBoxSizeMode.StretchImage;


        try{
            string path = Path.Combine(Application.StartupPath, "imagens", "torre.png");
            MessageBox.Show("Tentando carregar: " + path);
            torre.Image = Image.FromFile(path);


        }


        catch (Exception ex){
            MessageBox.Show("Erro ao carregar imagem: " + ex.Message);
        }


        this.Controls.Add(torre);


        PictureBox cavalo = new PictureBox();
        cavalo.Location = new Point(50, 50);
        cavalo.Size = new Size(50, 50);
        cavalo.SizeMode = PictureBoxSizeMode.StretchImage;


        try{
            string path = Path.Combine(Application.StartupPath, "imagens", "cavalo.png");
            MessageBox.Show("Tentando carregar: " + path);
            cavalo.Image = Image.FromFile(path);


        }


        catch (Exception ex){
            MessageBox.Show("Erro ao carregar imagem: " + ex.Message);
        }


        this.Controls.Add(cavalo);
       
        PictureBox bispo = new PictureBox();
        bispo.Location = new Point(50, 50);
        bispo.Size = new Size(50, 50);
        bispo.SizeMode = PictureBoxSizeMode.StretchImage;


        try{
            string path = Path.Combine(Application.StartupPath, "imagens", "bispo.png");
            MessageBox.Show("Tentando carregar: " + path);
            bispo.Image = Image.FromFile(path);


        }


        catch (Exception ex){
            MessageBox.Show("Erro ao carregar imagem: " + ex.Message);
        }


        this.Controls.Add(bispo);
       
        PictureBox peao = new PictureBox();
        peao.Location = new Point(50, 50);
        peao.Size = new Size(50, 50);
        peao.SizeMode = PictureBoxSizeMode.StretchImage;


        try{
            string path = Path.Combine(Application.StartupPath, "imagens", "peao.png");
            MessageBox.Show("Tentando carregar: " + path);
            peao.Image = Image.FromFile(path);


        }


        catch (Exception ex){
            MessageBox.Show("Erro ao carregar imagem: " + ex.Message);
        }


        this.Controls.Add(peao);  
    }
    #endregion
}
*/

public class Tabuleiro
{
    public Peca[,] Pecas { get; private set; } // Matriz 8x8 para armazenar as peças

    public Tabuleiro()
    {
        Pecas = new Peca[8, 8];
        InicializarTabuleiro();
    }

    private void InicializarTabuleiro()
    {
        // Posicionando as torres
        Pecas[0, 0] = new Torre(EnumCor.Branco, 0, 0);
        Pecas[0, 7] = new Torre(EnumCor.Branco, 0, 7);
        Pecas[7, 0] = new Torre(EnumCor.Preto, 7, 0);
        Pecas[7, 7] = new Torre(EnumCor.Preto, 7, 7);

        // Posicionando os bispos
        Pecas[0, 2] = new Bispo(EnumCor.Branco, 0, 2);
        Pecas[0, 5] = new Bispo(EnumCor.Branco, 0, 5);
        Pecas[7, 2] = new Bispo(EnumCor.Preto, 7, 2);
        Pecas[7, 5] = new Bispo(EnumCor.Preto, 7, 5);

        // Posicionando os cavalos
        Pecas[0, 1] = new Cavalo(EnumCor.Branco, 0, 1);
        Pecas[0, 6] = new Cavalo(EnumCor.Branco, 0, 6);
        Pecas[7, 1] = new Cavalo(EnumCor.Preto, 7, 1);
        Pecas[7, 6] = new Cavalo(EnumCor.Preto, 7, 6);

        // Posicionando a rainha
        Pecas[0, 3] = new Rainha(EnumCor.Branco, 0, 3);
        Pecas[7, 3] = new Rainha(EnumCor.Preto, 7, 3);

        // Posicionando o rei
        Pecas[0, 4] = new Rei(EnumCor.Branco, 0, 4);
        Pecas[7, 4] = new Rei(EnumCor.Preto, 7, 4);

        // Posicionando os peões
        for (int i = 0; i < 8; i++)
        {
            Pecas[1, i] = new Peao(EnumCor.Branco, 1, i);
            Pecas[6, i] = new Peao(EnumCor.Preto, 6, i);
        }
    }

    public Peca ObterPeca(int linha, int coluna)
    {
        return Pecas[linha, coluna];
    }

    public bool MoverPeca(int linhaOrigem, int colunaOrigem, int linhaDestino, int colunaDestino)
    {
        Peca peca = Pecas[linhaOrigem, colunaOrigem];

        if (peca == null || !peca.MovimentoValido(linhaDestino, colunaDestino))
            return false; // Movimento inválido

        Pecas[linhaDestino, colunaDestino] = peca;
        Pecas[linhaOrigem, colunaOrigem] = null;
        peca.Linha = linhaDestino;
        peca.Coluna = colunaDestino;

        return true; // Movimento bem-sucedido
    }
}