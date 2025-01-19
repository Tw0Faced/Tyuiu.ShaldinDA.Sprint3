using Tyuiu.ShaldinDA.Sprint3.Task7.V15.Lib;
namespace Tyuiu.ShaldinDA.Sprint3.Task7.V15
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
            Console.WriteLine("* Добавление к решению итоговых проектов по спринту                       *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #15                                                             *");
            Console.WriteLine("* Выполнил: Шалдин Данил Андреевич | ИИПБ-24-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *"); 
            
            Console.WriteLine("*Напишите программу, которая выводит таблицу значений функции             *");

            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int startValue = -5;
            int stopValue = 5;

            Console.WriteLine(startValue);
            Console.WriteLine(stopValue);

            int len = ds.GetMassFunction(startValue, stopValue).Length;

            double[] valueArray;
            valueArray = new double[len];

            valueArray = ds.GetMassFunction(startValue, stopValue);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("+-------------+------------+");
            Console.WriteLine("|      X      |     f(x)   |");
            Console.WriteLine("+-------------+------------+");
            for (int i = 0; i <=len-1; i++)
            {
                Console.WriteLine("|{0,5:d}      |   {1, 5:df2}     |", startValue,valueArray[i]);
                startValue++;
            }
            Console.WriteLine("+-------------+------------+");
            Console.ReadKey();
        }
    }
}