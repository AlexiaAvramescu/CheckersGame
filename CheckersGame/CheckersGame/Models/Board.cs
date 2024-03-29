using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckersGame.Models
{
    internal class Board
    {
        public ObservableCollection<Piece> Pieces { get; set; }
        public Board() { }

    }
}
