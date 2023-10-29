using System;

namespace SmurfasticFibo.Fundamentals;

public static class DebugMe
{
    public static long Tribonacci(ushort nb)
    {
        long n = 0;
        long n1 = 1;
        long n2 = 1;

        uint i = 1;
        while (i <= nb)
        {
            long temp = n + n1 + n2;
            n = n1;
            n1 = n2;
            n2 = temp;
            i++;
        }

        return n;
    }

    public static int Atoi(string str)
    {
        int n = str.Length;
        int res = 0;
        int i = 0;
        bool neg = str[0] == '-';
        if (neg)
            i++;

        char c;
        while (i < n && (c = str[i]) >= '0' && c <= '9')
        {
            res = (res * 10) + (c - '0');
            i++;
        }

        return neg ? -res : res;
    }

    public static string Pyramid(ulong height, char block)
    {
        string res = "";

        for (ulong i = 0; i < height; i++)
        {
            for (ulong j = 0; j < height - i - 1; j++)
            {
                res += ' ';
            }

            for (ulong k = 0; k < 2 * i + 1; k++)
            {
                res += block;
            }

            for (ulong j = 0; j < height - i - 1; j++)
            {
                res += ' ';
            }
            
            res += '\n';
        }

        return res;
    }
}