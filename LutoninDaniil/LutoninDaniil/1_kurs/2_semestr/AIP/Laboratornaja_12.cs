/*21.04.2025*/
/*
using System;
using System.Collections.Generic;
internal class Program
{
    private static void Main(string[] args)
    {
        try
        {
            StreamReader mim = new StreamReader("Laboratornaja_12_input.txt");
            List<string> dla = new List<string>();
            string lum = mim.ReadLine();
            while (lum != null)
            {
                foreach (char i in lum)
                {
                    int a = Convert.ToInt32(i);
                    if (a % 2 != 0)
                    {
                        dla.Add(lum);
                        break;
                    }
                }
                lum = mim.ReadLine();
            }
            mim.Close();
            StreamWriter imi = new StreamWriter("Laboratornaja_12_output.txt");
            foreach (string i in dla)
            {
                imi.WriteLine(i);
            }
            imi.Close();
        }
        catch (Exception) { }
    }
}
*/