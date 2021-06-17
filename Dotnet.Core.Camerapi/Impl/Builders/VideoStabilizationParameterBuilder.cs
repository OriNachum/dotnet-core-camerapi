using Dotnet.Core.Camerapi.Internal;
using Dotnet.Core.Camerapi.Models;

namespace Dotnet.Core.Camerapi.Impl.Builders
{
    internal class VideoStabilizationParameterBuilder : ISingleParameterBuilder
    {
        public string Build(ImageParameters imageParameters)
        {
            if (imageParameters.VideoStabilization)
            {
                return $"--vstab";
            }

            return string.Empty;
        }
    }
}