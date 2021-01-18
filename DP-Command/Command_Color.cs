
// Author  Martin Dubois, P.Eng.
// Product C-Sharp
// File    DP-Command/Command_Color.cs

using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace DP_Command
{
    class Command_Color : Command
    {

        public Command_Color(Label aLabel, Color aColor) : base(aLabel)
        {
            mColor = aColor;
        }

        // ===== Command ====================================================

        public override void Do()
        {
            Debug.Assert(mLabel.ForeColor != mColor);

            mPreviousColor = mLabel.ForeColor;

            mLabel.ForeColor = mColor;
        }

        public override void Undo()
        {
            Debug.Assert(mLabel.ForeColor != mPreviousColor);

            mLabel.ForeColor = mPreviousColor;
        }

        Color mColor;
        Color mPreviousColor;

    }

}
