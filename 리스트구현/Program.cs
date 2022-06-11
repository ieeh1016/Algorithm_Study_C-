using System;
using System.Collections.Generic;

namespace CSharp
{
    class Program
    {
        class Monster
        {
            public Monster (int id) { this.id = id; }
            public int id;

        }
        static void Main(string[] args)
        {
            Board board = new Board();
            board.Initialize();


            int[] arr = new int[5]; // 배열 생성

            List<int> list = new List<int>(); //리스트생성
            List<int> list2 = new List<int>();
            for (int i=0; i<5; i++)  
            {
                list.Add(i);
            }
            list.Insert(2, 11000); // 삽입
            list.RemoveAt(2);
            list.Clear();
            for (int i=0; i<list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
            Dictionary<int, Monster> dic = new Dictionary<int, Monster>();
            for(int i=0; i<10000; i++)
            {
                dic.Add(i, new Monster(i));
            }   

            Monster mon;
            bool found = dic.TryGetValue(7777, out mon);

            dic.Remove(7777);
            dic.Clear();

        }
    }
}
