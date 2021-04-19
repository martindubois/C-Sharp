
// Author  Martin Dubois, P.Eng.
// License https://creativecommons.org/licenses/by-nc-nd/4.0/legalcode
// Product C-Sharp
// File    TT-TicTacToc/Game.cs

using System.Diagnostics;

namespace TT_TicTacToc
{
    class Game
    {

        static public uint[,] LINES =
        {
            { 0, 1, 2 }, { 3, 4, 5 }, { 6, 7, 8 },
            { 0, 3, 6 }, { 1, 4, 7 }, { 2, 5, 8 },
            { 0, 4, 8 }, { 2, 4, 6 }
        };

        static public uint[,] POSITION_TO_LINE =
        {
            { 0, 3, 6, 8 }, { 0, 4, 8, 8 }, { 0, 5, 7, 8 },
            { 1, 4, 8, 8 }, { 1, 4, 6, 8 }, { 1, 5, 8, 8 },
            { 2, 3, 7, 8 }, { 2, 4, 8, 8 }, { 2, 5, 6, 8 },
        };

        public uint Get(uint aPosition)
        {
            Debug.Assert(9 > aPosition);

            return mPositions[aPosition];
        }

        public bool Play(uint aPlayer, uint aPosition)
        {
            Debug.Assert(1 <= aPlayer);
            Debug.Assert(2 >= aPlayer);
            Debug.Assert(9 > aPosition);

            Debug.Assert(0 == mPositions[aPosition]);

            mPositions[aPosition] = aPlayer;

            return Verify(aPlayer, aPosition);
        }

        public void Reset()
        {
            for (uint i = 0; i < 9; i ++)
            {
                mPositions[i] = 0;
            }
        }

        // Private
        /////////////////////////////////////////////////////////////////////

        private uint[] mPositions = new uint[9];

        private bool Verify(uint aPlayer, uint aPosition)
        {
            Debug.Assert(1 <= aPlayer);
            Debug.Assert(2 >= aPlayer);

            for (uint i = 0; i < 4; i++)
            {
                uint lLine = POSITION_TO_LINE[aPosition, i];
                if (8 <= lLine)
                {
                    break;
                }

                if (   (mPositions[LINES[lLine, 0]] == aPlayer)
                    && (mPositions[LINES[lLine, 1]] == aPlayer)
                    && (mPositions[LINES[lLine, 2]] == aPlayer))
                {
                    return true;
                }
            }

            return false;
        }

    }
}
