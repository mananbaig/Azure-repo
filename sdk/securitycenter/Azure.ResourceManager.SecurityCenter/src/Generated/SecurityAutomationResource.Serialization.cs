// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.SecurityCenter
{
    public partial class SecurityAutomationResource : IJsonModel<SecurityAutomationData>
    {
        void IJsonModel<SecurityAutomationData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<SecurityAutomationData>)Data).Write(writer, options);

        SecurityAutomationData IJsonModel<SecurityAutomationData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<SecurityAutomationData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<SecurityAutomationData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        SecurityAutomationData IPersistableModel<SecurityAutomationData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<SecurityAutomationData>(data, options);

        string IPersistableModel<SecurityAutomationData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<SecurityAutomationData>)Data).GetFormatFromOptions(options);
    }
}
