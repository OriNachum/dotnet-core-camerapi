using Dotnet.Core.Camerapi.Internal;
using Dotnet.Core.Camerapi.Models;

namespace Dotnet.Core.Camerapi.Impl.Builders
{
    internal class ContrastParameterBuilder : ISingleParameterBuilder
    {
        public string Build(ImageParameters imageParameters)
        {
            if (imageParameters.Contrast.HasValue)
            {
                return $"--constrast {imageParameters.Contrast}";
            }

            return string.Empty;
        }
    }
}