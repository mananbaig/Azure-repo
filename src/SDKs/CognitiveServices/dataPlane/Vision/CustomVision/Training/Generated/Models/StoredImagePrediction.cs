// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.CognitiveServices.Vision.CustomVision.Training.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// result of an image classification request
    /// </summary>
    public partial class StoredImagePrediction
    {
        /// <summary>
        /// Initializes a new instance of the StoredImagePrediction class.
        /// </summary>
        public StoredImagePrediction()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the StoredImagePrediction class.
        /// </summary>
        public StoredImagePrediction(string imageUri = default(string), string thumbnailUri = default(string), System.Guid domain = default(System.Guid), System.Guid id = default(System.Guid), System.Guid project = default(System.Guid), System.Guid iteration = default(System.Guid), System.DateTime created = default(System.DateTime), IList<Prediction> predictions = default(IList<Prediction>))
        {
            ImageUri = imageUri;
            ThumbnailUri = thumbnailUri;
            Domain = domain;
            Id = id;
            Project = project;
            Iteration = iteration;
            Created = created;
            Predictions = predictions;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "imageUri")]
        public string ImageUri { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "thumbnailUri")]
        public string ThumbnailUri { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "domain")]
        public System.Guid Domain { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public System.Guid Id { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "project")]
        public System.Guid Project { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "iteration")]
        public System.Guid Iteration { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "created")]
        public System.DateTime Created { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "predictions")]
        public IList<Prediction> Predictions { get; private set; }

    }
}
