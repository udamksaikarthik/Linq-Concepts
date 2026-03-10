using System;
using System.Collections.Generic;

namespace Linq_Concepts
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var linqOperations = new LinqOperations();

            List<Game> games = new List<Game>
            {
                    new Game(){ Name = "The Legend of Zelda: Breath of the Wild", Genre = "Action-Adventure", Platforms = new List<string>{ "Nintendo Switch", "Wii U" }, Rating = 9.5, ReleaseYear = 2017, Price = 59.99 },
                    new Game(){ Name = "God of War", Genre = "Action-Adventure", Platforms = new List<string>{ "PS4", "PC" }, Rating = 9.8, ReleaseYear = 2018, Price = 49.99 },
                    new Game(){ Name = "Red Dead Redemption 2", Genre = "Action-Adventure", Platforms = new List<string>{ "PS4", "Xbox One", "PC" }, Rating = 9.7, ReleaseYear = 2018, Price = 59.99 },
                    new Game(){ Name = "The Witcher 3: Wild Hunt", Genre = "RPG", Platforms = new List<string>{ "PC", "PS4", "Xbox One", "Nintendo Switch" }, Rating = 9.6, ReleaseYear = 2015, Price = 39.99 },
                    new Game(){ Name = "Cyberpunk 2077", Genre = "RPG", Platforms = new List<string>{ "PC", "PS4", "Xbox One", "PS5", "Xbox Series X" }, Rating = 7.5, ReleaseYear = 2020, Price = 59.99 },
                    new Game(){ Name = "Hades", Genre = "Roguelike", Platforms = new List<string>{ "PC", "Nintendo Switch", "PS4", "Xbox One" }, Rating = 9.0, ReleaseYear = 2020, Price = 24.99 },
                    new Game(){ Name = "Among Us", Genre = "Party", Platforms = new List<string>{ "PC", "iOS", "Android", "Nintendo Switch" }, Rating = 8.0, ReleaseYear = 2018, Price = 4.99 },
                    new Game(){ Name = "Minecraft", Genre = "Sandbox", Platforms = new List<string>{ "PC", "Xbox One", "PS4", "Nintendo Switch", "iOS", "Android" }, Rating = 9.2, ReleaseYear = 2011, Price = 26.95 },
                    new Game(){ Name = "Fortnite", Genre = "Battle Royale", Platforms = new List<string>{ "PC", "PS4", "Xbox One", "Nintendo Switch", "iOS", "Android" }, Rating = 8.5, ReleaseYear = 2017, Price = 0.00 },
                    new Game(){ Name = "Apex Legends", Genre = "Battle Royale", Platforms = new List<string>{ "PC", "PS4", "Xbox One", "Nintendo Switch" }, Rating = 8.7, ReleaseYear = 2019, Price = 0.00 },
                    new Game(){ Name = "Call of Duty: Warzone", Genre = "Battle Royale", Platforms = new List<string>{ "PC", "PS4", "Xbox One" }, Rating = 8.3, ReleaseYear = 2020, Price = 0.00 },
                    new Game(){ Name = "Valorant", Genre = "FPS", Platforms = new List<string>{ "PC" }, Rating = 8.4, ReleaseYear = 2020, Price = 0.00 },
                    new Game(){ Name = "Overwatch", Genre = "FPS", Platforms = new List<string>{ "PC", "PS4", "Xbox One", "Nintendo Switch" }, Rating = 8.9, ReleaseYear = 2016, Price = 39.99 },
                    new Game(){ Name = "League of Legends", Genre = "MOBA", Platforms = new List<string>{ "PC" }, Rating = 8.6, ReleaseYear = 2009, Price = 0.00 },
                    new Game(){ Name = "Dota 2", Genre = "MOBA", Platforms = new List<string>{ "PC" }, Rating = 8.7, ReleaseYear = 2013, Price = 0.00 },
                    new Game(){ Name = "World of Warcraft", Genre = "MMORPG", Platforms = new List<string>{ "PC" }, Rating = 9.0, ReleaseYear = 2004, Price = 14.99 },
                    new Game(){ Name = "Final Fantasy VII Remake", Genre = "RPG", Platforms = new List<string>{ "PS4", "PS5" }, Rating = 9.3, ReleaseYear = 2020, Price = 59.99 },
                    new Game(){ Name = "Resident Evil Village", Genre = "Horror", Platforms = new List<string>{ "PC", "PS5", "PS4", "Xbox Series X", "Xbox One" }, Rating = 8.5, ReleaseYear = 2021, Price = 59.99 },
                    new Game(){ Name = "Ghost of Tsushima", Genre = "Action-Adventure", Platforms = new List<string>{ "PS4", "PS5" }, Rating = 9.4, ReleaseYear = 2020, Price = 59.99 },
                    new Game(){ Name = "Animal Crossing: New Horizons", Genre = "Simulation", Platforms = new List<string>{ "Nintendo Switch" }, Rating = 9.1, ReleaseYear = 2020, Price = 59.99 },
                    new Game(){ Name = "Genshin Impact", Genre = "Action RPG", Platforms = new List<string>{ "PC", "PS4", "PS5", "iOS", "Android" }, Rating = 8.8, ReleaseYear = 2020, Price = 0.00 },
                    new Game(){ Name = "Hollow Knight", Genre = "Metroidvania", Platforms = new List<string>{ "PC", "Nintendo Switch", "PS4", "Xbox One" }, Rating = 9.2, ReleaseYear = 2017, Price = 14.99 },
                    new Game(){ Name = "Celeste", Genre = "Platformer", Platforms = new List<string>{ "PC", "Nintendo Switch", "PS4", "Xbox One" }, Rating = 9.5, ReleaseYear = 2018, Price = 19.99 },
                    new Game(){ Name = "Stardew Valley", Genre = "Simulation", Platforms = new List<string>{ "PC", "Nintendo Switch", "PS4", "Xbox One", "iOS", "Android" }, Rating = 9.3, ReleaseYear = 2016, Price = 14.99 },
                    new Game(){ Name = "The Last of Us Part II", Genre = "Action-Adventure", Platforms = new List<string>{ "PS4", "PS5" }, Rating = 9.6, ReleaseYear = 2020, Price = 59.99 },
                    new Game(){ Name = "Death Stranding", Genre = "Action-Adventure", Platforms = new List<string>{ "PS4", "PC", "PS5" }, Rating = 8.9, ReleaseYear = 2019, Price = 59.99 },
                    new Game(){ Name = "Sekiro: Shadows Die Twice", Genre = "Action-Adventure", Platforms = new List<string>{ "PS4", "Xbox One", "PC" }, Rating = 9.4, ReleaseYear = 2019, Price = 59.99 },
                    new Game(){ Name = "Mass Effect 2", Genre = "RPG", Platforms = new List<string>{ "PC", "Xbox 360", "PS3" }, Rating = 9.5, ReleaseYear = 2010, Price = 19.99 },
                    new Game(){ Name = "Uncharted 4: A Thief's End", Genre = "Action-Adventure", Platforms = new List<string>{ "PS4" }, Rating = 9.1, ReleaseYear = 2016, Price = 29.99 },
                    new Game(){ Name = "Metal Gear Solid V: The Phantom Pain", Genre = "Action", Platforms = new List<string>{ "PS4", "Xbox One", "PC" }, Rating = 9.0, ReleaseYear = 2015, Price = 39.99 },
                    new Game(){ Name = "Marvel's Spider-Man", Genre = "Action", Platforms = new List<string>{ "PS4", "PC", "PS5" }, Rating = 8.9, ReleaseYear = 2018, Price = 39.99 },
                    new Game(){ Name = "Batman: Arkham City", Genre = "Action", Platforms = new List<string>{ "PS3", "Xbox 360", "PC" }, Rating = 9.2, ReleaseYear = 2011, Price = 9.99 },
                    new Game(){ Name = "Portal 2", Genre = "Puzzle", Platforms = new List<string>{ "PC", "PS3", "Mac" }, Rating = 9.6, ReleaseYear = 2011, Price = 9.99 },
                    new Game(){ Name = "Half-Life 2", Genre = "FPS", Platforms = new List<string>{ "PC", "Xbox" }, Rating = 9.7, ReleaseYear = 2004, Price = 7.99 },
                    new Game(){ Name = "BioShock", Genre = "FPS", Platforms = new List<string>{ "PC", "PS3", "Xbox 360" }, Rating = 9.4, ReleaseYear = 2007, Price = 14.99 },
                    new Game(){ Name = "Dishonored", Genre = "Stealth", Platforms = new List<string>{ "PC", "PS3", "Xbox 360", "PS4", "Xbox One" }, Rating = 9.0, ReleaseYear = 2012, Price = 19.99 },
                    new Game(){ Name = "The Elder Scrolls V: Skyrim", Genre = "RPG", Platforms = new List<string>{ "PC", "PS3", "Xbox 360", "PS4", "Xbox One", "Nintendo Switch" }, Rating = 9.5, ReleaseYear = 2011, Price = 39.99 },
                    new Game(){ Name = "Fallout 4", Genre = "RPG", Platforms = new List<string>{ "PC", "PS4", "Xbox One" }, Rating = 8.8, ReleaseYear = 2015, Price = 29.99 },
                    new Game(){ Name = "Borderlands 2", Genre = "Shooter", Platforms = new List<string>{ "PC", "PS3", "Xbox 360", "PS4", "Xbox One" }, Rating = 9.1, ReleaseYear = 2012, Price = 14.99 },
                    new Game(){ Name = "Cuphead", Genre = "Platformer", Platforms = new List<string>{ "PC", "Xbox One", "Nintendo Switch", "PS4" }, Rating = 8.7, ReleaseYear = 2017, Price = 19.99 },
                    new Game(){ Name = "Undertale", Genre = "RPG", Platforms = new List<string>{ "PC", "PS4", "Nintendo Switch" }, Rating = 9.3, ReleaseYear = 2015, Price = 9.99 },
                    new Game(){ Name = "Persona 5", Genre = "RPG", Platforms = new List<string>{ "PS3", "PS4", "PC" }, Rating = 9.4, ReleaseYear = 2016, Price = 49.99 },
                    new Game(){ Name = "Mario Kart 8 Deluxe", Genre = "Racing", Platforms = new List<string>{ "Nintendo Switch" }, Rating = 9.0, ReleaseYear = 2017, Price = 59.99 },
                    new Game(){ Name = "Super Mario Odyssey", Genre = "Platformer", Platforms = new List<string>{ "Nintendo Switch" }, Rating = 9.7, ReleaseYear = 2017, Price = 59.99 },
                    new Game(){ Name = "Super Smash Bros. Ultimate", Genre = "Fighting", Platforms = new List<string>{ "Nintendo Switch" }, Rating = 9.5, ReleaseYear = 2018, Price = 59.99 },
                    new Game(){ Name = "Tetris Effect", Genre = "Puzzle", Platforms = new List<string>{ "PS4", "PC", "Xbox One", "Nintendo Switch" }, Rating = 8.6, ReleaseYear = 2018, Price = 39.99 },
                    new Game(){ Name = "Dead Cells", Genre = "Roguelike", Platforms = new List<string>{ "PC", "PS4", "Xbox One", "Nintendo Switch" }, Rating = 8.8, ReleaseYear = 2018, Price = 24.99 },
                    new Game(){ Name = "Monster Hunter: World", Genre = "Action", Platforms = new List<string>{ "PS4", "Xbox One", "PC" }, Rating = 9.0, ReleaseYear = 2018, Price = 39.99 },
                    new Game(){ Name = "No Man's Sky", Genre = "Exploration", Platforms = new List<string>{ "PC", "PS4", "Xbox One", "Nintendo Switch" }, Rating = 8.2, ReleaseYear = 2016, Price = 29.99 },
                    new Game(){ Name = "The Outer Worlds", Genre = "RPG", Platforms = new List<string>{ "PC", "PS4", "Xbox One", "Nintendo Switch" }, Rating = 8.4, ReleaseYear = 2019, Price = 39.99 },
                    new Game(){ Name = "Ori and the Will of the Wisps", Genre = "Platformer", Platforms = new List<string>{ "PC", "Xbox One", "Nintendo Switch", "PS4" }, Rating = 9.1, ReleaseYear = 2020, Price = 29.99 },
                    new Game(){ Name = "Horizon Zero Dawn", Genre = "Action RPG", Platforms = new List<string>{ "PS4", "PC", "PS5" }, Rating = 9.0, ReleaseYear = 2017, Price = 49.99 },
                    new Game(){ Name = "A Plague Tale: Innocence", Genre = "Adventure", Platforms = new List<string>{ "PC", "PS4", "Xbox One", "Nintendo Switch" }, Rating = 8.6, ReleaseYear = 2019, Price = 39.99 }
              };

            linqOperations.PerformLinqOperations(games);
        }
    }
}