using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckersGame.Models
{
    internal class Piece
    {
        public EColor Color { get; set; }
        public EType Type
        {
            get
            {
                return Type;
            }
            set
            {
                if (value == EType.King)
                {
                    if (Color == EColor.Black)
                        Movement = new BlackKingMovement();
                    else
                        Movement = new WhiteKingMovement();
                }
                else if (value == EType.Queen)
                {
                    if (Color == EColor.Black)
                        Movement = new BlackQueenMovement();
                    else
                        Movement = new WhiteQueenMovement();
                }
            }
        }

        public bool IsNull { get; set; }

        public IMovement Movement { get; set; }

        public Piece()
        {
            Color = EColor.None;
            Type = EType.None;
            IsNull = true;
        }
        public Piece(EColor color, EType type)
        {
            Color = color;
            Type = type;
            IsNull = false;
        }
    }
}
