// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Media.LiveVideoAnalytics.Edge.Models
{
    /// <summary> Encoding settings for Bmp images. </summary>
    public partial class MediaGraphImageFormatBmp : MediaGraphImageFormat
    {
        /// <summary> Initializes a new instance of MediaGraphImageFormatBmp. </summary>
        public MediaGraphImageFormatBmp()
        {
            Type = "#Microsoft.Media.MediaGraphImageFormatBmp";
        }

        /// <summary> Initializes a new instance of MediaGraphImageFormatBmp. </summary>
        /// <param name="type"> The discriminator for derived types. </param>
        internal MediaGraphImageFormatBmp(string type) : base(type)
        {
            Type = type ?? "#Microsoft.Media.MediaGraphImageFormatBmp";
        }
    }
}
