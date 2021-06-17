using Dotnet.Core.Camerapi.Internal;
using Dotnet.Core.Camerapi.Models;

namespace Dotnet.Core.Camerapi.Impl.Builders
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