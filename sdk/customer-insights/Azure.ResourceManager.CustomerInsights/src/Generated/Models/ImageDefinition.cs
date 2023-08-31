// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.CustomerInsights.Models
{
    /// <summary> The image definition. </summary>
    public partial class ImageDefinition
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ImageDefinition"/>. </summary>
        internal ImageDefinition()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ImageDefinition"/>. </summary>
        /// <param name="imageExists"> Whether image exists already. </param>
        /// <param name="contentUri"> Content URL for the image blob. </param>
        /// <param name="relativePath"> Relative path of the image. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ImageDefinition(bool? imageExists, Uri contentUri, string relativePath, Dictionary<string, BinaryData> rawData)
        {
            ImageExists = imageExists;
            ContentUri = contentUri;
            RelativePath = relativePath;
            _rawData = rawData;
        }

        /// <summary> Whether image exists already. </summary>
        public bool? ImageExists { get; }
        /// <summary> Content URL for the image blob. </summary>
        public Uri ContentUri { get; }
        /// <summary> Relative path of the image. </summary>
        public string RelativePath { get; }
    }
}
