using System.ComponentModel.Design;
using Tyuiu.ShaldinDA.Sprint3.Task1.V13.Lib;
namespace Tyuiu.ShaldinDA.Sprint3.Task1.V13
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #3 | Выполнил: Шалдин Данил Андреевич | ИИПБ-24-1";
            //Длинна строки 75 символов
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Оператор цикла while                                                    *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #13                                                             *");
            Console.WriteLine("* Выполнил: Шалдин Данил Андреевич | ИИПБ-24-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *"); 
            
            Console.WriteLine("*Написать программу используя цикл while, которая вычисляет произведение р*");
            Console.WriteLine("*ряда по формуле, при n=1,2.                                              *");

            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            double value = 1.2;
            int startValue = 1;
            int stopValur = 7;

            Console.WriteLine("Переменная n = " + value);
            Console.WriteLine("Страт шага =" + startValue);
            Console.WriteLine("Конец шага =" + stopValur);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Производня ряда =" + ds.GetMultiplySeries(value, startValue, stopValur));
            Console.ReadKey();
        }
    }
}