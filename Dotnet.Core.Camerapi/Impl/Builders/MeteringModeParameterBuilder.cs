using Dotnet.Core.Camerapi.Internal;
using Dotnet.Core.Camerapi.Models;

namespace Dotnet.Core.Camerapi.Impl.Builders
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