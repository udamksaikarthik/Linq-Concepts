using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Linq_Concepts
{
    public class Game
    {
        public string Name {  get; set; } = string.Empty;
        public string Genre { get; set; } = string.Empty;
        public List<string> Platforms { get; set; } = new List<string>();
        public double Rating { get; set; }
        public int ReleaseYear { get; set; }
        public double Price { get; set; }

    }
}
