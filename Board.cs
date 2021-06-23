using System;
using System.Collections.Generic;

namespace cs_chess_backend {

    public sealed class Board {
        private static Board instance;
        public Tuple<int, int> enPassant;

        public Dictionary<Tuple<int, int>, Piece> pieces;

        public bool addPiece(Piece p) {
            if (pieces.ContainsKey((p.x, p.y).ToTuple()))
                return false;
            pieces[(p.x, p.y).ToTuple()] = p;
            return true;
        }

        public bool tryCastle(King k) {
            return false;
        }

        public static Board Instance {
            get {
                if (instance == null)
                    instance = new Board();
                return instance;
            }
        }
    }
}
