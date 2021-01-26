
// Author  Martin Dubois, P.Eng.
// License https://creativecommons.org/licenses/by-nc-nd/4.0/legalcode
// Product C-Sharp
// File    TT-ImageProc/Form1.cs

using System;
using System.Windows.Forms;

namespace TT_ImageProc
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            mCamera    = new Camera_USB();
            mProcessor = new Processor();

            mProcessor.Camera = mCamera;
        }

        private void cTakePicture_Click(object sender, EventArgs e)
        {
            cPictureBox.Image = mProcessor.TakePicture(cPictureBox.Size.Width, cPictureBox.Size.Height);
        }

        private ICamera   mCamera;
        private Processor mProcessor;

    }

}
