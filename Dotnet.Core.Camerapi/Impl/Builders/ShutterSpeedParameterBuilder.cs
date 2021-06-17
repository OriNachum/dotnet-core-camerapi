using Dotnet.Core.Camerapi.Internal;
using Dotnet.Core.Camerapi.Models;

namespace Dotnet.Core.Camerapi.Impl.Builders
{
    internal class ShutterSpeedParameterBuilder : ISingleParameterBuilder
    {
        public string Build(ImageParameters imageParameters)
        {
            if (imageParameters.ShutterSpeed.HasValue)
            {
                return $"--shutter {imageParameters.ShutterSpeed}";
            }

            return string.Empty;
        }
    }
}