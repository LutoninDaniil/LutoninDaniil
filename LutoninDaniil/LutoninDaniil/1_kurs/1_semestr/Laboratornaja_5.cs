/*30.10.2024*/

using System;
using System.Data;
/*
class L5_1
{
    static void Main()
    {
        int s,h = 0;
        Console.WriteLine("Введите размерность массива:");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] vrum = new int[n];
        Console.WriteLine("Введите элементы массива:");
        for (int i = 0; i<vrum.Length; i++)
        {
            s = Convert.ToInt32(Console.ReadLine());
            vrum[i]=s;
        }
        int[] vrom = new int[vrum.Length];
        for (int j = 0; j<vrum.Length; j++)
        {
            s = vrum[j];
            if (s > 0)
            {
                vrom[h] = s;
                h+=1;
            }
        }
        for (int j = 0; j<vrum.Length; j++)
        {
            s = vrum[j];
            if (s == 0)
            {
                vrom[h] = s;
                h+=1;
            }
        }
        for (int j = 0; j<vrum.Length; j++)
        {
            s = vrum[j];
            if (s < 0)
            {
                vrom[h] = s;
                h+=1;
            }
        }
        Console.WriteLine("Выходной массив:");
        for (int j = 0; j<vrom.Length; j++)
        {
            Console.WriteLine(vrom[j]);
        }
    }

}
*/
/*
class L5_2
{
    static void Main()
    {
        int f=0,c=0,max = int.MaxValue;
        Console.WriteLine("Введите размерность массива:");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] ratatui = new int[n];
        Console.WriteLine("Введите элементы массива:");
        for (int i = 0; i<n; i++)
        {
            int r = Convert.ToInt32(Console.ReadLine());
            ratatui[i] = r;
        }
        for (int j = 0; j<max; j++)
        {
            for (int i = 1; i<n; i++)
            {
                if (ratatui[i-1]>ratatui[i])
                {
                    if (ratatui[i-1]-ratatui[i]==j)
                    {
                        c+=1;
                    }
                }
            }
            if (c==n-1)
            {
                f = c;
                Console.WriteLine("Является.");
            }
            c = 0;
        }
        if (f==0)
        {
            Console.WriteLine("Не является.");
        }
    }
}


class L5_2
{
    static void Main()
    {
        int c = 0;
        Console.WriteLine("Введите размерность массива:");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] tratata = new int[n];
        Console.WriteLine("Введите элементы массива:");
        for (int i = 0; i<n; i++)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            tratata[i] = a;
        }
        for (int i = 0; i<n; i++)
        {
            if (tratata[i]%2==0)
            {
                c+=1;
            }
        }
        if (c==n)
        {
            Console.WriteLine("ДА.");
        }
        else
        {
            Console.WriteLine("НЕТ.");
        }
    }
}
*/