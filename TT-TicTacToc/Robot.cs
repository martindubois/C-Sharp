
// Author  Martin Dubois, P.Eng.
// License https://creativecommons.org/licenses/by-nc-nd/4.0/legalcode
// Product C-Sharp
// File    TT-TicTacToc/Robot.cs

using System.Diagnostics;

namespace TT_TicTacToc
{
    class Robot
    {

        public static uint Play(Game aGame)
        {
            uint lResult = Game.POSITION_QTY;
            uint lSelected = 0;

            for (uint i = 0; i < Game.POSITION_QTY; i++)
            {
                if (Game.NOT_PLAYED == aGame.Get(i))
                {
                    uint lValue = 0;

                    for (uint j = 0; j < Game.LINE_PER_POSITION_MAX; j++)
                    {
                        uint lLine = Game.POSITION_TO_LINE[i, j];
                        if (Game.NO_LINE > lLine)
                        {
                            switch (Count(aGame, lLine, 2))
                            {
                                case 0: lValue += 1; break;
                                case 1: lValue += 3; break;
                                case 2: return i;
                            }

                            switch (Count(aGame, lLine, 1))
                            {
                                case 0: lValue += 2; break;
                                case 1: lValue += 0; break;
                                case 2: lValue += 10; break;
                                default: Debug.Assert(false); break;
                            }
                        }
                    }

                    if (lSelected < lValue)
                    {
                        lResult = i;
                        lSelected = lValue;
                    }
                }
            }

            return lResult;
        }

        // Private
        /////////////////////////////////////////////////////////////////////

        private static uint Count(Game aGame, uint aLine, uint aPlayer)
        {
            Debug.Assert(Game.LINE_QTY > aLine);
            Debug.Assert(Game.PLAYER_1 <= aPlayer);
            Debug.Assert(Game.PLAYER_2 >= aPlayer);

            uint lResult = 0;

            for (uint i = 0; i < Game.LINE_LENGTH; i ++)
            {
                if (aGame.Get(Game.LINES[aLine, i]) == aPlayer)
                {
                    lResult++;
                }
            }

            return lResult;
        }

    }
}
