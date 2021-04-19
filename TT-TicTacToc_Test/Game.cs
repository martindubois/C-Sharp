
// Author  Martin Dubois, P.Eng.
// License https://creativecommons.org/licenses/by-nc-nd/4.0/legalcode
// Product C-Sharp
// File    TT-TicTacToc_Test/Game.cs

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TT_TicTacToc_Test
{
    [TestClass]
    public class Game
    {
        [TestMethod]
        public void Test_1()
        {
            TT_TicTacToc.Game lGame = new TT_TicTacToc.Game();

            // Given _ _ _ 
            //       _ _ _
            //       _ _ _

            // When _ _ _
            //      _ O _
            //      _ _ _
            bool lRet = lGame.Play(TT_TicTacToc.Game.PLAYER_1, 4);

            // Then - Does not win
            Assert.IsFalse(lRet);

            // When _ _ X
            //      _ o _
            //      _ _ _
            lRet = lGame.Play(TT_TicTacToc.Game.PLAYER_2, 2);

            // Then - Does not win
            Assert.IsFalse(lRet);

            // When O _ x
            //      _ o _
            //      _ _ _
            lRet = lGame.Play(TT_TicTacToc.Game.PLAYER_1, 0);

            // Then - Does not win
            Assert.IsFalse(lRet);

            // When o _ x
            //      _ o X
            //      _ _ _
            lRet = lGame.Play(TT_TicTacToc.Game.PLAYER_2, 5);

            // Then - Does not win
            Assert.IsFalse(lRet);

            // When o _ x
            //      _ o x
            //      _ _ O
            lRet = lGame.Play(TT_TicTacToc.Game.PLAYER_1, 8);

            // Then - Win
            Assert.IsTrue(lRet);
        }

        [TestMethod]
        public void Test_2()
        {
            TT_TicTacToc.Game lGame = new TT_TicTacToc.Game();

            // Given _ _ _ 
            //       _ _ _
            //       _ _ _

            // When _ _ _
            //      _ X _
            //      _ _ _
            bool lRet = lGame.Play(TT_TicTacToc.Game.PLAYER_2, 4);

            // Then - Does not win
            Assert.IsFalse(lRet);

            // When O _ _
            //      _ x _
            //      _ _ _
            lRet = lGame.Play(TT_TicTacToc.Game.PLAYER_1, 0);

            // Then - Does not win
            Assert.IsFalse(lRet);

            // When o _ X
            //      _ x _
            //      _ _ _
            lRet = lGame.Play(TT_TicTacToc.Game.PLAYER_2, 2);

            // Then - Does not win
            Assert.IsFalse(lRet);

            // When o _ x
            //      O x _
            //      _ _ _
            lRet = lGame.Play(TT_TicTacToc.Game.PLAYER_1, 3);

            // Then - Does not win
            Assert.IsFalse(lRet);

            // When o _ x
            //      o x _
            //      X _ _
            lRet = lGame.Play(TT_TicTacToc.Game.PLAYER_2, 6);

            // Then - Win
            Assert.IsTrue(lRet);
        }

        [TestMethod]
        public void Test_3()
        {
            TT_TicTacToc.Game lGame = new TT_TicTacToc.Game();

            // Given _ _ _ 
            //       _ _ _
            //       _ _ _

            // When _ _ O
            //      _ _ _
            //      _ _ _
            bool lRet = lGame.Play(TT_TicTacToc.Game.PLAYER_1, 2);

            // Then - Does not win
            Assert.IsFalse(lRet);

            // When X _ o
            //      _ _ _
            //      _ _ _
            lRet = lGame.Play(TT_TicTacToc.Game.PLAYER_2, 0);

            // Then - Does not win
            Assert.IsFalse(lRet);

            // When x _ o
            //      _ _ _
            //      O _ _
            lRet = lGame.Play(TT_TicTacToc.Game.PLAYER_1, 6);

            // Then - Does not win
            Assert.IsFalse(lRet);

            // When x _ o
            //      _ _ _
            //      o _ X
            lRet = lGame.Play(TT_TicTacToc.Game.PLAYER_2, 8);

            // Then - Does not win
            Assert.IsFalse(lRet);

            // When x _ o
            //      _ O _
            //      o _ x
            lRet = lGame.Play(TT_TicTacToc.Game.PLAYER_1, 4);

            // Then - Win
            Assert.IsTrue(lRet);
        }
    }
}
