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
            List<HashSet<char>> list = new List<HashSet<char>>();
            for(int i = 0; i < args.Length; i++)
            {
                HashSet<char> hashSetTemp = new HashSet<char>();
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
                        hashSetTemp.Add(s[0]);
                    }
                }
                list.Add(hashSetTemp);
            }

            foreach (HashSet<char> set in list)
                list[0].IntersectWith(set);
            List<char> processed_final_set= list[0].ToList();
            processed_final_set.Sort();
            foreach(char c in processed_final_set)
            {
                Console.WriteLine(c);
            }
        }
    }
}
