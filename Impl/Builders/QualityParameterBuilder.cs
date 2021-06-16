using dotnet.core.camerapi.Internal;
using dotnet.core.camerapi.Models;

namespace dotnet.core.camerapi.Impl.Builders
{
    internal class QualityParameterBuilder : ISingleParameterBuilder
    {
        public string Build(ImageParameters imageParameters)
        {
            if (imageParameters.Quality.HasValue)
            {
                return $"--quality {imageParameters.Quality}";
            }

            return string.Empty;
        }
    }
}