using System;

namespace Training
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var budget = double.Parse(Console.ReadLine());
            var graphicCardCount = int.Parse(Console.ReadLine());
            var processorCount = int.Parse(Console.ReadLine());
            var ramCount = int.Parse(Console.ReadLine());

            //�	���������� � 250 ��./ ��.
            //�	�������� � 35 % �� ������ �� ���������� ����������/ ��.
            //�	��� ����� � 10 % �� ������ �� ���������� ����������/ ��.

            //��� ���� �� ������������
            //� ��-����� �� ���� �� ����������� ��������
            //15% �������� �� �������� ������


            const double gCost = 250;

            var gTotalCost = graphicCardCount * gCost;
            var pTotalCost = (gTotalCost * 0.35) * processorCount;
            var rTotalCost = (gTotalCost * 0.10) * ramCount;

            var totalCost = gTotalCost + pTotalCost + rTotalCost;


            if (graphicCardCount > processorCount)
            {
                totalCost *= 0.85;
            }
            if (budget >= totalCost)
            {
                Console.WriteLine($"You have {String.Format("{0:0.00}", (budget - totalCost))} leva left!");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {String.Format("{0:0.00}", (totalCost - budget))} leva more!");

            }









        }
    }
}
