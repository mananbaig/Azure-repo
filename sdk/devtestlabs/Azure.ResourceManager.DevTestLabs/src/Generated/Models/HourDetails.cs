// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DevTestLabs.Models
{
    /// <summary> Properties of an hourly schedule. </summary>
    internal partial class HourDetails
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="HourDetails"/>. </summary>
        public HourDetails()
        {
        }

        /// <summary> Initializes a new instance of <see cref="HourDetails"/>. </summary>
        /// <param name="minute"> Minutes of the hour the schedule will run. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal HourDetails(int? minute, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Minute = minute;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Minutes of the hour the schedule will run. </summary>
        public int? Minute { get; set; }
    }
}
