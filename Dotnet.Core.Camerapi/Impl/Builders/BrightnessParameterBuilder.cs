using Dotnet.Core.Camerapi.Internal;
using Dotnet.Core.Camerapi.Models;

namespace Dotnet.Core.Camerapi.Impl.Builders
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