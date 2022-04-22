// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.EdgeOrder.Models
{
    /// <summary> Image for the product. </summary>
    public partial class ImageInformation
    {
        /// <summary> Initializes a new instance of ImageInformation. </summary>
        internal ImageInformation()
        {
        }

        /// <summary> Initializes a new instance of ImageInformation. </summary>
        /// <param name="imageType"> Type of the image. </param>
        /// <param name="imageUrl"> Url of the image. </param>
        internal ImageInformation(ImageType? imageType, string imageUrl)
        {
            ImageType = imageType;
            ImageUrl = imageUrl;
        }

        /// <summary> Type of the image. </summary>
        public ImageType? ImageType { get; }
        /// <summary> Url of the image. </summary>
        public string ImageUrl { get; }
    }
}
