﻿using System;

namespace _07._Safe_Passwords_Generator
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int maxPasswords = int.Parse(Console.ReadLine());
            int count = 0;
            int A = 35;
            int B = 64;

            for (int x = 1; x <= a; x++)
            {
                for (int y = 1; y <= b; y++)
                {
                    Console.Write($"{(char)A}{(char)B}{x}{y}{(char)B}{(char)A}|");
                    count++;
                    if (count == maxPasswords)
                    {
                        return;
                    }
                    A++;
                    B++;
                    if (A > 55)
                    {
                        A = 35;
                    }
                    if (B > 96)
                    {
                        B = 64;
                    }
                }
            }
        }
    }
}
