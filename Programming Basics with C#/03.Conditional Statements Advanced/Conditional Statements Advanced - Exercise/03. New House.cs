using System;

namespace ���_���
{
    class Program
    {
        static void Main(string[] args)
        {/*
          * �����	����	�����	����	������	��������
            ���� 	 5	     3.80	2.80	  3	      2.50

            �	��� ���� ���� ������ �� 80 ���� - 10 % �������� �� �������� ����
            �	��� ���� ���� ������ �� 90  ����� - 15 % �������� �� �������� ����
            �	��� ���� ���� ������ �� 80 ������ - 15 % �������� �� �������� ����
            �	��� ���� ���� ��-����� �� 120 ������� - ������ �� �������� � 15 %
            �	��� ���� ���� ��-����� �� 80 �������� - ������ �� �������� � 20 %
            */
            var typeFlower = Console.ReadLine(); //��� �����
            var countFlower = int.Parse(Console.ReadLine()); //������ �����                        
            var budget = int.Parse(Console.ReadLine()); //������� �� ���
            var price = 0.00;
            var discount = 0.00;
            var finalPrice = 0.00;
            var priceIncrease = 0.00;

            if (typeFlower == "Roses" && countFlower > 80)
            {
                price = countFlower * 5.00;
                discount = 0.10 * price;
                finalPrice = price - discount;
                if (budget >= finalPrice)
                {
                    Console.WriteLine("Hey, you have a great garden with " + countFlower + " " + typeFlower + " and " + String.Format("{0:0.00}", (budget - finalPrice)) + " leva left.");
                }
                else
                {
                    Console.WriteLine("Not enough money, you need " + String.Format("{0:0.00}", (finalPrice - budget)) + " leva more.");
                }
            }
            else if (typeFlower == "Roses" && countFlower <= 80)
            {
                finalPrice = countFlower * 5.00;
                if (budget >= finalPrice)
                {
                    Console.WriteLine("Hey, you have a great garden with " + countFlower + " " + typeFlower + " and " + String.Format("{0:0.00}", (budget - finalPrice)) + " leva left.");
                }
                else
                {
                    Console.WriteLine("Not enough money, you need " + String.Format("{0:0.00}", (finalPrice - budget)) + " leva more.");
                }
            }




            else if (typeFlower == "Dahlias" && countFlower > 90)
            {
                price = countFlower * 3.80;
                discount = 0.15 * price;
                finalPrice = price - discount;
                if (budget >= finalPrice)
                {
                    Console.WriteLine("Hey, you have a great garden with " + countFlower + " " + typeFlower + " and " + String.Format("{0:0.00}", (budget - finalPrice)) + " leva left.");
                }
                else
                {
                    Console.WriteLine("Not enough money, you need " + String.Format("{0:0.00}", (finalPrice - budget)) + " leva more.");
                }
            }
            else if (typeFlower == "Dahlias" && countFlower <= 90)
            {
                finalPrice = countFlower * 3.80;
                if (budget >= finalPrice)
                {
                    Console.WriteLine("Hey, you have a great garden with " + countFlower + " " + typeFlower + " and " + String.Format("{0:0.00}", (budget - finalPrice)) + " leva left.");
                }
                else
                {
                    Console.WriteLine("Not enough money, you need " + String.Format("{0:0.00}", (finalPrice - budget)) + " leva more.");
                }
            }



            else if (typeFlower == "Tulips" && countFlower > 80)
            {
                price = countFlower * 2.80;
                discount = 0.15 * price;
                finalPrice = price - discount;
                if (budget >= finalPrice)
                {
                    Console.WriteLine("Hey, you have a great garden with " + countFlower + " " + typeFlower + " and " + String.Format("{0:0.00}", (budget - finalPrice)) + " leva left.");
                }
                else
                {
                    Console.WriteLine("Not enough money, you need " + String.Format("{0:0.00}", (finalPrice - budget)) + " leva more.");
                }
            }
            else if (typeFlower == "Tulips" && countFlower <= 80)
            {
                finalPrice = countFlower * 2.80;
                if (budget >= finalPrice)
                {
                    Console.WriteLine("Hey, you have a great garden with " + countFlower + " " + typeFlower + " and " + String.Format("{0:0.00}", (budget - finalPrice)) + " leva left.");
                }
                else
                {
                    Console.WriteLine("Not enough money, you need " + String.Format("{0:0.00}", (finalPrice - budget)) + " leva more.");
                }
            }


            else if (typeFlower == "Narcissus" && countFlower < 120)
            {
                price = countFlower * 3.00;
                priceIncrease = 0.15 * price;
                finalPrice = price + priceIncrease;
                if (budget >= finalPrice)
                {
                    Console.WriteLine("Hey, you have a great garden with " + countFlower + " " + typeFlower + " and " + String.Format("{0:0.00}", (budget - finalPrice)) + " leva left.");
                }
                else
                {
                    Console.WriteLine("Not enough money, you need " + String.Format("{0:0.00}", (finalPrice - budget)) + " leva more.");
                }
            }
            else if (typeFlower == "Narcissus" && countFlower >= 120)
            {
                finalPrice = countFlower * 3.00;
                if (budget >= finalPrice)
                {
                    Console.WriteLine("Hey, you have a great garden with " + countFlower + " " + typeFlower + " and " + String.Format("{0:0.00}", (budget - finalPrice)) + " leva left.");
                }
                else
                {
                    Console.WriteLine("Not enough money, you need " + String.Format("{0:0.00}", (finalPrice - budget)) + " leva more.");
                }
            }


            else if (typeFlower == "Gladiolus" && countFlower < 80)
            {
                price = countFlower * 2.50;
                priceIncrease = 0.20 * price;
                finalPrice = price + priceIncrease;
                if (budget >= finalPrice)
                {
                    Console.WriteLine("Hey, you have a great garden with " + countFlower + " " + typeFlower + " and " + String.Format("{0:0.00}", (budget - finalPrice)) + " leva left.");
                }
                else
                {
                    Console.WriteLine("Not enough money, you need " + String.Format("{0:0.00}", (finalPrice - budget)) + " leva more.");
                }
            }
            else if (typeFlower == "Gladiolus" && countFlower >= 80)
            {
                finalPrice = countFlower * 2.50;
                if (budget >= finalPrice)
                {
                    Console.WriteLine("Hey, you have a great garden with " + countFlower + " " + typeFlower + " and " + String.Format("{0:0.00}", (budget - finalPrice)) + " leva left.");
                }
                else
                {
                    Console.WriteLine("Not enough money, you need " + String.Format("{0:0.00}", (finalPrice - budget)) + " leva more.");
                }
            }







        }
    }
}
