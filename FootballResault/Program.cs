using System;
using System.Collections.Generic;


namespace FootballResault
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Result.resList.ForEach(x => {ParseResult(x);});

            Console.WriteLine($"Очков у команды 1: {score[0]}, Очков у команды 2: {score[1]}");
            Console.ReadLine();
        }

        static void ParseResult(string str)
        {
            try
            {
                string[] words = str.Split(':');

                if (words.Length != 2)
                    throw new Exception();

                scoreAdd(new int[] {Int32.Parse(words[0]), Int32.Parse(words[1])});
            }
            catch
            {
                Console.WriteLine($"Ошибка в строке '{str}' ");
            }
        }


        static private int[] score = { 0, 0 }; 

        public static void scoreAdd(int [] res)
        {
            if (res[0] == res[1])// Ничья
            {
                score[0]++;
                score[1]++;
                return;
            }
            else if (res[0] > res[1])// Победа 1 команды
            {
                score[0] = score[0] + 3;
                return;
            }
            else // Победа 2 команды
            {
                score[1] = score[1] + 3;
                return;
            }

        }

    }
 
    public static class Result
    {
        public static List<string> resList = new List<string>() {" ","213", "a:3","1:", "12:2", "0", "2:3:2", "3:1", "2:2", "0:1", "4:2","3:a", "3- 12"};
    }
                    
}
