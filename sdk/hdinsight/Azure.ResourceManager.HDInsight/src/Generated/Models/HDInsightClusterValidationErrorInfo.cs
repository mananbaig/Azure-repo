// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.HDInsight.Models
{
    /// <summary> The validation error information. </summary>
    public partial class HDInsightClusterValidationErrorInfo
    {
        /// <summary> Initializes a new instance of HDInsightClusterValidationErrorInfo. </summary>
        internal HDInsightClusterValidationErrorInfo()
        {
            MessageArguments = new Core.ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of HDInsightClusterValidationErrorInfo. </summary>
        /// <param name="code"> The error code. </param>
        /// <param name="message"> The error message. </param>
        /// <param name="errorResource"> The error resource. </param>
        /// <param name="messageArguments"> The message arguments. </param>
        internal HDInsightClusterValidationErrorInfo(string code, string message, string errorResource, IReadOnlyList<string> messageArguments)
        {
            Code = code;
            Message = message;
            ErrorResource = errorResource;
            MessageArguments = messageArguments;
        }

        /// <summary> The error code. </summary>
        public string Code { get; }
        /// <summary> The error message. </summary>
        public string Message { get; }
        /// <summary> The error resource. </summary>
        public string ErrorResource { get; }
        /// <summary> The message arguments. </summary>
        public IReadOnlyList<string> MessageArguments { get; }
    }
}
