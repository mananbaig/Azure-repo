// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Network.Models
{
    public partial class IpsecPolicy : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("saLifeTimeSeconds");
            writer.WriteNumberValue(SaLifeTimeSeconds);
            writer.WritePropertyName("saDataSizeKilobytes");
            writer.WriteNumberValue(SaDataSizeKilobytes);
            writer.WritePropertyName("ipsecEncryption");
            writer.WriteStringValue(IpsecEncryption.ToString());
            writer.WritePropertyName("ipsecIntegrity");
            writer.WriteStringValue(IpsecIntegrity.ToString());
            writer.WritePropertyName("ikeEncryption");
            writer.WriteStringValue(IkeEncryption.ToString());
            writer.WritePropertyName("ikeIntegrity");
            writer.WriteStringValue(IkeIntegrity.ToString());
            writer.WritePropertyName("dhGroup");
            writer.WriteStringValue(DhGroup.ToString());
            writer.WritePropertyName("pfsGroup");
            writer.WriteStringValue(PfsGroup.ToString());
            writer.WriteEndObject();
        }

        internal static IpsecPolicy DeserializeIpsecPolicy(JsonElement element)
        {
            int saLifeTimeSeconds = default;
            int saDataSizeKilobytes = default;
            IpsecEncryption ipsecEncryption = default;
            IpsecIntegrity ipsecIntegrity = default;
            IkeEncryption ikeEncryption = default;
            IkeIntegrity ikeIntegrity = default;
            DhGroup dhGroup = default;
            PfsGroup pfsGroup = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("saLifeTimeSeconds"))
                {
                    saLifeTimeSeconds = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("saDataSizeKilobytes"))
                {
                    saDataSizeKilobytes = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("ipsecEncryption"))
                {
                    ipsecEncryption = new IpsecEncryption(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("ipsecIntegrity"))
                {
                    ipsecIntegrity = new IpsecIntegrity(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("ikeEncryption"))
                {
                    ikeEncryption = new IkeEncryption(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("ikeIntegrity"))
                {
                    ikeIntegrity = new IkeIntegrity(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("dhGroup"))
                {
                    dhGroup = new DhGroup(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("pfsGroup"))
                {
                    pfsGroup = new PfsGroup(property.Value.GetString());
                    continue;
                }
            }
            return new IpsecPolicy(saLifeTimeSeconds, saDataSizeKilobytes, ipsecEncryption, ipsecIntegrity, ikeEncryption, ikeIntegrity, dhGroup, pfsGroup);
        }
    }
}
