using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktikum3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.CursorVisible = false;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.SetWindowSize(125, 50);

            Console.Title = "Сакара - компьютерный практикум 3";

            //1.       Составить программу, которая запрашивает название футбольной команды и повторяет его на экране со словами "— это чемпион!".

            Console.Write("введите название футбольной команды: ");
            string team = Console.ReadLine();
            Console.WriteLine($"{team} - это чемпион!");
            Console.ReadKey();

            //2.       Составить программу, которая запрашивает отдельно имя и отдельно фамилию, а затем выводит их как одну символьную строку.

            Console.Write("введите имя: ");
            string name = Console.ReadLine();
            Console.Write("введите фамилию: ");
            string surname = Console.ReadLine();
            Console.WriteLine($"{name} {surname}");
            Console.ReadKey();

            //3.       Составить программу, которая запрашивает название государства и его столицы, а затем выводит сообщение:
            //"Столица государства ... — город ..."(на месте многоточий должны быть выведены соответствующие значения).

            Console.Write("Введите название столицы: ");
            string capital = Console.ReadLine();
            Console.Write("Введите название государства: ");
            string state = Console.ReadLine();
            Console.WriteLine($"Столица государства {capital} - город {state}");
            Console.ReadKey();

            //4.       Составить программу, которая запрашивает название романа и фамилию его автора,
            //а затем выводит сообщение: "Писатель ... — автор романа ..." (на месте многоточий должны быть выведены соответствующие значения)

            Console.Write("Введите ФИО писателя: ");
            string name2 = Console.ReadLine();
            Console.WriteLine("Введите название романа: ");
            string roman = Console.ReadLine();
            Console.WriteLine($"Писатель {name2} - автор романа {roman}");
            Console.ReadKey();

            //5.       Напишите программу, в которую вводится целое число,
            //после чего на экран выводится следующее и предыдущее целое число. Например, при вводе числа 15 на экран должно быть выведено:
            //Следующее за числом 15 число – 16.

            //Для числа 15 предыдущее число – 14.

            Console.Write("введите число: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine($"следующее за числом {number} число - {number + 1} ");
            Console.WriteLine($"для числа {number} предыдущее число - {number - 1} ");
            Console.ReadKey();

            //6.       Дано название футбольного клуба. Определить количество символов в нем.

            Console.Write("Введите название футбольного клуба: ");
            string numb = Console.ReadLine();
            Console.Write($"Количество символов: {numb.Length}");
            Console.ReadKey();

            //7.       Написать программу, которая спрашивает имя пользователя и сколько ему лет и выводит на экран сообщение
            //«Здравствуй, Петя. Тебе 100 лет!))». Вместо Петя и 100 соответствующие введенные данные.

            Console.Write("Введите своё имя: ");
            string name3 = Console.ReadLine();
            Console.Write("Укажите ваш возраст: ");
            string age = Console.ReadLine();
            Console.Write($"Здравствуй {name3}. Тебе {age} лет!");
            Console.ReadKey();

            //8.       Написать программу, которая по введеному значению,
            //выводит само значение, значение увеличенное на 1, значение увеличенное на 2, и сумму всех трех значений.

            Console.Write("введите число: ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine($"{num}; {num++}; {num + 2}; {num + (num + 1) + (num + 2)} ");
            Console.ReadKey();

            //9.       Даны два ненулевых вещественных числа. Найти сумму, разность, произведение и частное их квадратов.

            Console.Write("введите число: ");
            double num1 = double.Parse(Console.ReadLine());
            Console.Write("введите число: ");
            double num2 = double.Parse(Console.ReadLine());
            Console.WriteLine($"{num1}^2 + {num2}^2 = {Math.Pow(num1, 2) + Math.Pow(num2, 2)}");
            Console.WriteLine($"{num1}^2 - {num2}^2 = {Math.Pow(num1, 2) - Math.Pow(num2, 2)}");
            Console.WriteLine($"{num1}^2 * {num2}^2 = {Math.Pow(num1, 2) * Math.Pow(num2, 2)}");
            Console.WriteLine($"{num1}^2 / {num2}^2 = {Math.Pow(num1, 2) / Math.Pow(num2, 2)}");
            Console.ReadKey();




            //10.       Применить операцию конкатенации к переменным a, b, c, d, e так,
            //чтобы получилось необходимое значение переменной x. Задать заголовок окна «Конкатенация строк».

            Console.Title = "Конкатенация строк";

            string a1 = "фальш";
            string b1 = "монеты";
            string c1 = "в";
            string d1 = "ивые";
            string e1 = "мешках";

            string x1 = a1 + d1 + " " + b1 + " " + c1 + " " + e1;

            string a2 = "количе";
            string b2 = "информа";
            string c2 = "в байтах";
            string d2 = "ство";
            string e2 = "ции";

            string x2 = a2 + d2 + " " + b2 + e2 + " " + c2;

            string a3 = "мозг";
            string b3 = "ребусы";
            string c3 = "человече";
            string d3 = "а";
            string e3 = "ского";

            string x3 = b3 + " " + c3 + e3 + " " + a3 + d3;

            string a4 = "мульти";
            string b4 = "технолог";
            string c4 = "ийные";
            string d4 = "ии";
            string e4 = "мед";

            string x4 = a4 + e4 + c4 + " " + b4 + d4;
            Console.WriteLine($"{x1} \n{x2} \n{x3} \n{x4}");

            Console.ReadKey();

        }
    }
}
