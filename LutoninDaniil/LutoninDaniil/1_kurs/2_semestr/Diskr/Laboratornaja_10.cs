/*10.04.2025*/
/*
using System;
using System.Collections.Generic;
public class LittleRight
{
    public static void Main()
    {
        int[,] Matrica = {
            { int.MaxValue, 10, 15, 20 },
            { 10, int.MaxValue, 35, 25 },
            { 15, 35, int.MaxValue, 30 },
            { 20, 25, 30, int.MaxValue }
        };
        var (chast, scet) = SolveTSP(Matrica);
        Console.WriteLine("Лучший пуууть: " + string.Join(" → ", chast));
        Console.WriteLine("Общая стоимость: " + scet);
    }
    public static (List<int>, int) SolveTSP(int[,] scMAt)
    {
        int n = scMAt.GetLength(0);
        List<int> chast = new List<int> { 0 };
        HashSet<int> tuda = new HashSet<int> { 0 };
        while (tuda.Count < n)
        {
            int posled = chast[chast.Count - 1];
            int sled = -1;
            int min = int.MaxValue;
            for (int i = 0; i < n; i++)
            {
                if (!tuda.Contains(i) && scMAt[posled, i] < min)
                {
                    min = scMAt[posled, i];
                    sled = i;
                }
            }
            if (sled == -1)
            {
                throw new Exception("Нельзя построить маршрут(ата-та-та)");
            }
            chast.Add(sled);
            tuda.Add(sled);
        }
        chast.Add(chast[0]);
        int finalscet = Scet(chast, scMAt);
        return (chast, finalscet);
    }
    private static int Scet(List<int> chast, int[,] scMat)
    {
        int fin = 0;
        for (int i = 0; i < chast.Count - 1; i++)
        {
            int iz = chast[i];
            int v = chast[i + 1];
            fin += scMat[iz, v];
        }
        return fin;
    }
}
*/