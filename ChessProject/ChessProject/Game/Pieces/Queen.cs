using ChessProject.Game.Basics;

namespace ChessProject.Game.Pieces;

public class Queen : Piece
{
    public Queen(bool isWhite)
    {
        base.IsWhite = isWhite;
        PieceValue = 9;
    }
    
}