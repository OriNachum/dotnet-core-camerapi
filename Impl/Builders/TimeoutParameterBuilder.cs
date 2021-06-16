using dotnet.core.camerapi.Internal;
using dotnet.core.camerapi.Models;

namespace dotnet.core.camerapi.Impl.Builders
{
    internal class TimeoutParameterBuilder : ISingleParameterBuilder
    {
        public string Build(ImageParameters imageParameters)
        {
            if (imageParameters.VerticalFlip)
            {
                return $"--vflip";
            }

            return string.Empty;
        }
    }
}