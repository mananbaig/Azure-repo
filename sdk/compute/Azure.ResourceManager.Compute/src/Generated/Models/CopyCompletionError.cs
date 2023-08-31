// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Indicates the error details if the background copy of a resource created via the CopyStart operation fails. </summary>
    public partial class CopyCompletionError
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="CopyCompletionError"/>. </summary>
        /// <param name="errorCode"> Indicates the error code if the background copy of a resource created via the CopyStart operation fails. </param>
        /// <param name="errorMessage"> Indicates the error message if the background copy of a resource created via the CopyStart operation fails. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="errorMessage"/> is null. </exception>
        public CopyCompletionError(CopyCompletionErrorReason errorCode, string errorMessage)
        {
            Argument.AssertNotNull(errorMessage, nameof(errorMessage));

            ErrorCode = errorCode;
            ErrorMessage = errorMessage;
        }

        /// <summary> Initializes a new instance of <see cref="CopyCompletionError"/>. </summary>
        /// <param name="errorCode"> Indicates the error code if the background copy of a resource created via the CopyStart operation fails. </param>
        /// <param name="errorMessage"> Indicates the error message if the background copy of a resource created via the CopyStart operation fails. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal CopyCompletionError(CopyCompletionErrorReason errorCode, string errorMessage, Dictionary<string, BinaryData> rawData)
        {
            ErrorCode = errorCode;
            ErrorMessage = errorMessage;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="CopyCompletionError"/> for deserialization. </summary>
        internal CopyCompletionError()
        {
        }

        /// <summary> Indicates the error code if the background copy of a resource created via the CopyStart operation fails. </summary>
        public CopyCompletionErrorReason ErrorCode { get; set; }
        /// <summary> Indicates the error message if the background copy of a resource created via the CopyStart operation fails. </summary>
        public string ErrorMessage { get; set; }
    }
}
