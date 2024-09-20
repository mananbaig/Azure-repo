// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Cdn
{
    public partial class FrontDoorCustomDomainResource : IJsonModel<FrontDoorCustomDomainData>
    {
        void IJsonModel<FrontDoorCustomDomainData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<FrontDoorCustomDomainData>)Data).Write(writer, options);

        FrontDoorCustomDomainData IJsonModel<FrontDoorCustomDomainData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<FrontDoorCustomDomainData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<FrontDoorCustomDomainData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        FrontDoorCustomDomainData IPersistableModel<FrontDoorCustomDomainData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<FrontDoorCustomDomainData>(data, options);

        string IPersistableModel<FrontDoorCustomDomainData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<FrontDoorCustomDomainData>)Data).GetFormatFromOptions(options);
    }
}
