// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.AppPlatform.Models
{
    /// <summary> Regenerate test key request payload. </summary>
    public partial class RegenerateTestKeyRequestPayload
    {
        /// <summary> Initializes a new instance of RegenerateTestKeyRequestPayload. </summary>
        /// <param name="keyType"> Type of the test key. </param>
        public RegenerateTestKeyRequestPayload(TestKeyType keyType)
        {
            KeyType = keyType;
        }

        /// <summary> Type of the test key. </summary>
        public TestKeyType KeyType { get; }
    }
}
