using Tyuiu.VashumirskayaEV.Sprint1.Task6.V1.Lib;

namespace Tyuiu.VashumirskayaEV.Sprint1.Task6.V1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнила: Вашумирская Е. В. | СМАРТб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Работа со строками класс String                                   *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #1                                                              *");
            Console.WriteLine("* Выполнила: Вашумирская Елизавета Владимировна | СМАРТб-25-1             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая выводит код введенного пользователем        *");
            Console.WriteLine("* символа. Программа должна завершать работу в результате ввода,          *");
            Console.WriteLine("* например, точки.                                                        *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ :                                                       *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите значение x1:");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение y1:");
            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение x2:");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение y2:");
            double y2 = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ :                                                             *");
            Console.WriteLine("***************************************************************************");

            int dist = ds.DistanceBetweenDots(x1, y1, x2, y2);
            Console.WriteLine($"Расстояние между точками: {dist}");

            Console.ReadKey();
        }
    }
}
