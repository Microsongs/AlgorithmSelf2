using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmSelfStudy.STL
{
    class Baekjoon_1406
    {
        static void Main(string[] args)
        {
            // 문자열 입력받아 리스트에 삽입
            string inputData = Console.ReadLine();
            List<char> data = new List<char>();
            foreach(char d in inputData)
            {
                data.Add(d);
            }
            // 횟수
            int tr = int.Parse(Console.ReadLine());

            // 반복하여 명령어 실행
            int currentPoint = data.Count;
            for(int i=0; i<tr; i++)
            {
                String order = Console.ReadLine();
                string []splitOrder = order.Split();
                switch (char.Parse(splitOrder[0]))
                {
                    // currentPoint가 0보다 크면 1감소, 0이면 그대로 0
                    case 'L':
                        // currentPoint = currentPoint > 0 ? currentPoint-- : 0;
                        if (currentPoint > 0)
                            currentPoint--;
                        break;
                    // currentPoint가 data의 크기 이상이면 유지 아니면 1 더함
                    case 'D':
                        //currentPoint = currentPoint >= data.Count ? data.Count : currentPoint++;
                        if (currentPoint < data.Count)
                            currentPoint++;
                        break;
                    case 'B':
                        if (currentPoint > 0)
                            data.RemoveAt(--currentPoint);
                        break;
                    case 'P':
                        data.Insert(currentPoint++, char.Parse(splitOrder[1]));
                        break;
                }
            }
            foreach(char c in data)
            {
                Console.Write(c);
            }
        }
    }
}
