using Dotnet.Core.Camerapi.Models;

namespace Dotnet.Core.Camerapi.Internal
{
    public interface IImageParametersBuilder
    {
        string BuildLineParameters(ImageParameters imageParameters);
    }
}