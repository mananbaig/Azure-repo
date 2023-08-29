// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.CognitiveServices.Models
{
    /// <summary> Regenerate key parameters. </summary>
    public partial class RegenerateServiceAccountKeyContent
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="RegenerateServiceAccountKeyContent"/>. </summary>
        /// <param name="keyName"> key name to generate (Key1|Key2). </param>
        public RegenerateServiceAccountKeyContent(ServiceAccountKeyName keyName)
        {
            KeyName = keyName;
        }

        /// <summary> Initializes a new instance of <see cref="RegenerateServiceAccountKeyContent"/>. </summary>
        /// <param name="keyName"> key name to generate (Key1|Key2). </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal RegenerateServiceAccountKeyContent(ServiceAccountKeyName keyName, Dictionary<string, BinaryData> rawData)
        {
            KeyName = keyName;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="RegenerateServiceAccountKeyContent"/> for deserialization. </summary>
        internal RegenerateServiceAccountKeyContent()
        {
        }

        /// <summary> key name to generate (Key1|Key2). </summary>
        public ServiceAccountKeyName KeyName { get; }
    }
}
