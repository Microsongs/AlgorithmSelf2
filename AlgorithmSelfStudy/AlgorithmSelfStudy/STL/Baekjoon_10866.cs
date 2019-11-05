using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmSelfStudy.STL
{
    class Baekjoon_10866
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];

            int loc = 0;
            for(int i=0; i<n; i++)
            {
                string temp = Console.ReadLine();
                string[] data = temp.Split();
                if (data[0].Equals("push_front"))
                {
                    for(int j = loc - 1; j >=0; j--)
                    {
                        arr[j + 1] = arr[j];
                    }
                    arr[0] = int.Parse(data[1]);
                    loc++;
                }
                else if (data[0].Equals("push_back"))
                {
                    arr[loc] = int.Parse(data[1]);
                    loc++;
                }
                else if (data[0].Equals("pop_front"))
                {
                    if (loc != 0)
                    {
                        Console.WriteLine(arr[0]);
                        for(int j=0; j<loc-1; j++)
                        {
                            arr[j] = arr[j + 1];
                        }
                        loc--;
                    }
                    else
                        Console.WriteLine("-1");
                }
                else if (data[0].Equals("pop_back"))
                {
                    if (loc != 0)
                    {
                        Console.WriteLine(arr[loc - 1]);
                        loc--;
                    }
                    else
                        Console.WriteLine("-1");
                }
                else if (data[0].Equals("size"))
                {
                    Console.WriteLine(loc);
                }
                else if (data[0].Equals("empty"))
                {
                    if (loc == 0)
                        Console.WriteLine("1");
                    else
                        Console.WriteLine("0");
                }
                else if (data[0].Equals("front"))
                {
                    if (loc != 0)
                        Console.WriteLine(arr[0]);
                    else
                        Console.WriteLine("-1");
                }
                else if (data[0].Equals("back"))
                {
                    if (loc != 0)
                        Console.WriteLine(arr[loc - 1]);
                    else
                        Console.WriteLine("-1");
                }
            }
        }
    }
}
