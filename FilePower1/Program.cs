﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace FilePower1
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = Path.Combine(args[0]);
            string s = "Yipee";
            string contents = "";
            Queue<string> queue = new Queue<string>();
            while (s != "")
            {
                s = Console.ReadLine();
                if(s =="")
                {
                    break;
                }
                else
                {
                    queue.Enqueue(s);
                }
            }
            foreach(string element in queue)
            {
                contents += $"{element}\n";
            }

            File.WriteAllText(path, contents);
        }
    }
}
