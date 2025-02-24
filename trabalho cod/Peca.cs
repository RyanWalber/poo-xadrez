public abstract class Peca {
    public int x, y;
    public string img = "";
    public PictureBox pictureBox = new PictureBox();

    public Peca(int x, int y, string img) {
        this.x = x;
        this.y = y;

        pictureBox.Location = new Point(x * 50, y * 50);
        pictureBox.Size = new Size(50, 50);
        pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

        try {
            this.img = Path.Combine(Application.StartupPath, "imagens", img);
            pictureBox.Image = Image.FromFile(this.img);
        } catch (Exception ex) {
            MessageBox.Show("Erro ao carregar imagem: " + ex.Message);
        }
    }

    public abstract bool validarMovimento(int destinoX, int destinoY);
}
