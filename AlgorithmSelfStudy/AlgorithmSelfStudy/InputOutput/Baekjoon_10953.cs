using System;
/*
Question
두 정수 A와 B를 입력받은 다음 A+B를 출력하는 프로그램을 작성

*/

namespace AlgorithmSelfStudy
{
    class Baekjoon_10953
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            int i = 0;
            while(i++ < count)
            {
                string data = Console.ReadLine();
                string []number = data.Split(',');
                Console.WriteLine(int.Parse(number[0]) + int.Parse(number[1]));
            }
        }
    }
}
