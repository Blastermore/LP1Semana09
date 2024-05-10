using System;
using System.Collections.Generic;

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
             foreach( int i in list)
                 Console.WriteLine($"List: {i}");

             foreach( int i in stack)
                 Console.WriteLine($"Stack: {i}");
            
             foreach( int i in queue)
                 Console.WriteLine($"Queue: {i}");
            
             foreach( int i in hashSet)
                 Console.WriteLine($"HashSet: {i}");

        }
    }
}
