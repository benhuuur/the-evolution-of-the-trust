public class Tolerante : Individuos
{
    public override Individuos Clone()
    {
        this.Coins /= 2;
        return new Tolerante();
    }

    public override bool Interagir(Individuos individuos)
    {
        if ((this.Trapaceado % 3) == 0 && this.Trapaceando < 3 && this.Trapaceado != 0)
        {
            Trapaceando++;
            individuos.Trapaceado++;
            return false;
        }
        else
        {
            Trapaceando = 0;
            return true;
        }
    }
}