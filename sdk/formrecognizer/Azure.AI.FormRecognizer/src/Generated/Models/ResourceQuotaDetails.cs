// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.FormRecognizer.DocumentAnalysis
{
    /// <summary> Quota used, limit, and next reset date/time. </summary>
    public partial class ResourceQuotaDetails
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ResourceQuotaDetails"/>. </summary>
        /// <param name="used"> Amount of the resource quota used. </param>
        /// <param name="quota"> Resource quota limit. </param>
        /// <param name="quotaResetsOn"> Date/time when the resource quota usage will be reset. </param>
        internal ResourceQuotaDetails(int used, int quota, DateTimeOffset quotaResetsOn)
        {
            Used = used;
            Quota = quota;
            QuotaResetsOn = quotaResetsOn;
        }

        /// <summary> Initializes a new instance of <see cref="ResourceQuotaDetails"/>. </summary>
        /// <param name="used"> Amount of the resource quota used. </param>
        /// <param name="quota"> Resource quota limit. </param>
        /// <param name="quotaResetsOn"> Date/time when the resource quota usage will be reset. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ResourceQuotaDetails(int used, int quota, DateTimeOffset quotaResetsOn, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Used = used;
            Quota = quota;
            QuotaResetsOn = quotaResetsOn;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ResourceQuotaDetails"/> for deserialization. </summary>
        internal ResourceQuotaDetails()
        {
        }

        /// <summary> Amount of the resource quota used. </summary>
        public int Used { get; }
        /// <summary> Resource quota limit. </summary>
        public int Quota { get; }
    }
}
