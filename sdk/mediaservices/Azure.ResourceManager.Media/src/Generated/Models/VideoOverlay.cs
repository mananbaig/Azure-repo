// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Media.Models
{
    /// <summary> Describes the properties of a video overlay. </summary>
    public partial class VideoOverlay : MediaOverlayBase
    {
        /// <summary> Initializes a new instance of <see cref="VideoOverlay"/>. </summary>
        /// <param name="inputLabel"> The label of the job input which is to be used as an overlay. The Input must specify exactly one file. You can specify an image file in JPG, PNG, GIF or BMP format, or an audio file (such as a WAV, MP3, WMA or M4A file), or a video file. See https://aka.ms/mesformats for the complete list of supported audio and video file formats. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="inputLabel"/> is null. </exception>
        public VideoOverlay(string inputLabel) : base(inputLabel)
        {
            Argument.AssertNotNull(inputLabel, nameof(inputLabel));

            OdataType = "#Microsoft.Media.VideoOverlay";
        }

        /// <summary> Initializes a new instance of <see cref="VideoOverlay"/>. </summary>
        /// <param name="odataType"> The discriminator for derived types. </param>
        /// <param name="inputLabel"> The label of the job input which is to be used as an overlay. The Input must specify exactly one file. You can specify an image file in JPG, PNG, GIF or BMP format, or an audio file (such as a WAV, MP3, WMA or M4A file), or a video file. See https://aka.ms/mesformats for the complete list of supported audio and video file formats. </param>
        /// <param name="start"> The start position, with reference to the input video, at which the overlay starts. The value should be in ISO 8601 format. For example, PT05S to start the overlay at 5 seconds into the input video. If not specified the overlay starts from the beginning of the input video. </param>
        /// <param name="end"> The end position, with reference to the input video, at which the overlay ends. The value should be in ISO 8601 format. For example, PT30S to end the overlay at 30 seconds into the input video. If not specified or the value is greater than the input video duration, the overlay will be applied until the end of the input video if the overlay media duration is greater than the input video duration, else the overlay will last as long as the overlay media duration. </param>
        /// <param name="fadeInDuration"> The duration over which the overlay fades in onto the input video. The value should be in ISO 8601 duration format. If not specified the default behavior is to have no fade in (same as PT0S). </param>
        /// <param name="fadeOutDuration"> The duration over which the overlay fades out of the input video. The value should be in ISO 8601 duration format. If not specified the default behavior is to have no fade out (same as PT0S). </param>
        /// <param name="audioGainLevel"> The gain level of audio in the overlay. The value should be in the range [0, 1.0]. The default is 1.0. </param>
        /// <param name="position"> The location in the input video where the overlay is applied. </param>
        /// <param name="opacity"> The opacity of the overlay. This is a value in the range [0 - 1.0]. Default is 1.0 which mean the overlay is opaque. </param>
        /// <param name="cropRectangle"> An optional rectangular window used to crop the overlay image or video. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal VideoOverlay(string odataType, string inputLabel, TimeSpan? start, TimeSpan? end, TimeSpan? fadeInDuration, TimeSpan? fadeOutDuration, double? audioGainLevel, RectangularWindow position, double? opacity, RectangularWindow cropRectangle, Dictionary<string, BinaryData> rawData) : base(odataType, inputLabel, start, end, fadeInDuration, fadeOutDuration, audioGainLevel, rawData)
        {
            Position = position;
            Opacity = opacity;
            CropRectangle = cropRectangle;
            OdataType = odataType ?? "#Microsoft.Media.VideoOverlay";
        }

        /// <summary> Initializes a new instance of <see cref="VideoOverlay"/> for deserialization. </summary>
        internal VideoOverlay()
        {
        }

        /// <summary> The location in the input video where the overlay is applied. </summary>
        public RectangularWindow Position { get; set; }
        /// <summary> The opacity of the overlay. This is a value in the range [0 - 1.0]. Default is 1.0 which mean the overlay is opaque. </summary>
        public double? Opacity { get; set; }
        /// <summary> An optional rectangular window used to crop the overlay image or video. </summary>
        public RectangularWindow CropRectangle { get; set; }
    }
}
