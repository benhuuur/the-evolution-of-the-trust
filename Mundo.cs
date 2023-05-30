using System;
using static System.Console;
public class Mundo
{
    public List<Individuos> Pessoas = new List<Individuos>();
    public void Start(int GB, int PL, int CP, int TL, int RB)
    {
        for (int i = 0; i < GB; i++)
            Pessoas.Add(new GenteBoa());
        for (int i = 0; i < PL; i++)
            Pessoas.Add(new Pilantra());
        for (int i = 0; i < CP; i++)
            Pessoas.Add(new Copiador());
        for (int i = 0; i < TL; i++)
            Pessoas.Add(new Tolerante());
        for (int i = 0; i < RB; i++)
            Pessoas.Add(new Rabugento());
    }
}

// bool Pessoa1 = Pessoas[rnd.Next(500)].Interagir();
// bool Pessoa2 = Pessoas[rnd.Next(500)].Interagir();
// WriteLine(Pessoa1);
// WriteLine(Pessoa2);
