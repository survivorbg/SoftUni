using System;

namespace �����_��_�������
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
         �	������ �� ���� �� ������ ���� �������� �  3000 ��.
         �	������ �� ���� �� ������ ���� ������ � ������ �  4200 ��.
         �	������ �� ���� �� ������ ���� ������ �  2600 ��.

         �	��� ������� � �� 6 ������ �����������  �  �������� �� 10%.
         �	��� ������� � �� 7 �� 11 ������ �����������  �  �������� �� 15%.
         �	��� ������� � �� 12 ������  �  �������� �� 25%. 

            �������� ������� ������������ 5% ��������, ��� �� ����� ���� ����� 
            ��� �� � ���� - ������ ����� ������������ ��������, ����� �� ��������� 
            ���� ���� �� ��������� ���������� �� ������� ��������.

              */

            var budget = int.Parse(Console.ReadLine());
            var season = Console.ReadLine();
            var fishermen = int.Parse(Console.ReadLine());
            var price = 0.00;


            switch (season)
            {
                case "Spring":
                    if (fishermen <= 6)
                    {
                        price = 3000 - (3000 * 0.10);
                        if (fishermen % 2 == 0)
                        {
                            price = price - (price * 0.05);
                            if (budget >= price)
                            {
                                Console.WriteLine("Yes! You have " + String.Format("{0:0.00}", (budget - price)) + " leva left.");
                            }
                            else
                            {
                                Console.WriteLine("Not enough money! You need " + String.Format("{0:0.00}", (price - budget)) + " leva.");
                            }
                        }
                        else
                        {
                            if (budget >= price)
                            {
                                Console.WriteLine("Yes! You have " + String.Format("{0:0.00}", (budget - price)) + " leva left.");
                            }
                            else
                            {
                                Console.WriteLine("Not enough money! You need " + String.Format("{0:0.00}", (price - budget)) + " leva.");
                            }
                        }
                    }


                    else if (fishermen > 6 && fishermen <= 11)
                    {
                        price = 3000 - (3000 * 0.15);
                        if (fishermen % 2 == 0)
                        {
                            price = price - (price * 0.05);
                            if (budget >= price)
                            {
                                Console.WriteLine("Yes! You have " + String.Format("{0:0.00}", (budget - price)) + " leva left.");
                            }
                            else
                            {
                                Console.WriteLine("Not enough money! You need " + String.Format("{0:0.00}", (price - budget)) + " leva.");
                            }
                        }
                        else
                        {
                            if (budget >= price)
                            {
                                Console.WriteLine("Yes! You have " + String.Format("{0:0.00}", (budget - price)) + " leva left.");
                            }
                            else
                            {
                                Console.WriteLine("Not enough money! You need " + String.Format("{0:0.00}", (price - budget)) + " leva.");
                            }
                        }
                    }

                    else if (fishermen > 11)
                    {
                        price = 3000 - (3000 * 0.25);
                        if (fishermen % 2 == 0)
                        {
                            price = price - (price * 0.05);
                            if (budget >= price)
                            {
                                Console.WriteLine("Yes! You have " + String.Format("{0:0.00}", (budget - price)) + " leva left.");
                            }
                            else
                            {
                                Console.WriteLine("Not enough money! You need " + String.Format("{0:0.00}", (price - budget)) + " leva.");
                            }
                        }
                        else
                        {
                            if (budget >= price)
                            {
                                Console.WriteLine("Yes! You have " + String.Format("{0:0.00}", (budget - price)) + " leva left.");
                            }
                            else
                            {
                                Console.WriteLine("Not enough money! You need " + String.Format("{0:0.00}", (price - budget)) + " leva.");
                            }
                        }
                    }
                    break;
                case "Summer":



                    if (fishermen <= 6)
                    {
                        price = 4200 - (4200 * 0.10);
                        if (fishermen % 2 == 0)
                        {
                            price = price - (price * 0.05);
                            if (budget >= price)
                            {
                                Console.WriteLine("Yes! You have " + String.Format("{0:0.00}", (budget - price)) + " leva left.");
                            }
                            else
                            {
                                Console.WriteLine("Not enough money! You need " + String.Format("{0:0.00}", (price - budget)) + " leva.");
                            }
                        }
                        else
                        {
                            if (budget >= price)
                            {
                                Console.WriteLine("Yes! You have " + String.Format("{0:0.00}", (budget - price)) + " leva left.");
                            }
                            else
                            {
                                Console.WriteLine("Not enough money! You need " + String.Format("{0:0.00}", (price - budget)) + " leva.");
                            }
                        }
                    }


                    else if (fishermen > 6 && fishermen <= 11)
                    {
                        price = 4200 - (4200 * 0.15);
                        if (fishermen % 2 == 0)
                        {
                            price = price - (price * 0.05);
                            if (budget >= price)
                            {
                                Console.WriteLine("Yes! You have " + String.Format("{0:0.00}", (budget - price)) + " leva left.");
                            }
                            else
                            {
                                Console.WriteLine("Not enough money! You need " + String.Format("{0:0.00}", (price - budget)) + " leva.");
                            }
                        }
                        else
                        {
                            if (budget >= price)
                            {
                                Console.WriteLine("Yes! You have " + String.Format("{0:0.00}", (budget - price)) + " leva left.");
                            }
                            else
                            {
                                Console.WriteLine("Not enough money! You need " + String.Format("{0:0.00}", (price - budget)) + " leva.");
                            }
                        }
                    }

                    else if (fishermen > 11)
                    {
                        price = 4200 - (4200 * 0.25);
                        if (fishermen % 2 == 0)
                        {
                            price = price - (price * 0.05);
                            if (budget >= price)
                            {
                                Console.WriteLine("Yes! You have " + String.Format("{0:0.00}", (budget - price)) + " leva left.");
                            }
                            else
                            {
                                Console.WriteLine("Not enough money! You need " + String.Format("{0:0.00}", (price - budget)) + " leva.");
                            }
                        }
                        else
                        {
                            if (budget >= price)
                            {
                                Console.WriteLine("Yes! You have " + String.Format("{0:0.00}", (budget - price)) + " leva left.");
                            }
                            else
                            {
                                Console.WriteLine("Not enough money! You need " + String.Format("{0:0.00}", (price - budget)) + " leva.");
                            }
                        }
                    }
                    break;
                case "Autumn":


                    if (fishermen <= 6)
                    {
                        price = 4200 - (4200 * 0.10);
                        if (budget >= price)
                        {
                            Console.WriteLine("Yes! You have " + String.Format("{0:0.00}", (budget - price)) + " leva left.");
                        }
                        else
                        {
                            Console.WriteLine("Not enough money! You need " + String.Format("{0:0.00}", (price - budget)) + " leva.");
                        }

                    }


                    else if (fishermen > 6 && fishermen <= 11)
                    {
                        price = 4200 - (4200 * 0.15);
                        if (budget >= price)
                        {
                            Console.WriteLine("Yes! You have " + String.Format("{0:0.00}", (budget - price)) + " leva left.");
                        }
                        else
                        {
                            Console.WriteLine("Not enough money! You need " + String.Format("{0:0.00}", (price - budget)) + " leva.");
                        }
                    }

                    else if (fishermen > 11)
                    {
                        price = 4200 - (4200 * 0.25);
                        if (budget >= price)
                        {
                            Console.WriteLine("Yes! You have " + String.Format("{0:0.00}", (budget - price)) + " leva left.");
                        }
                        else
                        {
                            Console.WriteLine("Not enough money! You need " + String.Format("{0:0.00}", (price - budget)) + " leva.");
                        }
                    }

                    break;
                case "Winter":
                    if (fishermen <= 6)
                    {
                        price = 2600 - (2600 * 0.10);
                        if (fishermen % 2 == 0)
                        {
                            price = price - (price * 0.05);
                            if (budget >= price)
                            {
                                Console.WriteLine("Yes! You have " + String.Format("{0:0.00}", (budget - price)) + " leva left.");
                            }
                            else
                            {
                                Console.WriteLine("Not enough money! You need " + String.Format("{0:0.00}", (price - budget)) + " leva.");
                            }
                        }
                        else
                        {
                            if (budget >= price)
                            {
                                Console.WriteLine("Yes! You have " + String.Format("{0:0.00}", (budget - price)) + " leva left.");
                            }
                            else
                            {
                                Console.WriteLine("Not enough money! You need " + String.Format("{0:0.00}", (price - budget)) + " leva.");
                            }
                        }
                    }


                    else if (fishermen > 6 && fishermen <= 11)
                    {
                        price = 2600 - (2600 * 0.15);
                        if (fishermen % 2 == 0)
                        {
                            price = price - (price * 0.05);
                            if (budget >= price)
                            {
                                Console.WriteLine("Yes! You have " + String.Format("{0:0.00}", (budget - price)) + " leva left.");
                            }
                            else
                            {
                                Console.WriteLine("Not enough money! You need " + String.Format("{0:0.00}", (price - budget)) + " leva.");
                            }
                        }
                        else
                        {
                            if (budget >= price)
                            {
                                Console.WriteLine("Yes! You have " + String.Format("{0:0.00}", (budget - price)) + " leva left.");
                            }
                            else
                            {
                                Console.WriteLine("Not enough money! You need " + String.Format("{0:0.00}", (price - budget)) + " leva.");
                            }
                        }
                    }

                    else if (fishermen > 11)
                    {
                        price = 2600 - (2600 * 0.25);
                        if (fishermen % 2 == 0)
                        {
                            price = price - (price * 0.05);
                            if (budget >= price)
                            {
                                Console.WriteLine("Yes! You have " + String.Format("{0:0.00}", (budget - price)) + " leva left.");
                            }
                            else
                            {
                                Console.WriteLine("Not enough money! You need " + String.Format("{0:0.00}", (price - budget)) + " leva.");
                            }
                        }
                        else
                        {
                            if (budget >= price)
                            {
                                Console.WriteLine("Yes! You have " + String.Format("{0:0.00}", (budget - price)) + " leva left.");
                            }
                            else
                            {
                                Console.WriteLine("Not enough money! You need " + String.Format("{0:0.00}", (price - budget)) + " leva.");
                            }
                        }
                    }

                    break;
            }



        }
    }
}
