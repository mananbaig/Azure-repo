// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.CognitiveServices.Vision.CustomVision.Prediction.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Result of an image prediction request.
    /// </summary>
    public partial class ImagePrediction
    {
        /// <summary>
        /// Initializes a new instance of the ImagePrediction class.
        /// </summary>
        public ImagePrediction()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ImagePrediction class.
        /// </summary>
        /// <param name="id">Prediction Id.</param>
        /// <param name="project">Project Id.</param>
        /// <param name="iteration">Iteration Id.</param>
        /// <param name="created">Date this prediction was created.</param>
        /// <param name="predictions">List of predictions.</param>
        public ImagePrediction(System.Guid id = default(System.Guid), System.Guid project = default(System.Guid), System.Guid iteration = default(System.Guid), System.DateTime created = default(System.DateTime), IList<PredictionModel> predictions = default(IList<PredictionModel>))
        {
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
        /// Gets prediction Id.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public System.Guid Id { get; private set; }

        /// <summary>
        /// Gets project Id.
        /// </summary>
        [JsonProperty(PropertyName = "project")]
        public System.Guid Project { get; private set; }

        /// <summary>
        /// Gets iteration Id.
        /// </summary>
        [JsonProperty(PropertyName = "iteration")]
        public System.Guid Iteration { get; private set; }

        /// <summary>
        /// Gets date this prediction was created.
        /// </summary>
        [JsonProperty(PropertyName = "created")]
        public System.DateTime Created { get; private set; }

        /// <summary>
        /// Gets list of predictions.
        /// </summary>
        [JsonProperty(PropertyName = "predictions")]
        public IList<PredictionModel> Predictions { get; private set; }

    }
}
