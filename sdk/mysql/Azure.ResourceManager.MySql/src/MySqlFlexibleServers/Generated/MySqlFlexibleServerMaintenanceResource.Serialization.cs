// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.MySql.FlexibleServers
{
    public partial class MySqlFlexibleServerMaintenanceResource : IJsonModel<MySqlFlexibleServerMaintenanceData>
    {
        void IJsonModel<MySqlFlexibleServerMaintenanceData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<MySqlFlexibleServerMaintenanceData>)Data).Write(writer, options);

        MySqlFlexibleServerMaintenanceData IJsonModel<MySqlFlexibleServerMaintenanceData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<MySqlFlexibleServerMaintenanceData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<MySqlFlexibleServerMaintenanceData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        MySqlFlexibleServerMaintenanceData IPersistableModel<MySqlFlexibleServerMaintenanceData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<MySqlFlexibleServerMaintenanceData>(data, options);

        string IPersistableModel<MySqlFlexibleServerMaintenanceData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<MySqlFlexibleServerMaintenanceData>)Data).GetFormatFromOptions(options);
    }
}
