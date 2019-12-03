using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmSelfStudy.STL
{
    class Baekjoon_1406_2
    {
        static void Main(string[] args)
        {
            String t = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            Stack<string> left = new Stack<string>();
            Stack<string> right = new Stack<string>();
            for (int i = 0; i < t.Length; i++)
                left.Push(t.Substring(i, 1));

            for (int i = 0; i < n; i++)
            {
                string c = Console.ReadLine();
                string[] temp = c.Split();
                switch (temp[0])
                {
                    case "L":
                        if (left.Count != 0)
                            right.Push(left.Pop());
                        break;

                    case "D":
                        if (right.Count != 0)
                            left.Push(right.Pop());
                        break;

                    case "B":
                        if (left.Count != 0)
                            left.Pop();
                        break;
                    case "P":
                        left.Push(temp[1]);
                        break;
                }
            }
            while (left.Count != 0)
                right.Push(left.Pop());
            while (right.Count != 0)
                Console.Write(right.Pop());
        }
    }
}
