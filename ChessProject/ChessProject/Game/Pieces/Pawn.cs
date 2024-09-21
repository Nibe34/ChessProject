using ChessProject.Game.Basics;

namespace ChessProject.Game.Pieces;

public class Pawn : Piece
{
    public Pawn(bool isWhite)
    {
        base.IsWhite = isWhite;
        PieceValue = 1;
    }
    
    

}