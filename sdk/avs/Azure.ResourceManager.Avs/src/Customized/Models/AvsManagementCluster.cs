// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Avs.Models
{
    /// <summary> The properties of a management cluster. </summary>
    public partial class AvsManagementCluster : CommonClusterProperties
    {
        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            base.JsonModelWriteCore(writer, options);
            if (Optional.IsDefined(VsanDatastoreName))
            {
                writer.WritePropertyName("vsanDatastoreName"u8);
                writer.WriteStringValue(VsanDatastoreName);
            }
        }
    }
}
