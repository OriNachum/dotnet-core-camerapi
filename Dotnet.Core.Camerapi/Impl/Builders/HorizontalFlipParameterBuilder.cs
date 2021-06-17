using Dotnet.Core.Camerapi.Internal;
using Dotnet.Core.Camerapi.Models;

namespace Dotnet.Core.Camerapi.Impl.Builders
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