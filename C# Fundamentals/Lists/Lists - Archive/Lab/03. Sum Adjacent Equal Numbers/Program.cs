﻿using System;
using System.Linq;

namespace _03._Sum_Adjacent_Equal_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var list = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToList();

            for (int i = 0; i < list.Count-1; i++)
            {
                if (list[i] == list[i + 1])
                {
                    list[i] += list[i + 1];
                    list.RemoveAt(i + 1);
                    i=-1;
                }
            }
            Console.WriteLine(String.Join(" ",list));





        }
    }
}
