using Dotnet.Core.Camerapi.Models;

namespace Dotnet.Core.Camerapi.Internal
{
    internal interface ISingleParameterBuilder
    {
        string Build(ImageParameters imageParameters);
    }
}