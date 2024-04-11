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
        //public ObservableCollection<ObservableCollection<Piece>> Pieces { get; set; }
        public ObservableCollection<Piece> Pieces { get; set; }
        public Board()
        {
            //Pieces = new ObservableCollection<ObservableCollection<Piece>>();
            Pieces = new ObservableCollection<Piece>();
            for (int i = 0; i < kLines; i++)
            {
                //Pieces.Add(new ObservableCollection<Piece>());
                for (int j = 0; j < kCollumns; j++)
                {
                    if (i == 0 || i == 1)
                        Pieces.Add(new Piece(EColor.White, EType.Queen));
                    else if (i == 6 || i == 7)
                        Pieces.Add(new Piece(EColor.Black, EType.Queen));
                    else
                    Pieces.Add(new Piece());
                }
            }
        }

    }
}
