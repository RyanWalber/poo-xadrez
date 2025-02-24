public class Cavalo : Peca {
    public Cavalo(int x, int y, string img) : base(x, y, img) { }

    public override bool validarMovimento(int destinoX, int destinoY) {
        int difX = Math.Abs(destinoX - x);
        int difY = Math.Abs(destinoY - y);
        return (difX == 2 && difY == 1) || (difX == 1 && difY == 2);
    }
}
