using System;
using System.Collections.Generic;
using System.Text;

/*
문제
N개의 정수가 주어진다. 이때, N개의 정수를 오름차순으로 정렬하는 프로그램을 작성하시오. 같은 정수는 한 번만 출력한다.

입력
첫째 줄에 수의 개수 N (1 ≤ N ≤ 100,000)이 주어진다. 둘째에는 숫자가 주어진다. 이 수는 절댓값이 1,000보다 작거나 같은 정수이다.

출력
첫째 줄에 수를 오름차순으로 정렬한 결과를 출력한다. 이때, 같은 수는 한 번만 출력한다.
*/

namespace AlgorithmSelfStudy.STL
{
    class Baekjoon_10867
    {
        static int MAX = 2003;
        static void Main(string[] args)
        {
            int  len = int.Parse(Console.ReadLine());
            int[] arr = new int[MAX];
            // 숫자 입력
            String input = Console.ReadLine();
            String[] temp = input.Split();
            for(int i=0; i<len; i++)
            {
                arr[int.Parse(temp[i])+(MAX/2)]++;
            }
            for(int i=0; i<MAX; i++)
            {
                if (arr[i] != 0)
                    Console.Write("{0} ", i - (MAX/2));
            }
        }
    }
}
