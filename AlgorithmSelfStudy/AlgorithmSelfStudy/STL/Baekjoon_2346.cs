﻿using System;
using System.Collections.Generic;
using System.Text;

/*
문제
N개의 풍선이 있다. 각 풍선 안에는 -N부터 N까지의 수가 적혀있는 종이가 들어 있다. 이 풍선들을 다음과 같은 규칙으로 터뜨린다.

우선, 제일 처음에는 1번 풍선을 터뜨린다. 다음에는 풍선 안에 있는 종이를 꺼내어 그 종이에 적혀있는 값만큼 이동하여 다음 풍선을 터뜨린다. 양수가 적혀 있을 경우에는 오른쪽으로, 음수가 적혀 있을 때는 왼쪽으로 이동한다. 풍선은 원형으로 놓여 있다고 생각한다. 즉, 1번 풍선의 왼쪽에 N번 풍선이 있고, N번 풍선의 오른쪽에 1번 풍선이 있는 것이다. 이동할 때에는 이미 터진 풍선은 빼고 생각한다.

예를 들어 다섯 개의 풍선 안에 차례로 3, 2, 1, -3, -1이 적혀 있었다고 하자. 이 경우 3이 적혀 있는 1번 풍선, -3이 적혀 있는 4번 풍선, -1이 적혀 있는 5번 풍선, 1이 적혀 있는 3번 풍선, 2가 적혀 있는 2번 풍선의 순서대로 터지게 된다.

입력
첫째 줄에 자연수 N(1≤N≤1,000)이 주어진다. 다음 줄에는 차례로 각 풍선 안의 종이에 적혀 있는 수가 주어진다. 편의상 0은 적혀있지 않다고 가정하자. 
*/

namespace AlgorithmSelfStudy.STL
{
    class Baekjoon_2346
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<List<int>> arr = new List<List<int>>();

            // 배열 내 데이터 삽입
            String data = Console.ReadLine();
            String[] temp = data.Split();
            for(int i=0; i<n; i++)
            {
                arr.Add(new List<int>());
            }
            for(int i=0; i<n; i++)
            {
                arr[0].Add(int.Parse(temp[i]));
                arr[1].Add(i + 1);
            }

            // 풍선 처리

            int pos = 0;
            int copyN = n;
            for(int i=0; i<copyN; i++) {
                Console.Write("{0} ", arr[1][pos]);
                int move = arr[0][pos];
                if (move > 0)
                    move--;
                arr[0].RemoveAt(pos);
                arr[1].RemoveAt(pos);
                pos += move;
                if (--n == 0)
                    break;
                pos = (pos >= 0 ? pos : n + pos % n);
                pos %= n;
            }
        }
    }
}
