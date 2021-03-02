
// Author  Martin Dubois, P.Eng.
// License https://creativecommons.org/licenses/by-nc-nd/4.0/legalcode
// Product C-Sharp
// File    TT-ImageProc_Test/Camera_Test.cs

using System.Drawing;

using TT_ImageProc;

namespace TT_ImageProc_Test
{
    class Camera_Test : ICamera
    {

        public Image Image
        {
            set
            {
                mImage = value;
            }
        }

        Image ICamera.TakePicture()
        {
            return mImage;
        }

        public Image mImage;

    }

}
