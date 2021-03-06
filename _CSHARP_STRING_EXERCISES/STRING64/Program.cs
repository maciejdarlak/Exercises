﻿using System;
using System.Text;

namespace STRING64 //How to find all possible substring of a given string?
{
    class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            Console.WriteLine("Pls write a string.");
            string str = Console.ReadLine();
            a.AllSubstrings(str);
            Console.WriteLine();
        }

        public class A
        {
            public void AllSubstrings(string str)
            {
                for (int i = 0; i < str.Length; i++) // 1st turn: d
                {
                    StringBuilder subString = new StringBuilder(str.Length - i); //Max. capacity of the StringBuilder object (e.g. "dog" is 3 (3 - 0), then 2 etc)

                    for (int j = i; j < str.Length; j++) //d do dog
                    {
                        subString.Append(str[j]); //3 first turns: d + 0, d + o, do + g
                        Console.Write(subString + " ");
                    }
                }
            }
        }
    }
}
