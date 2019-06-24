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
            Console.WriteLine("Please enter as follows: {json data path} {Maximum years} {Minimum rating} {new file path}");
            var Input = Console.ReadLine();
            string[] SplittedInput = Input.Split(' ');


            Console.WriteLine("\n-- A check on your input. You have entered: ");
            Console.WriteLine("JSON data path: " + SplittedInput[0] +
                "\nMaximum number of years: " + SplittedInput[1] +
                "\nMinimum qualifying rating: " + SplittedInput[2] +
                "\nThe path to the CSV file: " + SplittedInput[3]);


            try
            {
                List<BasketballPlayer> Players = LoadData.ReadPlayerInfo(SplittedInput[0]);

                int MaxYearNumber = int.Parse(SplittedInput[1]);
                int MinRating = int.Parse(SplittedInput[2]);
                string ResultPath = SplittedInput[3];

                GenerateData.CreateCsvFile(FilterData.FilterPlayers(Players,MaxYearNumber,MinRating),ResultPath);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("n You have entered either less or more than 4 arguments.");
                Console.WriteLine(ex);
            }
            catch (Exception)
            {
                Console.WriteLine("\n There was a problem with input.");
            }

            Console.ReadKey();
        }
    }
}
