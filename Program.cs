using System;

class Program
{
    static void Main(string[] args)
    {
        // Проверяем, что передано ровно 3 аргумента
        if (args.Length != 3)
        {
            Console.WriteLine("Ошибка: введите выражение в формате 'a оператор b'. Пример: program.exe 10 + 20");
            Console.ReadLine();
            return;
        }
            double num1 = double.Parse(args[0]);
            string act = args[1];
            double num2 = double.Parse(args[2]);

            double result = 0; 
            if (act == "+")
            {
                result = num1 + num2;
                Console.WriteLine($"{num1} + {num2} = {result}");
            }
            else if (act == "-")
            {
                result = num1 - num2;
                Console.WriteLine($"{num1} - {num2} = {result}");
            }
            else if (act == "*")
            {
                result = num1 * num2;
                Console.WriteLine($"{num1} * {num2} = {result}");
            }
            else if (act == "/")
            {
                if (num2 == 0)
                {
                    Console.WriteLine("Ошибка: деление на ноль невозможно.");
                }
                else
                {
                    result = num1 / num2;
                    Console.WriteLine($"{num1} / {num2} = {result}");
                }
            }
            else
            {
                Console.WriteLine("Ошибка: некорректный оператор. Используйте +, -, *, /.");
            }
        
    }
}
