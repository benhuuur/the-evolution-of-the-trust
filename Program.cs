using System;
using static System.Console;
// Random random = new Random();
Mundo mundo = new Mundo();
//mundo.start (GenteBoa, Pilantra, Copiador, Tolerante, Rabugento);
mundo.Start(300, 100, 0, 100, 0);
int contador = 0;
Clear();
WriteLine("The Evolution of Trust");
while (mundo.Pessoas.Count != 1)
{
    contador++;
    Write(contador.ToString("00") + " ");
    for (int n = 0; n < mundo.Pessoas.Count / 5; n++)
        Write("█");
    Write(mundo.Pessoas.Count);
    Write("\n");
    for (int j = 0; j < mundo.Pessoas.Count; j++)
    {
        mundo.Pessoas[j].Coins--;
        if (Random.Shared.Next(9) == 1)
        { mundo.Pessoas[j].Coins--; }
        if (mundo.Pessoas[j].Coins < 1)
        { mundo.Pessoas.Remove(mundo.Pessoas[j]); }
    }

    for (int i = 0; i < (mundo.Pessoas.Count) / 2; i++)
    {
        var Pessoa1 = mundo.Pessoas[Random.Shared.Next(mundo.Pessoas.Count)];
        var Pessoa2 = mundo.Pessoas[Random.Shared.Next(mundo.Pessoas.Count)];

        if (Pessoa1.Interagir(Pessoa2) && Pessoa2.Interagir(Pessoa1))
        {
            Pessoa1.Coins++;
            Pessoa2.Coins++;
        }

        else if (!Pessoa1.Interagir(Pessoa2) && Pessoa2.Interagir(Pessoa1))
        {
            Pessoa1.Coins += 4;
            Pessoa2.Coins--;
        }

        else if (Pessoa1.Interagir(Pessoa2) && !Pessoa2.Interagir(Pessoa1))
        {
            Pessoa1.Coins--;
            Pessoa2.Coins += 4;
        }

        else if (!Pessoa1.Interagir(Pessoa2) && !Pessoa2.Interagir(Pessoa1))
        { }
        if (Pessoa1.Coins < 1)
        { mundo.Pessoas.Remove(Pessoa1); }

        if (Pessoa1.Coins > 20)
        { mundo.Pessoas.Add(Pessoa1.Clone()); }

        if (Pessoa2.Coins > 20)
        { mundo.Pessoas.Add(Pessoa2.Clone()); }

        if (Pessoa2.Coins < 1)
        { mundo.Pessoas.Remove(Pessoa2); }
    }
}
