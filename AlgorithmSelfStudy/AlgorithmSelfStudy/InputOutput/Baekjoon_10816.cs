using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmSelfStudy.InputOutput
{
    class Baekjoon_10816
    {
        static int MAX = 20000003;
        static void Main(string[] args)
        {
            // 설정할 카드의 개수 n
            int n = int.Parse(Console.ReadLine());
            int[] myArr = new int[MAX];

            string temp = Console.ReadLine();
            string[] tempArr = temp.Split();

            for(int i=0; i<n; i++)
            {
                myArr[int.Parse(tempArr[i]) + (MAX / 2)]++;
            }
            StringBuilder sb = new StringBuilder();

            // 맞출 카드의 개수
            int m = int.Parse(Console.ReadLine());

            string yourTemp = Console.ReadLine();
            string []yourTempArr = yourTemp.Split();

            for(int i=0; i<m; i++)
            {
                sb.Append(myArr[int.Parse(yourTempArr[i]) + MAX / 2]+ " ");
            }

            Console.Write(sb);
        }
    }
}
