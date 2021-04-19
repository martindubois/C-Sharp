
// Author  Martin Dubois, P.Eng.
// License https://creativecommons.org/licenses/by-nc-nd/4.0/legalcode
// Product C-Sharp
// File    TT-TicTacToc/Form1.cs

using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace TT_TicTacToc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            cButtons[0] = cButton_0;
            cButtons[1] = cButton_1;
            cButtons[2] = cButton_2;
            cButtons[3] = cButton_3;
            cButtons[4] = cButton_4;
            cButtons[5] = cButton_5;
            cButtons[6] = cButton_6;
            cButtons[7] = cButton_7;
            cButtons[8] = cButton_8;

            mTimer.Enabled = false;
            mTimer.Interval = 1500; // ms
            mTimer.Tick += new EventHandler(OnTick);
        }

        // Private
        /////////////////////////////////////////////////////////////////////

        Button[] cButtons = new Button[Game.POSITION_QTY];

        uint mCount;
        Game mGame = new Game();
        uint mPlayer;
        String mPlayerLetter;
        Random mRandom = new Random();
        Timer mTimer = new Timer();

        void ActivateBegin()
        {
            Debug.Assert(!cButton_Begin   .Enabled);
            Debug.Assert(!cButton_Computer.Enabled);
            Debug.Assert(!cButton_Person  .Enabled);

            mTimer.Enabled = false;

            cButton_Begin   .Enabled = true;
            cButton_Computer.Enabled = true;
            cButton_Person  .Enabled = true;

            for (uint i = 0; i < Game.POSITION_QTY; i ++)
            {
                cButtons[i].Enabled = false;
            }
        }

        private void ActivatePlayer()
        {
            switch (mPlayer)
            {
                case Game.PLAYER_1:
                    cLabel_J1.ForeColor = Color.Green;
                    cLabel_J2.ForeColor = Color.Black;
                    cLabel_O.ForeColor = Color.Green;
                    cLabel_X.ForeColor = Color.Black;
                    cText_Instruction.Text = "C'est au joueur 1 de jouer";
                    mPlayerLetter = "O";
                    break;

                case Game.PLAYER_2:
                    cLabel_J1.ForeColor = Color.Black;
                    cLabel_J2.ForeColor = Color.Blue;
                    cLabel_O.ForeColor = Color.Black;
                    cLabel_X.ForeColor = Color.Blue;
                    cText_Instruction.Text = "C'est au joueur 2 de jouer";
                    mPlayerLetter = "X";
                    break;

                default:
                    Debug.Assert(false);
                    break;
            }
        }

        private uint FindButton(object aButton)
        {
            uint lResult;

            for (lResult = 0; lResult < Game.POSITION_QTY; lResult ++)
            {
                if (cButtons[lResult] == aButton)
                {
                    break;
                }
            }

            Debug.Assert(9 > lResult);

            return lResult;
        }

        void Play(uint aButton)
        {
            Debug.Assert(Game.POSITION_QTY > aButton);

            Debug.Assert(cButtons[aButton].Enabled);

            cButtons[aButton].Enabled = false;
            cButtons[aButton].Text = mPlayerLetter;

            if (mGame.Play(mPlayer, aButton))
            {
                switch (mPlayer)
                {
                    case Game.PLAYER_1: cText_Instruction.Text = "Le joueur 1 est le gagnant !"; break;
                    case Game.PLAYER_2: cText_Instruction.Text = "Le joueur 2 est le gagnant !"; break;

                    default: Debug.Assert(false); break;
                }

                ActivateBegin();
            }
            else
            {
                mCount++;

                if (Game.POSITION_QTY <= mCount)
                {
                    cText_Instruction.Text = "Partie nulle !";

                    ActivateBegin();
                }
                else
                {
                    switch (mPlayer)
                    {
                        case Game.PLAYER_1: mPlayer = Game.PLAYER_2; break;
                        case Game.PLAYER_2: mPlayer = Game.PLAYER_1; break;

                        default: Debug.Assert(false); break;
                    }

                    ActivatePlayer();
                }
            }
        }

        private void ResetButtons()
        {
            for (uint i = 0; i < Game.POSITION_QTY; i++)
            {
                Debug.Assert(!cButtons[i].Enabled);

                cButtons[i].Enabled = true;
                cButtons[i].Text = "";
            }
        }

        // ===== Event handlers =============================================

        private void OnTick(Object aObject, EventArgs aArgs)
        {
            if (Game.PLAYER_2 == mPlayer)
            {
                Play(Robot.Play(mGame));
            }
        }

        private void cButton_Begin_Click(object sender, EventArgs e)
        {
            Debug.Assert(cButton_Begin   .Enabled);
            Debug.Assert(cButton_Computer.Enabled);
            Debug.Assert(cButton_Person  .Enabled);

            cButton_Begin   .Enabled = false;
            cButton_Computer.Enabled = false;
            cButton_Person  .Enabled = false;

            mCount  = 0;
            mPlayer = (uint)mRandom.Next((int)Game.PLAYER_1, (int)Game.PLAYER_2 + 1);

            mGame.Reset();

            ActivatePlayer();
            ResetButtons();

            if (cButton_Computer.Checked)
            {
                mTimer.Enabled = true;
            }
        }

        private void cButton_Click(object aSender, EventArgs e)
        {
            uint lButton = FindButton(aSender);

            Debug.Assert(Game.POSITION_QTY > lButton);

            Play(lButton);
        }

    }

}
