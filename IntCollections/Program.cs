using System;
using System.Collections.Generic;
using System.Linq;

namespace IntCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            Stack<int> stack = new Stack<int>();
            Queue<int> queue = new Queue<int>();
            HashSet<int> hashSet = new HashSet<int>();

            int [] numbers = new int [] {1, 10, -30, 10, -5};

            foreach (int number in numbers)
            {
                list.Add(number);
                stack.Push(number);
                queue.Enqueue(number);
                hashSet.Add(number);
            }
            Console.WriteLine(PrintList("List", list));

            Console.WriteLine(PrintStack("Stack", stack));
            
            Console.WriteLine(PrintQueue("Queue", queue));
            
            Console.WriteLine(PrintList("HashSet", hashSet));

        }
        public static string PrintList(string type, IEnumerable<int> collection)
        {
            string s = $"{type}: ";
            int index = 0;
            int count = collection.Count();
            foreach (int number in collection )
            {
                if (index == (count -1))
                {
                    s += $"{number}";
                }
                else
                {
                    s += $"{number}, ";
                }
                index++;
            }
            return s;
        }
        public static string PrintStack(string type, Stack<int> collection)
        {
            string s = $"{type}: ";
            int count = collection.Count;
            for(int i = 0; i < count; i++)
            {
                s += collection.Pop();
                if ( i < count -1)
                {
                    s += ", ";
                }
            }
            return s;
        }
        public static string PrintQueue(string type, Queue<int> collection)
        {
            string s = $"{type}: ";
            int count = collection.Count;
            for(int i = 0; i < count; i++)
            {
                s += collection.Dequeue();
                if ( i < count -1)
                {
                    s += ", ";
                }
            }
            return s;
        }
    }
}
