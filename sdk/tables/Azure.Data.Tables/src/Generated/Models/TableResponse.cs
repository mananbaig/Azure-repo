// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Data.Tables.Models
{
    /// <summary> The response for a single table. </summary>
    internal partial class TableResponse : TableItem
    {
        /// <summary> Initializes a new instance of <see cref="TableResponse"/>. </summary>
        internal TableResponse()
        {
        }

        /// <summary> Initializes a new instance of <see cref="TableResponse"/>. </summary>
        /// <param name="name"> The name of the table. </param>
        /// <param name="odataType"> The odata type of the table. </param>
        /// <param name="odataId"> The id of the table. </param>
        /// <param name="odataEditLink"> The edit link of the table. </param>
        /// <param name="odataMetadata"> The metadata response of the table. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal TableResponse(string name, string odataType, string odataId, string odataEditLink, string odataMetadata, Dictionary<string, BinaryData> serializedAdditionalRawData) : base(name, odataType, odataId, odataEditLink, serializedAdditionalRawData)
        {
            OdataMetadata = odataMetadata;
        }

        /// <summary> The metadata response of the table. </summary>
        public string OdataMetadata { get; }
    }
}
