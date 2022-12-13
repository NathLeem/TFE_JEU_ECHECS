using System;
using System.Collections.Generic;
using System.Text;

namespace TFE_JEU_ECHECS
{
    class Horse
    {
        private int[,] _position = new int[8, 8];
        private bool _dead = false;
        private List<string> _moves = new List<string>();

        public Horse(int[,] position, bool dead, List<string> moves)
        {
            this._position = position;
            this._dead = dead;
            this._moves = moves;
        }
        public void Moves()
        {

        }

        public void ShowMoves()
        {

        }
    }
}
