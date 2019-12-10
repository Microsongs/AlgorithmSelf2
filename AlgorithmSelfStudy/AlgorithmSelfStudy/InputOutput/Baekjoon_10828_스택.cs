using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmSelfStudy.InputOutput
{
    class Baekjoon_10828_스택
    {
        // 스택 배열
        static int[] st;
        static int top;

        static void Main(string[] args)
        {
            st = new int[100001];
            top = 0;
            int n = int.Parse(Console.ReadLine());
            string []order;
            StringBuilder sb = new StringBuilder();
            for(int i=0; i<n; i++)
            {
                // 명령어
                order = Console.ReadLine().Split();
                switch (order[0])
                {
                    case "push":
                        st[top++] = int.Parse(order[1]);
                        break;
                    case "pop":
                        //Console.Write(top != 0 ? st[--top]+"\n" : "-1\n");
                        sb.Append(top != 0 ? st[--top] + "\n" : "-1\n");
                        break;
                    case "size":
                        //Console.Write(top + "\n");
                        sb.Append(top + "\n");
                        break;
                    case "empty":
                        //Console.Write(top != 0 ? "0\n" : "1\n");
                        sb.Append(top != 0 ? "0\n" : "1\n");
                        break;
                    case "top":
                        //Console.Write(top != 0 ? st[top - 1] + "\n" : "-1\n");
                        sb.Append(top != 0 ? st[top - 1] + "\n" : "-1\n");
                        break;
                }
            }
            Console.Write(sb);
        }
    }
}
