using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckersGame.Models
{
    internal class Piece
    {
        public EColor Color { get; set; }
        public EType Type { get; set; }
        public Piece(EColor color, EType type)
        {
            Color = color;
            Type = type;
        }
    }
}
