using System;
public abstract class Peças{


 public string Cor {get; set;}
 public int X {get; set;}
 public int Y {get; set;}


 public Peças (string cor, int X, int Y){
    this.Cor = cor;
    this.X = X;
    this.Y = Y;
  }
   
  public abstract bool VerificarMovimentacao();
}
