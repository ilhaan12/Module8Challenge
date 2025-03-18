using System;
using System.Collections.Generic;
using System.Linq;

namespace VideoGames
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Create a list of VideoGame objects
            List<VideoGame> games = new List<VideoGame>
            {
                new VideoGame { Name = "Super Mario Bros.", Genre = "Platform", Rating = 4.5 },
                new VideoGame { Name = "The Legend of Zelda", Genre = "Action", Rating = 4.7 },
                new VideoGame { Name = "Minecraft", Genre = "Sandbox", Rating = 4.3 },
                new VideoGame { Name = "Fortnite", Genre = "Battle Royale", Rating = 3.8 },
                new VideoGame { Name = "Halo", Genre = "Shooter", Rating = 4.6 }
            };

            // LINQ query to filter games with rating >= 4
            var topRatedGames = (from game in games
                                 where game.Rating >= 4
                                 select game).ToList();

            // LINQ query to order the games by name
            var sortedGames = (from game in topRatedGames
                               orderby game.Name
                               select game).ToList();

            // Print the sorted top-rated games
            foreach (var game in sortedGames)
            {
                Console.WriteLine(game.Name);
            }
        }
    }
}

