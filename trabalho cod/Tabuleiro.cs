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
*/

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
        Rainhas = new Rainha[2]; // uma preta e outra branca;
        cavalos = new Cavalo[4]; // dois black e dois white;
        reis = new Rei[2]; // um black e um white;
        torres = new Torre[4]; // dois pretos e dois white;
        bispos = new Bispo[4]; // dois black e dois white.
        peaos = new Peao[16]; // 8 peões do time black e 8 peões do time white


        InicializarTabuleiro();
    }


    private void InicializarTabuleiro()
    {
        // peças time black
        Pecas[1, 1] = new Torre("preto", 1, 1); // torre black
        Pecas[1, 2] = new Cavalo("black", 1, 2); // cavalo black
        Pecas[1, 3] = new Bispo("preto", 1, 3); // bispo black
        Pecas[1, 4] = new Rainha("black", 1, 4); //rainha black
        Pecas[1, 5] = new Rei("preto", 1, 5); // rei black
        Pecas[1, 6] = new Bispo("preto", 1, 6); // bispo balck
        Pecas[1, 7] = new Cavalo("black", 1, 7); // cavalo black
        Pecas[1, 8] = new Torre("preto", 1, 8); // torre black


        // peões black (linha 1)
        for (int i = 2; i < 9; i++)
        {
            Pecas[2, i] = new Peao("black", 2, i); // Peões black
        }


        // peças time white
        Pecas[8, 1] = new Torre("white", 8, 1); // Torre branca
        Pecas[8, 2] = new Cavalo("white", 8, 2); // Cavalo branco
        Pecas[8, 3] = new Bispo("white", 8, 3); // Bispo branco
        Pecas[8, 4] = new Rainha("white", 8, 4); // Rainha branca
        Pecas[8, 5] = new Rei("white", 8, 5); // Rei branco
        Pecas[8, 6] = new Bispo("white", 8, 6); // Bispo branco
        Pecas[8, 7] = new Cavalo("white", 8, 7); // Cavalo branco
        Pecas[8, 8] = new Torre("white", 8, 8); // Torre branca


        // peões white (linha 6)
        for (int i = 7; i < 9; i++)
        {
            Pecas[7, i] = new Peao("white", 7, i); // Peões brancos
        }


        // Inicializando as rainhas após a criação das peças no tabuleiro
        Rainhas[1] = new Rainha("black", 1, 4); // Rainha preta
        Rainhas[2] = new Rainha("branco", 8, 4); // Rainha branca


        // Inicializando os reis
        reis[1] = new Rei("preto", 1, 5); // Rei preto
        reis[2] = new Rei("white", 8, 5); // Rei branco


        // Inicializando as torres
        torres[1] = new Torre("black", 1, 1); // Torre preta
        torres[2] = new Torre("preto", 1, 8); // Torre preta
        torres[3] = new Torre("white", 8, 1); // Torre branca
        torres[4] = new Torre("branco", 8, 8); // Torre branca


        // Inicializando os cavalos
        cavalos[1] = new Cavalo("preto", 1, 2); // Cavalo preto
        cavalos[2] = new Cavalo("black", 1, 7); // Cavalo preto
        cavalos[3] = new Cavalo("white", 8, 2); // Cavalo branco
        cavalos[4] = new Cavalo("branca", 8, 7); // Cavalo branco


        // Inicializando os bispos
        bispos[1] = new Bispo("black", 1, 3); // Bispo preto
        bispos[2] = new Bispo("preto", 1, 6); // Bispo preto
        bispos[3] = new Bispo("white", 8, 3); // Bispo branco
        bispos[4] = new Bispo("branca", 8, 6); // Bispo branco
    }
}



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
