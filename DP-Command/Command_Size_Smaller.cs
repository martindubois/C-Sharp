
// Author  Martin Dubois, P.Eng.
// Product C-Sharp
// File    DP-Command/Command_Size_Smaller.cs

using System.Drawing;
using System.Windows.Forms;

namespace DP_Command
{
    class Command_Size_Smaller : Command
    {

        public Command_Size_Smaller(Label aLabel) : base(aLabel)
        {
        }

        // ===== Command ====================================================

        public override void Do()
        {
            mLabel.Font = new Font(mLabel.Font.Name, mLabel.Font.Size - 1);
        }

        public override void Undo()
        {
            mLabel.Font = new Font(mLabel.Font.Name, mLabel.Font.Size + 1);
        }

    }
}
