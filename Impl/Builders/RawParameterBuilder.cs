using dotnet.core.camerapi.Internal;
using dotnet.core.camerapi.Models;

namespace dotnet.core.camerapi.Impl.Builders
{
    internal class RawParameterBuilder : ISingleParameterBuilder
    {
        public string Build(ImageParameters imageParameters)
        {
            if (imageParameters.Height.HasValue)
            {
                return $"--height {imageParameters.Height}";
            }

            return string.Empty;
        }
    }
}