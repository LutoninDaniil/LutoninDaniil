/*27.11.2024*/
using System;
/*
class L8_1
{
    static void Main(string[] japi)
    {
        Console.WriteLine("Введите строку:");
        string t = "" + Console.ReadLine();
        string y = "";
        for(int i = 0; i<3; i++)
        {
            for(int j = 1+i; j+1<t.Length; j+=3)
            {
                string a = t.Substring(j-1, 3);
                if(a[0] =='A' && a[2] =='B'){
                    y+=a[1];
                }
            }
            y+=" ";
        }

        int u = 0;
        char p = ' ';
        foreach(char i in y)
        {
            if(i == ' ')continue;
            string[] b = y.Split(i);
            if(b.Length>u)
            {
                u = b.Length;
                p = i;
            }
        }

        Console.WriteLine("Ответ: " + (p == ' ' ? "Ничего нетю(((" : p));
    }
}
*/
/*
class L8_2
{
    static void Main(string[] japi)
    {
        Console.WriteLine("Введите строку:");
        string kol = "" + Console.ReadLine();
        string abc = "/";
        int m = 0;
        foreach(char i in kol)
        {
            if(i == 'a')
            {
                if(abc[abc.Length-1] != 'c')
                {
                   abc = "/"; 
                }
                abc+=i;
            }
            else if(i == 'b' && abc[abc.Length-1] == 'a')
            {
                abc+=i;
            }
            else if(i == 'c' && abc[abc.Length-1] == 'b')
            {
                abc+=i;
            }
            else 
            {
                abc = "/";
            }
            m=Math.Max(m, abc.Length-1);
        }
        Console.WriteLine("Ответ: " + m);
    }
}
*/