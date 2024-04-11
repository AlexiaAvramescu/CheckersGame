using CheckersGame.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckersGame.ViewModels
{
    internal class GameViewModel: BaseViewModel
    {
        public Game Game { get; set; }
        public Position SelectedPiece { get; set; }
        public String CurrentPlayer {  get; set; }
        public void MakeMove(int x, int y,  int toX, int toY) { }

        public GameViewModel() { 
            Game = new Game();
        }

    }
}
