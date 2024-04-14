using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckersGame.Models
{
    public class Piece : INotifyPropertyChanged
    {

        private EColor _color;
        private EType _type;
        private ECheckerType _checkerType;
        private bool _isNull;

        public EColor Color
        {
            get { return _color; }
            set
            {
                _color = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Color)));
            }
        }
        public EType Type
        {
            get { return _type; }
            set
            {
                _type = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Type)));
            }
        }
        public bool IsNull
        {
            get => _isNull;
            set
            {
                _isNull = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(IsNull)));
            }
        }
        public ECheckerType CheckerType
        {
            get { return _checkerType; }
            set
            {
                _checkerType = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(CheckerType)));
            }
        }
        public int Line { get; set; }
        public int Column { get; set; }
        public bool IsDark { get; set; }
        public IMovement Movement { get; set; }

        public Piece(int line, int column)
        {
            Color = EColor.None;
            Type = EType.None;
            IsNull = true;
            Line = line;
            Column = column;
            IsDark = (line + column) % 2 == 1;
        }
        public Piece(EColor color, EType type, int line, int column)
        {
            Color = color;
            Type = type;
            Line = line;
            Column = column;
            IsDark = (line + column) % 2 == 1;
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

        public event PropertyChangedEventHandler PropertyChanged;

        public void Clear()
        {
            Color = EColor.None;
            Type = EType.None;
            IsNull = true;
            CheckerType = ECheckerType.None;
        }

        public void MoveTo(Piece destiantion)
        {
            destiantion.Color = Color;
            destiantion.Type = Type;
            destiantion.CheckerType = CheckerType;
            destiantion.Movement = Movement;
            destiantion.IsNull = false;
            destiantion.UpdateType();
        }

        private void UpdateType()
        {
            if (Line == 0 && Color == EColor.Black)
            {
                Movement = new BlackKingMovement();
                CheckerType = ECheckerType.BlackKing;
            }
            else if (Line == 7 && Color == EColor.White)
            {
                Movement = new WhiteKingMovement();
                CheckerType = ECheckerType.WhiteKing;
            }
        }

        public override string ToString()
        {
            if (IsNull) return "No piece selected.";
            return $"Piece - Color: {Color}, Type: {Type}, \n CheckerType: {CheckerType},  \n Position: ({Line}, {Column})";
        }
    }
}
