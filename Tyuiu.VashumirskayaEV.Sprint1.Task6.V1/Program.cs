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

            Console.WriteLine("Введите символ и нажмите <Enter>.");
            Console.WriteLine("Для завершения введите точку.");

            while (true)
            {
                Console.WriteLine("->");
                string input = Console.ReadLine();

                if (input == ".")
                {
                    break;
                }



                Console.WriteLine("***************************************************************************");
                Console.WriteLine("* РЕЗУЛЬТАТ :                                                             *");
                Console.WriteLine("***************************************************************************");

                string code = ds.SymbolCode(input);
                Console.WriteLine(code);
            }
            Console.ReadKey();
        }
    }
}
