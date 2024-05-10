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
            int i = 0;
            string s;
            using StreamReader sr = new StreamReader("CharSets/"+args[i]);
            while ((s = sr.ReadLine()) != null)
            {
                Console.WriteLine(s);
            }
        }
    }
}
