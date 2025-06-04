/*
using System;
using System.Collections.Generic;
using System.Linq;
public class Program
{
    struct Gorod
    {
        public char Start;
        public char End;
    }
    static void Main()
    {
        List<Gorod> gradi = new List<Gorod>();
        while (true)
        {
            string? stroka = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(stroka)) break;
            string nazvanija = stroka.Trim();
            if (nazvanija.Length > 0)
            {
                gradi.Add(new Gorod
                {
                    Start = nazvanija[0],
                    End = nazvanija[^1]
                });
            }
        }
        if (gradi.Count == 0)
        {
            Console.WriteLine("0");
            return;
        }
        List<int>[] derevo = new List<int>[26];
        bool[] vertel = new bool[26];
        for (int i = 0; i < 26; i++)
        {
            derevo[i] = new List<int>();
            vertel[i] = false;
        }
        foreach (var city in gradi)
        {
            int u = city.Start - 'a';
            int v = city.End - 'a';
            derevo[u].Add(v);
            if (u != v) derevo[v].Add(u);
            vertel[u] = true;
            vertel[v] = true;
        }
        int[] cuc = new int[26];
        Array.Fill(cuc, -1);
        List<int> cyc = new List<int>();
        for (int i = 0; i < 26; i++)
        {
            if (vertel[i] && cuc[i] == -1)
            {
                int schet = 0;
                Stack<int> stuk = new Stack<int>();
                stuk.Push(i);
                cuc[i] = cyc.Count;
                while (stuk.Count > 0)
                {
                    int loper = stuk.Pop();
                    schet++;
                    foreach (int sosed in derevo[loper])
                    {
                        if (cuc[sosed] == -1)
                        {
                            cuc[sosed] = cyc.Count;
                            stuk.Push(sosed);
                        }
                    }
                }
                cyc.Add(schet);
            }
        }
        int[] utun = new int[cyc.Count];
        foreach (var city in gradi)
        {
            int u = city.Start - 'a';
            utun[cuc[u]]++;
        }
        Array.Sort(utun, (a, b) => b.CompareTo(a));
        Console.WriteLine(utun.Length);
        foreach (int count in utun)
        {
            Console.WriteLine(count);
        }
    }
}
*/