using InternTask.Entities;
using InternTask.Utils;
using System;
using System.Collections.Generic;

namespace InternTask
{
    public class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            string[] splittedInput = input.Split(' ');


            Console.WriteLine("\n-- You have entered: ");
            Console.WriteLine("JSON data path: " + splittedInput[0] +
                "\nMaximum number of years: " + splittedInput[1] +
                "\nMinimum qualifying rating: " + splittedInput[2] +
                "\nThe path to the CSV file: " + splittedInput[3]);


            try
            {
                List<BasketballPlayer> Players = LoadData.ReadInfo(splittedInput[0]);

                int MaxYearNumber = int.Parse(splittedInput[1]);
                int MinRating = int.Parse(splittedInput[2]);
                string ResultPath = splittedInput[3];

                GenerateData.CreateCsvFile(FilterData.FilterPlayers(Players,MaxYearNumber,MinRating),ResultPath);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            Console.ReadKey();
        }
    }
}
