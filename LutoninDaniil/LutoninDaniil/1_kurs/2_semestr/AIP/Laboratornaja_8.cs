/*27.03.2025*/
/*
using System;
using System.Collections.Generic;
//Задание 1
delegate void Mat(float x, float y);
internal class Program
{
    private static void Main(string[] args)
    {
        Mat huh = (float x, float y) =>
        {
            Console.WriteLine("Сумммммма: " + (x + y));
        };
        huh += (float x, float y) =>
        {
            Console.WriteLine("Разззззность: " + (x - y));
        };
        huh += (float x, float y) =>
        {
            Console.WriteLine("Произвеееееедение: " + (x * y));
        };
        huh += (float x, float y) =>
        {
            if (y == 0)
            {
                Console.WriteLine("На 0 делить незя");
                return;
            }
            Console.WriteLine("Часттттттное: " + (x / y));
        };
        huh(10, 0);
    }
}
*/
//Задание 2
/*
delegate void Vih(string[] rut, string tur);
internal class Program
{
    private static void Main(string[] args)
    {
        Vih vihod = (string[] rut, string tur) =>
        {
            foreach (string i in rut)
            {
                if (i.IndexOf(tur) == 0) Console.WriteLine(i);
            }
        };
        string[] rut = ["123", "213", "231", "211", "132", "321", "122"];
        string tur = "12";
        vihod(rut, tur);
    }
}
*/