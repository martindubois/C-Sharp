
// Author  Martin Dubois, P.Eng.
// License https://creativecommons.org/licenses/by-nc-nd/4.0/legalcode
// Product C-Sharp
// File    DP-Command/Form1.cs

using System;
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

            mNormalSize = cLabel.Font.Size;
        }

        // Private
        /////////////////////////////////////////////////////////////////////

        // ===== Event handler ==============================================

        private void cColor_Black_Click(object sender, EventArgs e)
        {
            cLabel.ForeColor = Color.Black;
        }

        private void cColor_Green_Click(object sender, EventArgs e)
        {
            cLabel.ForeColor = Color.Green;
        }

        private void cColor_Red_Click(object sender, EventArgs e)
        {
            cLabel.ForeColor = Color.Red;
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
            cLabel.Font = new Font(cLabel.Font.Name, cLabel.Font.Size + 1);
        }

        private void cSize_Normal_Click(object sender, EventArgs e)
        {
            cLabel.Font = new Font(cLabel.Font.Name, mNormalSize);
        }

        private void cSize_Smaller_Click(object sender, EventArgs e)
        {
            cLabel.Font = new Font(cLabel.Font.Name, cLabel.Font.Size - 1);
        }

        private void cRedo_Click(object sender, EventArgs e)
        {
            // TODO
        }

        private void cUndo_Click(object sender, EventArgs e)
        {
            // TODO
        }

        private float mNormalSize;

    }
}
