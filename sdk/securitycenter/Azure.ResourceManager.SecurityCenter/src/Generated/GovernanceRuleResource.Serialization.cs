// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.SecurityCenter
{
    public partial class GovernanceRuleResource : IJsonModel<GovernanceRuleData>
    {
        void IJsonModel<GovernanceRuleData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<GovernanceRuleData>)Data).Write(writer, options);

        GovernanceRuleData IJsonModel<GovernanceRuleData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<GovernanceRuleData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<GovernanceRuleData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        GovernanceRuleData IPersistableModel<GovernanceRuleData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<GovernanceRuleData>(data, options);

        string IPersistableModel<GovernanceRuleData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<GovernanceRuleData>)Data).GetFormatFromOptions(options);
    }
}
