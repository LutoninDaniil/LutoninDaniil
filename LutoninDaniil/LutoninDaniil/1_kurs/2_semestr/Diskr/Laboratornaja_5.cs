/*10.03.2025*/
//Алгоритм Форда-Беллмана
/*
using System;
using System.Collections.Generic;
public class Kell
{
    public List<int> Ferd { get; set; } = new List<int>();
    public List<int> Fard { get; set; } = new List<int>();
}
public class FordBelman
{
    public static void Tof(Kell[] trrew)
    {
        int?[][] bodc = new int?[trrew.Length][];
        for (int i = 0; i < trrew.Length; i++)
        {
            bodc[i] = new int?[trrew.Length];
        }
        bodc[0][0] = 0;
        for (int i = 1; i < bodc.Length; i++)
        {
            bodc[i][0] = 0;
            for (int j = 1; j < bodc[i].Length; j++)
            {
                for (int k = 0; k < bodc[i - 1].Length; k++)
                {
                    if (bodc[i - 1][k] == null || SearchWay(trrew, k, j) == null)
                    {
                        continue;
                    }
                    int dack = bodc[i - 1][k].Value + SearchWay(trrew, k, j).Value;
                    if (bodc[i][j] == null || bodc[i][j] > dack)
                    {
                        bodc[i][j] = dack;
                    }
                }
            }
        }
        Console.Write("Форд-Беллман: ");
        foreach (var erds in bodc[bodc.Length - 1])
        {
            Console.Write(erds + " ");
        }
        Console.WriteLine();
    }
    private static int? SearchWay(Kell[] trrew, int iz, int v)
    {
        if (!trrew[iz].Ferd.Contains(v))
        {
            return null;
        }
        int puh = trrew[iz].Ferd.IndexOf(v);
        return trrew[iz].Fard[puh];
    }
}
*/