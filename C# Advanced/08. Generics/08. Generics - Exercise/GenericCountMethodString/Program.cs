﻿namespace GenericCountMethodString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            Box<string> box = new Box<string>();
            for (int i = 0; i < n; i++)
            {
                box.AddElement(Console.ReadLine());
            }
            var input = Console.ReadLine();
            Console.WriteLine(box.CountGreater(input));
        }
    }
}