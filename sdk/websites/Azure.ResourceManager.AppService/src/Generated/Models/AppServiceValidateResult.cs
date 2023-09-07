// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Describes the result of resource validation. </summary>
    public partial class AppServiceValidateResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="AppServiceValidateResult"/>. </summary>
        internal AppServiceValidateResult()
        {
        }

        /// <summary> Initializes a new instance of <see cref="AppServiceValidateResult"/>. </summary>
        /// <param name="status"> Result of validation. </param>
        /// <param name="error"> Error details for the case when validation fails. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AppServiceValidateResult(string status, ValidateResponseError error, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Status = status;
            Error = error;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Result of validation. </summary>
        public string Status { get; }
        /// <summary> Error details for the case when validation fails. </summary>
        public ValidateResponseError Error { get; }
    }
}
