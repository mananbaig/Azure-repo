// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Synapse.Models
{
    /// <summary> The result returned from a data connection validation request. </summary>
    public partial class DataConnectionValidationResult
    {
        /// <summary> Initializes a new instance of DataConnectionValidationResult. </summary>
        internal DataConnectionValidationResult()
        {
        }

        /// <summary> Initializes a new instance of DataConnectionValidationResult. </summary>
        /// <param name="errorMessage"> A message which indicates a problem in data connection validation. </param>
        internal DataConnectionValidationResult(string errorMessage)
        {
            ErrorMessage = errorMessage;
        }

        /// <summary> A message which indicates a problem in data connection validation. </summary>
        public string ErrorMessage { get; }
    }
}
