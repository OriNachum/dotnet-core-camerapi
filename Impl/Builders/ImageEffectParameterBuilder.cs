using dotnet.core.camerapi.Internal;
using dotnet.core.camerapi.Models;

namespace dotnet.core.camerapi.Impl.Builders
{
    internal class ImageEffectParameterBuilder : ISingleParameterBuilder
    {
        public string Build(ImageParameters imageParameters)
        {
            if (imageParameters.ImageRotation.HasValue)
            {
                return $"--imxfx {imageParameters.ImageEffect}";
            }

            return string.Empty;
        }
    }
}