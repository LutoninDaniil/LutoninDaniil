/*05.05.2025*/
/*
using System;
using System.Collections.Generic;
class Bas
{
    public List<Tovar> tovari = new List<Tovar>();
    public List<Postavka> post = new List<Postavka>();
    public List<Sdvig> dvig = new List<Sdvig>();
}
class Tovar
{
    public int nomer;
    public string ima;
    public Tovar(int nomer, string ima)
    {
        this.nomer = nomer;
        this.ima = ima;
    }
    public string iiiifn()
    {
        return $"{nomer} {ima}";
    }
}
class Postavka
{
    public int nomer;
    public string ima, tel;
    public Postavka(int nomer, string ima, string tel)
    {
        this.nomer = nomer;
        this.ima = ima;
        this.tel = tel;
    }
    public string ofni()
    {
        return $"{nomer} {ima} {tel}";
    }
}
class Sdvig
{
    public int nomerT, nomerP, schet, cena;
    public string tymr;
    public Sdvig(int nomerT, int nomerP, string tymr, int schet, int cena)
    {
        this.nomerT = nomerT;
        this.nomerP = nomerP;
        this.tymr = tymr;
        this.schet = schet;
        this.cena = cena;
    }
    public string finooo()
    {
        return $"{nomerT} {nomerP} {tymr} {schet} {cena}";
    }
}
internal class Program
{
    private static void Main(string[] args)
    {
        Bas basa = new Bas();
        basa.dvig.Add(new Sdvig(1, 3, "30.08.25", 20, 100));
        basa.dvig.Add(new Sdvig(2, 1, "16.12.25", 30, 1000));
        basa.dvig.Add(new Sdvig(3, 2, "21.10.25", 8, 20));
        basa.tovari.Add(new Tovar(1, "молокочко"));
        basa.tovari.Add(new Tovar(2, "телефонирен"));
        basa.tovari.Add(new Tovar(3, "чё-то там"));
        basa.post.Add(new Postavka(1, "Хохон", "84564567889"));
        basa.post.Add(new Postavka(2, "Круса", "81234563535"));
        basa.post.Add(new Postavka(3, "Упругий_Лом", "89879516469"));
        {
            var nol = from n in basa.dvig
                       orderby n.nomerP
                       select n;

            var aut = from n in basa.tovari
                    where n.nomer == nol.First().nomerT
                    select n;
            foreach (Sdvig i in nol)
            {
                var wer = from n in basa.tovari
                        where n.nomer == i.nomerT
                        select n;
                aut = aut.Union(wer);
                aut = aut.Distinct();
            }
            foreach (Tovar i in aut)
            {
                Console.WriteLine(i.iiiifn());
            }
        }
        {
            string jot = "";
            var nol = from n in basa.dvig
                       where n.tymr.Contains(jot)
                       select n;
            int summa = 0;
            foreach (Sdvig i in nol)
            {
                summa += i.schet * i.cena;
            }
            Console.WriteLine(summa);
        }
        {
            var nol = from n in basa.dvig
                       group n by n.nomerP;

            int maxSumma = 0;
            int nomer = 0;
            for (int i = 0; i < nol.Count(); i++)
            {
                int summa = 0;
                foreach (var j in nol.ElementAt(i))
                {
                    summa += j.schet * j.cena;
                }
                if (summa > maxSumma)
                    {
                        maxSumma = summa;
                        nomer = nol.ElementAt(i).First().nomerP;
                    }
            }
            var odin = from n in basa.post
                      where n.nomer == nomer
                      select n;
            Console.WriteLine(odin.First().ofni());
        }
    }
}
*/