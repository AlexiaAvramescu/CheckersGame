﻿using System;
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
            MultipleJumps = false;
        }

        public Game(string name, string whitePlayer, string blackPlayer, bool multipleJumps)
        {
            Name = name;
            Board = new Board();
            PlayerWhite = whitePlayer;
            PlayerBlack = blackPlayer;
            MultipleJumps = multipleJumps;
        }

        public bool MakeMove(Piece pieceToMove, Piece destination, bool firstMoveMade, ref bool firstMoveCapture)
        {
            Collection<int> possiblePositions = pieceToMove.Movement.GetPosibleMovements(Board.Pieces, new Position(pieceToMove.Line, pieceToMove.Column));
            
            int destinationIndex = destination.Line * 8 + destination.Column;
            
            if (!possiblePositions.Contains(destinationIndex))
                return false;
            return Board.MakeMove(pieceToMove, destination, firstMoveMade, ref firstMoveCapture);
        }

    }
}
