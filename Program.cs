//******************************************
//* Практичсекая работа № 9                *
//* Выполнила: Трухина Е.Д., группа 2ИСП   *
//* Задание: обработка одномерных массивов *
//******************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PR_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Title = "Практическая работа 9";
            Console.Clear();

            Console.WriteLine("Здравствуй!");

            bool continueProgram = true;

            while (continueProgram)
            {

                const int count = 15;
                double[] array = new double[count];

                Console.WriteLine($"Введите {count} вещественных чисел.");

                int i = 0;
                while (i < array.Length)
                {
                    Console.Write($"Введите {i + 1} элемент: ");

                    try
                    {
                        array[i] = Convert.ToDouble(Console.ReadLine());
                        i++;
                    }
                    catch (FormatException ex)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"Возникла ошибка формата. {ex.Message}");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    catch (OverflowException ex)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"Возникла ошибка диапазона. {ex.Message}");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    catch (Exception ex)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"Возникла ошибка. {ex.Message}");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }

                Console.Write("\nИсходный массив: ");
                for (i = 0; i < array.Length; i++)
                {
                    Console.Write(array[i] + " ");
                }

                double k;

                while (true)
                {
                    Console.Write("\nВведите K, с которым будете сравнивать элементы последовательности: ");
                    try
                    {
                        k = Convert.ToDouble(Console.ReadLine());
                        break;
                    }
                    catch (FormatException ex)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"Ошибка формата. {ex.Message}");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    catch (OverflowException ex)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"Ошибка диапазона. {ex.Message}");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    catch (Exception ex)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"Возникла ошибка. {ex.Message}");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }

                int less = 0;
                int equal = 0;
                int more = 0;

                for (i = 0; i < array.Length; i++)
                {
                    if (array[i] < k)
                    {
                        less++;
                    }
                    else if (array[i] > k)
                    {
                        more++;
                    }
                    else
                    {
                        equal++;
                    }
                }


                Console.WriteLine($"\n\nЧисел меньше K: {less}");
                Console.WriteLine($"Чисел равно K: {equal}");
                Console.WriteLine($"Чисел больше K: {more}");

                bool answerA = false;

                while (!answerA)
                {
                    Console.Write("\nПродолжить выполнение программы? (да/нет): ");
                    string answer = Console.ReadLine();

                    if (answer == null)
                    {
                        answer = "";
                    }

                    if (answer == "да")
                    {
                        answerA = true;
                    }
                    else if (answer == "нет")
                    {
                        answerA = true;
                        continueProgram = false;
                        Console.WriteLine("Выход из программы. До свидания!");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Ошибка: введите \"да\" или \"нет\".");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }
            }
            Console.ReadKey();
        }
    }
}