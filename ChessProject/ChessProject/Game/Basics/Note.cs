using ChessProject.Game.Pieces;

namespace ChessProject.Game.Basics;

public class Note
{
    private string _record;                             // спершу чекати стовпець, потім рядок (тобто спершу х потім у)
    private Piece _piece;
    private Position _startPosition;
    private Position _endPosition;
    private bool _isWhitesMove;
    private bool? _isCapture;
    private bool? _isEnPassant;
    private bool? _isCheck;
    private bool? _isMate;
    private bool? _isCastling;
    private bool? _isPawnPromotion;
    private bool? _isDrawOffer;
    private bool? _isEndOfGame;

}