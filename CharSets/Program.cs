using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace CharSets
{
    class Program
    {
        static void Main(string[] args)
        {
            string s;
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
                    Console.WriteLine(s);
                }
            }
        }
    }
}
