// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Elastic.Models
{
    public partial class CompanyInfo : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(Domain))
            {
                writer.WritePropertyName("domain"u8);
                writer.WriteStringValue(Domain);
            }
            if (Core.Optional.IsDefined(Business))
            {
                writer.WritePropertyName("business"u8);
                writer.WriteStringValue(Business);
            }
            if (Core.Optional.IsDefined(EmployeesNumber))
            {
                writer.WritePropertyName("employeesNumber"u8);
                writer.WriteStringValue(EmployeesNumber);
            }
            if (Core.Optional.IsDefined(State))
            {
                writer.WritePropertyName("state"u8);
                writer.WriteStringValue(State);
            }
            if (Core.Optional.IsDefined(Country))
            {
                writer.WritePropertyName("country"u8);
                writer.WriteStringValue(Country);
            }
            writer.WriteEndObject();
        }

        internal static CompanyInfo DeserializeCompanyInfo(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Core.Optional<string> domain = default;
            Core.Optional<string> business = default;
            Core.Optional<string> employeesNumber = default;
            Core.Optional<string> state = default;
            Core.Optional<string> country = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("domain"u8))
                {
                    domain = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("business"u8))
                {
                    business = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("employeesNumber"u8))
                {
                    employeesNumber = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("state"u8))
                {
                    state = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("country"u8))
                {
                    country = property.Value.GetString();
                    continue;
                }
            }
            return new CompanyInfo(domain.Value, business.Value, employeesNumber.Value, state.Value, country.Value);
        }
    }
}
