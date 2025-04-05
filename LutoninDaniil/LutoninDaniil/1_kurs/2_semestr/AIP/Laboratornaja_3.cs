/*24.02.2025*/
/*
using System;
using System.Collections.Generic;
internal class Perudo
{
    private static void Main(string[] args)
    {
        Console.Write("Строка из всякой дичи: ");
        string trol = "" + Console.ReadLine();
        Stack<string> skb = new Stack<string>();

        foreach(char i in trol){
            if(skb.Count <= 0)
            {
                if("{[()]}".Contains(i))
                {
                    skb.Push("" + i);
                }
                continue;
            }
            if("{[(".Contains(i))
            {
                skb.Push(""+i);
            }
            else if(skb.Peek() == "{" && i == '}')
            {
                skb.Pop();
            }
            else if(skb.Peek() == "[" && i == ']')
            {
                skb.Pop();
            }
            else if(skb.Peek() == "(" && i == ')')
            {
                skb.Pop();
            }
        }
        Console.WriteLine("Последовательность скобок " + (skb.Count>0 ? "неверна:(" : "верна:)"));
    }
}
*/