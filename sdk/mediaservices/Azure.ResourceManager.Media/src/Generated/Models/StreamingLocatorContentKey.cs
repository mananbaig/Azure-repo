// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Media.Models
{
    /// <summary> Class for content key in Streaming Locator. </summary>
    public partial class StreamingLocatorContentKey
    {
        /// <summary> Initializes a new instance of StreamingLocatorContentKey. </summary>
        /// <param name="id"> ID of Content Key. </param>
        public StreamingLocatorContentKey(Guid id)
        {
            Id = id;
            Tracks = new Core.ChangeTrackingList<MediaTrackSelection>();
        }

        /// <summary> Initializes a new instance of StreamingLocatorContentKey. </summary>
        /// <param name="id"> ID of Content Key. </param>
        /// <param name="keyType"> Encryption type of Content Key. </param>
        /// <param name="labelReferenceInStreamingPolicy"> Label of Content Key as specified in the Streaming Policy. </param>
        /// <param name="value"> Value of Content Key. </param>
        /// <param name="policyName"> ContentKeyPolicy used by Content Key. </param>
        /// <param name="tracks"> Tracks which use this Content Key. </param>
        internal StreamingLocatorContentKey(Guid id, StreamingLocatorContentKeyType? keyType, string labelReferenceInStreamingPolicy, string value, string policyName, IReadOnlyList<MediaTrackSelection> tracks)
        {
            Id = id;
            KeyType = keyType;
            LabelReferenceInStreamingPolicy = labelReferenceInStreamingPolicy;
            Value = value;
            PolicyName = policyName;
            Tracks = tracks;
        }

        /// <summary> ID of Content Key. </summary>
        public Guid Id { get; set; }
        /// <summary> Encryption type of Content Key. </summary>
        public StreamingLocatorContentKeyType? KeyType { get; }
        /// <summary> Label of Content Key as specified in the Streaming Policy. </summary>
        public string LabelReferenceInStreamingPolicy { get; set; }
        /// <summary> Value of Content Key. </summary>
        public string Value { get; set; }
        /// <summary> ContentKeyPolicy used by Content Key. </summary>
        public string PolicyName { get; }
        /// <summary> Tracks which use this Content Key. </summary>
        public IReadOnlyList<MediaTrackSelection> Tracks { get; }
    }
}
