using Dotnet.Core.Camerapi.Internal;
using Dotnet.Core.Camerapi.Models;

namespace Dotnet.Core.Camerapi.Impl.Builders
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