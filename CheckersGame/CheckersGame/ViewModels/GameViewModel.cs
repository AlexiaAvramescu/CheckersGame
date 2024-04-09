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
        public Game GameStatus { get; set; }
    }
}
