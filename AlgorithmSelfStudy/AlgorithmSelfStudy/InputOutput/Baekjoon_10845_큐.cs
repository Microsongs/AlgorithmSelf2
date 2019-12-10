using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmSelfStudy.InputOutput
{
    class Baekjoon_10845_큐
    {
        static void Main(string[] args)
        {
            // 큐 배열
            int []queue = new int[10001];
            // 입력받는 정수
            int n = Int32.Parse(Console.ReadLine());
            // 큐의 앞, 뒤
            int front = 0, rear = 0;
            // 명령어 변수
            string[] order;
            // 출력 저장 변수
            StringBuilder sb = new StringBuilder();
            for(int i=0; i<n; i++)
            {
                order = Console.ReadLine().Split();
                switch (order[0])
                {
                    case "push":
                        queue[rear++] = Int32.Parse(order[1]);
                        break;
                    case "pop":
                        sb.Append((rear - front == 0) ? "-1\n" : queue[front++]+"\n");
                        break;
                    // rear - front만큼이 사이즈
                    case "size":
                        sb.Append(rear - front+"\n");
                        break;
                    // rear와 front가 같으면 1 아니면 0
                    case "empty":
                        sb.Append((rear - front == 0) ? "1\n" : "0\n");
                        break;
                        // rear == front이면 정수가 없으므로 -1, 아니면 front의 정수 출력
                    case "front":
                        sb.Append((rear - front == 0) ? "-1\n" : queue[front] + "\n");
                        break;
                        // rear == front이면 정수가 없으므로 -1, 아니면 rear의 정수 출력
                    case "back":
                        sb.Append((rear - front == 0) ? "-1\n" : queue[rear-1] + "\n");
                        break;
                }
            }
            Console.Write(sb);
        }
    }
}
