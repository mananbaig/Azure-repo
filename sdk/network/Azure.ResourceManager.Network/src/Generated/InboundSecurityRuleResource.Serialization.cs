// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Network
{
    public partial class InboundSecurityRuleResource : IJsonModel<InboundSecurityRuleData>
    {
        void IJsonModel<InboundSecurityRuleData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<InboundSecurityRuleData>)Data).Write(writer, options);

        InboundSecurityRuleData IJsonModel<InboundSecurityRuleData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<InboundSecurityRuleData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<InboundSecurityRuleData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        InboundSecurityRuleData IPersistableModel<InboundSecurityRuleData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<InboundSecurityRuleData>(data, options);

        string IPersistableModel<InboundSecurityRuleData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<InboundSecurityRuleData>)Data).GetFormatFromOptions(options);
    }
}
