// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.Core.Serialization;
using Azure.ResourceManager.AppService.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService
{
    public partial class SiteExtensionInfoData : IUtf8JsonSerializable, IModelJsonSerializable<SiteExtensionInfoData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<SiteExtensionInfoData>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<SiteExtensionInfoData>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SiteExtensionInfoData>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Kind))
            {
                writer.WritePropertyName("kind"u8);
                writer.WriteStringValue(Kind);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(ExtensionId))
            {
                writer.WritePropertyName("extension_id"u8);
                writer.WriteStringValue(ExtensionId);
            }
            if (Optional.IsDefined(Title))
            {
                writer.WritePropertyName("title"u8);
                writer.WriteStringValue(Title);
            }
            if (Optional.IsDefined(ExtensionType))
            {
                writer.WritePropertyName("extension_type"u8);
                writer.WriteStringValue(ExtensionType.Value.ToSerialString());
            }
            if (Optional.IsDefined(Summary))
            {
                writer.WritePropertyName("summary"u8);
                writer.WriteStringValue(Summary);
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(Version))
            {
                writer.WritePropertyName("version"u8);
                writer.WriteStringValue(Version);
            }
            if (Optional.IsDefined(ExtensionUri))
            {
                writer.WritePropertyName("extension_url"u8);
                writer.WriteStringValue(ExtensionUri.AbsoluteUri);
            }
            if (Optional.IsDefined(ProjectUri))
            {
                writer.WritePropertyName("project_url"u8);
                writer.WriteStringValue(ProjectUri.AbsoluteUri);
            }
            if (Optional.IsDefined(IconUri))
            {
                writer.WritePropertyName("icon_url"u8);
                writer.WriteStringValue(IconUri.AbsoluteUri);
            }
            if (Optional.IsDefined(LicenseUri))
            {
                writer.WritePropertyName("license_url"u8);
                writer.WriteStringValue(LicenseUri.AbsoluteUri);
            }
            if (Optional.IsDefined(FeedUri))
            {
                writer.WritePropertyName("feed_url"u8);
                writer.WriteStringValue(FeedUri.AbsoluteUri);
            }
            if (Optional.IsCollectionDefined(Authors))
            {
                writer.WritePropertyName("authors"u8);
                writer.WriteStartArray();
                foreach (var item in Authors)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(InstallerCommandLineParams))
            {
                writer.WritePropertyName("installer_command_line_params"u8);
                writer.WriteStringValue(InstallerCommandLineParams);
            }
            if (Optional.IsDefined(PublishedOn))
            {
                writer.WritePropertyName("published_date_time"u8);
                writer.WriteStringValue(PublishedOn.Value, "O");
            }
            if (Optional.IsDefined(DownloadCount))
            {
                writer.WritePropertyName("download_count"u8);
                writer.WriteNumberValue(DownloadCount.Value);
            }
            if (Optional.IsDefined(LocalIsLatestVersion))
            {
                writer.WritePropertyName("local_is_latest_version"u8);
                writer.WriteBooleanValue(LocalIsLatestVersion.Value);
            }
            if (Optional.IsDefined(LocalPath))
            {
                writer.WritePropertyName("local_path"u8);
                writer.WriteStringValue(LocalPath);
            }
            if (Optional.IsDefined(InstalledOn))
            {
                writer.WritePropertyName("installed_date_time"u8);
                writer.WriteStringValue(InstalledOn.Value, "O");
            }
            if (Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState);
            }
            if (Optional.IsDefined(Comment))
            {
                writer.WritePropertyName("comment"u8);
                writer.WriteStringValue(Comment);
            }
            writer.WriteEndObject();
            if (_serializedAdditionalRawData is not null && options.Format == ModelSerializerFormat.Json)
            {
                foreach (var property in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(property.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(property.Value);
#else
                    JsonSerializer.Serialize(writer, JsonDocument.Parse(property.Value.ToString()).RootElement);
#endif
                }
            }
            writer.WriteEndObject();
        }

        internal static SiteExtensionInfoData DeserializeSiteExtensionInfoData(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> kind = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> extensionId = default;
            Optional<string> title = default;
            Optional<SiteExtensionType> extensionType = default;
            Optional<string> summary = default;
            Optional<string> description = default;
            Optional<string> version = default;
            Optional<Uri> extensionUrl = default;
            Optional<Uri> projectUrl = default;
            Optional<Uri> iconUrl = default;
            Optional<Uri> licenseUrl = default;
            Optional<Uri> feedUrl = default;
            Optional<IList<string>> authors = default;
            Optional<string> installerCommandLineParams = default;
            Optional<DateTimeOffset> publishedDateTime = default;
            Optional<int> downloadCount = default;
            Optional<bool> localIsLatestVersion = default;
            Optional<string> localPath = default;
            Optional<DateTimeOffset> installedDateTime = default;
            Optional<string> provisioningState = default;
            Optional<string> comment = default;
            Dictionary<string, BinaryData> serializedAdditionalRawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"u8))
                {
                    kind = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("extension_id"u8))
                        {
                            extensionId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("title"u8))
                        {
                            title = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("extension_type"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            extensionType = property0.Value.GetString().ToSiteExtensionType();
                            continue;
                        }
                        if (property0.NameEquals("summary"u8))
                        {
                            summary = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("description"u8))
                        {
                            description = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("version"u8))
                        {
                            version = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("extension_url"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            extensionUrl = new Uri(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("project_url"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            projectUrl = new Uri(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("icon_url"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            iconUrl = new Uri(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("license_url"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            licenseUrl = new Uri(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("feed_url"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            feedUrl = new Uri(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("authors"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            authors = array;
                            continue;
                        }
                        if (property0.NameEquals("installer_command_line_params"u8))
                        {
                            installerCommandLineParams = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("published_date_time"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            publishedDateTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("download_count"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            downloadCount = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("local_is_latest_version"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            localIsLatestVersion = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("local_path"u8))
                        {
                            localPath = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("installed_date_time"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            installedDateTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            provisioningState = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("comment"u8))
                        {
                            comment = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    serializedAdditionalRawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new SiteExtensionInfoData(id, name, type, systemData.Value, extensionId.Value, title.Value, Optional.ToNullable(extensionType), summary.Value, description.Value, version.Value, extensionUrl.Value, projectUrl.Value, iconUrl.Value, licenseUrl.Value, feedUrl.Value, Optional.ToList(authors), installerCommandLineParams.Value, Optional.ToNullable(publishedDateTime), Optional.ToNullable(downloadCount), Optional.ToNullable(localIsLatestVersion), localPath.Value, Optional.ToNullable(installedDateTime), provisioningState.Value, comment.Value, kind.Value, serializedAdditionalRawData);
        }

        SiteExtensionInfoData IModelJsonSerializable<SiteExtensionInfoData>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SiteExtensionInfoData>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeSiteExtensionInfoData(doc.RootElement, options);
        }

        BinaryData IModelSerializable<SiteExtensionInfoData>.Serialize(ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SiteExtensionInfoData>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        SiteExtensionInfoData IModelSerializable<SiteExtensionInfoData>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            Core.ModelSerializerHelper.ValidateFormat<SiteExtensionInfoData>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeSiteExtensionInfoData(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="SiteExtensionInfoData"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="SiteExtensionInfoData"/> to convert. </param>
        public static implicit operator RequestContent(SiteExtensionInfoData model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="SiteExtensionInfoData"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator SiteExtensionInfoData(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeSiteExtensionInfoData(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
