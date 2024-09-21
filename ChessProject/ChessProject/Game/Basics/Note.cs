using System.Text.RegularExpressions;
using ChessProject.Game.Pieces;

namespace ChessProject.Game.Basics;

public class Note
{
    private string _record;                             // спершу чекати стовпець, потім рядок (тобто спершу х потім у)
    private Piece _piece;
    private Position _startPosition;
    private Position _endPosition;
    private bool _isWhitesMove;
    private bool _isValidMove;
    private bool _isCapture;
    private bool _isEnPassant;
    private bool _isCheck;  // важливо, що шах чи мат можна поставити не помітивши цього
    private bool _isMate;
    private bool _isCastling;
    private bool _isPawnPromotion;
    private bool _isDrawOffer;
    private bool _isResign;
    private bool _isEndOfGame;


    public Note(string record, bool isWhitesMove)
    {
        _record = record;
        _isWhitesMove = isWhitesMove;
        _isCapture = Regex.IsMatch(record, @"x", RegexOptions.IgnoreCase);
        _isEnPassant = Regex.IsMatch(record, @"e[^a-zA-Z0-9]*p", RegexOptions.IgnoreCase);
        _isCheck = Regex.IsMatch(record, @"[+#]");
        _isMate = Regex.IsMatch(record, @"[#]");
        _isCastling = Regex.IsMatch(record, @"0-0(-0)?");
    }
    
    
    
    
}