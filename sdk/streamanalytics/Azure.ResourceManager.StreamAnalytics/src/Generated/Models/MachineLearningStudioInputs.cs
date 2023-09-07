// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.StreamAnalytics.Models
{
    /// <summary> The inputs for the Azure Machine Learning Studio endpoint. </summary>
    public partial class MachineLearningStudioInputs
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="MachineLearningStudioInputs"/>. </summary>
        public MachineLearningStudioInputs()
        {
            ColumnNames = new ChangeTrackingList<MachineLearningStudioInputColumn>();
        }

        /// <summary> Initializes a new instance of <see cref="MachineLearningStudioInputs"/>. </summary>
        /// <param name="name"> The name of the input. This is the name provided while authoring the endpoint. </param>
        /// <param name="columnNames"> A list of input columns for the Azure Machine Learning Studio endpoint. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MachineLearningStudioInputs(string name, IList<MachineLearningStudioInputColumn> columnNames, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            ColumnNames = columnNames;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The name of the input. This is the name provided while authoring the endpoint. </summary>
        public string Name { get; set; }
        /// <summary> A list of input columns for the Azure Machine Learning Studio endpoint. </summary>
        public IList<MachineLearningStudioInputColumn> ColumnNames { get; }
    }
}
