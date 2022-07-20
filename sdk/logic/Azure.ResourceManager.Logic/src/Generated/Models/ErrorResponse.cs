// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Logic.Models
{
    /// <summary> Error response indicates Logic service is not able to process the incoming request. The error property contains the error details. </summary>
    internal partial class ErrorResponse
    {
        /// <summary> Initializes a new instance of ErrorResponse. </summary>
        public ErrorResponse()
        {
        }

        /// <summary> Initializes a new instance of ErrorResponse. </summary>
        /// <param name="error"> The error properties. </param>
        internal ErrorResponse(ErrorProperties error)
        {
            Error = error;
        }

        /// <summary> The error properties. </summary>
        public ErrorProperties Error { get; set; }
    }
}
