/*
using System;
public class Program
{
    static void Main()
    {
        string? strokA = Console.ReadLine();
        if (strokA == null) return;
        string[] traken = strokA.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
        int k = int.Parse(traken[0]);
        int l = int.Parse(traken[1]);
        string? strokB = Console.ReadLine();
        if (strokB == null) return;
        string[] kraken = strokB.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
        int m = int.Parse(kraken[0]);
        int n = int.Parse(kraken[1]);
        string? strokC = Console.ReadLine();
        if (strokC == null) return;
        int R = int.Parse(strokC);
        double late = k * Math.PI / 180.0;
        double leta = l * Math.PI / 180.0;
        double lata = m * Math.PI / 180.0;
        double lete = n * Math.PI / 180.0;
        double dunk = Math.Abs(leta - lete);
        dunk = Math.Min(dunk, 2 * Math.PI - dunk);
        double sin = Math.Sin((lata - late) / 2);
        double sun = Math.Sin(dunk / 2);
        double a = sin * sin +
                   Math.Cos(late) * Math.Cos(lata) *
                   sun * sun;
        if (a < 0) a = 0;
        if (a > 1) a = 1;
        double centr = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));
        double rasst = R * centr;
        Console.WriteLine(rasst.ToString("F3"));
    }
}
*/