using Dotnet.Core.Camerapi.Internal;
using Dotnet.Core.Camerapi.Models;

namespace Dotnet.Core.Camerapi.Impl.Builders
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