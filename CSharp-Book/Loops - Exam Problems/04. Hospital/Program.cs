using System;

namespace Hosputal
{
    class Program
    {
        static void Main(string[] args)
        {
            //������ - 7
            //����� ����� ��� ��������� ����� ����������
            //� ��� ����� �� �������������� �������� � ��-�����
            //�� ���� �� ������������, �� ��������� ��� ���� �����.

            var period = int.Parse(Console.ReadLine());
            var treatedForTheDay = 0;
            var untreatedForTheDay = 0;
            var doctors = 7;
            var treatedLifetime = 0;
            var untreatedLifetime = 0;

            for (int i = 1; i <= period; i++)
            {
                var dailyPatients = int.Parse(Console.ReadLine());
                if (i % 3 == 0)
                {
                    if (untreatedLifetime > treatedLifetime)
                    {
                        doctors += 1;
                    }
                }

                if (dailyPatients - doctors >= 0)
                {
                    untreatedForTheDay = dailyPatients - doctors;
                }
                else { untreatedForTheDay = 0; }
                untreatedLifetime = untreatedLifetime + untreatedForTheDay;
                treatedForTheDay = dailyPatients - untreatedForTheDay;
                treatedLifetime = treatedLifetime + treatedForTheDay;




            }
            Console.WriteLine("Treated patients: {0}.", treatedLifetime);
            Console.WriteLine("Untreated patients: {0}.", untreatedLifetime);






        }
    }
}
