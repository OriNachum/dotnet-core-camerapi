using Dotnet.Core.Camerapi.Internal;
using Dotnet.Core.Camerapi.Models;

namespace Dotnet.Core.Camerapi.Impl.Builders
{
    internal class TimelapseParameterBuilder : ISingleParameterBuilder
    {
        public string Build(ImageParameters imageParameters)
        {
            if (imageParameters.Timelapse.HasValue)
            {
                return $"--timelapse {imageParameters.Timelapse}";
            }

            return string.Empty;
        }
    }
}