using System;

namespace Training
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var magnolias = int.Parse(Console.ReadLine());
            var hyacinth = int.Parse(Console.ReadLine());
            var roses = int.Parse(Console.ReadLine());
            var cactuses = int.Parse(Console.ReadLine());
            var giftPrice = double.Parse(Console.ReadLine());

            //�	�������� � 3.25 ����
            //�	������� � 4 ����
            //�	���� � 3.50 ����
            //�	������� � 8 ����
            // 5% danyci ot obshtata suma
            var finalPrice = (magnolias * 3.25 + hyacinth * 4 + roses * 3.50 + cactuses * 8) * 0.95;
            if (finalPrice >= giftPrice)
            {
                Console.WriteLine("She is left with {0} leva.", Math.Floor(finalPrice - giftPrice));
            }
            else
            {
                Console.WriteLine("She will have to borrow {0} leva.", Math.Ceiling(giftPrice - finalPrice));
            }

        }
    }
}
