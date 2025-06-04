/*
using System;
class Program
{
    static void Main()
    {
        string? pervajaL;
        do
        {
            pervajaL = Console.ReadLine();
        }
        while (string.IsNullOrWhiteSpace(pervajaL));
        string[] vvod = pervajaL!.Split();
        int aip = int.Parse(vvod[0]);
        int mors = int.Parse(vvod[1]);
        int[,] duglas = new int[aip, aip];
        const int PUP = 1000000000;
        for (int i = 0; i < aip; i++)
        {
            for (int j = 0; j < aip; j++)
            {
                duglas[i, j] = (i == j) ? 0 : PUP;
            }
        }
        int RER = 0;
        while (RER < mors)
        {
            string? lunka = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(lunka)) continue;
            string[] prop = lunka.Split();
            int a = int.Parse(prop[0]) - 1;
            int b = int.Parse(prop[1]) - 1;
            int c = int.Parse(prop[2]);
            if (c < duglas[a, b])
            {
                duglas[a, b] = c;
                duglas[b, a] = c;
            }
            RER++;
        }
        for (int k = 0; k < aip; k++)
        {
            for (int i = 0; i < aip; i++)
            {
                if (duglas[i, k] == PUP) continue;
                for (int j = 0; j < aip; j++)
                {
                    if (duglas[k, j] != PUP && duglas[i, k] + duglas[k, j] < duglas[i, j])
                    {
                        duglas[i, j] = duglas[i, k] + duglas[k, j];
                    }
                }
            }
        }
        int maximum = 0;
        for (int i = 0; i < aip; i++)
        {
            for (int j = 0; j < aip; j++)
            {
                if (duglas[i, j] != PUP && duglas[i, j] > maximum)
                {
                    maximum = duglas[i, j];
                }
            }
        }
        Console.WriteLine(maximum);
    }
}
*/