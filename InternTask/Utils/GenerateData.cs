using CsvHelper;
using InternTask.Entities;
using System;
using System.Collections.Generic;
using System.IO;

namespace InternTask.Utils
{
    public class GenerateData
    {
        public static void CreateCsvFile(List<BasketballPlayer> sortedPlayers, string newFilePath)
        {
            if (!File.Exists(newFilePath))
            {
                using (var content = new StreamWriter(newFilePath))
                {
                    using (var csv = new CsvWriter(content))
                    {
                        csv.WriteRecords(sortedPlayers);
                    }
                }
                
                Console.WriteLine("\n-- Successfully added the file.");
            }
            else //if file with selected name already exists but you want to rewrite it for some reason
            {
                Console.WriteLine("\n-- Successfully rewrote the file.");

                File.Delete(newFilePath);

                using (var content = new StreamWriter(newFilePath))
                {
                    using (var csv = new CsvWriter(content))
                    {
                        csv.WriteRecords(sortedPlayers);
                    }
                }
            }
        }
    }
}


