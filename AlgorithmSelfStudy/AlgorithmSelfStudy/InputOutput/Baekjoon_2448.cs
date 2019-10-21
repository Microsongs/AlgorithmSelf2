using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmSelfStudy.InputOutput
{
    class Baekjoon_2448
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for(int i=0; i<n; i++)
            {
                for (int j = n - i-1; j > 0; j--)
                {
                    Console.Write(" ");
                }
                for(int j=0; j<(i*2)+1; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
            
            for(int i=n-1; i>0; i--)
            {
                for(int j=i;j < n; j++)
                {
                    Console.Write(" ");
                }
                for(int j=0; j<i*2-1; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
            
        }
    }
}
