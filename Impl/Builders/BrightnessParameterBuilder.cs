using dotnet.core.camerapi.Internal;
using dotnet.core.camerapi.Models;

namespace dotnet.core.camerapi.Impl.Builders
{
    internal class BrightnessParameterBuilder : ISingleParameterBuilder
    {
        public string Build(ImageParameters imageParameters)
        {
            if (imageParameters.Brightness.HasValue)
            {
                return $"--brightness {imageParameters.Brightness}";
            }

            return string.Empty;
        }
    }
}