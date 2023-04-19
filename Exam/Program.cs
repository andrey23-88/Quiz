using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{

    public class theme
    {
        public Dictionary<string, List<string>> slov = new Dictionary<string, List<string>>();

        public string Path { get; set; }

        public void StartGeography()
        {
            string[] questions =
             {
                "Самая высокая гора? эверест или эльбрус? - ",
                "Самая длинная река? амазонка или волга? - ",
                "Самая большая страна? россия или китай? - "
            };
            string[] answers =
            {
                "эверест", "амазонка", "россия"
            };
            int countOfRightAnswers = 0;
            string userAnswer;

            for (int i = 0; i < questions.Length; i++)
            {
                Write(questions[i]);
                userAnswer = ReadLine();
                if (userAnswer.ToLower() == answers[i])
                {
                    countOfRightAnswers++;
                    WriteLine("Ответ верный!");
                }
                else
                {
                    WriteLine("Ответ неверный!");
                }
            }
        }
        public void StartHistory()
        {
            string[] questions =
             {
                "В каком году началась вторая мировая война? 1939 или 1941? - ",
                "Кем был Сталин И.В.? Генералисимус или Генерал? - ",
                "В каком году произошла авария в Чернобыле? 1986 или 1979? - "
            };
            string[] answers =
            {
                "1939", "Генералисимус", "1986"
            };
            int countOfRightAnswers = 0;
            string userAnswer;

            for (int i = 0; i < questions.Length; i++)
            {
                Write(questions[i]);
                userAnswer = ReadLine();
                if (userAnswer.ToLower() == answers[i])
                {
                    countOfRightAnswers++;
                    WriteLine("Ответ верный!");
                }
                else
                {
                    WriteLine("Ответ неверный!");
                }
            }
        }
    }
    public class Start
    {

        public void Pusk()
        {
            theme geo = new theme();
            geo.Path = "geography.txt";
            theme his = new theme();
            his.Path = "history.txt";
            bool flag = true;
            while (flag)
            {
                Clear();
                WriteLine("Выберите тему : \n1 - География\n2 - История\n3 - выход");
                string a = String.Empty;
                ConsoleKeyInfo keyInfo = ReadKey();
                if (keyInfo.Key == ConsoleKey.D1) { a = "1"; }
                else if (keyInfo.Key == ConsoleKey.D2) { a = "2"; }
                else if (keyInfo.Key == ConsoleKey.D3) { a = "3"; }
                Clear();
                switch (a)
                {
                    case "1": geo.StartGeography(); break;
                    case "2": his.StartHistory(); break;
                    case "3": flag = false; WriteLine("До свидания!"); break;
                    default: break;
                }
            }

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            SetCursorPosition(30, 10);
            ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Викторина");
            SetCursorPosition(17, 14);
            Console.WriteLine("Для выбора темы нажмите любую клавишу!");
            ReadKey(); Clear();
            ForegroundColor = ConsoleColor.Gray;
            Start start = new Start();
            start.Pusk();
        }
    }
}