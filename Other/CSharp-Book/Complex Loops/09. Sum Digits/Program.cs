using System;

namespace �������_��_1_��_2_��_�_��_�_for_�����
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = int.Parse(Console.ReadLine());
            var sum = 0;
            while (x > 0)
            {
                sum += x % 10;

                x = x / 10;

            }
            Console.WriteLine(sum);
        }
    }
}