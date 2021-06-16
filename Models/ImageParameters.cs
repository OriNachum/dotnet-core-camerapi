using System;
using dotnet.core.camerapi.Enums;

namespace dotnet.core.camerapi.Models
{
    public class ImageParameters
    {
        ///
        /// Time (in ms) before takes picture and shuts down (if not specified, set to 5s)
        ///
        public long? Timeout { get; set; }

        public int? Width { get; set; }

        public int? Height { get; set; }

        ///
        /// Output filename <filename> (to write to stdout, use '-o -'). If not specified, no file is saved
        ///
        public string Output { get; set; }

        ///
        /// Set jpeg quality <0 to 100>
        ///
        public int? Quality { get; set; }

        public bool Raw  { get; set; }

        ///
        /// Timelapse mode. Takes a picture every <t>ms. %d == frame number (Try: -o img_%04d.jpg)
        ///
        public long? Timelapse { get; set; }

        public int Sharpness { get; set; }

        public int Contrast { get; set; }

        public int Brightness { get; set; }

        public int Saturation { get; set; }

        public bool CaptureIso { get; set; }

        public bool VideoStabilization { get; set; }


        public bool HorizontalFlip { get; set; }

        public bool VerticalFlip { get; set; }

        public int ShutterSpeed { get; set; }

        #nullable enable
        public eEncoding? Encoding { get; set; }
        ///
        /// Replace output pattern (%d)
        ///
        public eOutputPattern? OutputPattern { get; set; }


        public eImageEffect? ImageEffect { get; set; }
        public eMetering? MeteringMode { get; set; }

        public eRotation? ImageRotation { get; set; }
        #nullable disable
    }
}
