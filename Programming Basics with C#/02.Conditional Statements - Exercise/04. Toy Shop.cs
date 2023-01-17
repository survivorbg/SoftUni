using System;

namespace Training
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var holidayCost = double.Parse(Console.ReadLine());
            var puzzleCount = int.Parse(Console.ReadLine());
            var dollCount = int.Parse(Console.ReadLine());
            var bearCount = int.Parse(Console.ReadLine());
            var minionCount = int.Parse(Console.ReadLine());
            var truckCount = int.Parse(Console.ReadLine());


            //���� �� ���������:
            //�	����� - 2.60 ��.
            //�	�������� ����� -3 ��.
            //�	������� ���� -4.10 ��.
            //�	������ - 8.20 ��.
            //�	�������� - 2 ��.

            //50 ��� ������ ������� --> 25% �� ������ ����
            //10% �� ������ �� ���� 
            var totalCost = puzzleCount * 2.60 + dollCount * 3.00 + bearCount * 4.10
                + minionCount * 8.20 + truckCount * 2.00;
            if (puzzleCount + dollCount + bearCount + minionCount + truckCount >= 50)
            {
                totalCost *= 0.75;
            }
            totalCost -= totalCost * 0.10;
            if (totalCost >= holidayCost)
            {
                Console.WriteLine($"Yes! {String.Format("{0:0.00}", totalCost - holidayCost)} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {String.Format("{0:0.00}", holidayCost - totalCost)} lv needed.");
            }


        }
    }
}
