/*24.02.2025*/
/*
using System;
using System.Collections.Generic;
using System.Linq;
public class Tochka
{
    public List<int> DrugieTochki { get; set; } = new List<int>();
}
public static class Schet
{
    public static int Potok(Tochka[] tochki)
    {
        int[] redaw = Enumerable.Range(0, tochki.Length).ToArray();
        List<Tochka> caza = new List<Tochka> { new Tochka() };
        caza[0].DrugieTochki.Add(redaw[0]);
        redaw[0] = -1;
        for (int k = 0; k < caza.Count; k++)
        {
            for (int i = 0; i < caza[k].DrugieTochki.Count; i++)
            {
                int current = caza[k].DrugieTochki[i];
                for (int j = 0; j < redaw.Length; j++)
                {
                    if (redaw[j] != -1 && tochki[current].DrugieTochki.Contains(redaw[j]))
                    {
                        caza[k].DrugieTochki.Add(redaw[j]);
                        redaw[j] = -1;
                    }
                }
            }
            Array.Sort(redaw);
            if (redaw.Last() > -1)
            {
                caza.Add(new Tochka());
                caza.Last().DrugieTochki.Add(redaw.Last());
                redaw[redaw.Length - 1] = -1;
            }
        }
        return caza.Count;
    }
}
public static class Algoritm
{
    public static void Norve(Tochka[] tochkisssss)
    {
        int scet = Schet.Potok(tochkisssss);
        int mosti = 0;
        for (int i = 0; i < tochkisssss.Length; i++)
        {
            for (int j = 0; j < tochkisssss[i].DrugieTochki.Count; j++)
            {
                var scrap = tochkisssss.Select(p => new Tochka { DrugieTochki = new List<int>(p.DrugieTochki) }).ToArray();
                int sosed = tochkisssss[i].DrugieTochki[j];
                scrap[i].DrugieTochki.Remove(sosed);
                scrap[sosed].DrugieTochki.Remove(i);
                int newCount = Schet.Potok(scrap);
                if (newCount > scet)
                {
                    mosti++;
                }
            }
        }
        Console.WriteLine("Количество мостиков: " + mosti / 2);
    }
}
class Tromb
{
    static void Main()
    {
        Console.WriteLine("Введите матрицу смежности(только 0 и 1)(без пробельчиков):");
        List<string> tabl = new List<string>();
        while (true)
        {
            Console.Write("Строка: ");
            string blone = (Console.ReadLine() ?? "").Trim();
            if (string.IsNullOrEmpty(blone))
            {
                break;
            }
            if (blone.Any(c => c != '0' && c != '1'))
            {
                Console.WriteLine("Ошибочка! Используйте только 0 и 1");
                continue;
            }
            tabl.Add(blone);
        }
        Tochka[] tochki = new Tochka[tabl.Count];
        for (int i = 0; i < tochki.Length; i++)
        {
            tochki[i] = new Tochka();
            for (int j = 0; j < tabl[i].Length; j++)
            {
                if (tabl[i][j] == '1')
                {
                    tochki[i].DrugieTochki.Add(j);
                }
            }
        }
        Algoritm.Norve(tochki);
    }
}
*/