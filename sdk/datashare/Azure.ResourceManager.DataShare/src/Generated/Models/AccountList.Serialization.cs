// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.DataShare;

namespace Azure.ResourceManager.DataShare.Models
{
    internal partial class AccountList
    {
        internal static AccountList DeserializeAccountList(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<string> nextLink = default;
            IReadOnlyList<DataShareAccountData> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("value"u8))
                {
                    List<DataShareAccountData> array = new List<DataShareAccountData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DataShareAccountData.DeserializeDataShareAccountData(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new AccountList(nextLink.Value, value);
        }
    }
}
