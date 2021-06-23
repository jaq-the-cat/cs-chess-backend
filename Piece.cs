using System;

namespace cs_chess_backend {

    public abstract class Piece {
        public Board board;
        public int x, y;

        public Piece(int x, int y) {
            this.x = x;
            this.y = y;
        }

        protected abstract bool CanMove(int tx, int ty);
        public bool MoveTo(int tx, int ty) {
            if (CanMove(tx, ty))
                return true;
            return false;
        }
    }

    public class Queen : Piece {
        public Queen(int x, int y) : base(x, y) {}

        protected override bool CanMove(int tx, int ty) {
            return
                (Math.Abs(tx-x) == Math.Abs(ty-y)) || // diagonal
                (tx-x == 0) || // vertical
                (ty-y == 0) // horizontal
                ;
        }
    }
    public class Rook : Piece {
        public Rook(int x, int y) : base(x, y) {}
        protected override bool CanMove(int tx, int ty) {
            return
                tx-x == 0 || ty-y == 0; // horizontal
        }
    }
}
