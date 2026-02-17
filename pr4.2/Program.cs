using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr4._2
{
    internal class Program
    {

        static int cof = 10;
        static int milk = 5;
        static int sugar = 15;

        static bool CheckResurs(int needcof, int needmilk, int needsugar)
        {
            if (cof < needcof)
            {
                Console.WriteLine("недостаточно кофе");
                return false;
            }
            if (needmilk > milk)
            {
                Console.WriteLine("недостаточно молока");
                return false;
            }
            if (sugar < needsugar)
            {
                Console.WriteLine("недостаточно сахара");
                return false;
            }
            return true;
        }
        static void MakeCoffe(int docof, int domilk, int dosugar)
        {
            cof -= docof;
            milk -= domilk;
            sugar -= dosugar;
        }

        static void MakeEspresso()
        {
            if (cof > 0)
            {
                cof--;
                Console.WriteLine("эспрессо готов");
            }
            else
            {
                Console.WriteLine("недостаточно кофе или молока");
            }
            Console.WriteLine("хотите добавить сахар? (1 - да)");
            int chois = int.Parse(Console.ReadLine());
            if (chois == 1)
            {
                UsSugar();
            }
            else
            {
                return;
            }
        }
        static void MakeLatte()
        {
            if (cof > 0 && milk > 0)
            {
                cof--;
                milk = milk - 2;
                Console.WriteLine("латте готов");
            }
            else
            {
                Console.WriteLine("недостаточно кофе или молока");
            }
            Console.WriteLine("хотите добавить сахар? (1 - да)");
            int chois = int.Parse(Console.ReadLine());
            if (chois == 1)
            {
                UsSugar();
            }
            else
            {
                return;
            }
        }
        static void MakeCapuch()
        {
            if (cof > 0 && milk > 0)
            {
                cof--;
                milk--;
                Console.WriteLine("капучино готов");
            }
            else
            {
                Console.WriteLine("недостаточно кофе или молока");
            }
            Console.WriteLine("хотите добавить сахар? (1 - да)");
            int chois = int.Parse(Console.ReadLine());
            if (chois ==1)
            {
                UsSugar();
            }
            else
            {
                return;
            }
        }

        static void UsSugar()
        {
            if (sugar > 0)
            {
                sugar--;
                Console.WriteLine("сахар добавлен");
            }
            else
            {
                Console.WriteLine("сахар закончился");
            }
        }
        static void Resurs()
        {
            Console.WriteLine("остатки:");
            Console.WriteLine($"Кофе = {cof}");
            Console.WriteLine($"Молоко = {milk}");
            Console.WriteLine($"Сахар = {sugar}");
        }
        static void DopResurs()
        {
            cof = 10;
            milk = 5;
            sugar = 15;
            Console.WriteLine("запасы пополнены");
        }

        static void Main(string[] args)
        {
            int ch = 1;
            while (ch == 1)
            {
                Console.WriteLine("кофемашина");

                Console.WriteLine("меню:");
                Console.WriteLine("1. Эспрессо");
                Console.WriteLine("2. Капучино");
                Console.WriteLine("3. Латте");
                Console.WriteLine("4. Добавить сахар(только один)");
                Console.WriteLine("5. Показать запасы");
                Console.WriteLine("6. Заправить машину");
                Console.WriteLine("7. Выход");

                Console.WriteLine("ваш выбор");
                string chois = Console.ReadLine();
                switch (chois)
                {
                    case "1":
                        MakeEspresso();
                        break;
                    case "2":
                        MakeCapuch();
                        break;
                    case "3":
                        MakeLatte();
                        break;
                    case "4":
                        UsSugar();
                        break;
                    case "5":
                        Resurs();
                        break;
                    case "6":
                        DopResurs();
                        break;
                    case "7":
                        ch = 0;
                        break;
                }
            }
        }
    }
}

