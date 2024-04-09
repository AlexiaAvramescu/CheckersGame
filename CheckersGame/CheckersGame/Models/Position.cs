using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckersGame.Models
{
    public struct Position
    {
        int Line { get; set; }
        int Column { get; set; }
        Position(int line, int column) { Line = line; Column = column; }
    }
}
