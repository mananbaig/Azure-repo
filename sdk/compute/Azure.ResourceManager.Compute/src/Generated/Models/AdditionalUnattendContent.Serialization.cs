// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    public partial class AdditionalUnattendContent : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(PassName))
            {
                writer.WritePropertyName("passName");
                writer.WriteStringValue(PassName);
            }
            if (Optional.IsDefined(ComponentName))
            {
                writer.WritePropertyName("componentName");
                writer.WriteStringValue(ComponentName);
            }
            if (Optional.IsDefined(SettingName))
            {
                writer.WritePropertyName("settingName");
                writer.WriteStringValue(SettingName.Value.ToSerialString());
            }
            if (Optional.IsDefined(Content))
            {
                writer.WritePropertyName("content");
                writer.WriteStringValue(Content);
            }
            writer.WriteEndObject();
        }

        internal static AdditionalUnattendContent DeserializeAdditionalUnattendContent(JsonElement element)
        {
            Optional<string> passName = default;
            Optional<string> componentName = default;
            Optional<SettingNames> settingName = default;
            Optional<string> content = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("passName"))
                {
                    passName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("componentName"))
                {
                    componentName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("settingName"))
                {
                    settingName = property.Value.GetString().ToSettingNames();
                    continue;
                }
                if (property.NameEquals("content"))
                {
                    content = property.Value.GetString();
                    continue;
                }
            }
            return new AdditionalUnattendContent(passName.Value, componentName.Value, Optional.ToNullable(settingName), content.Value);
        }
    }
}
