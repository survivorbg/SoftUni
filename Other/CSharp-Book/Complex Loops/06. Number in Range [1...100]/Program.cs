using System;

namespace �������_��_1_��_2_��_�_��_�_for_�����
{
    class Program
    {
        static void Main(string[] args)
        {


            var n = -1;
            while (true)
            {

                try
                {
                    n = int.Parse(Console.ReadLine());
                    if (n >= 1 && n <= 100)
                    {
                        Console.WriteLine($"The number is: {n}");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid number!");
                    }
                }
                catch (Exception e)
                {

                    Console.WriteLine(e.Message);
                    Console.WriteLine("Try again: ");
                }

            }




        }
    }
}
