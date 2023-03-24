using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace kheirshalaby
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Welcome to amir's game");
            char[] lines = {'_', '_', '_', '_' };
            string tw = getTodayWord();
            int heart = tw.Length;
            printLines(lines);
            while (heart > 0)
            {

                char C = askuser();
                int result = checkLetter(tw, C, lines);
                if (result == -1)
                {
                    heart--;
                 Console.WriteLine("You have " + heart + " hearts left");
                
                }
                
                else
                {
                    lines[result] = C;
                    Console.WriteLine("Thats the one, keep going");
                }

                printLines(lines);

                if (checkWin(tw, lines)) {
                    break;
                }
            }

            if (heart <= 0)
            {
                Console.WriteLine("HAHAHA You lose!");
            } else
            {
                Console.WriteLine("You won ;)");
            }
            



        }
        public static char askuser()
        {
            Console.WriteLine("enter a character");
            var v = Console.ReadLine()[0];
            char c = v;
            return c;
        }
        public static string getTodayWord()
        {
            string[] words = { "home", "word", "farm", "camp", "luck", "love","limb","duck","kick","crew","bell","bear","play","sing","dark","tree","bird","free","bind"};
            Random rnd = new Random();
            int num = rnd.Next(0, words.Length);
            return words[num];
        }
        public static int checkLetter(string todayword, char ch, char[] lines)
        {
            for (int i = 0; i < todayword.Length; i++)
            {
                if (todayword[i] == ch && lines[i] != ch)
                {
                    return i;
                }
            }
            return -1;
        }
        public static bool checkWin(string todayWord, char[] lines)
        {
            for (int i = 0; i < lines.Length; i++)
            {
                if (todayWord[i] != lines[i])
                {
                    return false;
                }
            }
            return true;


        }
        
        public static void printLines(char[] lines) {
            for (int i = 0; i < lines.Length; i++)
            {
                Console.Write(lines[i] + " ");
            }

            Console.WriteLine();
        }
    }
}
