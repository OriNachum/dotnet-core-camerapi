using dotnet.core.camerapi.Internal;
using dotnet.core.camerapi.Models;

namespace dotnet.core.camerapi.Impl.Builders
{
    internal class CaptureIsoParameterBuilder : ISingleParameterBuilder
    {
        public string Build(ImageParameters imageParameters)
        {
            if (imageParameters.CaptureIso)
            {
                return "--ISO";
            }

            return string.Empty;
        }
    }
}