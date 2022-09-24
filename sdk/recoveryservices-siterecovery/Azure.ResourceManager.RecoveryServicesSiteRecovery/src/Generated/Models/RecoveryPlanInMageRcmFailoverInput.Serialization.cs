// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class RecoveryPlanInMageRcmFailoverInput : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("recoveryPointType");
            writer.WriteStringValue(RecoveryPointType.ToString());
            if (Optional.IsDefined(UseMultiVmSyncPoint))
            {
                writer.WritePropertyName("useMultiVmSyncPoint");
                writer.WriteStringValue(UseMultiVmSyncPoint);
            }
            writer.WritePropertyName("instanceType");
            writer.WriteStringValue(InstanceType);
            writer.WriteEndObject();
        }
    }
}
