// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Media.Models
{
    /// <summary> Describes the properties for producing a series of PNG images from the input video. </summary>
    public partial class PngImage : MediaImageBase
    {
        /// <summary> Initializes a new instance of PngImage. </summary>
        /// <param name="start"> The position in the input video from where to start generating thumbnails. The value can be in ISO 8601 format (For example, PT05S to start at 5 seconds), or a frame count (For example, 10 to start at the 10th frame), or a relative value to stream duration (For example, 10% to start at 10% of stream duration). Also supports a macro {Best}, which tells the encoder to select the best thumbnail from the first few seconds of the video and will only produce one thumbnail, no matter what other settings are for Step and Range. The default value is macro {Best}. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="start"/> is null. </exception>
        public PngImage(string start) : base(start)
        {
            if (start == null)
            {
                throw new ArgumentNullException(nameof(start));
            }

            Layers = new ChangeTrackingList<PngLayer>();
            OdataType = "#Microsoft.Media.PngImage";
        }

        /// <summary> Initializes a new instance of PngImage. </summary>
        /// <param name="odataType"> The discriminator for derived types. </param>
        /// <param name="label"> An optional label for the codec. The label can be used to control muxing behavior. </param>
        /// <param name="keyFrameInterval"> The distance between two key frames. The value should be non-zero in the range [0.5, 20] seconds, specified in ISO 8601 format. The default is 2 seconds(PT2S). Note that this setting is ignored if VideoSyncMode.Passthrough is set, where the KeyFrameInterval value will follow the input source setting. </param>
        /// <param name="stretchMode"> The resizing mode - how the input video will be resized to fit the desired output resolution(s). Default is AutoSize. </param>
        /// <param name="syncMode"> The Video Sync Mode. </param>
        /// <param name="start"> The position in the input video from where to start generating thumbnails. The value can be in ISO 8601 format (For example, PT05S to start at 5 seconds), or a frame count (For example, 10 to start at the 10th frame), or a relative value to stream duration (For example, 10% to start at 10% of stream duration). Also supports a macro {Best}, which tells the encoder to select the best thumbnail from the first few seconds of the video and will only produce one thumbnail, no matter what other settings are for Step and Range. The default value is macro {Best}. </param>
        /// <param name="step"> The intervals at which thumbnails are generated. The value can be in ISO 8601 format (For example, PT05S for one image every 5 seconds), or a frame count (For example, 30 for one image every 30 frames), or a relative value to stream duration (For example, 10% for one image every 10% of stream duration). Note: Step value will affect the first generated thumbnail, which may not be exactly the one specified at transform preset start time. This is due to the encoder, which tries to select the best thumbnail between start time and Step position from start time as the first output. As the default value is 10%, it means if stream has long duration, the first generated thumbnail might be far away from the one specified at start time. Try to select reasonable value for Step if the first thumbnail is expected close to start time, or set Range value at 1 if only one thumbnail is needed at start time. </param>
        /// <param name="range"> The position relative to transform preset start time in the input video at which to stop generating thumbnails. The value can be in ISO 8601 format (For example, PT5M30S to stop at 5 minutes and 30 seconds from start time), or a frame count (For example, 300 to stop at the 300th frame from the frame at start time. If this value is 1, it means only producing one thumbnail at start time), or a relative value to the stream duration (For example, 50% to stop at half of stream duration from start time). The default value is 100%, which means to stop at the end of the stream. </param>
        /// <param name="layers"> A collection of output PNG image layers to be produced by the encoder. </param>
        internal PngImage(string odataType, string label, TimeSpan? keyFrameInterval, InputVideoStretchMode? stretchMode, VideoSyncMode? syncMode, string start, string step, string range, IList<PngLayer> layers) : base(odataType, label, keyFrameInterval, stretchMode, syncMode, start, step, range)
        {
            Layers = layers;
            OdataType = odataType ?? "#Microsoft.Media.PngImage";
        }

        /// <summary> A collection of output PNG image layers to be produced by the encoder. </summary>
        public IList<PngLayer> Layers { get; }
    }
}
