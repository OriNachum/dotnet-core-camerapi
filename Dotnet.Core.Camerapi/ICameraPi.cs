using Dotnet.Core.Camerapi.Models;
using System;

namespace Dotnet.Core.Camerapi
{
    public interface ICameraPi
    {
        string CaptureImage(ImageParameters imageParameters);
    }
}
