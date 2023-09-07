// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.AI.TextAnalytics.Legacy.Models;
using Azure.Core;

namespace Azure.AI.TextAnalytics.Legacy
{
    /// <summary> The TargetRelation. </summary>
    internal partial class TargetRelation
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="TargetRelation"/>. </summary>
        /// <param name="relationType"> The type related to the target. </param>
        /// <param name="ref"> The JSON pointer indicating the linked object. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="ref"/> is null. </exception>
        internal TargetRelation(TargetRelationType relationType, string @ref)
        {
            Argument.AssertNotNull(@ref, nameof(@ref));

            RelationType = relationType;
            Ref = @ref;
        }

        /// <summary> Initializes a new instance of <see cref="TargetRelation"/>. </summary>
        /// <param name="relationType"> The type related to the target. </param>
        /// <param name="ref"> The JSON pointer indicating the linked object. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal TargetRelation(TargetRelationType relationType, string @ref, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            RelationType = relationType;
            Ref = @ref;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="TargetRelation"/> for deserialization. </summary>
        internal TargetRelation()
        {
        }

        /// <summary> The type related to the target. </summary>
        public TargetRelationType RelationType { get; }
        /// <summary> The JSON pointer indicating the linked object. </summary>
        public string Ref { get; }
    }
}
