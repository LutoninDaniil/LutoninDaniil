/*22.11.2024*/
using System;
/*
class L7_1
{
    static void Main()
    {
        int e = 0, k = 0, c = int.MinValue;
        Console.WriteLine("Введите количество строк:");
        int n = Convert.ToInt32(Console.ReadLine());
        int[][] griva = new int[n][];
        for (int i = 0; i<n; i++)
        {
            Console.WriteLine("Введите количество элементов в строке №" + (i+1));
            int d = Convert.ToInt32(Console.ReadLine());
            griva[i] = new int[d];
            Console.WriteLine("Введите элементы в строке №" + (i+1));
            for (int j = 0; j<d; j++)
            {
                int x = Convert.ToInt32(Console.ReadLine());
                griva[i][j] = x;
            }
        }
        for (int i = 0; i<n; i++)
        {
            for (int j = 0; j<griva[i].Length;j++)
            {
                if (griva[i][j]>c)
                {
                    c = griva[i][j];
                    k = j;
                }
            }
            for (int y = 0; y<griva[i].Length;y++)
            {
                if (k!=y)
                {
                    e = e + griva[i][y];
                }
            }
            if (c>e)
            {
                Console.WriteLine("Подходящая строка:" + " " + (i+1));
            }
            c=int.MinValue;
            e=0;
            k=0;
        }
    }
}
*/
/*
class L7_2
{
    private static void Main(string[] japi)
    {
        Console.Write("Введите количество строк: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int [][] tartar = new int[n][];
        for (int i = 0; i<n; i++)
        {
            Console.WriteLine($"Введите элементы строки {i+1} через пробел:");
            tartar[i] = GGG();
        }
        for (int i = 0; i<tartar.Length; i++){

            int b = 0;
            int a = 1;
            int c = 0;
            bool d = false;

            for (int j = 1; j<tartar[i].Length; j++)
            {
                if (tartar[i][j] - tartar[i][j-1] == b && b<0)
                {
                  a+=1;  
                }
                
                else 
                {
                    if (!d && a>1){c = a; d=true;}
                    else if (a>1)c = Math.Min(a, c);
                    a = 1;
                    b = tartar[i][j] - tartar[i][j-1];
                }
            }
            if (!d && a>1){c = a; d = true;}
            else if (a>1)c = Math.Min(a, c);
            if (d)Console.WriteLine($"В строке {i+1} наименьшая длинна равномерно убывающей последовательности равна: {c+1}");
            else Console.WriteLine($"В строке {i+1} равномерно убывающей последовательности нет:(");
        }
    }
    static int[] GGG()
    {

        string l = ""+Console.ReadLine();

        string[] k = l.Split(" ");
        int[] lira = new int[k.Length];

        for (int i = 0; i<lira.Length; i++)
        {
            lira[i] = Convert.ToInt32(k[i]);
        }

        return lira;
    }
}
*/