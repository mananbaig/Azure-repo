// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Kusto.Models
{
    /// <summary> The result returned from a follower invitation generation request. </summary>
    public partial class DatabaseInviteFollowerResult
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="DatabaseInviteFollowerResult"/>. </summary>
        internal DatabaseInviteFollowerResult()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DatabaseInviteFollowerResult"/>. </summary>
        /// <param name="generatedInvitation"> The generated invitation token. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal DatabaseInviteFollowerResult(string generatedInvitation, Dictionary<string, BinaryData> rawData)
        {
            GeneratedInvitation = generatedInvitation;
            _rawData = rawData;
        }

        /// <summary> The generated invitation token. </summary>
        public string GeneratedInvitation { get; }
    }
}
