public class Peao : Peca {
    private bool primeiroMovimento = true;
    private bool ehBranco;

    public Peao(int x, int y, string img, bool ehBranco) : base(x, y, img) {
        this.ehBranco = ehBranco;
    }

    public override bool validarMovimento(int destinoX, int destinoY) {
        int direcao = ehBranco ? -1 : 1;
        if (destinoX == x && destinoY == y + direcao) {
            primeiroMovimento = false;
            return true;
        }
        if (primeiroMovimento && destinoX == x && destinoY == y + (2 * direcao)) {
            primeiroMovimento = false;
            return true;
        }
        return false;
    }
}
