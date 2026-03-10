using System;
using System.Collections.Generic;
using System.Text;

namespace Linq_Concepts
{
    public class LinqOperations
    {
        public void PerformLinqOperations(List<Game> games)
        {
            if(games == null || games.Count == 0)
            {
                Console.WriteLine("No games available to perform LINQ operations.");
                return;
            }
            //Show all games info
            var allGameNames = games.Select(g => g.Name);
            foreach(var name in allGameNames)
            {
                Console.WriteLine(name);
            }

            // Example of a LINQ query to filter games with a rating above 9.0


            // Example of a LINQ query to group games by genre

        }
    }
}
