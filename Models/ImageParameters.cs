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

        public eEncoding? Encoding { get; set; }

        ///
        /// Set jpeg quality <0 to 100>
        ///
        public int? Quality { get; set; }

        
        public bool Raw  { get; set; }


        ///
        /// Timelapse mode. Takes a picture every <t>ms. %d == frame number (Try: -o img_%04d.jpg)
        ///
        public long? Timelapse { get; set; }

        ///
        /// Replace output pattern (%d)
        ///
        public eOutputPattern OutputPattern { get; set; }

    }
}
