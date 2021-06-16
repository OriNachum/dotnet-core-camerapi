using dotnet.core.camerapi.Internal;
using dotnet.core.camerapi.Models;

namespace dotnet.core.camerapi.Impl.Builders
{
    internal class HorizontalFlipParameterBuilder : ISingleParameterBuilder
    {
        public string Build(ImageParameters imageParameters)
        {
            if (imageParameters.HorizontalFlip)
            {
                return $"--hflip";
            }

            return string.Empty;
        }
    }
}