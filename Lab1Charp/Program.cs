//// See https://aka.ms/new-console-template for more information

// static void task1()
//{
//    Console.WriteLine("Task1 !");
//    Console.Write("s= ");
//    string? str = Console.ReadLine();
//    float s = 0; 
//    if (str != null) s = float.Parse(str);
//    double p = 4 * Math.Sqrt(s);
//    Console.WriteLine("p=" + p);

//}
//Console.WriteLine("Lab 1 !");
//task1();
//// continue ...

//////////////////////////////////////////////////



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

//  // Встановлення кодування UTF-8 для консолі
//     Console.OutputEncoding = System.Text.Encoding.UTF8;

namespace Lab1Charp

{
    internal class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            while (true)
            {

                Console.WriteLine("Оберіть завдання:");
                Console.WriteLine("1. Середнє арифметичне кубів двох чисел");
                Console.WriteLine("2. Перевірка ділення цілого числа націло");
                Console.WriteLine("3. Перевірка чи лежить точка всередині заштрихованої області");
                Console.WriteLine("4. Визначення назви карти за номером");
                Console.WriteLine("5. Визначення частки двох цілих чисел");
                Console.WriteLine("6. Обчислення виразу ((a*b+(a+b)*(a+b)-1)/(a^2 + b^2))-5");

                Console.Write("Введіть номер завдання (або 0 для виходу): ");
                string input = Console.ReadLine();
                Console.WriteLine();

                if (int.TryParse(input, out int choice))
                {
                    switch (choice)
                    {
                        case 1:
                            Task1();
                            break;
                        case 2:
                            Task2();
                            break;
                        case 3:
                            Task3();
                            break;
                        case 4:
                            Task4();
                            break;
                        case 5:
                            Task5();
                            break;
                        case 6:
                            Task6();
                            break;
                        case 0:
                            Console.WriteLine("Дякую за використання програми. До побачення!");
                            return;
                        default:
                            Console.WriteLine("Невірний вибір. Будь ласка, введіть коректний номер завдання.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Помилка: Введіть коректне число для вибору завдання.");
                }
            }
        }

        // Завдання 1. Середнє арифметичне кубів двох чисел
        static void Task1()
        {
            Console.WriteLine("Ви обрали завдання 1: Середнє арифметичне кубів двох чисел");

            double number1, number2;

            if (GetUserInput("Введіть перше число: ", out number1) && GetUserInput("Введіть друге число: ", out number2))
            {
                double cube1 = Math.Pow(number1, 3);
                double cube2 = Math.Pow(number2, 3);

                double averageCube = (cube1 + cube2) / 2;

                Console.WriteLine($"Середнє арифметичне кубів {number1} і {number2} дорівнює {averageCube}");
            }

            // Повернення до меню
            Console.WriteLine("Натисніть Enter для повернення до меню.");
            Console.ReadLine();
        }


        // Завдання 2. Перевірка ділення цілого числа націло
        static void Task2()
        {
            Console.WriteLine("Ви обрали завдання 4: Перевірка ділення цілого числа націло");

            int m, n;

            if (GetUserInput("Введіть ціле число M: ", out m) && GetUserInput("Введіть ціле число N (не дорівнює 0): ", out n))
            {
                if (IsDivisible(m, n))
                {
                    int quotient = m / n;
                    Console.WriteLine($"{m} ділиться націло на {n}. Частка від ділення: {quotient}");
                }
                else
                {
                    Console.WriteLine($"{m} на {n} націло не ділиться.");
                }
            }

            // Повернення до меню
            Console.WriteLine("Натисніть Enter для повернення до меню.");
            Console.ReadLine();
        }


        // Завдання 3. Перевірка точки відносно двох кол
        static void Task3()
        {
            Console.WriteLine("Ви обрали завдання 3: Перевірка точки відносно двох кол");

            double x, y;

            if (GetUserInput("Введіть координату x точки: ", out x) && GetUserInput("Введіть координату y точки: ", out y))
            {
                double radius1 = 8;  // Радіус першого кола
                double radius2 = 3;  // Радіус другого кола

                double distance = Math.Sqrt(x * x + y * y);  // Відстань від точки до початку координат

                if ((x > 0 && y > 0) || (x > 0 && y < 0) || distance < radius2 || distance > radius1)
                {
                    Console.WriteLine("Ні");
                }
                else if (distance == radius1 || distance == radius2)
                {
                    Console.WriteLine("На межі");
                }
                else
                {
                    Console.WriteLine("Так");
                }
            }

            // Повернення до меню
            Console.WriteLine("Натисніть Enter для повернення до меню.");
            Console.ReadLine();
        }


        // Завдання 4. Визначення назви карти за номером
        static void Task4()
        {
            Console.WriteLine("Ви обрали завдання 3: Визначення назви карти за номером");

            int k;

            if (GetUserInput("Введіть номер карти (від 6 до 14): ", out k))
            {
                if (k >= 6 && k <= 14)
                {
                    string cardName = GetCardName(k);
                    Console.WriteLine($"Назва карти з номером {k}: {cardName}");
                }
                else
                {
                    Console.WriteLine("Некоректний номер карти. Введіть число від 6 до 14.");
                }
            }

            // Повернення до меню
            Console.WriteLine("Натисніть Enter для повернення до меню.");
            Console.ReadLine();
        }


        // Завдання 5. Визначення частки двох цілих чисел
        static void Task5()
        {
            Console.WriteLine("Ви обрали завдання 2: Визначення частки двох цілих чисел");

            int a, b;

            if (GetUserInput("Введіть перше ціле число: ", out a) && GetUserInput("Введіть друге ціле число (не дорівнює 0): ", out b))
            {
                int result = DivideNumbers(a, b);

                if (result != int.MinValue)
                {
                    Console.WriteLine($"Результат ділення {a} на {b} дорівнює {result}");
                }
                else
                {
                    Console.WriteLine("Помилка: Друге число не повинно дорівнювати 0.");
                }
            }

            // Повернення до меню
            Console.WriteLine("Натисніть Enter для повернення до меню.");
            Console.ReadLine();
        }


        // Завдання 6. Обчислення виразу ((a*b+(a+b)*(a+b)-1)/(a^2 + b^2))-5
        static void Task6()
        {
            Console.WriteLine("Ви обрали завдання 6: Обчислення виразу ((a*b+(a+b)*(a+b)-1)/(a^2 + b^2))-5");

            double a, b;

            if (GetUserInput("Введіть значення a: ", out a) && GetUserInput("Введіть значення b: ", out b))
            {
                double result = ((a * b + (a + b) * (a + b) - 1) / (a * a + b * b)) - 5;

                Console.WriteLine($"Результат виразу: {result}");
            }

            // Повернення до меню
            Console.WriteLine("Натисніть Enter для повернення до меню.");
            Console.ReadLine();
        }




        // Метод для визначення назви карти за номером
        static string GetCardName(int cardNumber)
        {
            switch (cardNumber)
            {
                case 14:
                    return "Туз";
                case 13:
                    return "Король";
                case 12:
                    return "Дама";
                case 11:
                    return "Валет";
                case 10:
                    return "Десятка";
                case 9:
                    return "Дев'ятка";
                case 8:
                    return "Вісімка";
                case 7:
                    return "Сімка";
                case 6:
                    return "Шістка";
                default:
                    return "Невідома карта";
            }
        }

        // Метод для обчислення частки двох цілих чисел
        static int DivideNumbers(int dividend, int divisor)
        {
            if (divisor != 0)
            {
                return dividend / divisor;
            }
            else
            {
                return int.MinValue;
            }
        }

        // Метод для перевірки ділення цілого числа націло
        static bool IsDivisible(int m, int n)
        {
            return n != 0 && m % n == 0;
        }

        // Метод для отримання коректного введення від користувача
        static bool GetUserInput(string prompt, out int result)
        {
            int attempts = 2;

            do
            {
                Console.Write(prompt);
                string input = Console.ReadLine();

                if (int.TryParse(input, out result))
                {
                    return true;
                }
                else
                {
                    Console.WriteLine("Помилка: Введіть коректне ціле число.");
                    attempts--;

                    if (attempts == 0)
                    {
                        Console.WriteLine("Використані всі спроби. Повернення до меню.");
                        return false;
                    }

                    Console.WriteLine($"Залишилося спроб: {attempts}");
                }
            } while (true);
        }

        // Метод для отримання коректного введення від користувача
        static bool GetUserInput(string prompt, out double result)
        {
            int attempts = 2;

            do
            {
                Console.Write(prompt);
                string input = Console.ReadLine();

                if (double.TryParse(input, out result))
                {
                    return true;
                }
                else
                {
                    Console.WriteLine("Помилка: Введіть коректне число.");
                    attempts--;

                    if (attempts == 0)
                    {
                        Console.WriteLine("Використані всі спроби. Повернення до меню.");
                        return false;
                    }

                    Console.WriteLine($"Залишилося спроб: {attempts}");
                }
            } while (true);
        }
    }
}



