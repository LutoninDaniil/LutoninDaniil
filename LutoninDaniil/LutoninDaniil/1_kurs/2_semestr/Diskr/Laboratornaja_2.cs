/*13.02.2025*/
/*
using System;
using System.Collections.Generic;
using System.Linq;
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
        while (REPO.Count < tochki.Length)
        {
            if (!REPO.Contains(i))
            {
                REPO.Add(i);
            }
            int miiiiin = 0;
            foreach (int volt in Lol[i])
            {
                if (volt > 0 && (miiiiin == 0 || volt < miiiiin))
                {
                    miiiiin = volt;
                }
            }
            SSSSS += miiiiin;
            for (int j = tochki[i].DrugieTochki.Count - 1; j >= 0; j--)
            {
                int a = tochki[i].DrugieTochki[j];
                if (!REPO.Contains(a) && Lol[i][a] == miiiiin && miiiiin > 0)
                {
                    REPO.Add(a);
                    Lol[i][a] = 0;
                    Lol[a][i] = 0;
                    i = a;
                    break;
                }
            }
            if (miiiiin == 0)
            {
                i++;
            }
            if (i >= tochki.Length)
            {
                i = 0;
            }
        }
        Console.WriteLine("\tОтветочка: " + SSSSS);
    }
}
class Prop
{
    static void Main()
    {
        Console.WriteLine("Введите матрицу(числа через пробел):");
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