using System.Collections.ObjectModel;

namespace CheckersGame.Models
{
    public interface IMovement
    {
        Collection<Position> GetPosibleMovements(Position pos);
    }
}