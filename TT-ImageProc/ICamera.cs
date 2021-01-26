
// Author  Martin Dubois, P.Eng.
// License https://creativecommons.org/licenses/by-nc-nd/4.0/legalcode
// Product C-Sharp
// File    TT-ImageProc/ICamera.cs

using System.Drawing;

namespace TT_ImageProc
{
    interface ICamera
    {

        Image TakePicture();

    }
}
