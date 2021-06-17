using System;

namespace cs_chess_backend {

    public abstract class Piece {
        public Board board;
        public readonly Tuple<int, int> position;

        public Piece(int ix, int iy) {
            this.position = (ix, iy).ToTuple();
        }

        protected abstract bool CheckMove(int tx, int ty);

        public abstract bool MoveTo();
    }

    public class Queen : Piece {
        public Queen(int ix, int iy) : base(ix, iy) {}

        protected override bool CheckMove(int tx, int ty) {
            return true;
        }

        override public bool MoveTo() {
            return true;
        }
    }
}
