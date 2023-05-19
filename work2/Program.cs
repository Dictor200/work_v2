using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace work2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int c = int.Parse(Console.ReadLine()); if (c < 0)
            {
                c -= 5; Console.WriteLine("Число отрицательное " + c);
            }
            else if (c > 0)
            {
                c += 5;
                Console.WriteLine("Число положительное " + c);
            }
            Console.ReadLine();
            Console.WriteLine("Задайте значения");
            Console.WriteLine("Первое число"); int first = int.Parse(Console.ReadLine());
            Console.WriteLine("Второе число"); int second = int.Parse(Console.ReadLine());
            Console.WriteLine("Третье число"); int third = int.Parse(Console.ReadLine());
            if (first > second)
            {
                if (first > third)
                {
                    Console.WriteLine("Первое число наибольшее " + first);
                }
                else
                {
                    Console.WriteLine("Третье число наибольшее " + third);
                }
            }
            else
            {
                if (second > first)
                {
                    if (second > third)
                    {
                        Console.WriteLine("Второе число наибольшее " + second);
                    }
                    else
                    {
                        Console.WriteLine("Третье число наибольшее " + third);
                    }
                }
            }
            {
                Console.WriteLine("Третье задание");

                int positiveSum = 0;

                for (int i = 1; i <= 3; i++)
                {
                    Console.Write($"Введите {i}-е число: ");
                    int number = int.Parse(Console.ReadLine());

                    if (number > 0)
                    {
                        positiveSum += number;
                    }
                }

                Console.WriteLine($"Сумма положительных чисел: {positiveSum}");
                Console.WriteLine("Введите число:");
                int x = Convert.ToInt32(Console.ReadLine()); // считываем число, введенное пользователем
                if (x > 10)
                {
                    x *= 2; // удваиваем значение x
                }
                Console.WriteLine("Результат: " + x); // выводим результат в консоль
                Console.WriteLine("Введите число от 1 до 7:");
                int dayNumber = Convert.ToInt32(Console.ReadLine()); // считываем число, введенное пользователем
                string day;
                switch (dayNumber)
                {
                    case 1:
                        day = "Понедельник";
                        break;
                    case 2:
                        day = "Вторник";
                        break;
                    case 3:
                        day = "Среда";
                        break;
                    case 4:
                        day = "Четверг";
                        break;
                    case 5:
                        day = "Пятница";
                        break;
                    case 6:
                        day = "Суббота";
                        break;
                    case 7:
                        day = "Воскресенье";
                        break;
                    default:
                        day = "Неизвестный день недели!"; // в случае, если пользователь ввел число вне диапазона 1-7
                        break;
                }
                Console.WriteLine(day); // выводим день недели в консоль
                Console.ReadKey();
            }
        }
    }
}





