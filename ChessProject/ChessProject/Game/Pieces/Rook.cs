using ChessProject.Game.Basics;

namespace ChessProject.Game.Pieces;

public class Rook : Piece
{
    public Rook(bool isWhite)
    {
        base.IsWhite = isWhite;
        PieceValue = 5;
    }
    
}