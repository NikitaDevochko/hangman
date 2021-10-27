using System;

namespace TMS_Project_2_Viselica
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mass = new int[35];

            for (int i = 1; i < mass.Length; i++)
            {
                mass[i] = i;
            }

            foreach (int item in mass)
            {
                if (item % 2 == 0)
                {
                    Console.WriteLine(item.ToString() + " - четное");
                }
                else
                {
                    Console.WriteLine(item.ToString() + " - нечетное");
                }

                switch (item)
                {
                    case 5: forFive(); break;
                    case 7: Console.WriteLine("Счастливое число!"); break;
                    case 33:
                    case 13: Console.WriteLine("Число с неудачей("); break;
                }
            }

            Console.WriteLine("Сейчас просто посчитаю до 5");
            int x = 0;
            while (x < 5)
            {
                Console.WriteLine(x + 1);
                x++;
            }
        }

        static void forFive()
        {
            Console.WriteLine("это число 5!");
        }
    }
}
