// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Resources.Models
{
    /// <summary> The ResourceTypeAliasPathMetadata. </summary>
    public partial class ResourceTypeAliasPathMetadata
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ResourceTypeAliasPathMetadata"/>. </summary>
        internal ResourceTypeAliasPathMetadata()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ResourceTypeAliasPathMetadata"/>. </summary>
        /// <param name="tokenType"> The type of the token that the alias path is referring to. </param>
        /// <param name="attributes"> The attributes of the token that the alias path is referring to. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ResourceTypeAliasPathMetadata(ResourceTypeAliasPathTokenType? tokenType, ResourceTypeAliasPathAttributes? attributes, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            TokenType = tokenType;
            Attributes = attributes;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The type of the token that the alias path is referring to. </summary>
        public ResourceTypeAliasPathTokenType? TokenType { get; }
        /// <summary> The attributes of the token that the alias path is referring to. </summary>
        public ResourceTypeAliasPathAttributes? Attributes { get; }
    }
}
