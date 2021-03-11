using System;

namespace Picknum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = Func();
            for (int i = 0; i < 99; i++)
            {
                if (a[i] != 0)
                {
                    Console.WriteLine(a[i]);
                }
            }
        }

        static int[] Func()
        {
            int[] prime = new int[101];
            for(int i = 2; i < 101; i++)
            {
                prime[i] = i;
            }
            for(int i = 2; i < 99; i++)
            {
                for(int j = 2; i*j <= 100; j++)
                {
                    prime[i * j] = 0;
                }
            }
            return prime;
        }

    }
}
