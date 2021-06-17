using Dotnet.Core.Camerapi.Impl.Builders;
using Dotnet.Core.Camerapi.Internal;
using Dotnet.Core.Camerapi.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dotnet.Core.Camerapi.Impl
{
    public class ImageParametersBuilder : IImageParametersBuilder
    {
        private List<ISingleParameterBuilder> _list;

        public ImageParametersBuilder()
        {
            _list = new List<ISingleParameterBuilder>
            {
                new BrightnessParameterBuilder(),
                new CaptureIsoParameterBuilder(),
                new ContrastParameterBuilder(),
                new EncodingParameterBuilder(),
                new HeightParameterBuilder(),
                new HorizontalFlipParameterBuilder(),
                new ImageEffectParameterBuilder(),
                new ImageRotationParameterBuilder(),
                new MeteringModeParameterBuilder(),
                new OutputParameterBuilder(),
                new OutputPatternParameterBuilder(),
                new RawParameterBuilder(),
                new SaturationParameterBuilder(),
                new SharpnessParameterBuilder(),
                new ShutterSpeedParameterBuilder(),
                new TimelapseParameterBuilder(),
                new TimeoutParameterBuilder(),
                new VerticalFlipParameterBuilder(),
                new VideoStabilizationParameterBuilder(),
                new WidthParameterBuilder(),
            };
        }

        public string BuildLineParameters(ImageParameters imageParameters)
        {
            var sb = new StringBuilder();
            foreach (ISingleParameterBuilder builder in _list)
            {
                sb.Append(builder.Build(imageParameters)).Append(" ");
            }

            return sb.ToString();
        }
    }
}
