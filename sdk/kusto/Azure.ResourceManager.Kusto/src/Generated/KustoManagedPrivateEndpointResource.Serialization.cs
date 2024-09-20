// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Kusto
{
    public partial class KustoManagedPrivateEndpointResource : IJsonModel<KustoManagedPrivateEndpointData>
    {
        void IJsonModel<KustoManagedPrivateEndpointData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<KustoManagedPrivateEndpointData>)Data).Write(writer, options);

        KustoManagedPrivateEndpointData IJsonModel<KustoManagedPrivateEndpointData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<KustoManagedPrivateEndpointData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<KustoManagedPrivateEndpointData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        KustoManagedPrivateEndpointData IPersistableModel<KustoManagedPrivateEndpointData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<KustoManagedPrivateEndpointData>(data, options);

        string IPersistableModel<KustoManagedPrivateEndpointData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<KustoManagedPrivateEndpointData>)Data).GetFormatFromOptions(options);
    }
}
