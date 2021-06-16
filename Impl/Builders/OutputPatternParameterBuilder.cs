using dotnet.core.camerapi.Internal;
using dotnet.core.camerapi.Models;

namespace dotnet.core.camerapi.Impl.Builders
{
    internal class OutputPatternParameterBuilder : ISingleParameterBuilder
    {
        public string Build(ImageParameters imageParameters)
        {
            if (imageParameters.OutputPattern.HasValue)
            {
                return $"--datetime {imageParameters.OutputPattern}";
            }

            return string.Empty;
        }
    }
}