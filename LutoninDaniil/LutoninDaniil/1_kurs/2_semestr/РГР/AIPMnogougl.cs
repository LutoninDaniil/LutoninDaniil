/*
using System;
using System.Collections.Generic;
using System.Linq;
public class Program
{
    public struct Brat
    {
        public long X;
        public long Y;
        public Brat(long x, long y)
        {
            X = x;
            Y = y;
        }
    }
    static long Cross(Brat a, Brat b, Brat c)
    {
        return (b.X - a.X) * (c.Y - a.Y) - (b.Y - a.Y) * (c.X - a.X);
    }
    static void Main()
    {
        string? pervajalin;
        do
        {
            pervajalin = Console.ReadLine();
        }
        while (string.IsNullOrWhiteSpace(pervajalin));
        int n = int.Parse(pervajalin!.Trim());
        List<Brat> ochki = new List<Brat>();
        for (int i = 0; i < n; i++)
        {
            string? line;
            do
            {
                line = Console.ReadLine();
            }
            while (string.IsNullOrWhiteSpace(line));
            string[] s = line!.Split();
            long x = long.Parse(s[0]);
            long y = long.Parse(s[1]);
            ochki.Add(new Brat(x, y));
        }
        ochki = ochki.OrderBy(p => p.X).ThenBy(p => p.Y).ToList();
        List<Brat> hell = new List<Brat>();
        for (int i = 0; i < ochki.Count; i++)
        {
            while (hell.Count >= 2)
            {
                Brat a = hell[^2];
                Brat b = hell[^1];
                Brat c = ochki[i];
                if (Cross(a, b, c) <= 0)
                {
                    hell.RemoveAt(hell.Count - 1);
                }
                else
                {
                    break;
                }
            }
            hell.Add(ochki[i]);
        }
        int petr = hell.Count;
        for (int i = ochki.Count - 2; i >= 0; i--)
        {
            while (hell.Count > petr)
            {
                Brat a = hell[^2];
                Brat b = hell[^1];
                Brat c = ochki[i];
                if (Cross(a, b, c) <= 0)
                {
                    hell.RemoveAt(hell.Count - 1);
                }
                else
                {
                    break;
                }
            }
            hell.Add(ochki[i]);
        }
        if (hell.Count > 1)
        {
            hell.RemoveAt(hell.Count - 1);
        }
        long frfr = 0;
        int cnut = hell.Count;
        for (int i = 0; i < cnut; i++)
        {
            int sert = (i + 1) % cnut;
            frfr += hell[i].X * hell[sert].Y - hell[i].Y * hell[sert].X;
        }
        double qwerty = Math.Abs(frfr) * 0.5;
        Console.WriteLine(qwerty.ToString("F3"));
    }
}
*/