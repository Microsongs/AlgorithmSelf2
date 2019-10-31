using System;
using System.Collections.Generic;
using System.Text;

/*
정수 X가 주어진다. 정수 X는 항상 8진수, 10진수, 16진수 중에 하나이다.

8진수인 경우에는 수의 앞에 0이 주어지고, 16진수인 경우에는 0x가 주어진다.

X를 10진수로 바꿔서 출력하는 프로그램을 작성하시오.
*/
namespace AlgorithmSelfStudy.STL
{
    class Baekjoon_11816
    {
        static int Pow(int num, int pw)
        {
            int result = 1;
            for(int i=0; i<pw; i++)
            {
                result *= num;
            }
            return result;
        }
        static void Main(string[] args)
        {
            string splitNum = Console.ReadLine();
            int result = 0;
            // 8진수나 16진수일 경우
            if (splitNum[0].Equals('0'))
            {
                int cipher = 0; // 자릿수
                // 16진수일 경우
                if (splitNum[1].Equals('x'))
                {
                    for (int i = splitNum.Length - 1; i > 1; i--, cipher++)
                    {
                        int temp = splitNum[i];
                        temp = (temp < 'a') ? temp - '0' : temp - 'a' + 10;
                        result += (int)(temp) * (int)(Math.Pow(16, cipher));
                    }
                }
                // 8진수일 경우
                else
                {
                    for (int i = splitNum.Length - 1; i > 0; i--, cipher++)
                        result += (int)(splitNum[i] - '0') * (int)(Math.Pow(8, cipher));
                }
            }
            else
                result = int.Parse(splitNum);

            Console.WriteLine(result);
        }
    }
}
