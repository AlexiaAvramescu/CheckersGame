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
        public Player PlayerWhite { get; set; }
        public Player PlayerBlack { get; set; }
        public bool MultipleJumps { get; set; }
        public Game() { }



    }
}
