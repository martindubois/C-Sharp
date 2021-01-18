
// Author  Martin Dubois, P.Eng.
// Product C-Sharp
// File    DP-Command/Command_Size_Larger.cs

using System.Drawing;
using System.Windows.Forms;

namespace DP_Command
{
    class Command_Size_Larger : Command
    {

        public Command_Size_Larger(Label aLabel) : base(aLabel)
        {
        }

        // ===== Command ====================================================

        public override void Do()
        {
            mLabel.Font = new Font(mLabel.Font.Name, mLabel.Font.Size + 1);
        }

        public override void Undo()
        {
            mLabel.Font = new Font(mLabel.Font.Name, mLabel.Font.Size - 1);
        }

    }
}
