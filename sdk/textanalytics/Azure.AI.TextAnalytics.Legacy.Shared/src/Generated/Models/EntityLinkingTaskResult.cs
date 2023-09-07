// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.TextAnalytics.Legacy
{
    /// <summary> The EntityLinkingTaskResult. </summary>
    internal partial class EntityLinkingTaskResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        protected internal Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="EntityLinkingTaskResult"/>. </summary>
        internal EntityLinkingTaskResult()
        {
        }

        /// <summary> Initializes a new instance of <see cref="EntityLinkingTaskResult"/>. </summary>
        /// <param name="results"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal EntityLinkingTaskResult(EntityLinkingResult results, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Results = results;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets the results. </summary>
        public EntityLinkingResult Results { get; }
    }
}
