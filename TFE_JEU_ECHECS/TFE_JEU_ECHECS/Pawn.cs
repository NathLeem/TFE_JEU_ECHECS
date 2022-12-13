using System;
using System.Collections.Generic;
using System.Text;

namespace TFE_JEU_ECHECS
{
    class Pawn
    {
        private int[,] _position = new int[8, 8];
        private bool _dead = false;
        private bool _passantYes = false;
        private bool _doubleMove = false;
        private List<string> _moves = new List<string>();

        public Pawn(int[,] position, bool dead, bool passantYes, bool doubleMove, List<string> moves)
        {
            this._position = position;
            this._dead = dead;
            this._passantYes = passantYes;
            this._doubleMove = doubleMove;
            this._moves = moves;
        }
        public void Moves()
        {

        }

        public void AfficheMoves()
        {

        }
    }
}
