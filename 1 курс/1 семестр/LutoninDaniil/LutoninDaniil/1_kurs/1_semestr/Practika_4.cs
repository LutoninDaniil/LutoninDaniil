/*24.10.2024*/
/*
using System;
Console.WriteLine("Введите размерность массива:");
int n = Convert.ToInt32(Console.ReadLine());
int[] name = new int[n];
P4.Main(name);
P4.DA(name);
P4.NET(name);
class P4
{
    public static void Main(int[] name)
    {
        Console.WriteLine("Введите элементы массива:");
        for (int i = 0;i<name.Length;i++)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            name[i] = a;
        }
    }
    public static void DA(int[] name)
    {
        for (int j = 0;j<name.Length;j++)
        {
            name[j]=name[j]*name[j];
        }
    }
    public static void NET(int[] name)
    {
        Console.Write("Изменённый масиив:" + "\n");
        for (int k = 0;k<name.Length;k++)
        {
            Console.Write(name[k] + "\n");
        }
    }
}
*/