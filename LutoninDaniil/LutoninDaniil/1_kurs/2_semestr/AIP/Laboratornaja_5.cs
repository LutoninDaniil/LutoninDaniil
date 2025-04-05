/*10.03.2025*/
/*
using System;
using System.Collections.Generic;
class Telek
{
    public string nomer, opera;
    public Telek(string opera, string nomer)
    {
        this.nomer = nomer;
        this.opera = opera;
    }
}
internal class Puding
{
    private static void Main(string[] args)
    {
        List<Telek> teleki = new List<Telek>();
        while (true)
        {
            Console.Write("Введите оператора и номер телефона через SPACEик (ENTER чтобы закончить): ");
            string b = "" + Console.ReadLine();
            if(b.Length < 3) 
            {
                break;
            }
            string[] nullllli = b.Split(" ");
            teleki.Add(new Telek(nullllli[0], nullllli[1]));
        }
        Dictionary<string, int> svoid = new Dictionary<string, int>();
        foreach(Telek i in teleki)
        {
            if(svoid.ContainsKey(i.opera))
            {
                svoid[i.opera] += 1;
            }
            else
            {
                svoid.Add(i.opera, 1);
            }
        }

        foreach(var i in svoid)
        {
            Console.WriteLine($"Оператор {i.Key} встречается {i.Value} раз(а)(◕‿◕)");
        }
    }
}
*/