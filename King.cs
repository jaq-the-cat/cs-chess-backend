using System;

namespace cs_chess_backend
{
    public struct Castle
    {
        public bool queenSide, kingSide;
    }

    public class King : Piece
    {

        private bool hasMoved;
        public Piece queenSideRook;
        public Piece kingSideRook;

        public King(int x, int y, Piece queenSideRook, Piece kingSideRook)
        : base(x, y)
        {
            this.queenSideRook = queenSideRook;
            this.kingSideRook = kingSideRook;
        }

        public Castle CanCastle()
        {
            return new Castle()
            {
                queenSide = false,
                kingSide = false
            };
        }

        protected override bool CanMove(int tx, int ty)
        {
            return false;
        }
    }
}
