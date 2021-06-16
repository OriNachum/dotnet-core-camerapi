using dotnet.core.camerapi.Models;
using System;

namespace dotnet.core.camerapi
{
    public interface ICameraPi
    {
        void CaptureImage(ImageParameters imageParameters);
    }
}
