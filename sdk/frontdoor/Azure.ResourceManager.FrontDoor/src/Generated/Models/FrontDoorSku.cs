// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.FrontDoor.Models
{
    /// <summary> The pricing tier of the web application firewall policy. </summary>
    internal partial class FrontDoorSku
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private Dictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="FrontDoorSku"/>. </summary>
        public FrontDoorSku()
        {
        }

        /// <summary> Initializes a new instance of <see cref="FrontDoorSku"/>. </summary>
        /// <param name="name"> Name of the pricing tier. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal FrontDoorSku(FrontDoorSkuName? name, Dictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Name of the pricing tier. </summary>
        public FrontDoorSkuName? Name { get; set; }
    }
}
