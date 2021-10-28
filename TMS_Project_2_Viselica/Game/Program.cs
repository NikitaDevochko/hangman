using System;

namespace Game
{
    class Program
    {
        public static string path = @"D:\TMS_Progect_2_Viselica\word_rus.txt";
        private const int maxErrorsCount = 10;

        static void Main(string[] args)
        {
            Console.WriteLine("Hi Player!");
            Hangman hangman = new Hangman(path);

            while (true)
            {
                hangman.GenerateWord();
                int errors = maxErrorsCount;

                Console.WriteLine($"Загадано слово из {hangman.WordLetter} букв. У вас есть {maxErrorsCount} попыток его угадать");

                while (errors > 0 && !hangman.IsSolved)
                {
                    Console.WriteLine("Введите букву");
                    string inputString = Console.ReadLine();
                    if (inputString.Length > 1 || inputString.Length == 0 || !Char.IsLetter(inputString[0]))
                    {
                        Console.Clear();
                        Console.WriteLine("Вы должны ввести 1 букву!");
                        continue;
                    }


                    Console.Clear();
                    if (hangman.CheckLetter(inputString[0]))
                    {
                        Console.WriteLine("Есть такая буква!");
                    }
                    else
                    {
                        errors--;
                        Console.WriteLine($"Такой буквы нет! Осталось {errors} попыток");
                    }

                    Console.WriteLine(hangman.ViewWord);
                }
                Console.WriteLine($"Было слово {hangman.MainWord}. Чтобы продолжить нажми \"Enter\"");
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
