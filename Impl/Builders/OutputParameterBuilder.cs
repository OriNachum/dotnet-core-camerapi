using dotnet.core.camerapi.Internal;
using dotnet.core.camerapi.Models;

namespace dotnet.core.camerapi.Impl.Builders
{
    internal class OutputParameterBuilder : ISingleParameterBuilder
    {
        public string Build(ImageParameters imageParameters)
        {
            if (!string.IsNullOrWhiteSpace(imageParameters.Output))
            {
                return $"--output {imageParameters.Output}";
            }

            return string.Empty;
        }
    }
}