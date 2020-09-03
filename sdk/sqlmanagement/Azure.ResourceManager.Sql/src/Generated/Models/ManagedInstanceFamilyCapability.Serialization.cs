// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Sql.Models
{
    public partial class ManagedInstanceFamilyCapability
    {
        internal static ManagedInstanceFamilyCapability DeserializeManagedInstanceFamilyCapability(JsonElement element)
        {
            Optional<string> name = default;
            Optional<string> sku = default;
            Optional<IReadOnlyList<LicenseTypeCapability>> supportedLicenseTypes = default;
            Optional<IReadOnlyList<ManagedInstanceVcoresCapability>> supportedVcoresValues = default;
            Optional<CapabilityStatus> status = default;
            Optional<string> reason = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sku"))
                {
                    sku = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("supportedLicenseTypes"))
                {
                    List<LicenseTypeCapability> array = new List<LicenseTypeCapability>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(LicenseTypeCapability.DeserializeLicenseTypeCapability(item));
                    }
                    supportedLicenseTypes = array;
                    continue;
                }
                if (property.NameEquals("supportedVcoresValues"))
                {
                    List<ManagedInstanceVcoresCapability> array = new List<ManagedInstanceVcoresCapability>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ManagedInstanceVcoresCapability.DeserializeManagedInstanceVcoresCapability(item));
                    }
                    supportedVcoresValues = array;
                    continue;
                }
                if (property.NameEquals("status"))
                {
                    status = property.Value.GetString().ToCapabilityStatus();
                    continue;
                }
                if (property.NameEquals("reason"))
                {
                    reason = property.Value.GetString();
                    continue;
                }
            }
            return new ManagedInstanceFamilyCapability(name.Value, sku.Value, Optional.ToList(supportedLicenseTypes), Optional.ToList(supportedVcoresValues), Optional.ToNullable(status), reason.Value);
        }
    }
}
