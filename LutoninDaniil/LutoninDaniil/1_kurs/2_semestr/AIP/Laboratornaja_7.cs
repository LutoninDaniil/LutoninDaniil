/*24.03.2025*/
/*
using System;
using System.Collections.Generic;
//Задание 1
public class Tochka
{
    public int x, y;

    public Tochka(int x, int y)
    {
        this.x = x;
        this.y = y;
    }
    public void Coordi(int x, int y)
    {
        this.x += x;
        this.y += y;
    }
}
public delegate void Stope();
public class Kokmok{
    Tochka[] gr = new Tochka[2];
    public Tochka toch;
    public static event Stope Konec;
    public Kokmok(int x1, int x2, int y1, int y2)
    {
        var tom=new Random();
        gr[0]=new Tochka(x1, y1);
        gr[1]=new Tochka(x2, y2);
        int minX = Math.Min(x1, x2);
        int maxX = Math.Max(x1, x2);
        int minY = Math.Min(y1, y2);
        int maxY = Math.Max(y1, y2);
        toch=new Tochka(tom.Next(minX, maxX), tom.Next(minY, maxY));
    }
    public void Vooooo()
    {
        int minX = Math.Min(gr[0].x, gr[1].x);
        int maxX = Math.Max(gr[0].x, gr[1].x);

        int minY = Math.Min(gr[0].y, gr[1].y);
        int maxY = Math.Max(gr[0].y, gr[1].y);
        if(toch.x < minX || toch.x > maxX || toch.y < minY || toch.y > maxY){
            Konec=()=>
            {
                Console.WriteLine("Точка вышла из чата:)");
            };
        }
    }
    public static bool Zack()
    {
        if (Konec == null)
        {
            return false;
        }
        Konec();
        return true;
    }
}
internal class Program
{
    private static void Main(string[] args)
    {
        Kokmok sper = new Kokmok(0, 0, 500, 500);
        while (true)
        {
            Console.WriteLine($"X: {sper.toch.x}; Y: {sper.toch.y}");
            if (Kokmok.Zack()) break;
            var nim = new Random();
            sper.toch.Coordi(nim.Next(-50, 50), nim.Next(-50, 50));
            sper.Vooooo();
        }
    }
}
*/
//Задание 2
/*
public class Loshad
{
    public int FFF;
    public void dvig()
    {
        var Rom = new Random();
        FFF += Rom.Next(0, 70);
        Console.Write(FFF + " ");
    }
}
public delegate void Stap(int i);
public class Konec
{
    int SSS;
    event Stap Set = Pobeda.gta;
    public Konec(int SSS) { this.SSS = SSS; }
    public bool Prov(Loshad[] loshadi)
    {
        for (int i = 0; i < loshadi.Length; i++)
        {
            if (loshadi[i].FFF >= SSS)
            {
                Set(i);
                return true;
            }
        }
        return false;
    }
}
public class Pobeda
{
    public static void gta(int i)
    {
        Console.WriteLine("Затащила лошать под номером: " + (i + 1));
    }
}
internal class Program
{
    private static void Main(string[] args)
    {
        Loshad[] loshadi = new Loshad[3];
        Console.Write("Номерки лошадей: \n");
        for (int i = 0; i < loshadi.Length; i++)
        {
            loshadi[i] = new Loshad();
            Console.Write((i + 1) + " ");
        }
        Console.WriteLine("\n");
        Konec kon = new Konec(500);
        while (true)
        {
            foreach (Loshad i in loshadi)
            {
                i.dvig();
            }
            Console.WriteLine();
            if (kon.Prov(loshadi))
            {
                break;
            }
        }
    }
}
*/