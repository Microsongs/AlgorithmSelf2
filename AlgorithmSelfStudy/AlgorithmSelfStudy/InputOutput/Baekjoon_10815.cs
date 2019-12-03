using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmSelfStudy.InputOutput
{
    class Baekjoon_10815
    {
        static int max = 20000003;
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());  // 내 카드의 카운트
            string[] temp = new string[count];  // 내 카드들의 임시배열
            int[] card = new int[max];              // 내 카드들의 배열

            string input = Console.ReadLine();  // 카드들을 입력받는 변수
            temp = input.Split();                       // 임시배열에 삽입 

            for(int i=0; i<count; i++)
            {
                card[int.Parse(temp[i]) + max / 2]++;
            }

            int yourCount = int.Parse(Console.ReadLine());  // 상대의 카드 개수를 입력

            input = Console.ReadLine(); // 상대의 카드들을 입력
            
            // 입력받은 카드들을 분리
            string []temp2 = new string[yourCount];           
            temp2 = input.Split();

            StringBuilder result = new StringBuilder();   // 결과를 출력할 변수 result
            int n;  //result에 더할 임시변수

            for(int i=0; i<yourCount; i++)
            {
                if (card[int.Parse(temp2[i])+(max/2)] == 1)
                    result.Append("1 ");
                else
                    result.Append("0 ");
            }
            Console.Write(result);
        }
    }
}
