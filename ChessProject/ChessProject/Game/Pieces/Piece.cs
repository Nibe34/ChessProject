using ChessProject.Game.Basics;

namespace ChessProject.Game.Pieces;

public abstract class Piece
{
    protected bool IsWhite;
    protected int? PieceValue;


    public Position? GetPosition(Board board)
    {
        Piece?[,] fieldsMatrix = board.GetFieldsMatrix();
        for (int i = 0; i < board.GetHeight(); i++)
        {
            for (int j = 0; j < board.GetWidth(); j++)
            {
                if (fieldsMatrix[i, j] == this)
                {
                    return new Position(i, j);
                }
            }
        }
        return null;
    }
    
}