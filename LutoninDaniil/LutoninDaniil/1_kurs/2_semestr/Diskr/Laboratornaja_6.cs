/*13.03.2025*/
//Алгоритм Флойда
/*
using System;
public class Klop
{
    public List<int> ghk { get; set; } = new List<int>();
    public List<int> vopl { get; set; } = new List<int>();
}
public class Floid
{
    public static void Groj(Klop[] hutor)
    {
        int?[][] mol = new int?[hutor.Length][];
        int?[][] sled = new int?[hutor.Length][];
        for (int i = 0; i < hutor.Length; i++)
        {
            mol[i] = new int?[hutor.Length];
            sled[i] = new int?[hutor.Length];
            for (int j = 0; j < hutor.Length; j++)
            {
                if (i == j)
                {
                    mol[i][j] = 0;
                }
                else if (hutor[i].ghk.Contains(j))
                {
                    int yre = hutor[i].ghk.IndexOf(j);
                    mol[i][j] = hutor[i].vopl[yre];
                }
                else
                {
                    mol[i][j] = null;
                }
            }
        }
        sled = AAAAAn(mol, sled);
        for (int k = 0; k < hutor.Length; k++)
        {
            for (int i = 0; i < hutor.Length; i++)
            {
                for (int j = 0; j < hutor.Length; j++)
                {
                    if (mol[i][k] == null || mol[k][j] == null)
                    {
                        continue;
                    }
                    int btr = mol[i][k].Value + mol[k][j].Value;
                    if (sled[i][j] == null || sled[i][j] > btr)
                    {
                        sled[i][j] = btr;
                    }
                }
            }
            mol = AAAAAn(sled, mol);
        }
        Console.WriteLine("Алгоритм Флойда:");
        for (int i = 0; i < sled.Length; i++)
        {
            for (int j = 0; j < sled.Length; j++)
            {
                Console.Write(sled[i][j] + " ");
            }
            Console.WriteLine();
        }
    }
    private static int?[][] AAAAAn(int?[][] sous, int?[][] dreik)
    {
        for (int i = 0; i < sous.Length; i++)
        {
            Array.Copy(sous[i], dreik[i], sous.Length);
        }
        return dreik;
    }
}
*/