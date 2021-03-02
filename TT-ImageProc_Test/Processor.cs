
// Author  Martin Dubois, P.Eng.
// License https://creativecommons.org/licenses/by-nc-nd/4.0/legalcode
// Product C-Sharp
// File    TT-ImageProc_Test/Processor.cs

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace TT_ImageProc_Test
{
    [TestClass]
    public class Processor
    {
        [TestMethod]
        public void Test_TakePicture_0()
        {
            Mock<TT_ImageProc.ICamera> lC = new Mock<TT_ImageProc.ICamera>();

            TT_ImageProc.Processor lP = new TT_ImageProc.Processor();

            lP.Camera = lC.Object;

            for (int i = 0; i < 7; i ++)
            {
                lC.Setup(p => p.TakePicture()).Returns(Image.FromFile(mImages[i]));

                Image lI = lP.TakePicture(128, 128);

                VerifyImage(lI, i);
            }
        }

        [TestMethod]
        public void Test_TakePicture_1()
        {
            Camera_Test lC = new Camera_Test();

            TT_ImageProc.Processor lP = new TT_ImageProc.Processor();

            lP.Camera = lC;

            for (int i = 0; i < 7; i ++)
            {
                lC.Image = Image.FromFile(mImages[i]);

                Image lI = lP.TakePicture(128, 128);

                VerifyImage(lI, i);
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

        private static void VerifyImage(Image aImage, int aIndex)
        {
            String lName = "..\\..\\Images\\" + aIndex.ToString() + "_R0.png";
            if (System.IO.File.Exists(lName))
            {
                Image lR = Image.FromFile(lName);

                Assert.IsTrue(CompareImage(aImage, lR));
            }
            else
            {
                aImage.Save(lName);
            }
        }

        private List<String> mImages = new List<String>
        {
            "..\\..\\Images\\00.jpg",
            "..\\..\\Images\\01.jpg",
            "..\\..\\Images\\02.jpg",
            "..\\..\\Images\\03.png",
            "..\\..\\Images\\04.png",
            "..\\..\\Images\\05.jpg",
            "..\\..\\Images\\06.jpg",
        };

    }
}
