using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pochtipr
{
    internal class Program
    {
        static int CalculateSizeDiscount(double price)
        {
            if (price >= 10000)
                return 15;
            else if (price >= 5000)
                return 10;
            else
                return 5;
        }
        static double CalculateFinalPrice(double price, double discount)
        {
            double sumdisc = price *(discount / 100);
            return price - sumdisc;
        }
        static void Ticket(double price)
        {
            double procent = CalculateSizeDiscount(price);
            double finalprice = CalculateFinalPrice(price, procent);

            Console.WriteLine("     чек покупки:     ");
            Console.WriteLine($"сумма покупки: {price}");
            Console.WriteLine($"скидка: {procent}%");
            Console.WriteLine($"к оплате: {finalprice}");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("введите сумму покупки");
        }
    }
}
