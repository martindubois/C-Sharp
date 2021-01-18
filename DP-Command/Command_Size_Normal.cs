
// Author  Martin Dubois, P.Eng.
// Product C-Sharp
// File    DP-Command/Command_Size_Normal.cs

using System.Drawing;
using System.Windows.Forms;

namespace DP_Command
{
    class Command_Size_Normal : Command
    {

        public Command_Size_Normal(Label aLabel, float aNormalSize) : base(aLabel)
        {
            mNormalSize = aNormalSize;
        }

        // ===== Command ====================================================

        public override void Do()
        {
            mPreviousSize = mLabel.Font.Size;

            mLabel.Font = new Font(mLabel.Font.Name, mNormalSize);
        }

        public override void Undo()
        {
            mLabel.Font = new Font(mLabel.Font.Name, mPreviousSize);
        }

        float mNormalSize;
        float mPreviousSize;

    }
}
