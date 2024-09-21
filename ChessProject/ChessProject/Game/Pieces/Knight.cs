using ChessProject.Game.Basics;

namespace ChessProject.Game.Pieces;

public class Knight : Piece
{    public Knight(bool isWhite)
    {
        base.IsWhite = isWhite;
        PieceValue = 3;
    }
    
}