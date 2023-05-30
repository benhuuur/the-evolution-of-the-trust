public class Rabugento : Individuos
{
    public override Individuos Clone()
    {
        this.Coins /= 2;
        return new Rabugento();
    }
    public override bool Interagir(Individuos individuos)
    {
        if (this.Trapaceado > 0)
        {
            individuos.Trapaceado++;
            return false;
        }
        else
            return true;
    }
}