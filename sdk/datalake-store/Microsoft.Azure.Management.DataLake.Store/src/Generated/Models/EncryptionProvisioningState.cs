// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataLake.Store.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for EncryptionProvisioningState.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum EncryptionProvisioningState
    {
        [EnumMember(Value = "Creating")]
        Creating,
        [EnumMember(Value = "Succeeded")]
        Succeeded
    }
    internal static class EncryptionProvisioningStateEnumExtension
    {
        internal static string ToSerializedValue(this EncryptionProvisioningState? value)
        {
            return value == null ? null : ((EncryptionProvisioningState)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this EncryptionProvisioningState value)
        {
            switch( value )
            {
                case EncryptionProvisioningState.Creating:
                    return "Creating";
                case EncryptionProvisioningState.Succeeded:
                    return "Succeeded";
            }
            return null;
        }

        internal static EncryptionProvisioningState? ParseEncryptionProvisioningState(this string value)
        {
            switch( value )
            {
                case "Creating":
                    return EncryptionProvisioningState.Creating;
                case "Succeeded":
                    return EncryptionProvisioningState.Succeeded;
            }
            return null;
        }
    }
}
