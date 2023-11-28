// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Media.Models
{
    /// <summary> An object of optional configuration settings for encoder. </summary>
    public partial class EncoderPresetConfigurations
    {
        /// <summary> Initializes a new instance of <see cref="EncoderPresetConfigurations"/>. </summary>
        public EncoderPresetConfigurations()
        {
        }

        /// <summary> Initializes a new instance of <see cref="EncoderPresetConfigurations"/>. </summary>
        /// <param name="complexity"> Allows you to configure the encoder settings to control the balance between speed and quality. Example: set Complexity as Speed for faster encoding but less compression efficiency. </param>
        /// <param name="interleaveOutput"> Sets the interleave mode of the output to control how audio and video are stored in the container format. Example: set InterleavedOutput as NonInterleavedOutput to produce audio-only and video-only outputs in separate MP4 files. </param>
        /// <param name="keyFrameIntervalInSeconds"> The key frame interval in seconds. Example: set KeyFrameIntervalInSeconds as 2 to reduce the playback buffering for some players. </param>
        /// <param name="maxBitrateBps"> The maximum bitrate in bits per second (threshold for the top video layer). Example: set MaxBitrateBps as 6000000 to avoid producing very high bitrate outputs for contents with high complexity. </param>
        /// <param name="maxHeight"> The maximum height of output video layers. Example: set MaxHeight as 720 to produce output layers up to 720P even if the input is 4K. </param>
        /// <param name="maxLayers"> The maximum number of output video layers. Example: set MaxLayers as 4 to make sure at most 4 output layers are produced to control the overall cost of the encoding job. </param>
        /// <param name="minBitrateBps"> The minimum bitrate in bits per second (threshold for the bottom video layer). Example: set MinBitrateBps as 200000 to have a bottom layer that covers users with low network bandwidth. </param>
        /// <param name="minHeight"> The minimum height of output video layers. Example: set MinHeight as 360 to avoid output layers of smaller resolutions like 180P. </param>
        internal EncoderPresetConfigurations(EncodingComplexity? complexity, InterleaveOutput? interleaveOutput, float? keyFrameIntervalInSeconds, int? maxBitrateBps, int? maxHeight, int? maxLayers, int? minBitrateBps, int? minHeight)
        {
            Complexity = complexity;
            InterleaveOutput = interleaveOutput;
            KeyFrameIntervalInSeconds = keyFrameIntervalInSeconds;
            MaxBitrateBps = maxBitrateBps;
            MaxHeight = maxHeight;
            MaxLayers = maxLayers;
            MinBitrateBps = minBitrateBps;
            MinHeight = minHeight;
        }

        /// <summary> Allows you to configure the encoder settings to control the balance between speed and quality. Example: set Complexity as Speed for faster encoding but less compression efficiency. </summary>
        public EncodingComplexity? Complexity { get; set; }
        /// <summary> Sets the interleave mode of the output to control how audio and video are stored in the container format. Example: set InterleavedOutput as NonInterleavedOutput to produce audio-only and video-only outputs in separate MP4 files. </summary>
        public InterleaveOutput? InterleaveOutput { get; set; }
        /// <summary> The key frame interval in seconds. Example: set KeyFrameIntervalInSeconds as 2 to reduce the playback buffering for some players. </summary>
        public float? KeyFrameIntervalInSeconds { get; set; }
        /// <summary> The maximum bitrate in bits per second (threshold for the top video layer). Example: set MaxBitrateBps as 6000000 to avoid producing very high bitrate outputs for contents with high complexity. </summary>
        public int? MaxBitrateBps { get; set; }
        /// <summary> The maximum height of output video layers. Example: set MaxHeight as 720 to produce output layers up to 720P even if the input is 4K. </summary>
        public int? MaxHeight { get; set; }
        /// <summary> The maximum number of output video layers. Example: set MaxLayers as 4 to make sure at most 4 output layers are produced to control the overall cost of the encoding job. </summary>
        public int? MaxLayers { get; set; }
        /// <summary> The minimum bitrate in bits per second (threshold for the bottom video layer). Example: set MinBitrateBps as 200000 to have a bottom layer that covers users with low network bandwidth. </summary>
        public int? MinBitrateBps { get; set; }
        /// <summary> The minimum height of output video layers. Example: set MinHeight as 360 to avoid output layers of smaller resolutions like 180P. </summary>
        public int? MinHeight { get; set; }
    }
}
