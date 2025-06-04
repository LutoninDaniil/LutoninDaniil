/*07.04.2025*/
/*
using System;
using System.Collections.Generic;
public class Spisok<Ef>
{
    List<Ef> rty = new List<Ef>();
    public void bad(Ef a)
    {
        rty.Add(a);
    }
    public void ern(int a)
    {
        rty.RemoveAt(a);
    }
    public Ef oter(int a)
    {
        return rty[a];
    }
}
internal class Program
{
    private static void Main(string[] args)
    {
        Spisok<int> Spisok = new Spisok<int>();
        Spisok.bad(1);
        Spisok.bad(2);
        Spisok.bad(3);
        Spisok.ern(1);
        Console.WriteLine(Spisok.oter(0));
        Console.WriteLine(Spisok.oter(1));
    }
}
*/