// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Authorization
{
    public partial class RoleAssignmentScheduleRequestResource : IJsonModel<RoleAssignmentScheduleRequestData>
    {
        void IJsonModel<RoleAssignmentScheduleRequestData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<RoleAssignmentScheduleRequestData>)Data).Write(writer, options);

        RoleAssignmentScheduleRequestData IJsonModel<RoleAssignmentScheduleRequestData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<RoleAssignmentScheduleRequestData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<RoleAssignmentScheduleRequestData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        RoleAssignmentScheduleRequestData IPersistableModel<RoleAssignmentScheduleRequestData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<RoleAssignmentScheduleRequestData>(data, options);

        string IPersistableModel<RoleAssignmentScheduleRequestData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<RoleAssignmentScheduleRequestData>)Data).GetFormatFromOptions(options);
    }
}
