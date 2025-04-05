using System;
/*
class Kompanija_XXX
{
    static void Main(string[] japi)
    {
        string[] bonk = [];
        try
        {
            string vutut = "";
            StreamReader ser = new StreamReader("vvod\\input_s1_01.txt");//возможно мой единственный коментарий: берёте свой файл с входными данными:)

            string a = "" + ser.ReadLine();
            while(!a.Equals(""))
            {
                vutut+=a + "\n";
                a = "" + ser.ReadLine();
            }
            bonk = vutut.Split("\n");
            ser.Close();
        }
        catch(Exception){}
        int sas = 0;
        try
        {
            sas = Convert.ToInt32(bonk[bonk.Length-2]);
        }
        catch(Exception)
        {
            foreach(string i in bonk)
            {
                if( (" "+bonk[bonk.Length-2]).Equals(i.Substring(4)) )
                {
                    sas = Convert.ToInt32(i.Substring(0,4));
                    break;
                }
            }
        }
        string[] error = search(bonk, sas).Split("\n");
        int[] rorre = new int[error.Length-1];
        for(int i=1; i<error.Length; i++)
        {
            rorre[i-1] = Convert.ToInt32(error[i]);
        }
        Array.Sort(rorre);
        error = new string[rorre.Length];
        for(int i = 0; i<error.Length; i++)
        {
            error[i] = "";
            for(int j=0; j<bonk.Length-3; j++)
            {
                int b = Convert.ToInt32(bonk[j].Substring(0,4));
                if(b == rorre[i] && error[i].Length<bonk[j].Length)
                {
                    error[i] = bonk[j];
                }
            }
        }
        foreach(string i in error)
        {
            Console.WriteLine(i.Length == 4 ? i + " Unknown Name" : i);
        }
    }
    static string search(string[] bonk, int griva)
    {
        string robin = "" + griva;
        for(int i = 0; i<bonk.Length-3; i+=2)
        {
            int b = Convert.ToInt32(bonk[i].Substring(0,4));
            if(b == griva)
            {
                robin += "\n" + search(bonk, Convert.ToInt32(bonk[i+1].Substring(0,4)));
            }
        }
        return robin;
    }
}
*/