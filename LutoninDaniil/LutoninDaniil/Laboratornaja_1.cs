﻿using System;

class Z1{
  static void Main() {
      int a,b;
      a=Convert.ToInt32(Console.ReadLine());
      b=Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(a+b-a);Console.WriteLine(b+a-b);
  }
}
 /*
class Z2{
  static void Main() {
      int x,y;
      x=Convert.ToInt32(Console.ReadLine());
      y=Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(((Math.Abs(x-y))/2.0)+(Math.Abs(y+x)/2.0));
  }
}

class Z3{
  static void Main() {
      int p,l,m,n;
      n=Convert.ToInt32(Console.ReadLine());
      l=3;
      m=3;
      p=5;
    Console.WriteLine((2*n*p)+n*(2*l+2*m)+n*(l*n-l));
  }
}
*/