using System;
using System.Collections.Generic;
using System.Text;

/*
문제
예제를 보고 규칙을 유추한 뒤에 별을 찍어 보세요.

입력
첫째 줄에 N(1 ≤ N ≤ 100)이 주어진다.

출력
첫째 줄부터 2×N-1번째 줄까지 차례대로 별을 출력한다.
*/

namespace AlgorithmSelfStudy.InputOutput
{
    class Baekjoon_2445
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for(int i=0;i<n; i++)
            {
                // 선두 별
                for(int j=0; j<=i; j++)
                {
                    Console.Write("*");
                }
                // 띄어쓰기
                for(int j=(n-i-1)*2; j>0; j--)
                {
                    Console.Write(" ");
                }
                // 뒷별
                for(int j=0; j<=i; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
            //하위
            for(int i=n-1; i>0; i--) {
                //앞별
                for (int j = 0; j < i; j++)
                    Console.Write("*");
                //띄어쓰기
                for(int j=(n - i)*2; j>0; j--)
                    Console.Write(" ");
                //뒷별
                for (int j = 0; j < i; j++)
                    Console.Write("*");
                Console.Write("\n");
            }
        }
    }
}
