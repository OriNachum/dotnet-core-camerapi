using dotnet.core.camerapi.Internal;
using dotnet.core.camerapi.Models;

namespace dotnet.core.camerapi.Impl.Builders
{
    internal class ImageRotationParameterBuilder : ISingleParameterBuilder
    {
        public string Build(ImageParameters imageParameters)
        {
            if (imageParameters.ImageRotation.HasValue)
            {
                return $"--rotation {imageParameters.ImageRotation}";
            }

            return string.Empty;
        }
    }
}