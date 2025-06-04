/*27.02.2025*/
//Алгоритм Дейкстра
/*
using System;
using System.Collections.Generic;
public class Tchk
{
    public List<int> pururum { get; set; } = new List<int>();
    public List<int> pararam { get; set; } = new List<int>();
}
public class Deikstra
{
    public static void Vkach(Tchk[] tchki)
    {
        List<Tchk> zix = new List<Tchk>();
        Dictionary<Tchk, int?> mrak = new Dictionary<Tchk, int?>();
        foreach (var tchk in tchki)
        {
            mrak[tchk] = null;
        }
        Tchk inter = tchki[0];
        mrak[inter] = 0;
        while (zix.Count < tchki.Length)
        {
            for (int i = 0; i < inter.pururum.Count; i++)
            {
                int ind = inter.pururum[i];
                Tchk tch = tchki[ind];
                if (zix.Contains(tch))
                {
                    continue;
                }
                int nuw = inter.pararam[i] + mrak[inter]!.Value;
                if (mrak[tch] == null || mrak[tch] > nuw)
                {
                    mrak[tch] = nuw;
                }
            }
            zix.Add(inter);
            Tchk nyw = inter;
            int? min = null;
            foreach (var tchk in tchki)
            {
                if (zix.Contains(tchk) || mrak[tchk] == null)
                {
                    continue;
                }
                if (min == null || min > mrak[tchk])
                {
                    min = mrak[tchk];
                    nyw = tchk;
                }
            }
            if (inter == nyw)
            {
                break;
            }
            inter = nyw;
        }
        Console.Write("Алгоритм Дейкстра: ");
        foreach (var tchk in tchki)
        {
            Console.Write(mrak[tchk] + " ");
        }
        Console.WriteLine();
    }
}
*/