using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nopr2
{
    internal class Program
    { 
        static int CountWords(string text)// метод посдчета слов
        {
            string[] words = text.Split(new char[] { ' ', '.', ',', '!', ':', ';', '?' }, 
                StringSplitOptions.RemoveEmptyEntries);//разбиваем слова и убираем лишние проьелы
            return words.Length;//возвращаем количество слов
        }
        static int CountsSymbolsWithoutSpaces(string text)//считаем количество символов без пробелов
        {
            int counter = 0;
            foreach (char symbol in text)
            {
                if (symbol != ' ')
                    counter++;
            }
            return counter;
        }
        static string SearchVeryLongWord(string text)//ищем самое длинное слово
        {
            string[] words = text.Split(new char[] { ' ', '.', ',', '!', ':', ';', '?' },
                StringSplitOptions.RemoveEmptyEntries);
            string verylong = "";
            foreach (string word in words)
            {
                if (word.Length > verylong.Length)
                    verylong = word;
            }
            return verylong;
        }
        static bool IsItQestion(string text)//проверка наличия вопроса
        {

            string cleartext = text.Trim();
            if (cleartext.Length == 0)
                return false;
            return cleartext[cleartext.Length - 1] == '?';
        }

        static int CountUnicWords(string text)//подсчет уникальных слов
        {
            string[] words = text.Split(new char[] { ' ', '.', ',', '!', ':', ';', '?' }, 
                StringSplitOptions.RemoveEmptyEntries);
            string[] uniquewords = words.Distinct().ToArray();
            int count = 0;
            foreach (string word in uniquewords)
            {
                count++;
            }
            return count;
        }
        static string GetTone(string text)//определение тона
        {
            string textlower = text.ToLower();
            if (textlower.Contains("хороший") || textlower.Contains("отличный") || textlower.Contains("веселый"))
                return "позитивный";
            if (textlower.Contains("плохой") || textlower.Contains("ужасный") || textlower.Contains("грустный"))
                return "негативный";

            return "нейтральный";
        }
        static string AnalyzeText(string text)//анализ текста
        {
            while (true)
            {
                if (string.IsNullOrEmpty(text))
                    break;
                int words = text.Split(new char[] { ' ', '.', ',', '!', ':', ';', '?' }, StringSplitOptions.RemoveEmptyEntries).Length;
                int unic = CountUnicWords(text);
                string tone = GetTone(text);
                string verylong = SearchVeryLongWord(text);
                bool question = IsItQestion(text);
                int countsymbol = CountsSymbolsWithoutSpaces(text);
                int countwords = CountWords(text);

                //Console.WriteLine("анализ:");
                //Console.WriteLine("1. количетсво слов");
                //Console.WriteLine("2. количетсво уникальных слов");
                //Console.WriteLine("3. тон текста");
                //Console.WriteLine("4. вопрос");
                //Console.WriteLine("5. количество символов без пробелов");
                //Console.WriteLine("введите цифру пункта анализа:");

                //int num = int.Parse(Console.ReadLine());

                return $"количетсво cлов: {words}, из них уникальных: {unic}"+
                   $" тон текста: {tone}, самое длинное: {verylong}, вопрос: {question}"+
                   $" количество символов без пробелов: {countsymbol}, количетсво символов: {countwords}";
            }
            return "вы ввели пустую строку";
        }
    
        static void Main(string[] args)
        {
            bool work = true;

            while (work)
            {
                Console.WriteLine("АНАЛИЗ ТЕКСТА:");
                Console.WriteLine("1. анализ текста");
                //Console.WriteLine("2. анализ нескольких текстов");
                Console.WriteLine("3. выход");
                Console.Write("Выберите действие: ");

                string choice = Console.ReadLine();
                string text;

                switch (choice)
                {
                    case "1":
                        Console.WriteLine("введите текст для анализа");
                        text = Console.ReadLine();
                        Console.WriteLine( AnalyzeText(text));
                        break;
                    //case "2":
                    //    Console.WriteLine("");
                    //    text = Console.ReadLine();
                    //    Console.WriteLine( MuchTexts(text));
                    //    break;
                    case "3":
                        work = false;
                        Console.WriteLine("Программа завершена. До свидания!");
                        break;
                    default:
                        Console.WriteLine("Ошибка! Выберите 1 млм 3");
                        break;
                }
            }
        }

    }
}
