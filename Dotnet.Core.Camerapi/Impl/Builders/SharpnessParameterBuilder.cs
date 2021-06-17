using Dotnet.Core.Camerapi.Internal;
using Dotnet.Core.Camerapi.Models;

namespace Dotnet.Core.Camerapi.Impl.Builders
{
    internal class SharpnessParameterBuilder : ISingleParameterBuilder
    {
        public string Build(ImageParameters imageParameters)
        {
            if (imageParameters.Height.HasValue)
            {
                return $"--sharpness {imageParameters.Height}";
            }

            return string.Empty;
        }
    }
}