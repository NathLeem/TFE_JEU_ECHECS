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
<<<<<<< HEAD
            this._passant = false;
            this._notMove = false;
=======
            this._position = position;
            this._dead = dead;
            this._passantYes = passantYes;
            this._doubleMove = doubleMove;
            this._moves = moves;
        }

        public int[,] Position
        {
            get { return _position; }
            set { _position = value; }
        }

        public bool Dead
        {
            get { return _dead; }
            set { _dead = value; }
        }

        public bool PassantYes
        {
            get { return _passantYes; }
            set { _passantYes = value; }
        }

        public bool DoubleMove
        {
            get { return _doubleMove; }
            set { _doubleMove = value; }
        }

        public List<string> Moves
        {
            get { return _moves; }
            set { _moves = value; }
        }



        public void MovesPossible(string typePion, int nLigne, int nColonne)

        {
            if (typePion == "♟")
            {
                _moves.Add((nLigne + 1).ToString());

                if (_passantYes)
                {
                    _moves.Add((nLigne + 2).ToString());
                }
            }
        }

        public void AfficheMoves(ref MainWindow plateau)
        {
            for (int i = 0; i < _moves.Count; i++)
            {
                plateau.cases[];
            }
>>>>>>> 235323d30db3fcee3640ee1f5c23ca6a6e959784
        }
    }
}
