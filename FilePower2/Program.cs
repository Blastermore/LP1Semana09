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
            string content = null;

            using StreamWriter sw = new StreamWriter(args[0]);
            
            while ((content = Console.ReadLine()) != "")
            {
                sw.WriteLine(content);
            }
        }
    }
}

