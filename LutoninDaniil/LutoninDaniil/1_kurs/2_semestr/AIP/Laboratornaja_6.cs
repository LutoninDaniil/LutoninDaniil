/*13.03.2025*/
/*
using System;
using System.Collections.Generic;
//Задание 1
public delegate int CALCCCC(Calc calc);
public class Calc
{
    public int x, y;
    public Calc(int x, int y)
    {
        this.x = x;
        this.y = y;
    }
    public static int Add(int x, int y)
    {
        return x + y;
    }
    public static int Subtract(int x, int y)
    {
        return x - y;
    }
    public static int Multiply(int x, int y)
    {
        return x * y;
    }
    public static int Divide(int x, int y)
    {
        if (y == 0) return 0;
        return x / y;
    }
}
internal class Program
{
    private static void Main(string[] args)
    {
        Calc yor = new Calc(12, 3);
        CALCCCC doom = delegate (Calc cul)
        {
            int sir = Calc.Add(cul.x, cul.y);
            sir = Calc.Subtract(sir, cul.y);
            sir = Calc.Divide(sir, cul.y);
            return sir;
        };
        Calc uor = new Calc(6, 3);
        CALCCCC dom = delegate (Calc col)
        {
            int ris = Calc.Multiply(col.x, col.y);
            ris = Calc.Add(ris, col.x);
            return ris;
        };
        Console.WriteLine(doom(yor));
        Console.WriteLine(dom(uor));
    }
}
*/
//Задание 2
/*
public class Bibic
{
    string god, bibika, vodila;
    public bool chistka;
    public Bibic(string g, string b, string v, bool c)
    {
        god = g;
        bibika = b;
        this.vodila = v;
        this.chistka = c;
    }
}
public delegate void Chist(Bibic bib);
class Garazh
{
    event Chist tuntun;
    public List<Bibic> bibi = new List<Bibic>();
    public Garazh()
    {
        tuntun = Mit.wash;
    }
    public void check()
    {
        foreach (Bibic i in bibi)
        {
            if (!i.chistka)
            {
                tuntun(i);
            }
        }
    }
}
class Mit
{
    public static void wash(Bibic car)
    {
        car.chistka = true;
    }
}
internal class Program
{
    private static void Main(string[] args)
    {
        Garazh grazh = new Garazh();
        grazh.bibi.Add(new Bibic("a", "b", "c", true));
        grazh.bibi.Add(new Bibic("a", "b", "c", false));
        grazh.bibi.Add(new Bibic("a", "b", "c", true));
        grazh.bibi.Add(new Bibic("a", "b", "c", false));
        grazh.bibi.Add(new Bibic("a", "b", "c", true));
        grazh.check();
        foreach (Bibic i in grazh.bibi)
        {
            Console.WriteLine(i.chistka);
        }
    }
}
*/