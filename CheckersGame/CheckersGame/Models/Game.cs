using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckersGame.Models
{
    internal class Game
    {
        public string Name { get; set; }
        public Board Board { get; set; }
        public string PlayerWhite { get; set; }
        public string PlayerBlack { get; set; }
        public bool MultipleJumps { get; set; }
        public Game() { }

        public Game(string name, string whitePlayer, string blackPlayer, bool multipleJumps)
        {
            Name = name;
            Board = new Board();
            PlayerWhite = whitePlayer;
            PlayerBlack = blackPlayer;
            MultipleJumps = multipleJumps;
        }



    }
}
