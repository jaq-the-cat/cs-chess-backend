namespace cs_chess_backend {
    public struct Castle {
        public bool queenSide, kingSide;
    }

    public class King : Piece {

        private bool hasMoved;
        public Piece queenSideRook;
        public Piece kingSideRook;

        public King(int ix, int iy, Piece queenSideRook, Piece kingSideRook)
        : base(ix, iy) {
            this.queenSideRook = queenSideRook;
            this.kingSideRook = kingSideRook;
        }

        public Castle CanCastle() {
            return new Castle() {
                queenSide = false,
                kingSide = false
            };
        }

        protected override bool CheckMove(int tx, int ty) {
            return true;
        }

        override public bool MoveTo() {
            return true;
        }
    }
}
