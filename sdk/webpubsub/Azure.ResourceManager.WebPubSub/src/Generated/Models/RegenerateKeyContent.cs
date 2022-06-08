// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.WebPubSub.Models
{
    /// <summary> Parameters describes the request to regenerate access keys. </summary>
    public partial class RegenerateKeyContent
    {
        /// <summary> Initializes a new instance of <see cref="RegenerateKeyContent"/>. </summary>
        public RegenerateKeyContent()
        {
        }

        /// <summary> The keyType to regenerate. Must be either &apos;primary&apos; or &apos;secondary&apos;(case-insensitive). </summary>
        public KeyType? KeyType { get; set; }
    }
}
