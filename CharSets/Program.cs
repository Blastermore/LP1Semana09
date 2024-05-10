using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Linq;

namespace CharSets
{
    class Program
    {
        static void Main(string[] args)
        {
            string s;
            HashSet<char> hashSet = new HashSet<char>();
            List<HashSet<char>> list = new List<HashSet<char>>();
            for(int i = 0; i < args.Length; i++)
            {
                string path = Path.Combine("CharSets",args[i]);
                using StreamReader sr = new StreamReader(path);
                while ((s = sr.ReadLine()) != null)
                {
                    if (s.Length >1)
                    {
                        Console.WriteLine("Line Has more than 1 character");
                        return;
                    }
                    else
                    {
                        hashSet.Add(s[0]);
                    }
                }
                list.Add(hashSet);
            }
            HashSet<char>final_set = list[0];
            foreach (HashSet<char> set in list)
                final_set.IntersectWith(set);
        }
    }
}
