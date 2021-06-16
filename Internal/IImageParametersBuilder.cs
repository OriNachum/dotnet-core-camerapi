using dotnet.core.camerapi.Models;

namespace dotnet.core.camerapi.Internal
{
    public interface IImageParametersBuilder
    {
        string BuildLineParameters(ImageParameters imageParameters);
    }
}