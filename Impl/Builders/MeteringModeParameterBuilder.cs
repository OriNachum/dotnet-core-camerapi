using dotnet.core.camerapi.Internal;
using dotnet.core.camerapi.Models;

namespace dotnet.core.camerapi.Impl.Builders
{
    internal class MeteringModeParameterBuilder : ISingleParameterBuilder
    {
        public string Build(ImageParameters imageParameters)
        {
            if (imageParameters.MeteringMode.HasValue)
            {
                return $"--metering {imageParameters.MeteringMode}";
            }

            return string.Empty;
        }
    }
}