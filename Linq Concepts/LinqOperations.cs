using System;
using System.Collections.Generic;
using System.Text;

namespace Linq_Concepts
{
    public class LinqOperations
    {
        public void PerformLinqOperations(List<Game> games)
        {
            if (games == null || games.Count == 0)
            {
                Console.WriteLine("No games available to perform LINQ operations.");
                return;
            }
            //Show all games info

            //var allGameNames = games.Select(g => g.Name);
            //foreach(var name in allGameNames)
            //{
            //    Console.WriteLine(name);
            //}

            // Example of a LINQ query to filter games with a rating above 9.0
            //var highlyRatedGames = games.Where(g => g.Rating > 9.0)
            //    .OrderByDescending(g => g.Rating);
            //Console.WriteLine("Highly Rated Games");
            //Console.WriteLine(@"------------------");
            //foreach (var game in highlyRatedGames)
            //{
            //    Console.WriteLine($"{game.Name} - {game.Rating}");
            //}

            //Example of a LINQ query to group games by genre
            //var gamesByGenre = games.OrderBy(g => g.ReleaseYear)
            //    .GroupBy(g => g.Genre)
            //    .OrderByDescending(g => g.Count());
            //Console.WriteLine("Games Grouped by Genre");
            //Console.WriteLine(@"------------------");
            //foreach (var game in gamesByGenre)
            //{
            //    Console.WriteLine(game.Key);
            //    Console.WriteLine(@"------------------");
            //    foreach (var g in game)
            //    {
            //        Console.WriteLine($"  {g.Name} - {g.Rating} - {g.ReleaseYear}");
            //    }
            //}

            //Average price and rating of games released after 2015
            //var gamesByGenre = games.Where(g => g.ReleaseYear > 2015)
            //    .GroupBy(g => g.Genre)
            //    .OrderByDescending(g => g.Count());
            //Console.WriteLine("Games Grouped by Genre");
            //Console.WriteLine(@"------------------");
            //foreach (var game in gamesByGenre)
            //{
            //    Console.WriteLine(game.Key);
            //    Console.WriteLine(@"------------------");

            //    // Calculate averages for the group (price and rating)
            //    var avgPrice = game.Average(g => g.Price);
            //    var avgRating = game.Average(g => g.Rating);
            //    Console.WriteLine($"  Average Price: {avgPrice:F2}, Average Rating: {avgRating:F2}");

            //}

            // Example of a LINQ query to find the top 3 most expensive games

            //var topExpensiveGames = games.OrderByDescending(g => g.Price)
            //    .Take(3);

            //foreach (var game in topExpensiveGames)
            //{
            //    Console.WriteLine($"{game.Name} - {game.Price}"); 

            //}

            // Example of a Linq Query to show games that can only played on ps4

            //var switchExclusiveGames = games.Where(g => g.Platforms.Contains("PS4") && g.Platforms.Count == 1);

            //foreach (var game in switchExclusiveGames)
            //{
            //    Console.WriteLine($"{game.Name} - {string.Join(", ", game.Platforms)}");

            //}
        }
    }
}
