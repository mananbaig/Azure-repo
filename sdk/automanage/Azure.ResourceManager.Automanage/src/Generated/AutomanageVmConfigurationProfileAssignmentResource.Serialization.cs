// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Automanage
{
    public partial class AutomanageVmConfigurationProfileAssignmentResource : IJsonModel<AutomanageConfigurationProfileAssignmentData>
    {
        void IJsonModel<AutomanageConfigurationProfileAssignmentData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<AutomanageConfigurationProfileAssignmentData>)Data).Write(writer, options);

        AutomanageConfigurationProfileAssignmentData IJsonModel<AutomanageConfigurationProfileAssignmentData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<AutomanageConfigurationProfileAssignmentData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<AutomanageConfigurationProfileAssignmentData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        AutomanageConfigurationProfileAssignmentData IPersistableModel<AutomanageConfigurationProfileAssignmentData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<AutomanageConfigurationProfileAssignmentData>(data, options);

        string IPersistableModel<AutomanageConfigurationProfileAssignmentData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<AutomanageConfigurationProfileAssignmentData>)Data).GetFormatFromOptions(options);
    }
}
