// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure;

namespace Azure.ResourceManager.DataBox.Models
{
    /// <summary> The UnknownValidationInputResponse. </summary>
    internal partial class UnknownValidationInputResponse : DataBoxValidationInputResult
    {
        /// <summary> Initializes a new instance of <see cref="UnknownValidationInputResponse"/>. </summary>
        /// <param name="validationType"> Identifies the type of validation response. </param>
        /// <param name="error"> Error code and message of validation response. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal UnknownValidationInputResponse(DataBoxValidationInputDiscriminator validationType, ResponseError error, Dictionary<string, BinaryData> rawData) : base(validationType, error, rawData)
        {
            ValidationType = validationType;
        }

        /// <summary> Initializes a new instance of <see cref="UnknownValidationInputResponse"/> for deserialization. </summary>
        internal UnknownValidationInputResponse()
        {
        }
    }
}
