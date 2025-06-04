/*
using System;
using System.Collections.Generic;
using System.Linq;
public class Program
{
    static int Poisk(int x, int[] tyu)
    {
        if (tyu[x] != x)
        {
            tyu[x] = Poisk(tyu[x], tyu);
        }
        return tyu[x];
    }
    static void Upor(int x, int y, int[] uty, int[] lol)
    {
        int a = Poisk(x, uty);
        int b = Poisk(y, uty);
        if (a == b) return;
        if (lol[a] < lol[b])
        {
            uty[a] = b;
        }
        else if (lol[a] > lol[b])
        {
            uty[b] = a;
        }
        else
        {
            uty[b] = a;
            lol[a]++;
        }
    }
    static void Main()
    {
        string? pervlin = Console.ReadLine();
        if (pervlin == null)
        {
            Console.WriteLine("0");
            return;
        }
        string[] dofa = pervlin.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        if (dofa.Length < 2)
        {
            Console.WriteLine("0");
            return;
        }
        int A = int.Parse(dofa[0]);
        int B = int.Parse(dofa[1]);
        List<(int u, int v, int weight)> ves = new List<(int, int, int)>();
        int glob = 0;
        while (glob < B)
        {
            string? luna = Console.ReadLine();
            if (luna == null) break;
            if (string.IsNullOrWhiteSpace(luna)) continue;
            string[] chasti = luna.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            if (chasti.Length < 3) continue;
            if (int.TryParse(chasti[0], out int u) &&
                int.TryParse(chasti[1], out int v) &&
                int.TryParse(chasti[2], out int weight))
            {
                ves.Add((u, v, weight));
                glob++;
            }
        }
        if (ves.Count == 0)
        {
            Console.WriteLine("0");
            return;
        }
        ves = ves.OrderBy(e => e.weight).ToList();
        int[] dosss = new int[A + 1];
        int[] klm = new int[A + 1];
        for (int i = 1; i <= A; i++)
        {
            dosss[i] = i;
            klm[i] = 0;
        }
        List<(int u, int v, int weight)> gmt = new List<(int, int, int)>();
        int FinalVes = 0;
        foreach (var eeee in ves)
        {
            int u = eeee.u;
            int v = eeee.v;
            int x = Poisk(u, dosss);
            int y = Poisk(v, dosss);
            if (x != y)
            {
                gmt.Add(eeee);
                FinalVes += eeee.weight;
                Upor(x, y, dosss, klm);
            }
        }
        List<(int to, int weight)>[] jokey = new List<(int, int)>[A + 1];
        for (int i = 1; i <= A; i++)
        {
            jokey[i] = new List<(int, int)>();
        }
        HashSet<string> rat = new HashSet<string>();
        foreach (var edge in gmt)
        {
            int malo = Math.Min(edge.u, edge.v);
            int mnogo = Math.Max(edge.u, edge.v);
            jokey[edge.u].Add((edge.v, edge.weight));
            jokey[edge.v].Add((edge.u, edge.weight));
            rat.Add($"{malo},{mnogo}");
        }
        int[,] meb = new int[A + 1, A + 1];
        for (int i = 1; i <= A; i++)
        {
            int[] mfix = new int[A + 1];
            Array.Fill(mfix, -1);
            Queue<int> res = new Queue<int>();
            mfix[i] = 0;
            res.Enqueue(i);
            while (res.Count > 0)
            {
                int tetr = res.Dequeue();
                foreach (var sosed in jokey[tetr])
                {
                    int sled = sosed.to;
                    if (mfix[sled] == -1)
                    {
                        mfix[sled] = Math.Max(mfix[tetr], sosed.weight);
                        res.Enqueue(sled);
                    }
                }
            }
            for (int j = 1; j <= A; j++)
            {
                meb[i, j] = mfix[j];
            }
        }
        int mun = int.MaxValue;
        bool nolp = false;
        foreach (var edge in ves)
        {
            int malo = Math.Min(edge.u, edge.v);
            int mnogo = Math.Max(edge.u, edge.v);
            string kruk = $"{malo},{mnogo}";
            if (rat.Contains(kruk)) continue;
            int rost = meb[edge.u, edge.v];
            if (rost == -1) continue;
            int konk = FinalVes - rost + edge.weight;
            if (konk > FinalVes)
            {
                nolp = true;
                if (konk < mun)
                {
                    mun = konk;
                }
            }
        }
        Console.WriteLine(nolp ? mun : FinalVes);
    }
}
*/