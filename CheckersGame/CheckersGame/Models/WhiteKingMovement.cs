using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckersGame.Models
{
    internal class WhiteKingMovement : IMovement
    {
        public Collection<int> GetPosibleMovements(ObservableCollection<Piece> board, Position fromPos, bool multipleJumps)
        {
            throw new NotImplementedException();
        }
    }
}
