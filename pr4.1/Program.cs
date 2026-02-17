using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr4._1
{
    internal class Program
    {
        static bool CheckLenthPassword(string password)
        {
           if (password.Length >= 8)
               return true;
            else
              return false; 
        }
        static bool CheckNumInPass(string password)
        {
            if (!password.Any(c => char.IsDigit(c)))
            {
                return false;
            }
            else
                return true;
        }
        static bool UpLetInPass(string password)
        {
            if(password.Any(c => char.IsUpper(c)))
            {
                return true;
            }
            else
                return false;
        }
        static string CheckPass(string password)
        {
            bool checklen = CheckLenthPassword(password);
            bool checknum = CheckNumInPass(password);
            bool checkup = UpLetInPass(password);
            if (checklen && checknum && checkup)
                return $"ваш пароль содержит:{checklen}, {checknum}, {checkup}. это надежный пароль";
            else
                return "ваш пароль не надежный";
        }

        static void Main(string[] args)
        {
            Console.WriteLine("введите пароль:");
            string password= Console.ReadLine();
            Console.WriteLine(CheckPass(password));
        }
    }
}
