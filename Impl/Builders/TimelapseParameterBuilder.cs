using dotnet.core.camerapi.Internal;
using dotnet.core.camerapi.Models;

namespace dotnet.core.camerapi.Impl.Builders
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