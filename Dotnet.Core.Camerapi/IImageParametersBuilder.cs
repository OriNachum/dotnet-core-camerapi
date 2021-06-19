using Dotnet.Core.Camerapi.Models;

namespace Dotnet.Core.Camerapi
{
    public interface IImageParametersBuilder
    {
        string BuildLineParameters(ImageParameters imageParameters);
    }
}