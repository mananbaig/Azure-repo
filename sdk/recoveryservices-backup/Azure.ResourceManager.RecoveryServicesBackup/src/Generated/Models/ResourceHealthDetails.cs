// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    /// <summary> Health Details for backup items. </summary>
    public partial class ResourceHealthDetails
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        protected internal Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ResourceHealthDetails"/>. </summary>
        public ResourceHealthDetails()
        {
            Recommendations = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="ResourceHealthDetails"/>. </summary>
        /// <param name="code"> Health Code. </param>
        /// <param name="title"> Health Title. </param>
        /// <param name="message"> Health Message. </param>
        /// <param name="recommendations"> Health Recommended Actions. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ResourceHealthDetails(int? code, string title, string message, IReadOnlyList<string> recommendations, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Code = code;
            Title = title;
            Message = message;
            Recommendations = recommendations;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Health Code. </summary>
        public int? Code { get; }
        /// <summary> Health Title. </summary>
        public string Title { get; }
        /// <summary> Health Message. </summary>
        public string Message { get; }
        /// <summary> Health Recommended Actions. </summary>
        public IReadOnlyList<string> Recommendations { get; }
    }
}
