using System;

namespace �������_��_1_��_2_��_�_��_�_for_�����
{
    class Program
    {
        static void Main(string[] args)
        {

            var x = int.Parse(Console.ReadLine());
            //fact = 1 * 2 * 3 * 4 * 5
            var fact = 1;
            while (x >= 1)
            {
                fact *= x;
                x--;
            }
            Console.WriteLine(fact);



        }
    }
}
