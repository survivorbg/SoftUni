using System;

namespace ����������
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var deposit = double.Parse(Console.ReadLine());
            var months = int.Parse(Console.ReadLine());
            var percent = double.Parse(Console.ReadLine());

            //���� = ���������� ����  + ���� �� �������� * ((���������� ���� * ������� ������ ������� ) / 12)
            var finalSum = deposit + months * ((deposit * percent * 0.01) / 12);
            Console.WriteLine(finalSum);




        }
    }
}
