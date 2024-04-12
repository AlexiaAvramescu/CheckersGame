using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckersGame.Models
{
    public class Board
    {
        const int kLines = 8;
        const int kCollumns = 8;
        public ObservableCollection<Piece> Pieces { get; set; }
        public Board()
        {
            Pieces = new ObservableCollection<Piece>();
            for (int i = 0; i < kLines; i++)
            {
                for (int j = 0; j < kCollumns; j++)
                {
                    if (i == 0 && j % 2 == 0 || i == 1 && j % 2 == 1)
                        Pieces.Add(new Piece(EColor.White, EType.Queen, i, j));
                    else if (i == 6 && j % 2 == 1 || i == 7 && j % 2 == 0)
                        Pieces.Add(new Piece(EColor.Black, EType.Queen, i, j));
                    else 
                        Pieces.Add(new Piece());
                }
            }
            Piece piece = new Piece();
        }

    }
}
