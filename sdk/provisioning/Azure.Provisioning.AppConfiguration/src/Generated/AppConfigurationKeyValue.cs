// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure;
using Azure.Core;
using Azure.Provisioning;
using Azure.Provisioning.Primitives;
using Azure.Provisioning.Resources;
using System;

namespace Azure.Provisioning.AppConfiguration;

/// <summary>
/// AppConfigurationKeyValue.
/// </summary>
public partial class AppConfigurationKeyValue : ProvisionableResource
{
    /// <summary>
    /// Identifier of key and label combination. Key and label are joined by $
    /// character. Label is optional.
    /// </summary>
    public BicepValue<string> Name { get => _name; set => _name.Assign(value); }
    private readonly BicepValue<string> _name;

    /// <summary>
    /// The content type of the key-value&apos;s value.             Providing a
    /// proper content-type can enable transformations of values when they are
    /// retrieved by applications.
    /// </summary>
    public BicepValue<string> ContentType { get => _contentType; set => _contentType.Assign(value); }
    private readonly BicepValue<string> _contentType;

    /// <summary>
    /// A dictionary of tags that can help identify what a key-value may be
    /// applicable for.
    /// </summary>
    public BicepDictionary<string> Tags { get => _tags; set => _tags.Assign(value); }
    private readonly BicepDictionary<string> _tags;

    /// <summary>
    /// The value of the key-value.
    /// </summary>
    public BicepValue<string> Value { get => _value; set => _value.Assign(value); }
    private readonly BicepValue<string> _value;

    /// <summary>
    /// An ETag indicating the state of a key-value within a configuration
    /// store.
    /// </summary>
    public BicepValue<ETag> ETag { get => _eTag; }
    private readonly BicepValue<ETag> _eTag;

    /// <summary>
    /// Gets the Id.
    /// </summary>
    public BicepValue<ResourceIdentifier> Id { get => _id; }
    private readonly BicepValue<ResourceIdentifier> _id;

    /// <summary>
    /// A value indicating whether the key-value is locked.             A
    /// locked key-value may not be modified until it is unlocked.
    /// </summary>
    public BicepValue<bool> IsLocked { get => _isLocked; }
    private readonly BicepValue<bool> _isLocked;

    /// <summary>
    /// The primary identifier of a key-value.             The key is used in
    /// unison with the label to uniquely identify a key-value.
    /// </summary>
    public BicepValue<string> Key { get => _key; }
    private readonly BicepValue<string> _key;

    /// <summary>
    /// A value used to group key-values.             The label is used in
    /// unison with the key to uniquely identify a key-value.
    /// </summary>
    public BicepValue<string> Label { get => _label; }
    private readonly BicepValue<string> _label;

    /// <summary>
    /// The last time a modifying operation was performed on the given
    /// key-value.
    /// </summary>
    public BicepValue<DateTimeOffset> LastModifiedOn { get => _lastModifiedOn; }
    private readonly BicepValue<DateTimeOffset> _lastModifiedOn;

    /// <summary>
    /// Gets the SystemData.
    /// </summary>
    public BicepValue<SystemData> SystemData { get => _systemData; }
    private readonly BicepValue<SystemData> _systemData;

    /// <summary>
    /// Gets or sets a reference to the parent AppConfigurationStore.
    /// </summary>
    public AppConfigurationStore? Parent { get => _parent!.Value; set => _parent!.Value = value; }
    private readonly ResourceReference<AppConfigurationStore> _parent;

    /// <summary>
    /// Creates a new AppConfigurationKeyValue.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the AppConfigurationKeyValue resource.
    /// This can be used to refer to the resource in expressions, but is not
    /// the Azure name of the resource.  This value can contain letters,
    /// numbers, and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the AppConfigurationKeyValue.</param>
    public AppConfigurationKeyValue(string bicepIdentifier, string? resourceVersion = default)
        : base(bicepIdentifier, "Microsoft.AppConfiguration/configurationStores/keyValues", resourceVersion ?? "2024-05-01")
    {
        _name = BicepValue<string>.DefineProperty(this, "Name", ["name"], isRequired: true);
        _contentType = BicepValue<string>.DefineProperty(this, "ContentType", ["properties", "contentType"]);
        _tags = BicepDictionary<string>.DefineProperty(this, "Tags", ["properties", "tags"]);
        _value = BicepValue<string>.DefineProperty(this, "Value", ["properties", "value"]);
        _eTag = BicepValue<ETag>.DefineProperty(this, "ETag", ["properties", "eTag"], isOutput: true);
        _id = BicepValue<ResourceIdentifier>.DefineProperty(this, "Id", ["id"], isOutput: true);
        _isLocked = BicepValue<bool>.DefineProperty(this, "IsLocked", ["properties", "locked"], isOutput: true);
        _key = BicepValue<string>.DefineProperty(this, "Key", ["properties", "key"], isOutput: true);
        _label = BicepValue<string>.DefineProperty(this, "Label", ["properties", "label"], isOutput: true);
        _lastModifiedOn = BicepValue<DateTimeOffset>.DefineProperty(this, "LastModifiedOn", ["properties", "lastModified"], isOutput: true);
        _systemData = BicepValue<SystemData>.DefineProperty(this, "SystemData", ["systemData"], isOutput: true);
        _parent = ResourceReference<AppConfigurationStore>.DefineResource(this, "Parent", ["parent"], isRequired: true);
    }

    /// <summary>
    /// Supported AppConfigurationKeyValue resource versions.
    /// </summary>
    public static class ResourceVersions
    {
        /// <summary>
        /// 2024-05-01.
        /// </summary>
        public static readonly string V2024_05_01 = "2024-05-01";

        /// <summary>
        /// 2023-03-01.
        /// </summary>
        public static readonly string V2023_03_01 = "2023-03-01";

        /// <summary>
        /// 2022-05-01.
        /// </summary>
        public static readonly string V2022_05_01 = "2022-05-01";
    }

    /// <summary>
    /// Creates a reference to an existing AppConfigurationKeyValue.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the AppConfigurationKeyValue resource.
    /// This can be used to refer to the resource in expressions, but is not
    /// the Azure name of the resource.  This value can contain letters,
    /// numbers, and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the AppConfigurationKeyValue.</param>
    /// <returns>The existing AppConfigurationKeyValue resource.</returns>
    public static AppConfigurationKeyValue FromExisting(string bicepIdentifier, string? resourceVersion = default) =>
        new(bicepIdentifier, resourceVersion) { IsExistingResource = true };
}
