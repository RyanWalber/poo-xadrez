public class Bispo : Peca {
    public Bispo(int x, int y, string img) : base(x, y, img) { }

    public override bool validarMovimento(int destinoX, int destinoY) {
        int difX = Math.Abs(destinoX - x);
        int difY = Math.Abs(destinoY - y);
        return difX == difY;
    }
}
