// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DevTestLabs.Models
{
    /// <summary> Policy violation. </summary>
    public partial class DevTestLabPolicyViolation
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="DevTestLabPolicyViolation"/>. </summary>
        internal DevTestLabPolicyViolation()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DevTestLabPolicyViolation"/>. </summary>
        /// <param name="code"> The code of the policy violation. </param>
        /// <param name="message"> The message of the policy violation. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DevTestLabPolicyViolation(string code, string message, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Code = code;
            Message = message;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The code of the policy violation. </summary>
        public string Code { get; }
        /// <summary> The message of the policy violation. </summary>
        public string Message { get; }
    }
}
