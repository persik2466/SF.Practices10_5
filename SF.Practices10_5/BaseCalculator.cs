using System;

namespace SF.Practices10_5
{/// <summary>
/// Класс калькулятор - наследник интерфейсов
/// </summary>
    public class BaseCalculator : ICalculator, IException
    {
        ILogger Logger { get; }
        public BaseCalculator(ILogger logger)
        {
            Logger = logger;
        }
        /// <summary>
        /// Метод сложения двух чисел
        /// </summary>
        /// <param name="numberOne"></param>
        /// <param name="numberTwo"></param>
        public void Solve(int numberOne, int numberTwo)
        {
            Logger.Event($"Сумма чисел {numberOne} и {numberTwo} равна {numberOne + numberTwo}");
        }
        /// <summary>
        /// Метод для обработки ошибок
        /// </summary>
        public void ExpErr()
        {
            Logger.Error("Введено некорректное значение, вводите числа!");
        }
        /// <summary>
        /// Метод базового цвета
        /// </summary>
        public void FinColor()
        {
            Logger.BaseColor();
        }
    }
}

