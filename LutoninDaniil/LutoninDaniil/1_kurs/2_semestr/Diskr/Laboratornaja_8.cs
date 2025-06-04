/*27.03.2025*/
//Волновой алгоритм
/*
using System;
using System.Collections.Generic;
public class Wave
{
    public static int[,] Poisk(int[,] lop, int startX, int startY, int endX, int endY)
    {
        int rir = lop.GetLength(0);
        int uru = lop.GetLength(1);
        int[,] distancija = new int[rir, uru];
        for (int i = 0; i < rir; i++)
        {
            for (int j = 0; j < uru; j++)
            {
                distancija[i, j] = -1;
            }
        }
        distancija[startX, startY] = 0;
        var kurlik = new Queue<(int x, int y)>();
        kurlik.Enqueue((startX, startY));
        int[] dx = { -1, 1, 0, 0 };
        int[] dy = { 0, 0, -1, 1 };
        while (kurlik.Count > 0)
        {
            var (x, y) = kurlik.Dequeue();
            for (int i = 0; i < 4; i++)
            {
                int fx = x + dx[i];
                int fy = y + dy[i];
                if (fx >= 0 && fx < rir && fy >= 0 && fy < uru
                    && lop[fx, fy] != -1 && distancija[fx, fy] == -1)
                {
                    distancija[fx, fy] = distancija[x, y] + 1;
                    kurlik.Enqueue((fx, fy));
                    if (fx == endX && fy == endY)
                    {
                        return distancija;
                    }
                }
            }
        }
        return distancija;
    }
    public static List<(int x, int y)> Menjat(int[,] distancija, int endX, int endY)
    {
        var chast = new List<(int x, int y)>();
        if (distancija[endX, endY] == -1)
        {
            return chast;
        }
        int x = endX, y = endY;
        chast.Add((x, y));
        int[] dx = { -1, 1, 0, 0 };
        int[] dy = { 0, 0, -1, 1 };
        while (distancija[x, y] != 0)
        {
            for (int i = 0; i < 4; i++)
            {
                int fx = x + dx[i];
                int fy = y + dy[i];
                if (fx >= 0 && fx < distancija.GetLength(0)
                    && fy >= 0 && fy < distancija.GetLength(1)
                    && distancija[fx, fy] == distancija[x, y] - 1)
                {
                    x = fx;
                    y = fy;
                    chast.Add((x, y));
                    break;
                }
            }
        }
        chast.Reverse();
        return chast;
    }
}
*/