
// Author  Martin Dubois, P.Eng.
// License https://creativecommons.org/licenses/by-nc-nd/4.0/legalcode
// Product C-Sharp
// File    TT-ImageProc/Processor.cs

using System.Drawing;

namespace TT_ImageProc
{
    public class Processor
    {
        public ICamera Camera
        {
            set
            {
                mCamera = value;
            }
        }

        public Image TakePicture(int aWidth, int aHeight)
        {
            Image lRaw = mCamera.TakePicture();

            Bitmap lResult = new Bitmap(lRaw, aWidth, aHeight);

            for (int y = 0; y < aHeight; y ++)
            {
                for (int x = 0; x < aWidth; x++)
                {
                    Color lPixel = lResult.GetPixel(x, y);

                    byte lRed   = lPixel.R;
                    byte lGreen = lPixel.G;
                    byte lBlue  = lPixel.B;

                    if (128 <= lRed) { lRed = 255; }
                    else             { lRed =   0; }

                    if (128 <= lGreen) { lGreen = 255; }
                    else               { lGreen =   0; }

                    if (128 <= lBlue) { lBlue = 255; }
                    else              { lBlue =   0; }

                    lResult.SetPixel(x, y, Color.FromArgb(lRed, lGreen, lBlue));
                }
            }


            return lResult;
        }

        private ICamera mCamera;

    }
}
