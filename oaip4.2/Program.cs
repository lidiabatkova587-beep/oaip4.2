using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oaip4._2
{
    internal class Program
    {
        static int AddNumber()
        {
            Console.WriteLine("введите первое число");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("введите второе число");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int sum = num1 + num2;

            return sum;
        }
        static void CheckEven()
        {
            Console.WriteLine("введите число");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number % 2 == 0)
                Console.WriteLine("число четное");
            else
                Console.WriteLine("число нечетное");
        }
        static void CalculateDiscount()
        {
            Console.WriteLine("введите цену товара");
            double price = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("введите процент скидки");
            double discout = Convert.ToDouble(Console.ReadLine());

            double discoutAmount = price * (discout / 100);
            double finalPrice = price - discoutAmount;
            Console.WriteLine($"начальная цена: {price}");
            Console.WriteLine($"финальная цена: {finalPrice}");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("");
            Console.WriteLine(AddNumber());
            Console.WriteLine(AddNumber());
            Console.WriteLine(AddNumber());

            Console.WriteLine("");
            CheckEven();
            CheckEven();
            CheckEven();

            Console.WriteLine("");
            CalculateDiscount();
            CalculateDiscount();
        }
    }
}
