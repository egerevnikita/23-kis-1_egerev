using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Калькулятр
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double result = 0;
            double car= 0;
            string operation = "";
            bool isr = true;

            Console.WriteLine("Простой калькулятор. ");

            while (true)
            {
                if (isr)
                {
                    Console.Write("Введите число: ");
                    car= Convert.ToDouble(Console.ReadLine());
                    result = car; 
                    isr = false;
                }
                else
                {
                    Console.Write("Введите операцию (+, -, *, /) или '=' для завершения: ");
                    operation = Console.ReadLine();

                    if (operation == "=")
                    {
                        Console.WriteLine($"Результат: {result}");
                        break;
                    }

                    Console.Write("Введите следующее число: ");
                    car = Convert.ToDouble(Console.ReadLine());

                    switch (operation)
                    {
                        case "+":
                            result += car;
                            break;
                        case "-":
                            result -= car;
                            break;
                        case "*":
                            result *= car;
                            break;
                        case "/":
                            if (car != 0)
                            {
                                result /= car;
                            }
                            else
                            {
                                Console.WriteLine("Ошибка: Деление на ноль!");
                                continue; 
                            }
                            break;
                        default:
                            Console.WriteLine("Ошибка: Неверная операция.");
                            continue; 
                    }
                }

                Console.WriteLine($"Текущий результат: {result}");
            }
        }
    }
}
    

