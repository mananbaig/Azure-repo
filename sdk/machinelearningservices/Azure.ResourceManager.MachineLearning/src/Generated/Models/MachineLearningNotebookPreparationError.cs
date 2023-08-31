// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> The MachineLearningNotebookPreparationError. </summary>
    public partial class MachineLearningNotebookPreparationError
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="MachineLearningNotebookPreparationError"/>. </summary>
        internal MachineLearningNotebookPreparationError()
        {
        }

        /// <summary> Initializes a new instance of <see cref="MachineLearningNotebookPreparationError"/>. </summary>
        /// <param name="errorMessage"></param>
        /// <param name="statusCode"></param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal MachineLearningNotebookPreparationError(string errorMessage, int? statusCode, Dictionary<string, BinaryData> rawData)
        {
            ErrorMessage = errorMessage;
            StatusCode = statusCode;
            _rawData = rawData;
        }

        /// <summary> Gets the error message. </summary>
        public string ErrorMessage { get; }
        /// <summary> Gets the status code. </summary>
        public int? StatusCode { get; }
    }
}
