using Dotnet.Core.Camerapi.Internal;
using Dotnet.Core.Camerapi.Models;

namespace Dotnet.Core.Camerapi.Impl.Builders
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