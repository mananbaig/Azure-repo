// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.RecoveryServicesDataReplication.Models
{
    /// <summary> Error model. </summary>
    public partial class DataReplicationErrorInfo
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="DataReplicationErrorInfo"/>. </summary>
        internal DataReplicationErrorInfo()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DataReplicationErrorInfo"/>. </summary>
        /// <param name="code"> Gets or sets the error code. </param>
        /// <param name="errorModelType"> Gets or sets the error type. </param>
        /// <param name="severity"> Gets or sets the error severity. </param>
        /// <param name="createdOn"> Gets or sets the creation time of error. </param>
        /// <param name="message"> Gets or sets the error message. </param>
        /// <param name="causes"> Gets or sets the possible causes of error. </param>
        /// <param name="recommendation"> Gets or sets the recommended action to resolve error. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DataReplicationErrorInfo(string code, string errorModelType, string severity, DateTimeOffset? createdOn, string message, string causes, string recommendation, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Code = code;
            ErrorModelType = errorModelType;
            Severity = severity;
            CreatedOn = createdOn;
            Message = message;
            Causes = causes;
            Recommendation = recommendation;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets or sets the error code. </summary>
        public string Code { get; }
        /// <summary> Gets or sets the error type. </summary>
        public string ErrorModelType { get; }
        /// <summary> Gets or sets the error severity. </summary>
        public string Severity { get; }
        /// <summary> Gets or sets the creation time of error. </summary>
        public DateTimeOffset? CreatedOn { get; }
        /// <summary> Gets or sets the error message. </summary>
        public string Message { get; }
        /// <summary> Gets or sets the possible causes of error. </summary>
        public string Causes { get; }
        /// <summary> Gets or sets the recommended action to resolve error. </summary>
        public string Recommendation { get; }
    }
}
