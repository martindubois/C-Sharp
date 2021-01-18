
// Author  Martin Dubois, P.Eng.
// Product C-Sharp
// File    DP-Command/Command.cs

using System.Windows.Forms;

namespace DP_Command
{
    abstract class Command
    {

        public abstract void Do();

        public abstract void Undo();

        // Protected
        /////////////////////////////////////////////////////////////////////

        protected Command(Label aLabel)
        {
            mLabel = aLabel;
        }

        protected Label mLabel;

    }

}
