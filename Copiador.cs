public class Copiador : Individuos
{
    public override Individuos Clone()
    {
        this.Coins /= 2;
        return new Copiador();
    }

    public override bool Interagir(Individuos individuos)
    {
        if (individuos.JogadaAnterior == false)
            individuos.Trapaceado++;
        return individuos.JogadaAnterior;
    }
}
