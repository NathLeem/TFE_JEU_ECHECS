using System;
using System.Collections.Generic;
using System.Text;

namespace TFE_JEU_ECHECS
{
    class King : Piece
    {
        private bool _check;
        private bool _checkMate;

        public King()
        {
            _check = false;
            _checkMate = false;
        }
    }
}
