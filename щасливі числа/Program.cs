using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        Console.WriteLine("Вітаю! Ця програма знаходить позицію щасливого числа і виводить її на екран");
        Console.WriteLine("Якщо ви хочете побачити щасливе число, яке буде мати змінну чисел 4 рази, введіть число 1");
        Console.WriteLine("Якщо ви хочете побачити щасливе число, яке буде мати змінну чисел 7 разів, введіть число 2");
        Console.WriteLine("Якщо хочете одразу перейти до відповіді, введіть число 3");
        Console.WriteLine("Якщо хочете завершити програму, введіть число 0");

        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out int choice))
            {
                switch (choice)
                {
                    case 1:
                        var resultFourTimes = GenerateChangeNumbersFourTimes.GenerateNumber();
                        Console.WriteLine($"Щасливе число яке змінюється чотири рази: {resultFourTimes.Item2}, Позиція: {resultFourTimes.Item1}");
                        break;
                    case 2:
                        var resultSevenTimes = GenerateChangeNumbersSevenTimes.GenerateNumber();
                        Console.WriteLine($"Щасливе число яке змінюється сім разів: {resultSevenTimes.Item2}, Позиція: {resultSevenTimes.Item1}");
                        break;
                    case 3:
                        var resultLuckySevenTimes = GenerateChangeNumbersSevenTimes.GenerateNumber();
                        var position = GenerateChangeNumbersSevenTimes.GenerateNumber();
                        Console.WriteLine($"Найщасливіше число: {resultLuckySevenTimes.Item2}, Позиція: {position.Item1}");
                        break;
                    case 0:
                        Console.WriteLine("Програма завершила свою роботу!");
                        return; 
                    default:
                        Console.WriteLine("Невірний вибір. Будь ласка, введіть правильне число.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Неправильний формат даних. Будь ласка, введіть число.");
            }
        }
    }
}
