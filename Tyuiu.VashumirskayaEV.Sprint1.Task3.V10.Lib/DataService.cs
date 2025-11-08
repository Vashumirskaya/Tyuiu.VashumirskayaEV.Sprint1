using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.VashumirskayaEV.Sprint1.Task3.V10.Lib
{
    public class DataService : ISprint1Task3V10
    {
        public string NumberToMoney(double number)
        {
            number = Math.Round(number, 3);
            int rub = (int)number;
            int kop = (int)Math.Round((number - rub) * 100);
            return $"{rub} руб. {kop:D2} коп.";
        }
    }
}
