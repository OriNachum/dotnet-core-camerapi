using dotnet.core.camerapi.Internal;
using dotnet.core.camerapi.Models;

namespace dotnet.core.camerapi.Impl.Builders
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