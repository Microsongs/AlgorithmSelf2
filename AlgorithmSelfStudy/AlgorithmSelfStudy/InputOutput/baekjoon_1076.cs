using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmSelfStudy.InputOutput
{
    class baekjoon_1076
    {
        static long pow(long n)
        {
            long number = 1;
            for(int i=0; i<n; i++)
            {
                number *= 10;
            }
            return number;
        }
        static int MAX = 3;
        static void Main(string[] args)
        {
            string[] input = new string[MAX];
            long result = 0;     //결과값
            long tempNum = 0;    //임시값

            // 단어 입력받음
            for(int i=0; i<MAX; i++)
            {
                input[i] = Console.ReadLine();
            }

            for(int order=0; order<MAX; order++)
            {
                switch (input[order])
                {
                    case "black":
                        tempNum = 0;
                        break;
                    case "brown":
                        tempNum = 1;
                        break;
                    case "red":
                        tempNum = 2;
                        break;
                    case "orange":
                        tempNum = 3;
                        break;
                    case "yellow":
                        tempNum = 4;
                        break;
                    case "green":
                        tempNum = 5;
                        break;
                    case "blue":
                        tempNum = 6;
                        break;
                    case "violet":
                        tempNum = 7;
                        break;
                    case "grey":
                        tempNum = 8;
                        break;
                    case "white":
                        tempNum = 9;
                        break;
                }
                if (order == 0)
                    result += (tempNum) * 10;
                else if (order == 1)
                    result += tempNum;
                else
                    result *= pow(tempNum);

                tempNum = 0;
            }
            Console.Write(result);
        }
    }
}
