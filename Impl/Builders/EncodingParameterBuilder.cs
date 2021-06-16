using dotnet.core.camerapi.Internal;
using dotnet.core.camerapi.Models;

namespace dotnet.core.camerapi.Impl.Builders
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