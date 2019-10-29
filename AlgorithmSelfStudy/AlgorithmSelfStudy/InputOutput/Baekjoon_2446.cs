using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmSelfStudy.InputOutput
{
    class Baekjoon_2446
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for(int i=0; i<n; i++)
            {
                for(int j=0; j<i; j++)
                {
                    Console.Write(" ");
                }
                for(int j=(n*2)-(i*2)-1; j>0; j--)
                {
                     Console.Write("*");
                }
                Console.Write("\n");
            }
            for(int i = 2; i<=n; i++)
            {
                for(int j=n-i; j>0; j--)
                {
                    Console.Write(" ");
                }
               for(int j=0; j<(i*2)-1; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
        }
    }
}
