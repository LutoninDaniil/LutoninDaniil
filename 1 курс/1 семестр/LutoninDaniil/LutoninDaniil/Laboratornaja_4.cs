/*
using System;
using System.Diagnostics;
using System.Globalization;

class Z4_1{
    static void Main(){
        int a,b=0,v;
        int n = Convert.ToInt32(Console.ReadLine());
        v=n;
        if (n<=0)
        {
            Console.WriteLine("АБОБА");
        }
        else if (n>0)
        {
            while (n>0)
            {
                while (v>0)
                {
                    a=v%10;
                    if (a%2!=0)
                    {
                        b=b*10+a;
                    }
                    v=v/10;
                }
                if (b>0)
                {
                    Console.WriteLine(b);
                }
                else if (b<=0)
                {
                    Console.WriteLine("Нетю(((");
                }
                b=0;
                int z = Convert.ToInt32(Console.ReadLine());
                if (z<=0)
                {
                    Console.WriteLine("АБОБА");
                }
                n=z;
                v=n;
            }
        }
        
    }
}
*/