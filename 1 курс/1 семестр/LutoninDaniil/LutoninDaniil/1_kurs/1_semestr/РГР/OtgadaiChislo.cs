using System;
/*
class Otgadai_Chislo
{
    static void Main(string[] japi)
    {
        string[] krut = [];
        try
        {
            StreamReader rom = new("vvod\\input_s1_01.txt");//мой единственный(второй) коментарий(абсолютно такой же, какой и первый): берёте свой файл с входными данными:)
            string reka = "";
            string ferma = "" + rom.ReadLine();
            while(!ferma.Equals(""))
            {
                reka+=ferma + "\n";
                ferma = "" + rom.ReadLine();
            }
            krut = reka.Split("\n");
            rom.Close();
        }
        catch(Exception){}
        int g = 1;
        int u = 0;
        for(int i = 1; i<krut.Length-2; i++){
            switch(krut[i].Substring(0,1)){
                case "+":
                    if(krut[i].Substring(2) == "x")
                    {
                        g+=1;;
                    }
                    else
                    {
                        u += Convert.ToInt32(krut[i].Substring(2));
                    }
                break;
                case "-":
                    if(krut[i].Substring(2) == "x")
                    {
                        g-=1;
                    }
                    else 
                    {
                        u -= Convert.ToInt32(krut[i].Substring(2));
                    }
                break;
                case "*":
                    g *= Convert.ToInt32(krut[i].Substring(2));
                    u *= Convert.ToInt32(krut[i].Substring(2));
                break;
            }
        }
        int otvet = (Convert.ToInt32(krut[krut.Length-2])- u)/g;
        Console.WriteLine("Вывод: " + otvet);
    }
}
*/