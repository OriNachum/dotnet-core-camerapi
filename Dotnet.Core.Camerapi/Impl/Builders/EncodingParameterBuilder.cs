using Dotnet.Core.Camerapi.Internal;
using Dotnet.Core.Camerapi.Models;

namespace Dotnet.Core.Camerapi.Impl.Builders
{
    internal class EncodingParameterBuilder : ISingleParameterBuilder
    {
        public string Build(ImageParameters imageParameters)
        {
            if (imageParameters.Encoding.HasValue)
            {
                return $"--encoding {imageParameters.Encoding}";
            }

            return string.Empty;
        }
    }
}