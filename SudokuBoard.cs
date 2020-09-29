using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuSolver
{
    class SudokuBoard
    {
        private int[,] _board;

        public int[,] Board
        {
            get { return _board; }
            set { _board = value; }
        }


        private bool IsPossible(int x, int y, int n)
        {
            for (int x0 = 0; x0 < 9; x0++)
                if (Board[x0, y] == n)
                    return false;

            for (int y0 = 0; y0 < 9; y0++)
                if (Board[x, y0] == n)
                    return false;


            for (int y0 = 0; y0 < 3; y0++)
            {
                for (int x0 = 0; x0 < 3; x0++)
                {
                    if ((x/3)*3)
                    {

                    }
                }
            }

            return true;
        }
    }
}
