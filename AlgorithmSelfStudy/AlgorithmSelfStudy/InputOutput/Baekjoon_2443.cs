using System;
using System.Collections.Generic;
using System.Text;

/*
첫째 줄에는 별 2×N-1개, 둘째 줄에는 별 2×N-3개, ..., N번째 줄에는 별 1개를 찍는 문제

별은 가운데를 기준으로 대칭이어야 한다.
 */

namespace AlgorithmSelfStudy.InputOutput
{
    class Baekjoon_2443
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for(int i = n; i>0; i--)
            {
                for(int j = 0; j<n-i; j++)
                {
                    Console.Write(" ");
                }
                for(int j=0; j<(i*2)-1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
