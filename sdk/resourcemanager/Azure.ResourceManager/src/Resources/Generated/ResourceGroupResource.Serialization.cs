// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Resources
{
    public partial class ResourceGroupResource : IJsonModel<ResourceGroupData>
    {
        void IJsonModel<ResourceGroupData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<ResourceGroupData>)Data).Write(writer, options);

        ResourceGroupData IJsonModel<ResourceGroupData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<ResourceGroupData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<ResourceGroupData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        ResourceGroupData IPersistableModel<ResourceGroupData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<ResourceGroupData>(data, options);

        string IPersistableModel<ResourceGroupData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<ResourceGroupData>)Data).GetFormatFromOptions(options);
    }
}
