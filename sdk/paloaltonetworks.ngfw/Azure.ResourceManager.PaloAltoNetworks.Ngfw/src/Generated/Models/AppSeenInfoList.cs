// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.ResourceManager.PaloAltoNetworks.Ngfw.Models
{
    /// <summary> Data Type for App Seen. </summary>
    public partial class AppSeenInfoList
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="AppSeenInfoList"/>. </summary>
        /// <param name="count"> number of rows. </param>
        /// <param name="appSeenList"> array of appSeen. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="appSeenList"/> is null. </exception>
        internal AppSeenInfoList(int count, IEnumerable<AppSeenInfo> appSeenList)
        {
            Argument.AssertNotNull(appSeenList, nameof(appSeenList));

            Count = count;
            AppSeenList = appSeenList.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="AppSeenInfoList"/>. </summary>
        /// <param name="count"> number of rows. </param>
        /// <param name="appSeenList"> array of appSeen. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AppSeenInfoList(int count, IReadOnlyList<AppSeenInfo> appSeenList, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Count = count;
            AppSeenList = appSeenList;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="AppSeenInfoList"/> for deserialization. </summary>
        internal AppSeenInfoList()
        {
        }

        /// <summary> number of rows. </summary>
        public int Count { get; }
        /// <summary> array of appSeen. </summary>
        public IReadOnlyList<AppSeenInfo> AppSeenList { get; }
    }
}
