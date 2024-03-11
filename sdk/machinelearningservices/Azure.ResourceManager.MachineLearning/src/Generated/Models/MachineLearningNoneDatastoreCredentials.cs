// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Empty/none datastore credentials. </summary>
    public partial class MachineLearningNoneDatastoreCredentials : MachineLearningDatastoreCredentials
    {
        /// <summary> Initializes a new instance of <see cref="MachineLearningNoneDatastoreCredentials"/>. </summary>
        public MachineLearningNoneDatastoreCredentials()
        {
            CredentialsType = CredentialsType.None;
        }

        /// <summary> Initializes a new instance of <see cref="MachineLearningNoneDatastoreCredentials"/>. </summary>
        /// <param name="credentialsType"> [Required] Credential type used to authentication with storage. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MachineLearningNoneDatastoreCredentials(CredentialsType credentialsType, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(credentialsType, serializedAdditionalRawData)
        {
            CredentialsType = credentialsType;
        }
    }
}
