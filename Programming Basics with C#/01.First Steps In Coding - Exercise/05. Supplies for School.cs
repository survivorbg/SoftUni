using System;

namespace ����������
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var penCount = int.Parse(Console.ReadLine());
            var markerCount = int.Parse(Console.ReadLine());
            var litersClean = int.Parse(Console.ReadLine());
            var discountPercent = int.Parse(Console.ReadLine());

            //�	����� �������� -5.80 ��.
            //�	����� ������� -7.20 ��.
            //�	�������� - 1.20 ��(�� �����)

            const double penPrice = 5.80;
            const double markerPrice = 7.20;
            const double cleaningPrice = 1.20;

            var price = penCount * penPrice + markerCount * markerPrice + litersClean * cleaningPrice;
            var discount = price * (discountPercent * 0.01);
            Console.WriteLine(price - discount);



        }
    }
}
