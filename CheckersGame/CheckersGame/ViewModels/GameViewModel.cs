using CheckersGame.Commands;
using CheckersGame.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CheckersGame.ViewModels
{
    internal class GameViewModel : BaseViewModel
    {
        public GameViewModel()
        {
            Game = new Game();
            SquareClickCommand = new RelayCommand(SquareClick);
            CurrentPlayer = EColor.Black;
            SelectedPiece = new Piece();
        }
        public Game Game { get; set; }
        public Piece SelectedPiece { get; set; }
        public EColor CurrentPlayer { get; set; }
        public void MakeMove(int x, int y, int toX, int toY) { }
        public ICommand SquareClickCommand { get; set; }
        public void SquareClick(object parameter)
        {
            var piece = parameter as Piece;

            if(piece != null )
            {
                if(!piece.IsNull && SelectedPiece.IsNull && piece.Color == CurrentPlayer)
                {
                    SelectedPiece = piece;
                }
                else if(!SelectedPiece.IsNull && piece.IsNull) 
                {
                }
            }
        }

    }
}
