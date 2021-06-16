using dotnet.core.camerapi.Internal;
using dotnet.core.camerapi.Models;

namespace dotnet.core.camerapi.Impl.Builders
{
    internal class TimeoutParameterBuilder : ISingleParameterBuilder
    {
        public string Build(ImageParameters imageParameters)
        {
            if (imageParameters.Timeout.HasValue)
            {
                return $"--timeout {imageParameters.Timeout}";
            }

            return string.Empty;
        }
    }
}