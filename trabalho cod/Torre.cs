public class Torre : Peca {
    public Torre(int x, int y, string img) : base(x, y, img) { }

    public override bool validarMovimento(int destinoX, int destinoY) {
        return x == destinoX || y == destinoY;
    }
}
