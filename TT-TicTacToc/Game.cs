
// Author  Martin Dubois, P.Eng.
// License https://creativecommons.org/licenses/by-nc-nd/4.0/legalcode
// Product C-Sharp
// File    TT-TicTacToc/Game.cs

using System.Diagnostics;

namespace TT_TicTacToc
{
    public class Game
    {

        public const uint NOT_PLAYED = 0;

        public const uint PLAYER_1 = 1;
        public const uint PLAYER_2 = 2;

        public const uint LINE_LENGTH = 3;
        public const uint LINE_QTY = 8;

        static public readonly uint[,] LINES =
        {
            { 0, 1, 2 }, { 3, 4, 5 }, { 6, 7, 8 },
            { 0, 3, 6 }, { 1, 4, 7 }, { 2, 5, 8 },
            { 0, 4, 8 }, { 2, 4, 6 }
        };

        public const uint LINE_PER_POSITION_MAX = 4;
        public const uint NO_LINE = 8;
        public const uint POSITION_QTY = 9;

        static public readonly uint[,] POSITION_TO_LINE =
        {
            { 0, 3, 6, NO_LINE }, { 0, 4, 8, NO_LINE }, { 0, 5, 7, NO_LINE },
            { 1, 4, 8, NO_LINE }, { 1, 4, 6, 7       }, { 1, 5, 8, NO_LINE },
            { 2, 3, 7, NO_LINE }, { 2, 4, 8, NO_LINE }, { 2, 5, 6, NO_LINE },
        };

        public uint Get(uint aPosition)
        {
            Debug.Assert(POSITION_QTY > aPosition);

            return mPositions[aPosition];
        }

        public bool Play(uint aPlayer, uint aPosition)
        {
            Debug.Assert(PLAYER_1 <= aPlayer);
            Debug.Assert(PLAYER_2 >= aPlayer);
            Debug.Assert(POSITION_QTY > aPosition);

            Debug.Assert(NOT_PLAYED == mPositions[aPosition]);

            mPositions[aPosition] = aPlayer;

            return Verify(aPlayer, aPosition);
        }

        public void Reset()
        {
            for (uint i = 0; i < POSITION_QTY; i ++)
            {
                mPositions[i] = NOT_PLAYED;
            }
        }

        // Private
        /////////////////////////////////////////////////////////////////////

        private uint[] mPositions = new uint[POSITION_QTY];

        private bool Verify(uint aPlayer, uint aPosition)
        {
            Debug.Assert(PLAYER_1 <= aPlayer);
            Debug.Assert(PLAYER_2 >= aPlayer);

            for (uint i = 0; i < LINE_PER_POSITION_MAX; i++)
            {
                uint lLine = POSITION_TO_LINE[aPosition, i];
                if (NO_LINE <= lLine)
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
