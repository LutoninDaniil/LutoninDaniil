/*22.05.2025*/
//Алгоритм Робертса-Флореса
/*
using System;
using System.Collections.Generic;
public class RobertsFlores
{
    private static int[,] Matric = new int[7, 7]
    {
        { 0, 1, 1, 1, 0, 0, 0 },
        { 1, 0, 1, 0, 1, 0, 1 },
        { 1, 1, 0, 1, 1, 1, 1 },
        { 1, 0, 1, 0, 1, 1, 1 },
        { 0, 1, 1, 1, 0, 1, 0 },
        { 0, 0, 1, 1, 1, 0, 1 },
        { 0, 1, 1, 1, 0, 1, 0 }
    };
    private static List<List<int>> cher = new List<List<int>>();
    private static List<List<int>> crug = new List<List<int>>();
    public static void Main()
    {
        for (int nach = 0; nach < 7; nach++)
        {
            List<int> vern = new List<int> { nach + 1 };
            hytr(nach, vern);
        }
        Console.WriteLine("Все пути:");
        foreach (var path in cher)
        {
            Console.WriteLine(string.Join(" → ", path));
        }
        Console.WriteLine("\nВсе циклы:");
        foreach (var cycle in crug)
        {
            Console.WriteLine(string.Join(" → ", cycle));
        }
    }
    private static void hytr(int prav, List<int> pravo)
    {
        if (pravo.Count == 7)
        {
            int perv = pravo[0] - 1;
            int posl = pravo[6] - 1;
            if (Matric[perv, posl] == 1)
            {
                List<int> cycle = new List<int>(pravo);
                cycle.Add(pravo[0]);
                if (!Dudum(cycle))
                {
                    crug.Add(cycle);
                }
            }
            else
            {
                cher.Add(new List<int>(pravo));
            }
            return;
        }
        for (int sled = 0; sled < 7; sled++)
        {
            if (Matric[prav, sled] == 1 && !pravo.Contains(sled + 1))
            {
                pravo.Add(sled + 1);
                hytr(sled, pravo);
                pravo.RemoveAt(pravo.Count - 1);
            }
        }
    }
    private static bool Dudum(List<int> cycle)
    {
        foreach (var krug in crug)
        {
            if (Ora(cycle, krug))
            {
                return true;
            }
        }
        return false;
    }
    private static bool Ora(List<int> cyc, List<int> cuc)
    {
        if (cyc.Count != cuc.Count)
        {
            return false;
        }
        for (int dsa = 0; dsa < cyc.Count; dsa++)
        {
            bool tram = true;
            for (int i = 0; i < cyc.Count; i++)
            {
                if (cyc[i] != cuc[(i + dsa) % cuc.Count])
                {
                    tram = false;
                    break;
                }
            }
            if (tram) return true;
        }
        return false;
    }
}
*/