using dotnet.core.camerapi.Internal;
using dotnet.core.camerapi.Models;

namespace dotnet.core.camerapi.Impl.Builders
{
    internal class ContrastParameterBuilder : ISingleParameterBuilder
    {
        public string Build(ImageParameters imageParameters)
        {
            if (imageParameters.Contrast.HasValue)
            {
                return $"--constrast {imageParameters.Contrast}";
            }

            return string.Empty;
        }
    }
}