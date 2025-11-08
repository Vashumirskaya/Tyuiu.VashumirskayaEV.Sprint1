using Tyuiu.VashumirskayaEV.Sprint1.Task5.V3.Lib;

namespace Tyuiu.VashumirskayaEV.Sprint1.Task5.V3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнила: Вашумирская Е. В. | СМАРТб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Преобразование типов и класс Convert                              *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #3                                                              *");
            Console.WriteLine("* Выполнила: Вашумирская Елизавета Владимировна | СМАРТб-25-1             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая решает задачу: Присвоить целой переменной   *");
            Console.WriteLine("* h третью от конца цифру в записи положительного целого числа k.         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ :                                                       *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите положительное целое число k:");
            int k = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ :                                                             *");
            Console.WriteLine("***************************************************************************");

            if (k >= 100)
            {
                int h = ds.Calculate(k);
                Console.WriteLine($"Третья цифра от конца числа {k}: {h}");
            }

            else
            {
                Console.WriteLine("Ошибка: число должно иметь минимум 3 цифры");
            }

            Console.ReadKey();
        }
    }
}
