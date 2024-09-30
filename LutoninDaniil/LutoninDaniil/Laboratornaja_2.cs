using System;
using System.Diagnostics;
using System.Globalization;
/*
class Z2_1{
  static void Main() {
      int c,a,b,z=0;
      int n=Convert.ToInt32(Console.ReadLine());
      a=Convert.ToInt32(Console.ReadLine());
      b=Convert.ToInt32(Console.ReadLine());
      c=Convert.ToInt32(Console.ReadLine());
      if (n==3)
      {
        if ((a>b) & (c>b))
        {
          Console.WriteLine("Ответ: 1");
        }
        else
        {
          Console.WriteLine("Ответ: 0");
        }
      }
      else
      {
        if ((a>b) & (c>b))
          {
            z+=1;
          }
        for (int i=0; i<n-3; i++)
        {
          int x=Convert.ToInt32(Console.ReadLine());
          a=b;
          b=c;
          c=x;
          if ((a>b) & (c>b))
          {
            z+=1;
          }
        }
        Console.WriteLine($"Ответ: {z}");
      }
      
  }
}

class Z2_2{
    static void Main(){
      int c=0;
      int n=Convert.ToInt32(Console.ReadLine());
      for (int i=0; i<n; i++)
      {
        int x=Convert.ToInt32(Console.ReadLine());
        x=Math.Abs(x);
        if (x%10==2){
            c+=1;
        }
      }
      Console.WriteLine($"Ответ: {c}");
    }
}*/
/*
class Z2_3{
    static void Main(){
      int n=Convert.ToInt32(Console.ReadLine());
      int max_1=Convert.ToInt32(Console.ReadLine());
      int max_2=Convert.ToInt32(Console.ReadLine());
      if (max_2>max_1)
      {
        max_1=max_1+max_2;
        max_2=max_1-max_2;
        max_1=max_1-max_2;
      }
      for (int i=0;i<n-2;i++)
      {
        int a=Convert.ToInt32(Console.ReadLine());
        if (a>=max_2)
        {
          max_2=a;
        }
        if (max_2>=max_1)
        {
          max_1=max_1+max_2;
          max_2=max_1-max_2;
          max_1=max_1-max_2;
        }
      }
      Console.WriteLine($"Второй максимум: {max_2}");
    }
}
*/
class Z2_4{
    static void Main(){
      int b=0,c=0;
      int n=Convert.ToInt32(Console.ReadLine());
      for (int i=0; i<n; i++)
      {
        int x=Convert.ToInt32(Console.ReadLine());
        x=Math.Abs(x);
        if ((x%2==0) & (b<=c) & (i==n-1)){
            c+=1;
            b=c;
        }
        else if (x%2==0){
            c+=1;
        }
        else if ((x%2!=0) & (b<c)){
            b=c;
            c=0;
        }
        else if ((x%2!=0) & (b>=c)){
            c=0;
        }
        
      }
      Console.WriteLine($"Ответ: {b}");
    }
}
