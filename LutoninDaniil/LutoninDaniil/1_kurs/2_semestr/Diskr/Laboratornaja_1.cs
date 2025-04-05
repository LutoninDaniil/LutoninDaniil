/*10.02.2025*/
/*
using System;
using System.Collections.Generic;
using System.Linq;
public class Tochka
{
    public List<int> DrugieTochki;
    public Tochka()
    {
        DrugieTochki = new List<int>();
    }
}
public static class Algoritm1
{
    public static void IIIIIU(Tochka[] tochki)
    {
        int[] tochka = new int[tochki.Length];
        for (int i = 0; i < tochka.Length; i++)
        {
            tochka[i] = i + 1; 
        }
        List<Tochka> tablica = new List<Tochka> { new Tochka() };
        tablica[0].DrugieTochki.Add(tochka[0]);
        tochka[0] = 0;
        for (int k = 0; k < tablica.Count; k++)
        {
            for (int i = 0; i < tablica[k].DrugieTochki.Count; i++)
            {
                for (int j = 0; j < tochka.Length; j++)
                {
                    if (tochka[j] != 0 && tochki[tablica[k].DrugieTochki[i] - 1].DrugieTochki.Contains(tochka[j]))
                    {
                        tablica[k].DrugieTochki.Add(tochka[j]);
                        tochka[j] = 0;
                    }
                }
            }
            tochka = tochka.OrderBy(x => x).ToArray();
            if (tochka.Last() > 0)
            {
                tablica.Add(new Tochka());
                tablica.Last().DrugieTochki.Add(tochka.Last());
                tochka[^1] = 0;
            }
        }
        Console.WriteLine("\tОтвет: " + tablica.Count + " график(а/ов)");
    }
}
public static class Algoritm2
{
    public static void UUUUUI(Tochka[] tochki)
    {
        int[] NomerTochki = new int[tochki.Length];
        NomerTochki[0] = 1;
        int i = 0;
        while (i < NomerTochki.Length)
        {
            if (NomerTochki[i] == 0)
            {
                NomerTochki[i] = NomerTochki.Max() + 1;
            }
            for (int j = 0; j < tochki[i].DrugieTochki.Count; j++)
            {
                int a = tochki[i].DrugieTochki[j] - 1;
                if (a < i && NomerTochki[i] > NomerTochki[a])
                {
                    NomerTochki[i] = NomerTochki[a];    
                }
            }
            bool PUPUPU = false;
            for (int j = 0; j < tochki[i].DrugieTochki.Count; j++)
            {
                int a = tochki[i].DrugieTochki[j] - 1;
                if (a < i && NomerTochki[i] < NomerTochki[a])
                {
                    NomerTochki[a] = NomerTochki[i];
                    PUPUPU = true;
                    break;
                }
            }
            if (PUPUPU)
            {
                i = -1;    
            }
            i++;
        }
        Console.WriteLine("\tОтвет: " + NomerTochki.Max() + " график(а/ов)");
    }
}
class Program
{
    static void Main()
    {
        Console.WriteLine("Введите матрицу смежности построчно, используя только 0 и 1(без пробельчика):)))");
        Console.WriteLine("Завершите ввод пустой строкой(:");
        List<string> Rar = new List<string>();
        while (true)
        {
            string str = (Console.ReadLine() ?? "").Trim();
            if (string.IsNullOrEmpty(str)) break;
            Rar.Add(str);
        }
        Tochka[] tochki = new Tochka[Rar.Count];
        for (int i = 0; i < tochki.Length; i++)
        {
            tochki[i] = new Tochka();
            for (int j = 0; j < Rar[i].Length; j++)
            {
                if (Rar[i][j] == '1') 
                    tochki[i].DrugieTochki.Add(j + 1);
            }
        }
        Console.WriteLine("\nАлгоритм I(уан):");
        Algoritm1.IIIIIU(tochki);
        Console.WriteLine("Алгоритм II(ту):");
        Algoritm2.UUUUUI(tochki);
    }
}
*/