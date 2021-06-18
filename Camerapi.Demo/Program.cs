using System;
using Dotnet.Core.Camerapi;
using Dotnet.Core.Camerapi.Impl;
using Dotnet.Core.Camerapi.Models;

namespace Camerapi.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Hello World!");

            var cameraPi = new CameraPiModule(null);
            cameraPi.CaptureImage(new ImageParameters
            {
                Output = args.Length == 0 ? "test" : args[0],
            });
        }
    }
}
