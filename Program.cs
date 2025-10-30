using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practic12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1 = 4;
            double num2 = 5;
            Console.WriteLine($"Сложение: {Calculator.Add(num1, num2)}");
            Console.WriteLine($"Вычитание: {Calculator.Subtract(num1, num2)}");
            Console.WriteLine($"Умножение: {Calculator.Multiply(num1, num2)}");
            Console.WriteLine($"Деление: {Calculator.Divide(num1, num2)}");
        }                
    }
}
