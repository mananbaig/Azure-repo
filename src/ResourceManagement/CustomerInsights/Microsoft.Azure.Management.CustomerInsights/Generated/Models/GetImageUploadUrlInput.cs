// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.CustomerInsights.Models
{
    using System.Linq;

    /// <summary>
    /// Input type for getting image upload url.
    /// </summary>
    public partial class GetImageUploadUrlInput
    {
        /// <summary>
        /// Initializes a new instance of the GetImageUploadUrlInput class.
        /// </summary>
        public GetImageUploadUrlInput() { }

        /// <summary>
        /// Initializes a new instance of the GetImageUploadUrlInput class.
        /// </summary>
        /// <param name="entityType">Type of entity. Can be Profile or
        /// Interaction.</param>
        /// <param name="entityTypeName">Name of the entity type.</param>
        /// <param name="relativePath">Relative path of the image.</param>
        public GetImageUploadUrlInput(string entityType = default(string), string entityTypeName = default(string), string relativePath = default(string))
        {
            EntityType = entityType;
            EntityTypeName = entityTypeName;
            RelativePath = relativePath;
        }

        /// <summary>
        /// Gets or sets type of entity. Can be Profile or Interaction.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "entityType")]
        public string EntityType { get; set; }

        /// <summary>
        /// Gets or sets name of the entity type.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "entityTypeName")]
        public string EntityTypeName { get; set; }

        /// <summary>
        /// Gets or sets relative path of the image.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "relativePath")]
        public string RelativePath { get; set; }

    }
}
