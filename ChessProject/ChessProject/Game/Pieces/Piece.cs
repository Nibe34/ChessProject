namespace ChessProject.Game.Pieces;

public abstract class Piece
{
    private bool _isWhite;
    protected int _position;


    public abstract void move();
}