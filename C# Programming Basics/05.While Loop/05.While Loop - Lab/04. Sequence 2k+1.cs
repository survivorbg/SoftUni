using System;

namespace ������_�����_2�_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var x = 1;
            while (x <= n)
            {
                Console.WriteLine(x);
                x = 2 * x + 1;
            }
        }
    }
}
