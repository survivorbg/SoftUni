﻿using System;

namespace _08._Center_Point
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());




            double distance = CalculateD(x1, x2);
            double distance1 = CalculateD(y1, y2);
            if (distance <= distance1)
            {
                Console.WriteLine((x1, x2));

            }
            else
            {
                Console.WriteLine((y1, y2));
            }



            static double CalculateD(double x1, double x2)
            {
                return Math.Sqrt(Math.Pow(0 - x1, 2) + Math.Pow(0 - x2, 2));
            }
        }
    }
}
