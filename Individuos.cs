public abstract class Individuos
{
    public int Coins { get; set; } = 10;
    public bool JogadaAnterior { get; set; } = true;
    public int Trapaceado { get; set; } = 0;
    public int Trapaceando { get; set; } = 0;
    public abstract bool Interagir(Individuos individuos);
    public abstract Individuos Clone();
}