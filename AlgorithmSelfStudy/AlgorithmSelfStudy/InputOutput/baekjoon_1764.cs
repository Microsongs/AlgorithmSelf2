using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmSelfStudy.InputOutput
{
    class baekjoon_1764
    {
        static int maxCount = 21;
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] temp = input.Split();

            ArrayList noListenList = new ArrayList();
            //ArrayList noLook = new ArrayList();
            int[] max = new int[maxCount];
            for(int i=0; i < int.Parse(temp[0]); i++)
            {
                noListenList.Add(Console.ReadLine());
            }
            noListenList.Sort();
            string[] noListen = new string[noListenList.Count];
            noListen = (string[])noListenList.ToArray(typeof(string));

            ArrayList noLook = new ArrayList();
            for (int i = 0; i < int.Parse(temp[1]); i++)
            {
                string s = Console.ReadLine();
                if(Array.BinarySearch(noListen,s) >= 0)
                {
                    noLook.Add(s);
                }
            }
            noLook.Sort();
            Console.Write(noLook.Count + "\n");
            foreach(string data in noLook)
            {
                Console.Write(data + "\n");
            }
        }
    }
}
