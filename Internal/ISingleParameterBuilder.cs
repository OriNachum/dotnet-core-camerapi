using dotnet.core.camerapi.Models;

namespace dotnet.core.camerapi.Internal
{
    internal interface ISingleParameterBuilder
    {
        string Build(ImageParameters imageParameters);
    }
}