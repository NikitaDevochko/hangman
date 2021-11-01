using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNumber;
            double secondNumber = 0;
            double result;
            string operation;

            while (true)
            {
                Console.WriteLine("Ввдете 1ое число");
                firstNumber = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Ввдете знак математической операции:\n+ (сумма)\n- (разность)\n* (произведение)\n/ (частное)\n^ (степень)\n√ (квадратный корень)");
                operation = Console.ReadLine();

                if (operation != "√")
                {
                    Console.WriteLine("Ввдете 2ое число");
                    secondNumber = Convert.ToDouble(Console.ReadLine());
                }

                switch (operation)
                {
                    case "+":
                        result = firstNumber + secondNumber;
                        Console.WriteLine($"{firstNumber} + {secondNumber} = {result}");
                        break;
                    case "-":
                        result = firstNumber - secondNumber;
                        Console.WriteLine($"{firstNumber} - {secondNumber} = {result}");
                        break;
                    case "*":
                        result = firstNumber * secondNumber;
                        Console.WriteLine($"{firstNumber} * {secondNumber} = {result}");
                        break;
                    case "/":
                        result = firstNumber / secondNumber;
                        Console.WriteLine($"{firstNumber} / {secondNumber} = {result}");
                        break;
                    case "^":
                        result = Math.Pow(firstNumber, secondNumber);
                        Console.WriteLine($"{firstNumber} ^ {secondNumber} = {result}");
                        break;
                    case "√":
                        result = Math.Sqrt(firstNumber);
                        Console.WriteLine($"√{firstNumber} = {result}");
                        break;
                    default: Console.WriteLine("Неверный знак операции"); break;
                }

                Console.WriteLine("Чтобы продолжить, нажмите любую клавишу");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
