using ChessProject.Game.Basics;

namespace ChessProject.Game.Pieces;

public class Bishop : Piece
{
    public Bishop(bool isWhite)
    {
        base.IsWhite = isWhite;
        PieceValue = 3;
    }
    
}