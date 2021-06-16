using dotnet.core.camerapi.Models;
using System;
using System.Diagnostics;

namespace dotnet.core.camerapi.Impl
{
    public class CameraPi : ICameraPi
    {
        public string CaptureImage(ImageParameters imageParameters)
        {
            string lineParameters = BuildLineParameters(imageParameters);
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

        private string BuildLineParameters(ImageParameters imageParameters)
        {
            throw new NotImplementedException();
        }
    }
}
