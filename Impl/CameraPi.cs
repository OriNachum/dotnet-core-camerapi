using dotnet.core.camerapi.Internal;
using dotnet.core.camerapi.Models;
using System;
using System.Diagnostics;
using System.Text;

namespace dotnet.core.camerapi.Impl
{
    public class CameraPi : ICameraPi
    {
        private IImageParametersBuilder _imageParameterBuilder;

        public CameraPi(IImageParametersBuilder imageParameterBuilder)
        {
            _imageParameterBuilder = imageParameterBuilder ?? new ImageParametersBuilder();
        }

        public string CaptureImage(ImageParameters imageParameters)
        {
            string lineParameters = _imageParameterBuilder.BuildLineParameters(imageParameters);
            string command = "raspistill";
            string result = "";
            using (var proc = new Process())
            {
                proc.StartInfo.FileName = "/bin/bash";
                proc.StartInfo.Arguments = $"-c \" {command} {lineParameters} \"";
                proc.StartInfo.UseShellExecute = false;
                proc.StartInfo.RedirectStandardOutput = true;
                proc.StartInfo.RedirectStandardError = true;
                proc.Start();

                result += proc.StandardOutput.ReadToEnd();
                result += proc.StandardError.ReadToEnd();

                proc.WaitForExit();
            }

            return result;
        }
    }
}
