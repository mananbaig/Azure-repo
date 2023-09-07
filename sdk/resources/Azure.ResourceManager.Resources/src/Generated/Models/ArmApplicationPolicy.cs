// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Resources.Models
{
    /// <summary> Managed application policy. </summary>
    public partial class ArmApplicationPolicy
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ArmApplicationPolicy"/>. </summary>
        public ArmApplicationPolicy()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ArmApplicationPolicy"/>. </summary>
        /// <param name="name"> The policy name. </param>
        /// <param name="policyDefinitionId"> The policy definition Id. </param>
        /// <param name="parameters"> The policy parameters. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ArmApplicationPolicy(string name, string policyDefinitionId, string parameters, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            PolicyDefinitionId = policyDefinitionId;
            Parameters = parameters;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The policy name. </summary>
        public string Name { get; set; }
        /// <summary> The policy definition Id. </summary>
        public string PolicyDefinitionId { get; set; }
        /// <summary> The policy parameters. </summary>
        public string Parameters { get; set; }
    }
}
