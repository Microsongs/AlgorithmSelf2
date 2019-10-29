using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmSelfStudy.InputOutput
{
    class Baekjoon_10992
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for(int i=0; i<n; i++)
            {
                for (int j = n - i-1; j > 0; j--)
                   Console.Write(" ");
                for(int j=0; j<=i*2; j++)
                {
                    if (j == 0 || j == i * 2)
                        Console.Write("*");
                    else if (i == n-1)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.Write("\n");
            }
        }
    }
}
