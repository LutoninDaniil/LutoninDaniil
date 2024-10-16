/*
using System;
using System.Diagnostics;
using System.Globalization;

class Z3_1{
    static void Main(){
        int d=0,b,a,c=1;
        int n=Convert.ToInt32(Console.ReadLine());
        a=Convert.ToInt32(Console.ReadLine());
        for (int i=0;i<n-1;i++)
        {
            b=a;
            a=Convert.ToInt32(Console.ReadLine());
            if (b==a)
            {
                c+=1;
                if(c>d)
                {
                    d=c;
                }
            }
            else
            {
                if(c>=d)
                {
                    d=c;
                }
                c=1;
            }
        }
        Console.WriteLine($"Ответ: {d}");
    }
}

class Z3_2{
    static void Main(){
        int e1=0,e2=1*10^1000000000,d,c=0;
        int n=Convert.ToInt32(Console.ReadLine());
        for (int i=0;i<n;i++)
        {
            d=Convert.ToInt32(Console.ReadLine());
            if ((d%2==0) & (i==n-1))
            {
                c+=1;
                if(c<e2)
                {
                    e2=c;
                }
            }
            else if ((d%2==0) & (i!=n-1))
            {
                c+=1;
            }
            else if (d%2!=0)
            {
                e1+=1;
                if((e1!=n) & (c<e2) & (c!=0))
                {
                    e2=c;
                }
                else if (e1==n)
                {
                    e2=0;
                }
                c=0;
            }
        }
        Console.WriteLine($"Ответ: {e2}");
    }
}
*/
/*
class Z3_3{
    static void Main(){
        int b=0,d=(-10)^1000000001,a,c=0;
        int n=Convert.ToInt32(Console.ReadLine());
        for (int i=0;i<n;i++)
        {
            a=Convert.ToInt32(Console.ReadLine());
            if ((a%2==0) & (i==n-1))
            {
                c+=a;
                if (c>=d)
                {
                    d=c;
                }
            }
            else if (a%2==0)
            {
                c+=a;
            }
            else
            {
                b+=1;
                if ((c>=d) & (c!=0))
                {
                    d=c;
                }
                else if (b==n)
                {
                    d=0;
                }
                c=0;
            }
        }
        Console.WriteLine($"Ответ: {d}");
    }
}
*/
