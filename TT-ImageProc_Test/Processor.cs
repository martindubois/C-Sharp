
// Author  Martin Dubois, P.Eng.
// License https://creativecommons.org/licenses/by-nc-nd/4.0/legalcode
// Product C-Sharp
// File    TT-ImageProc_Test/Processor.cs

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Drawing;

namespace TT_ImageProc_Test
{
    [TestClass]
    public class Processor
    {
        [TestMethod]
        public void Test_TakePicture()
        {
            TT_ImageProc.ICamera lC = new Camera_Test();

            TT_ImageProc.Processor lP = new TT_ImageProc.Processor();

            lP.Camera = lC;

            for (int i = 0; i < 7; i ++)
            {
                Image lI = lP.TakePicture(128, 128);

                String lName = "..\\..\\Images\\" + i.ToString() + "_R0.png";
                if (System.IO.File.Exists(lName))
                {
                    Image lR = Image.FromFile(lName);

                    Assert.IsTrue(CompareImage(lI, lR));
                }
                else
                {
                    lI.Save(lName);
                }
            }
        }

        private static bool CompareImage(Image aA, Image aB)
        {
            if ((aA.Height != aB.Height) || (aA.Width != aB.Width))
            {
                return false;
            }

            Bitmap lA = new Bitmap(aA, aA.Width, aA.Height);
            Bitmap lB = new Bitmap(aB, aB.Width, aA.Height);

            for (int y = 0; y < aA.Height; y ++)
            {
                for (int x = 0; x < aA.Width; x ++)
                {
                    if (lA.GetPixel(x, y) != lB.GetPixel(x, y))
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
