
// Author  Martin Dubois, P.Eng.
// License https://creativecommons.org/licenses/by-nc-nd/4.0/legalcode
// Product C-Sharp
// File    DP-Command/Form1.cs

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace DP_Command
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            cColor_Black.Enabled = false;

            cSize_Normal.Enabled = false;

            cRedo.Enabled = false;
            cUndo.Enabled = false;

            mCommandIndex = 0;
            mCommands = new List<Command>();

            mNormalSize = cLabel.Font.Size;
        }

        // Private
        /////////////////////////////////////////////////////////////////////

        private void Command_Add(Command aCommand)
        {
            if (mCommandIndex < mCommands.Count)
            {
                mCommands.RemoveRange(mCommandIndex, mCommands.Count - mCommandIndex);

                cRedo.Enabled = false;
            }

            mCommands.Add(aCommand);

            mCommandIndex = mCommands.Count;

            cUndo.Enabled = true;

            aCommand.Do();
        }

        // ===== Event handler ==============================================

        private void cColor_Black_Click(object sender, EventArgs e)
        {
            Command_Add(new Command_Color(cLabel, Color.Black));
        }

        private void cColor_Green_Click(object sender, EventArgs e)
        {
            Command_Add(new Command_Color(cLabel, Color.Green));
        }

        private void cColor_Red_Click(object sender, EventArgs e)
        {
            Command_Add(new Command_Color(cLabel, Color.Red));
        }

        private void cLabel_FontChanged(object sender, EventArgs e)
        {
            cSize_Normal.Enabled = mNormalSize != cLabel.Font.Size;
        }

        private void cLabel_ForeColorChanged(object sender, EventArgs e)
        {
            cColor_Black.Enabled = Color.Black.ToArgb() != cLabel.ForeColor.ToArgb();
            cColor_Green.Enabled = Color.Green.ToArgb() != cLabel.ForeColor.ToArgb();
            cColor_Red  .Enabled = Color.Red  .ToArgb() != cLabel.ForeColor.ToArgb();
        }

        private void cSize_Larger_Click(object sender, EventArgs e)
        {
            Command_Add(new Command_Size_Larger(cLabel));
        }

        private void cSize_Normal_Click(object sender, EventArgs e)
        {
            Command_Add(new Command_Size_Normal(cLabel, mNormalSize));
        }

        private void cSize_Smaller_Click(object sender, EventArgs e)
        {
            Command_Add(new Command_Size_Smaller(cLabel));
        }

        private void cRedo_Click(object sender, EventArgs e)
        {
            mCommands[mCommandIndex].Do();
            mCommandIndex++;

            if (mCommands.Count <= mCommandIndex)
            {
                cRedo.Enabled = false;
            }

            cUndo.Enabled = true;
        }

        private void cUndo_Click(object sender, EventArgs e)
        {
            mCommandIndex--;
            mCommands[mCommandIndex].Undo();

            cRedo.Enabled = true;

            if (0 >= mCommandIndex)
            {
                cUndo.Enabled = false;
            }
        }

        private int mCommandIndex;

        private List<Command> mCommands;

        private float mNormalSize;

    }
}
