// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class HyperVReplicaAzureFailbackProviderInput : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(DataSyncOption))
            {
                writer.WritePropertyName("dataSyncOption");
                writer.WriteStringValue(DataSyncOption);
            }
            if (Optional.IsDefined(RecoveryVmCreationOption))
            {
                writer.WritePropertyName("recoveryVmCreationOption");
                writer.WriteStringValue(RecoveryVmCreationOption);
            }
            if (Optional.IsDefined(ProviderIdForAlternateRecovery))
            {
                writer.WritePropertyName("providerIdForAlternateRecovery");
                writer.WriteStringValue(ProviderIdForAlternateRecovery);
            }
            writer.WritePropertyName("instanceType");
            writer.WriteStringValue(InstanceType);
            writer.WriteEndObject();
        }
    }
}
