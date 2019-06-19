using InternTask.Entities;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace InternTask.Utils
{
    public class LoadData
    {
        public static List<BasketballPlayer> ReadInfo(string path)
        {
            List<BasketballPlayer> players;
           
            using (StreamReader sr = new StreamReader(path))
            {
                string nbaPlayersData = sr.ReadToEnd();

                players = JsonConvert.DeserializeObject<List<BasketballPlayer>>(nbaPlayersData);
            }

            return players;
        }
    }
}
