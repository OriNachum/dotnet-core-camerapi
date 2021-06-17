using Dotnet.Core.Camerapi.Internal;
using Dotnet.Core.Camerapi.Models;

namespace Dotnet.Core.Camerapi.Impl.Builders
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