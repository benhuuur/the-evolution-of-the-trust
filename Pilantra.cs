public class Pilantra : Individuos
{
    public override Individuos Clone()
    {
        this.Coins /= 2;
        return new Pilantra();
    }

    public override bool Interagir(Individuos individuos)
    {
        individuos.Trapaceado++;
        return false;
    }
}
