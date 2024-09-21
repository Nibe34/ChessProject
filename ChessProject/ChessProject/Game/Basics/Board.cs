using ChessProject.Game.Pieces;

namespace ChessProject.Game.Basics;

public class Board
{
    private Piece?[,] _fieldsMatrix;

    private Board(Piece?[,] fieldsMatrix)
    {
        _fieldsMatrix = fieldsMatrix;
    }

    public int GetWidth()
    {
        return _fieldsMatrix.GetLength(1);
    }

    public int GetHeight()
    {
        return _fieldsMatrix.GetLength(0);
    }

    public Piece?[,] GetFieldsMatrix()
    {
        return _fieldsMatrix;
    }

    public void InitializeBoardWithClassicConfiguration()
    {
        Board board = new Board(new Piece?[8, 8])
        {
            _fieldsMatrix =
            {
                [0, 0] = new Rook(true),
                [1, 0] = new Knight(true),
                [2, 0] = new Bishop(true),
                [3, 0] = new Queen(true),
                [4, 0] = new King(true),
                [5, 0] = new Bishop(true),
                [6, 0] = new Knight(true),
                [7, 0] = new Rook(true),
                
                [0, 1] = new Pawn(true),
                [1, 1] = new Pawn(true),
                [2, 1] = new Pawn(true),
                [3, 1] = new Pawn(true),
                [4, 1] = new Pawn(true),
                [5, 1] = new Pawn(true),
                [6, 1] = new Pawn(true),
                [7, 1] = new Pawn(true),
                
                
                [0, 7] = new Rook(false),
                [1, 7] = new Knight(false),
                [2, 7] = new Bishop(false),
                [3, 7] = new Queen(false),
                [4, 7] = new King(false),
                [5, 7] = new Bishop(false),
                [6, 7] = new Knight(false),
                [7, 7] = new Rook(false),
                
                [0, 6] = new Pawn(false),
                [1, 6] = new Pawn(false),
                [2, 6] = new Pawn(false),
                [3, 6] = new Pawn(false),
                [4, 6] = new Pawn(false),
                [5, 6] = new Pawn(false),
                [6, 6] = new Pawn(false),
                [7, 6] = new Pawn(false)
            }
        };
    }
}