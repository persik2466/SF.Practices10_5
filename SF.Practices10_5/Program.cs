using System;

namespace SF.Practices10_5
{
    class Program
    {
        static ILogger Logger { get; set; }
        static void Main(string[] args)
        {
            Logger = new Logger();
            var calc = new BaseCalculator(Logger);
            Console.WriteLine("Калькулятор сложения 2-х чисел.");
            while (true)
            {
                Console.WriteLine();
                try
                {
                    Console.WriteLine("Введите первое число:");
                    int number1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите второе число:");
                    int number2 = Convert.ToInt32(Console.ReadLine());
                    calc.Solve(number1, number2);
                }
                catch (FormatException)
                {
                    calc.ExpErr();
                }
                finally
                {
                    calc.FinColor();
                }

            }
        }
    }
    public interface ILogger
    {
        void Event(string message);
        void Error(string message);
        void BaseColor();
    }
    /// <summary>
    /// Интерфейс для механизма внедрения зависимостей
    /// </summary>
    public class Logger : ILogger
    {
        public void Error(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
        }
        public void Event(string message)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(message);
        }
        public void BaseColor()
        {
            Console.ForegroundColor = ConsoleColor.White;
        }

    }

    /// <summary>
    /// Интерфейс для калькулятора
    /// </summary>
    public interface ICalculator
    {
        void Solve(int numberOne, int numberTwo);

    }
    /// <summary>
    /// Интерфейс для цвета
    /// </summary>
    public interface IException
    {
        void ExpErr();
        void FinColor();
    }

}
