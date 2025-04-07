/*13.02.2025*/

using System;
using System.Collections.Generic;
using System.Linq;
/*
// Алгоритм Прима
public class Tochka
{
    public List<int> DrugieTochki { get; } = new List<int>();
}
public static class Algoritm
{
    public static void YUI(Tochka[] tochki, string[] str)
    {
        List<int> REPO = new List<int>();
        int SSSSS = 0;
        int[][] Lol = str.Select(line => line.Split(' ').Select(int.Parse).ToArray()).ToArray();
        int i = 0;
        int visitedCheck = 0;
        while (REPO.Count < tochki.Length && visitedCheck < tochki.Length * 2)
        {
            if (!REPO.Contains(i))
            {
                REPO.Add(i);
            }
            int miiiiin = int.MaxValue;
            foreach (int volt in Lol[i])
            {
                if (volt > 0 && volt < miiiiin)
                {
                    miiiiin = volt;
                }
            }
            if (miiiiin != int.MaxValue)
            {
                SSSSS += miiiiin;
            }
            bool found = false;
            for (int j = 0; j < tochki[i].DrugieTochki.Count; j++)
            {
                int a = tochki[i].DrugieTochki[j];
                if (!REPO.Contains(a) && Lol[i][a] == miiiiin && miiiiin > 0)
                {
                    REPO.Add(a);
                    Lol[i][a] = 0;
                    i = a;
                    found = true;
                    break;
                }
            }
            if (!found)
            {
                i = (REPO.Count < tochki.Length) ? 0 : i; 
                i++;
                if (i >= tochki.Length)
                {
                    i = 0;
                }
            }
            visitedCheck++;
        }
        Console.WriteLine("\tОтветочка: " + (SSSSS > 0 ? SSSSS : 0));
    }
}
class Prop
{
    static void Main()
    {
        Console.WriteLine("Введите матрицу(числа через пробельчик):");
        List<string> tremor = new List<string>();
        while (true)
        {
            Console.Write("> ");
            string luna = (Console.ReadLine() ?? "").Trim();
            if (string.IsNullOrEmpty(luna)) 
            {
                break;
            }
            if (!luna.All(c => char.IsDigit(c) || c == ' '))
            {
                Console.WriteLine("Ошибочка! Используйте только цифры и пробелы(позязя)");
                continue;
            }
            tremor.Add(luna);
        }
        Tochka[] points = new Tochka[tremor.Count];
        for (int i = 0; i < points.Length; i++)
        {
            points[i] = new Tochka();
            int[] vawel = tremor[i].Split(' ').Select(int.Parse).ToArray();
            for (int j = 0; j < vawel.Length; j++)
            {
                if (vawel[j] > 0)
                {
                    points[i].DrugieTochki.Add(j);
                }
            }
        }
        Console.WriteLine("\nДлина пути:");
        Algoritm.YUI(points, tremor.ToArray());
    }
}
*/
// Алгоритм Краскала
/*
public class Repa
{
    public int[] Papa;
    public Repa(int shirina)
    {
        Papa = Enumerable.Range(0, shirina).ToArray();
    }
    public int Poisk(int x)
    {
        if (Papa[x] != x)
        {
            Papa[x] = Poisk(Papa[x]);
        }
        return Papa[x];
    }
    public void Utub(int x, int y)
    {
        int Sos = Poisk(x);
        int Oso = Poisk(y);
        if (Sos != Oso)
        {
            Papa[Oso] = Sos;
        }
    }
}
public static class Vter
{
    public static void SSrt(List<Tuple<int, int, int>> rer)
    {
        for (int i = 0; i < rer.Count; i++)
        {
            for (int j = 0; j < rer.Count - 1; j++)
            {
                if (rer[j].Item3 > rer[j + 1].Item3)
                {
                    (rer[j], rer[j + 1]) = (rer[j + 1], rer[j]);
                }
            }
        }
    }
    public static void Mramor(string[] str)
    {
        List<Tuple<int, int, int>> VSrer = new List<Tuple<int, int, int>>();
        for (int i = 0; i < str.Length; i++)
        {
            int[] hlop = str[i].Split(' ').Select(int.Parse).ToArray();
            for (int j = i + 1; j < hlop.Length; j++)
            {
                if (hlop[j] > 0)
                {
                    VSrer.Add(Tuple.Create(i, j, hlop[j]));
                }
            }
        }
        SSrt(VSrer);
        Repa dsu = new Repa(str.Length);
        int Suuumka = 0;
        foreach (var rebro in VSrer)
        {
            if (dsu.Poisk(rebro.Item1) != dsu.Poisk(rebro.Item2))
            {
                Suuumka += rebro.Item3;
                dsu.Utub(rebro.Item1, rebro.Item2);
            }
        }
        Console.WriteLine("Суммарик: " + Suuumka);
    }
}
class Frog
{
    static void Main()
    {
        Console.WriteLine("Введите матрицу(0 и 1 через пробел/пустая строка - конец матрицы):");
        List<string> motik = new List<string>();
        while (true)
        {
            Console.Write("> ");
            string tuput = (Console.ReadLine() ?? "").Trim();
            if (string.IsNullOrEmpty(tuput))
            {
                break;
            }
            if (tuput.Split(' ').Any(x => !int.TryParse(x, out _)))
            {
                Console.WriteLine("Только цифры и пробелы!🤬🪓");
                continue;
            }
            motik.Add(tuput);
        }
        Vter.Mramor(motik.ToArray());
    }
}
*/
