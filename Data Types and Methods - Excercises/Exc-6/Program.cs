﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//
//Strings and Objects
//
namespace Exc_6
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "Hello";
            string str2 = "World";
            object obj = str1 + " " + str2;
            string str3 = (string)obj;
            Console.WriteLine(str3);
        }
    }
}
