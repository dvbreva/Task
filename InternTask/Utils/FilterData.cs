using InternTask.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace InternTask.Utils
{
    public class FilterData
    {
        public static List<BasketballPlayer> FilterPlayers(List<BasketballPlayer> basketballPlayers, int maxYearNumber, int minRating)
        {
            List<BasketballPlayer> filteredPlayers = new List<BasketballPlayer>();

            foreach(var player in basketballPlayers)
            {
                if (player.Rating >= minRating && (DateTime.Now.Year-player.PlayingSince <= maxYearNumber))
                {
                    filteredPlayers.Add(player);
                }
                // sort them as well
                filteredPlayers.OrderByDescending(x => x.Rating);
            }

            return filteredPlayers;
        }
    }
}
