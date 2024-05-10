using System;

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

            int [] numbers = new int [] {1, 10, -30, 10, -5}

            foreach (int number in numbers)
                list.Add(number)
                stack.Push(number)
                Queue.Enqueue(number)
                HashSet.Add(number)

            foreach( int i in list)
                Console.WriteLine($"{i}")

            Console.WriteLine("Hello, World!");
        }
    }
}
