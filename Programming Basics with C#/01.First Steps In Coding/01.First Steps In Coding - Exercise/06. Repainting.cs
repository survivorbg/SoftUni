using System;

namespace ����������
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var nylonNeeded = int.Parse(Console.ReadLine());
            var paintNeeded = int.Parse(Console.ReadLine());
            var mixerNeeded = int.Parse(Console.ReadLine());
            var hoursNeeded = int.Parse(Console.ReadLine());

            //�	��������� ������ -1.50 ��.�� ��. �����
            //�	��� - 14.50 ��.�� �����
            //�	���������� �� ��� - 5.00 ��.�� �����

            var priceMats = (nylonNeeded + 2) * 1.50 + (paintNeeded * 14.50) * 1.10 + mixerNeeded * 5.00 + 0.40;

            var priceWorkers = hoursNeeded * (priceMats * 0.30);
            Console.WriteLine(priceMats + priceWorkers);


        }
    }
}