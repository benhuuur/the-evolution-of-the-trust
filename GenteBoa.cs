public class GenteBoa : Individuos
{
    public override Individuos Clone()
    {
        this.Coins /= 2;
        return new GenteBoa();
    }

    public override bool Interagir(Individuos individuos)
    {
        return true;
    }
}
