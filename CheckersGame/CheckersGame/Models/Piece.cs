using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckersGame.Models
{
    public class Piece
    {
        public EColor Color { get; set; }
        public EType Type { get; set; }
        public int Line { get; set; }
        public int Column { get; set; }
        public bool IsNull { get; set; }
        public ECheckerType CheckerType { get; set; }
        public IMovement Movement { get; set; }

        public Piece(int line, int column)
        {
            Color = EColor.None;
            Type = EType.None;
            IsNull = true;
            Line = line;    
            Column = column;
        }
        public Piece(EColor color, EType type, int line, int column)
        {
            Color = color;
            Type = type;
            Line = line;
            Column = column;
            IsNull = false;

            if (type == EType.King)
            {
                if (Color == EColor.Black)
                {
                    Movement = new BlackKingMovement();
                    CheckerType = ECheckerType.BlackKing;
                }
                else
                {
                    Movement = new WhiteKingMovement();
                    CheckerType = ECheckerType.WhiteKing;
                }
            }
            else if (type == EType.Queen)
            {
                if (Color == EColor.Black)
                {
                    Movement = new BlackQueenMovement();
                    CheckerType = ECheckerType.BlackQueen;
                }
                else
                {
                    Movement = new WhiteQueenMovement();
                    CheckerType = ECheckerType.WhiteQueen;
                }
            }
        }

        public void Clear()
        {
            Color = EColor.None;
            Type = EType.None;
            IsNull = true;
        }

        public void MoveTo(Piece destiantion)
        {
            destiantion.Color = Color;
            destiantion.Type = Type;
            destiantion.CheckerType = CheckerType;
            destiantion.Movement = Movement;
            destiantion.IsNull = false;
        }
    }
}
