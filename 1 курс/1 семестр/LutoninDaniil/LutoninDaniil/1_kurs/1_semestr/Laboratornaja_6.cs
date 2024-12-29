/*08.11.2024*/
using System;
using System.ComponentModel.DataAnnotations;
/*
class L6_1
{
    static void Main()
    {
        int h = 0, p = 0, e = 1, s = 1, q = 0, r = 0, f = 0, c = 0, k = 0;
        Console.WriteLine("Введите размерность массива(строки, столбцы):");
        int n = Convert.ToInt32(Console.ReadLine());
        int m = Convert.ToInt32(Console.ReadLine());
        int[,] lom = new int[n,m];
        Console.WriteLine("Введите элементы массива(по столбцам):");
        for (int j = 0; j<m; j++)
        {
            Console.WriteLine("Столбец №" + (j+1));
            for (int i = 0; i<n; i++)
            {
            int a = Convert.ToInt32(Console.ReadLine());
            lom[i,j] = a;
            }
        }
        for (int i = 0; i<m-1; i++)
        {
            for (k = 1; k<m; k++)
            {
                for (int j = 0; j<n; j++)
                {
                    for (int l = 0; l<n; l++)
                    {
                        if ((lom[j,i]==lom[l,k]) && (k!=i) && (f==0))
                        {
                            c+=1;
                            f+=1;
                            r+=j;
                            q+=l;
                            e=e*j;
                            s=s*l;
                            if (lom[j,i]==0)
                            {
                                p+=1;
                            }
                            if (lom[l,k]==0)
                            {
                                h+=1;
                            }
                        }
                    }
                    f=0;
                }
                if ((c==n) && (r==q) && (e==s) && (p==h))
                {
                    Console.WriteLine($"Пара: {i}{k}");
                }
                r=0;
                q=0;
                c=0;
            }
            k+=1;
        }
    }
}
*/
/*
class L6_2
{
    static void Main()
    {
        int y=0,x=0,f=0,g=0,b, max = int.MinValue, min = int.MaxValue;
        Console.WriteLine("Введите размерность массива(строки, столбцы):");
        int n = Convert.ToInt32(Console.ReadLine());
        int m = Convert.ToInt32(Console.ReadLine());
        int[,] limbo = new int[n,m];
        Console.WriteLine("Введите элементы массива(по столбцам):");
        for (int j = 0; j<m; j++)
        {
            Console.WriteLine("Столбец №" + (j+1));
            for (int i = 0; i<n; i++)
            {
                int a = Convert.ToInt32(Console.ReadLine());
                limbo[i,j] = a;
            }
        }
        for (int j = 0; j<m; j++)
        {
            for (int i = 0; i<n; i++)
            {
                b = limbo[i,j];
                if (b>max)
                {
                    max = b;
                    f = j;
                }
            }
        }
        for (int j = 0; j<m; j++)
        {
            for (int i = 0; i<n; i++)
            {
                b = limbo[i,j];
                if (b<min)
                {
                    min = b;
                    g = j;
                }
            }
        }
        for (int i = 0; i<n; i++)
        {
            y = limbo[i,f];
            x = limbo[i,g];
            limbo[i,f] = x;
            limbo[i,g] = y;
        }
        Console.WriteLine("Итоговая матрица:");
        for (int i = 0; i<n; i++)
        {
            for (int j = 0; j<m; j++)
            {
                Console.Write("{0}\t",limbo[i,j]);
            }
            Console.WriteLine();
        }
    }
}
*/
/*
class L6_3
{
    static void Main()
    {
        int z=0,v=0,w=0;
        Console.WriteLine("Введите размерность массива(строки, столбцы):");
        int n = Convert.ToInt32(Console.ReadLine());
        int m = Convert.ToInt32(Console.ReadLine());
        int[,] oblako = new int[n,m];
        Console.WriteLine("Введите элементы массива(по строкам):");
        for (int i = 0; i<n; i++)
        {
            Console.WriteLine("Строка №" + (i+1));
            for (int j = 0; j<m; j++)
            {
                int a = Convert.ToInt32(Console.ReadLine());
                oblako[i,j] = a;
            }
        }
        for (int i = 0; i<n; i++)
        {
            for (int j = 1; j<m-1; j++)
            {
                z=i+1;
                v+=1;
                if ((oblako[i,j-1]-oblako[i,j]==oblako[i,j]-oblako[i,j+1]) && (oblako[i,j-1]-oblako[i,j]>0))
                {
                    w+=1;
                }
            }
            if (v==w)
            {
                Console.WriteLine("Подходящая строка:" + ' ' + z);
            }
            v=0;
            w=0;
        }
    }
}
*/