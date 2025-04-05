using System;
/*
class Z_1
{
    static void main(string[] japi)
    {
        int x = 0, c = 1;
        Console.WriteLine("Введите строку(из строчных букв латинского алфавита):");
        string a = "" + Console.ReadLine();
        string s = "eioauyEIOAUY";
        for (int i = 0; i<a.Length - 1; i++)
        {
            if (s.Contains(a[i]) != s.Contains(a[i + 1]))
            {
                c += 1;
                x = math.max(x, c);
            }
            else
            {
                c = 1;
            }
        }
        Console.WriteLine(x);
    }
}
*/
/*
class Z_2
{
    static void Pomogator(int[,] topor, int n, int m)
    {
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write($"Введите элемент [{j},{i}] столбика №{i+1}: ");
                topor[j, i] = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
    static int Summmmmmmmm(int[,] topor, int n, int c)
    {
        int s = 0;
        for (int i = 0; i < n; i++)
        {
            s += topor[i, c];
        }
        return s;
    }
    static int Proizvedenie(int[,] topor, int n, int c)
    {
        int p = 1;
        for (int i = 0; i < n; i++)
        {
            p *= topor[i, c];
        }
        return p;
    }
    static void Nado(int[,] topor, int n, int m)
    {
        Console.WriteLine("Номера столбиков, где сумммммма больше произведения:");
        for (int i = 0; i < m; i++)
        {
            int s = Summmmmmmmm(topor, n, i);
            int p = Proizvedenie(topor, n, i);
            if (s > p)
            {
                Console.WriteLine(i+1);
            }
        }
    }
    static void Main(string[] japi)
    {
        Console.Write("Введите количество строчек(n): ");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите количество столбиков(m): ");
        int m = Convert.ToInt32(Console.ReadLine());
        int[,] topor = new int[n, m];
        Pomogator(topor, n, m);
        Nado(topor, n, m);
    }
}
*/