using ChessProject.Game.Basics;

namespace ChessProject.Game.Pieces;

public class King : Piece
{
    public King(bool isWhite)
    {
        base.IsWhite = isWhite;
        PieceValue = null;
    }
    
}