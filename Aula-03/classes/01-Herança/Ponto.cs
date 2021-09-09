namespace classes.Herança
{
  public class Ponto
  {
    public int x,y;
    
    private int distancia;

    public Ponto(int x, int y)
    {
      this.x = x;
      this.y = y;
    }

    protected void CalcularDistancia()
    {
      //Fazz a ação...
    }

    private void CalcularDistancia2()
    {
      //fazzz...
    }
    
    public virtual void CalcularDistancia3()
    {
      //fazxzz
    }
  }
}