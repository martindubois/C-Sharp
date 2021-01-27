
// Author  Martin Dubois, P.Eng.
// License https://creativecommons.org/licenses/by-nc-nd/4.0/legalcode
// Product C-Sharp
// File    TT-ImageProc_Test/Camera_Test.cs

using System;
using System.Collections.Generic;
using System.Drawing;

using TT_ImageProc;

namespace TT_ImageProc_Test
{
    class Camera_Test : ICamera
    {

        Image ICamera.TakePicture()
        {
            String lCD = System.IO.Directory.GetCurrentDirectory();

            Image lResult = Image.FromFile(mImages[mImageIndex % mImages.Count]);

            mImageIndex++;

            return lResult;
        }

        private int mImageIndex = 0;

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
