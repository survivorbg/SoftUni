﻿using System;

namespace _10._Clock___part_2
{
    internal class Program
    {
        static void Main(string[] args)
        {


            for (int hour = 0; hour < 24; hour++)
            {
                for (int min = 0; min < 60; min++)
                {
                    for (int sec = 0; sec < 60; sec++)
                    {
                        Console.WriteLine($"{hour} : {min} : {sec}");
                    }
                }
            }













        }
    }
}
