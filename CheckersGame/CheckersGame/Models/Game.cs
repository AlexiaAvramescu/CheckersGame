using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckersGame.Models
{
    public class Game
    {
        public string Name { get; set; }
        public Board Board { get; set; }
        public string PlayerWhite { get; set; }
        public string PlayerBlack { get; set; }
        public bool MultipleJumps { get; set; }
        public Game()
        {
            Board = new Board();
        }

        public Game(string name, string whitePlayer, string blackPlayer, bool multipleJumps)
        {
            Name = name;
            Board = new Board();
            PlayerWhite = whitePlayer;
            PlayerBlack = blackPlayer;
            MultipleJumps = multipleJumps;
        }

        public void MakeMove(Piece pieceToMove, Piece destination)
        {
            Collection<int> possiblePositions = pieceToMove.Movement.GetPosibleMovements(Board.Pieces, new Position(pieceToMove.Line, pieceToMove.Column), MultipleJumps);
            Collection<int> eva = Board.Pieces[21].Movement.GetPosibleMovements(Board.Pieces, new Position(2, 5), MultipleJumps);
            int destinationIndex = destination.Line * 8 + destination.Column;
            if (!possiblePositions.Contains(destinationIndex))
                return;
            Board.MakeMove(pieceToMove, destination);
        }

    }
}
