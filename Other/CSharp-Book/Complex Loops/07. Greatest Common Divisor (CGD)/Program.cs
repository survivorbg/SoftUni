using System;

namespace �������_��_1_��_2_��_�_��_�_for_�����
{
    class Program
    {
        static void Main(string[] args)
        {

            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());

            while (!(b == 0))
            {
                var oldB = b; //16 //8
                b = a % b; //8 //0
                a = oldB; //16 //8
            }
            Console.WriteLine(a);




        }
    }
}
