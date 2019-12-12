using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmSelfStudy.InputOutput
{
    class Baekjoon_1158_조세피스_순열
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            // 총 개수
            int n = Int32.Parse(input[0]);
            // 위치 개수
            int k = Int32.Parse(input[1]);
            Queue<int> queue = new Queue<int>();

            StringBuilder sb = new StringBuilder();
            sb.Append("<");
            // 큐에 삽입
            for (int i = 0; i < n; i++)
            {
                queue.Enqueue(i + 1);
            }
            // 큐가 비지 않을 동안 반복
            do
            {
                if(queue.Count == 1)
                {
                    sb.Append(queue.Dequeue());
                    break;
                }
                for (int i = 0; i <k-1; i++)
                {
                    queue.Enqueue(queue.Dequeue());
                }
                sb.Append(queue.Dequeue() + ", ");
            } while (queue.Count != 0);
            sb.Append(">");
            Console.Write(sb);
        }
    }
}
