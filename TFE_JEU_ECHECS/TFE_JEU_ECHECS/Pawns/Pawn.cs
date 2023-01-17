using System;
using System.Collections.Generic;
using System.Text;

namespace TFE_JEU_ECHECS
{
    class Pawn : Piece
    {
        private bool _passant;
        private bool _notMove;

        public Pawn(int[] position, string color) : base(position, color)
        {
            this._passant = false;
            this._notMove = false;
        }
    }
}
