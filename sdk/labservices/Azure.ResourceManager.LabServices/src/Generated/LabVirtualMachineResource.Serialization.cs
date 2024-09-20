// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.LabServices
{
    public partial class LabVirtualMachineResource : IJsonModel<LabVirtualMachineData>
    {
        void IJsonModel<LabVirtualMachineData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<LabVirtualMachineData>)Data).Write(writer, options);

        LabVirtualMachineData IJsonModel<LabVirtualMachineData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<LabVirtualMachineData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<LabVirtualMachineData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        LabVirtualMachineData IPersistableModel<LabVirtualMachineData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<LabVirtualMachineData>(data, options);

        string IPersistableModel<LabVirtualMachineData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<LabVirtualMachineData>)Data).GetFormatFromOptions(options);
    }
}
