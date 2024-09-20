// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.SecurityInsights
{
    public partial class SecurityInsightsMetadataResource : IJsonModel<SecurityInsightsMetadataData>
    {
        void IJsonModel<SecurityInsightsMetadataData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<SecurityInsightsMetadataData>)Data).Write(writer, options);

        SecurityInsightsMetadataData IJsonModel<SecurityInsightsMetadataData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<SecurityInsightsMetadataData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<SecurityInsightsMetadataData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        SecurityInsightsMetadataData IPersistableModel<SecurityInsightsMetadataData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<SecurityInsightsMetadataData>(data, options);

        string IPersistableModel<SecurityInsightsMetadataData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<SecurityInsightsMetadataData>)Data).GetFormatFromOptions(options);
    }
}
