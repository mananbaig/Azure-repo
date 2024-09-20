// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Network
{
    public partial class VirtualRouterPeeringResource : IJsonModel<VirtualRouterPeeringData>
    {
        void IJsonModel<VirtualRouterPeeringData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<VirtualRouterPeeringData>)Data).Write(writer, options);

        VirtualRouterPeeringData IJsonModel<VirtualRouterPeeringData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<VirtualRouterPeeringData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<VirtualRouterPeeringData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        VirtualRouterPeeringData IPersistableModel<VirtualRouterPeeringData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<VirtualRouterPeeringData>(data, options);

        string IPersistableModel<VirtualRouterPeeringData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<VirtualRouterPeeringData>)Data).GetFormatFromOptions(options);
    }
}
