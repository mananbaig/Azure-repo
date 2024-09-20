// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.AppService
{
    public partial class SiteSlotProcessModuleResource : IJsonModel<ProcessModuleInfoData>
    {
        void IJsonModel<ProcessModuleInfoData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<ProcessModuleInfoData>)Data).Write(writer, options);

        ProcessModuleInfoData IJsonModel<ProcessModuleInfoData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<ProcessModuleInfoData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<ProcessModuleInfoData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        ProcessModuleInfoData IPersistableModel<ProcessModuleInfoData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<ProcessModuleInfoData>(data, options);

        string IPersistableModel<ProcessModuleInfoData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<ProcessModuleInfoData>)Data).GetFormatFromOptions(options);
    }
}
