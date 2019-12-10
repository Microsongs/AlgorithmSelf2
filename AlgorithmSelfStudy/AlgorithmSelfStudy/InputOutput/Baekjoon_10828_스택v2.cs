using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmSelfStudy.InputOutput
{
    class Baekjoon_10828_스택v2
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            int n = int.Parse(Console.ReadLine());
            for(int i=0; i<n; i++)
            {
                string input = Console.ReadLine();
                string[] order = input.Split();
                switch (order[0])
                {
                    case "push":
                        stack.Push(int.Parse(order[1]));
                        break;
                    case "top":
                        Console.Write(stack.Count == 0 ? "-1\n" : stack.Peek() + "\n");
                        break;
                    case "size":
                        Console.Write(stack.Count+"\n");
                        break;
                    case "empty":
                        Console.Write(stack.Count == 0 ? "1\n" : "0\n");
                        break;
                    case "pop":
                        Console.Write(stack.Count == 0 ? "-1\n" : stack.Pop() + "\n");
                        break;
                }
            }
        }
    }
}
